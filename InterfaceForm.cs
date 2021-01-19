using SimpleWifi;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Etwap_Detector
{
    public partial class InterfaceForm : Form
    {
        private static Wifi wifi;
        private int Ticks;

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
                lbl_Status.Text = wifi.ConnectionStatus.ToString();

                ListViewItem listView = new ListViewItem(ap.Name);
                listView.SubItems.Add(ap.SignalStrength + "%");
                listView.SubItems.Add(ap.IsSecure.ToString());

                listView.Tag = ap;

                listView_AP.Items.Add(listView);

                if (lbl_Status.Text == WifiStatus.Connected.ToString())
                {
                    btn_Connect.Text = "Disconnect";
                    txBox_SSID.Enabled = false;
                    txBox_Password.Enabled = false;

                    if (NetworkInterface.GetIsNetworkAvailable())
                    {
                        lbl_StatInt.Text = "Secured";
                    }
                    else
                    {
                        lbl_StatInt.Text = "No Internet";
                    }
                }
                else if (lbl_Status.Text == WifiStatus.Disconnected.ToString())
                {
                    btn_Connect.Text = "Connect";
                    txBox_SSID.Enabled = true;
                    txBox_Password.Enabled = true;
                    lbl_AP.Text = "N/A";
                }
            }

            try
            {
                if (lbl_Status.Text == WifiStatus.Connected.ToString())
                {
                    lbl_AP.Text = listView_AP.Items[0].Text;
                }
                else if (lbl_Status.Text == WifiStatus.Disconnected.ToString())
                {
                    lbl_AP.Text = "N/A";
                }
            }
            catch
            {
                lbl_AP.Text = "N/A";
            }
            timer.Enabled = true;
            timer.Start();
        }

        private void TxBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Connect_Click(this, new EventArgs());
            }
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (wifi.ConnectionStatus == WifiStatus.Connected)
            {
                wifi.Disconnect();

                lbl_AP.Text = "N/A";
                lbl_Status.Text = WifiStatus.Disconnected.ToString();
                btn_Connect.Text = "Connect";
                txBox_SSID.Enabled = true;
                txBox_Password.Enabled = true;

                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    lbl_StatInt.Text = "Secured";
                }
                else
                {
                    lbl_StatInt.Text = "No Internet";
                }
            }
            if (wifi.ConnectionStatus == WifiStatus.Disconnected)
            {
                if (listView_AP.SelectedItems.Count > 0 && txBox_Password.Text.Length > 0)
                {
                    ListViewItem selectedItem = listView_AP.SelectedItems[0];

                    AccessPoint ap = (AccessPoint)selectedItem.Tag;

                    if (Connecter(ap, txBox_Password.Text))
                    {
                        lbl_Status.Text = wifi.ConnectionStatus.ToString();
                        if (lbl_Status.Text == WifiStatus.Connected.ToString())
                        {
                            btn_Connect.Text = "Disconnect";
                            txBox_SSID.Enabled = false;
                            txBox_Password.Enabled = false;
                            lbl_AP.Text = txBox_SSID.Text.ToString();
                        }
                    }
                }
            }
        }

        private bool Connecter(AccessPoint ap, string password)
        {
            AuthRequest authRequest = new AuthRequest(ap)
            {
                Password = password
            };

            return ap.Connect(authRequest);
        }

        private void ListView_AP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_AP.SelectedItems.Count <= 0)
            {
                txBox_SSID.Clear();
                return;
            }

            try
            {
                if (listView_AP.SelectedItems[0].Tag != null)
                {
                    string selectedSSID = listView_AP.SelectedItems[0].Text.ToString();
                    if (lbl_Status.Text == WifiStatus.Disconnected.ToString())
                    {
                        txBox_SSID.Text = selectedSSID;
                        if (listView_AP.SelectedItems[0].SubItems[2].Text.ToString() == "False")
                        {
                            lbl_Warning.Visible = true;
                            txBox_Password.Text = "#";
                            lbl_Password.Visible = false;
                            txBox_Password.Visible = false;
                            txBox_Password.ReadOnly = true;
                        }
                        if (listView_AP.SelectedItems[0].SubItems[2].Text.ToString() == "True")
                        {
                            lbl_Warning.Visible = false;
                            txBox_Password.Clear();
                            lbl_Password.Visible = true;
                            txBox_Password.Visible = true;
                            txBox_Password.ReadOnly = false;
                        }
                    }
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Ticks++;
            Text = Ticks.ToString();

            lbl_Refreshed.Text = "Refreshed: " + Text + "s ago";
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Ticks = 0;

            listView_AP.Items.Clear();
            wifi = new Wifi();

            List<AccessPoint> aps = wifi.GetAccessPoints();

            foreach (AccessPoint ap in aps)
            {
                lbl_Status.Text = wifi.ConnectionStatus.ToString();

                ListViewItem listView = new ListViewItem(ap.Name);
                listView.SubItems.Add(ap.SignalStrength + "%");
                listView.SubItems.Add(ap.IsSecure.ToString());

                listView.Tag = ap;

                listView_AP.Items.Add(listView);

                if (lbl_Status.Text == WifiStatus.Connected.ToString())
                {
                    btn_Connect.Text = "Disconnect";
                    txBox_SSID.Enabled = false;
                    txBox_Password.Enabled = false;

                    if (NetworkInterface.GetIsNetworkAvailable())
                    {
                        lbl_StatInt.Text = "Secured";
                    }
                    else
                    {
                        lbl_StatInt.Text = "No Internet";
                    }
                }
                else if (lbl_Status.Text == WifiStatus.Disconnected.ToString())
                {
                    btn_Connect.Text = "Connect";
                    txBox_SSID.Enabled = true;
                    txBox_Password.Enabled = true;
                    lbl_AP.Text = "N/A";
                }
            }

            try
            {
                if (lbl_Status.Text == WifiStatus.Connected.ToString())
                {
                    lbl_AP.Text = listView_AP.Items[0].Text;
                }
                else if (lbl_Status.Text == WifiStatus.Disconnected.ToString())
                {
                    lbl_AP.Text = "N/A";
                }
            }
            catch
            {
                lbl_AP.Text = "N/A";
            }
            timer.Enabled = true;
            timer.Start();
        }
    }
}