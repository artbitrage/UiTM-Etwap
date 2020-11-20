using SimpleWifi;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Etwap_Detector
{
    public partial class InterfaceForm : Form
    {
        private static Wifi wifi;

        public InterfaceForm()
        {
            InitializeComponent();
        }

        private void InterfaceForm_Load(object sender, EventArgs e)
        {
            wifi = new Wifi();

            List<AccessPoint> aps = wifi.GetAccessPoints();

            foreach (AccessPoint ap in aps)
            {
                ListViewItem listView = new ListViewItem(ap.Name);
                listView.SubItems.Add(ap.SignalStrength + "%");
                listView.Tag = ap;

                listView_AP.Items.Add(listView);
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (listView_AP.SelectedItems.Count > 0 && txBox_Password.Text.Length > 0)
            {
                ListViewItem selectedItem = listView_AP.SelectedItems[0];

                AccessPoint ap = (AccessPoint)selectedItem.Tag;

                if (connecter(ap, txBox_Password.Text))
                {
                    lbl_Status.Text = "Connected to " + ap.Name + ".";
                }

                lbl_Status.Text = "Not connected.";
            }
        }

        private bool connecter(AccessPoint ap, string password)
        {
            AuthRequest authRequest = new AuthRequest(ap);
            authRequest.Password = password;

            return ap.Connect(authRequest);
        }
    }
}