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
    }
}