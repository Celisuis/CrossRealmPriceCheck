using CrossRealmPriceCheck.Managers;
using CrossRealmPriceCheck.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossRealmPriceCheck
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();

            if(!String.IsNullOrWhiteSpace(Settings.Default.API_KEY))
            {
                API_KEY_Textbox.Text = Settings.Default.API_KEY;
                InformationManager.Instance.API_KEY = Settings.Default.API_KEY;
            }
        }

        private void API_KEY_Textbox_TextChanged(object sender, EventArgs e)
        {
            InformationManager.Instance.API_KEY = API_KEY_Textbox.Text;
            
        }

        private void TSM_Account_Page_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitTSMAccountPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to Open Web Browser. Error: {ex.Message}");
            }
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            Settings.Default.API_KEY = InformationManager.Instance.API_KEY;
            Settings.Default.Save();

            if(String.IsNullOrWhiteSpace(API_KEY_Textbox.Text))
            {
                MessageBox.Show("Please enter your TSM API Key");
                return;
            }

            AuctionManager.Instance.ConnectClient();
            CrossRealmCheck crc = new CrossRealmCheck();
            Logger.InitializeWindow();
            crc.Show();

            Hide();
        }

        private void VisitTSMAccountPage()
        {
            System.Diagnostics.Process.Start($"https://www.tradeskillmaster.com/user");
            TSM_Account_Page_Link.LinkVisited = true;
        }
    }
}
