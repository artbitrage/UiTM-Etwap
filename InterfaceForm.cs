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
                lbl_Status.Text = wifi.ConnectionStatus.ToString();

                ListViewItem listView = new ListViewItem(ap.Name);
                listView.SubItems.Add(ap.SignalStrength + "%");
                listView.SubItems.Add(ap.IsSecure.ToString());

                listView.Tag = ap;

                listView_AP.Items.Add(listView);

                if (lbl_Status.Text == WifiStatus.Connected.ToString())
                {
                    btn_Connect.Enabled = false;
                    txBox_SSID.Enabled = false;
                    txBox_Password.Enabled = false;
                    btn_Disconnect.Enabled = true;
                }
                else if (lbl_Status.Text == WifiStatus.Disconnected.ToString())
                {
                    btn_Connect.Enabled = true;
                    txBox_SSID.Enabled = true;
                    txBox_Password.Enabled = true;
                    btn_Disconnect.Enabled = false;
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
            if (listView_AP.SelectedItems.Count > 0 && txBox_Password.Text.Length > 0)
            {
                ListViewItem selectedItem = listView_AP.SelectedItems[0];

                AccessPoint ap = (AccessPoint)selectedItem.Tag;

                if (Connecter(ap, txBox_Password.Text))
                {
                    lbl_Status.Text = wifi.ConnectionStatus.ToString();
                    if (lbl_Status.Text == WifiStatus.Connected.ToString())
                    {
                        btn_Connect.Enabled = false;
                        txBox_SSID.Enabled = false;
                        txBox_Password.Enabled = false;
                        btn_Disconnect.Enabled = true;
                        lbl_AP.Text = txBox_SSID.Text.ToString();
                    }
                }
                else
                {
                    lbl_Status.Text = wifi.ConnectionStatus.ToString();
                    if (lbl_Status.Text == WifiStatus.Disconnected.ToString())
                    {
                        btn_Connect.Enabled = true;
                        txBox_SSID.Enabled = true;
                        txBox_Password.Enabled = true;
                        txBox_Password.Clear();
                        btn_Disconnect.Enabled = false;
                        lbl_AP.Text = "N/A";
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

        private void Btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (wifi.ConnectionStatus == WifiStatus.Connected)
                wifi.Disconnect();

            lbl_AP.Text = "N/A";
            lbl_Status.Text = WifiStatus.Disconnected.ToString();
            btn_Connect.Enabled = true;
            txBox_SSID.Enabled = true;
            txBox_Password.Enabled = true;
            btn_Disconnect.Enabled = false;
        }

        private void ListView_AP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_AP.SelectedIndices.Count <= 0)
            {
                txBox_SSID.Clear();
                return;
            }
            int selectedIndex = listView_AP.SelectedIndices[0];

            try
            {
                if (selectedIndex >= 0)
                {
                    var selectedSSID = listView_AP.SelectedItems[selectedIndex].Text;
                    txBox_SSID.Text = selectedSSID;
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}