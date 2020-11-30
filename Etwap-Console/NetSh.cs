using System.Text.RegularExpressions;

namespace NetSh
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;

    public class Wrapper
    {
        private static readonly XNamespace ns = "http://www.microsoft.com/networking/WLAN/profile/v1";

        public static List<Profile> GetProfiles()
        {
            ExportAllProfiles();

            var profiles = new List<Profile>();
            foreach (string file in Directory.EnumerateFiles(Environment.CurrentDirectory, "*.xml"))
            {
                var x = XElement.Load(file);
                if (x.Name.Namespace == ns)
                {
                    profiles.Add(new Profile()
                    {
                        Name = x.Descendants(ns + "name").First().Value,
                        ConnMode = x.Descendants(ns + "connectionMode").FirstOrDefault()?.Value,
                        Auth = x.Descendants(ns + "authentication").FirstOrDefault()?.Value
                    });
                }
            }
            DeleteExportedProfiles();
            return profiles;
        }

        public static void DeleteExportedProfiles()
        {
            foreach (string file in Directory.EnumerateFiles(Environment.CurrentDirectory, "*.xml"))
                File.Delete(file);
        }

        public static string DeleteProfiles(string profileName)
        {
            string result = ExecuteNetSh(string.Format("wlan delete profile name=\"{0}\"", profileName));
            return result;
        }

        public static bool WithoutEncryption(Profile profile)
        {
            return profile.Auth == "open" && profile.ConnMode == "auto";
        }

        private static void ExportAllProfiles()
        {
            string result = ExecuteNetSh("wlan show profiles");

            var listOfProfiles = Regex.Matches(result, "(?<=: )(.*?)(?=\\r)", RegexOptions.IgnoreCase);

            foreach (var match in listOfProfiles)
            {
                ExecuteNetSh(string.Format("wlan export profile \"{0}\" folder=\"{1}\"", match.ToString(), Environment.CurrentDirectory));
                Console.Write(".");
            }
            Console.WriteLine();
        }

        private static string ExecuteNetSh(string arguments = null)
        {
            Process p = new Process();
            p.StartInfo.FileName = "netsh.exe";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = arguments ?? string.Empty;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            return output;
        }
    }
}