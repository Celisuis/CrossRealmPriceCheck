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
    public partial class RealmList : Form
    {
        public RealmList()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Realm_List.Text))
            {
                MessageBox.Show($"Please enter at least one Realm to save.");
                return;
            }

            try
            {
                Saver.SaveFile(InformationManager.Instance.RealmsToCompare);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: Saving Text to File. {ex.Message}");
            }
        }
    }
}
