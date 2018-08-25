using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CrossRealmPriceCheck
{
    public partial class UpdateAvailable : Form
    {
        public UpdateAvailable()
        {
            InitializeComponent();
        }

        private void No_Button_Click(object sender, EventArgs e)
        {
            Connect newConnect = new Connect();
            newConnect.Show();

            Hide();
        }

        private void Yes_Button_Click(object sender, EventArgs e)
        {
            DownloadUpdate();
        }

        private void DownloadUpdate()
        {
            using (var client = new WebClient())
            {
                XmlDocument remoteXML = new XmlDocument();
                remoteXML.Load($"https://raw.githubusercontent.com/Celisuis/CrossRealmPriceCheck/master/Versioning.xml");

                XmlNode remoteNode = remoteXML.SelectSingleNode("Versioning/DownloadLink");

                client.DownloadFile(remoteNode.Value, "Update.zip");
            }

            
        }
    }
}
