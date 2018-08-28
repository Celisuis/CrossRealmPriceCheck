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
    public partial class ItemList : Form
    {
        public ItemList()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(ItemID_RichBox.Text))
            {
                MessageBox.Show($"Please enter at least one Item ID to save.");
                return;
            }

            try
            {
                Saver.SaveFile(InformationManager.Instance.ItemIDsToCompare);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: Saving Text to File. {ex.Message}");
            }
        }
    }
}
