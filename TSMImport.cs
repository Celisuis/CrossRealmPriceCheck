using CrossRealmPriceCheck.Managers;
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
    public partial class TSMImport : Form
    {
        public TSMImport()
        {
            InitializeComponent();
        }

        private void Import_Button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(TSM_Import_Textbox.Text))
            {
                MessageBox.Show($"Please enter at least one TSM Item ID. Groups can be made on the TSM Group Maker.");
            }
            string[] itemIDArray = TSM_Import_Textbox.Text.Split(';');
            ProcessIDs(itemIDArray);
            Logger.UpdateItemList(InformationManager.Instance.ItemIDsToCompare);
            MessageBox.Show($"Item IDs Successfully Imported.");
            Close();
        }

        private void ProcessIDs(string[] itemIDArray)
        {
            for(int i = 0; i < itemIDArray.Length; i++)
            {
                string newID = itemIDArray[i].Replace("i:", String.Empty);
                if (!InformationManager.Instance.ItemIDsToCompare.Contains(newID))
                    InformationManager.Instance.ItemIDsToCompare.Add(newID);
            }
        }
    }
}
