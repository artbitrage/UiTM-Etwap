namespace Etwap_Console
{
    using NetSh;
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length > 1 && args[0].ToUpperInvariant() == Resources.stringResource.Delete && !string.IsNullOrEmpty(args[1]))
                Delete(args[1]);
            else
                List(args.Length == 1 && args[0].ToUpperInvariant() == Resources.stringResource.AutoDeletarParam);
        }

        private static void Delete(string profileName)
        {
            Console.WriteLine(Wrapper.DeleteProfiles(profileName));
        }

        private static void List(bool autoDelete)
        {
            var profiles = Wrapper.GetProfiles();
            var ETNetworkFoud = false;

            foreach (var a in profiles)
            {
                var warning = Wrapper.WithoutEncryption(a) ? Resources.stringResource.WarningAutoConnect : string.Empty;
                Console.WriteLine("{0, -30} {1, 10} {2, 10} {3, 30}", a.Name, a.ConnMode, a.Auth, warning);
                if (!string.IsNullOrWhiteSpace(warning)) ETNetworkFoud = true;
            }

            if (ETNetworkFoud)
            {
                if (!autoDelete) Console.WriteLine(Resources.stringResource.DeleteAutoConnect);
                if (autoDelete || Console.ReadLine().Trim().ToUpperInvariant().StartsWith(Resources.stringResource.AutoDeleteChar))
                {
                    foreach (var a in profiles.Where(Wrapper.WithoutEncryption))
                    {
                        Console.WriteLine(Wrapper.DeleteProfiles(a.Name));
                    }
                }
            }
            else
            {
                Console.WriteLine(Resources.stringResource.NoWifi);
            }
        }
    }
}