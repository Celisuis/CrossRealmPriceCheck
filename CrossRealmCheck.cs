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
using TSMCSharp.Helpers;
using Microsoft.WindowsAPICodePack.Dialogs;


using TSMItem = TSMCSharp.Item;
namespace CrossRealmPriceCheck
{
    public partial class CrossRealmCheck : Form
    {
        public CrossRealmCheck()
        {
            InitializeComponent();
        }

        private void Realm_Name_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Realm_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Realm_Name_Textbox.Text))
            {
                MessageBox.Show("Please Enter a Realm Name");
                return;
            }

            string realmToAdd = Realm_Name_Textbox.Text.Replace(' ', '-').ToLower();

            if (InformationManager.Instance.RealmsToCompare.Contains(realmToAdd))
            {
                MessageBox.Show($"Compare list already contains {realmToAdd}!");
            }
            else
            {
                InformationManager.Instance.RealmsToCompare.Add(realmToAdd);

                Logger.AddRealm(realmToAdd);

                if (Display_Message_Checkbox.Checked)
                {
                    MessageBox.Show($"{realmToAdd} has been added to Compare List.");
                }

            }



            Realm_Name_Textbox.Text = String.Empty;
        }

        private void Remove_Realm_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Realm_Name_Textbox.Text))
            {
                MessageBox.Show("Please Enter a Realm Name");
            }

            string realmToAdd = Realm_Name_Textbox.Text.Replace(' ', '-').ToLower();

            if (InformationManager.Instance.RealmsToCompare.Contains(realmToAdd))
            {
                InformationManager.Instance.RealmsToCompare.Remove(realmToAdd);

                Logger.RemoveRealm(realmToAdd);

                if (Display_Message_Checkbox.Checked)
                {
                    MessageBox.Show($"{realmToAdd} has been removed to Compare List.");
                }
            }
            else
            {
                MessageBox.Show($"Cannot find {realmToAdd} in the Compare List!");
            }



            Realm_Name_Textbox.Text = String.Empty;
        }

        private void Check_Realms_Button_Click(object sender, EventArgs e)
        {
            InformationManager.Instance.TabsGenerated.Clear();
            Report_TabControl.Controls.Clear();
            AuctionManager.Instance.ClearDictionaryList();

            foreach (string id in InformationManager.Instance.ItemIDsToCompare)
            {
                int itemID = int.Parse(id);
                AuctionManager.Instance.FetchAuctions(itemID, InformationManager.Instance.RealmsToCompare);
                
            }
            GenerateTabs(AuctionManager.Instance.DictionaryList);

        }

        private void GenerateTabs(List<Dictionary<TSMItem, string>> items)
        {
            foreach (Dictionary<TSMItem, string> dict in items)
            {
                KeyValuePair<TSMItem, string> kvp = dict.First();
                if (!InformationManager.Instance.TabsGenerated.Contains(kvp.Key.Name))
                    GenerateTab(dict);
            }
        }

        private void GenerateTab(Dictionary<TSMItem, string> items)
        {
            DataGridView dgv = new DataGridView
            {
                Location = new Point(22, 17),
                Size = new Size(637, 233),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
            };
            
            DataGridViewTextBoxColumn realmCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Realm Name",
                Name = "RealmName",
                Width = 200
            };

            DataGridViewTextBoxColumn marketCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Market Average",
                Name = "MarketAverage",
                Width = 150
            };

            DataGridViewTextBoxColumn minCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Minimum Buyout",
                Name = "MinimumBuyout",
                Width = 150
            };

            DataGridViewTextBoxColumn quanCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Realm Quantity",
                Name = "RealmQuantity",
                Width = 150
            };
            
            dgv.Columns.Insert(0, realmCol);
            dgv.Columns.Insert(1, marketCol);
            dgv.Columns.Insert(2, minCol);
            dgv.Columns.Insert(3, quanCol);

            foreach (KeyValuePair<TSMItem, string> kvp in items)
            {
                dgv.Rows.Add($"{kvp.Value}", $"{PriceHelper.ReturnGoldValue(kvp.Key.MarketValue)}", $"{PriceHelper.ReturnGoldValue(kvp.Key.MinimumBuyoutPrice)}", $"{kvp.Key.Quantity}");

            }

            KeyValuePair<TSMItem, string> firstItem = items.First();

            TabPage newPage = new TabPage
            {
                Text = $"{firstItem.Key.Name}",
                Size = new Size(682, 273),
            };
            newPage.Controls.Add(dgv);

            InformationManager.Instance.TabsGenerated.Add(firstItem.Key.Name);

            Report_TabControl.Controls.Add(newPage);
        }


        private void Display_Message_Checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void Item_Report_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                TryWowHeadLink(AuctionManager.Instance.ItemDictionary.First().Key.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to Open Web Browser. Error: {ex.Message}");
            }
        }

        private void TryWowHeadLink(long itemID)
        {
            System.Diagnostics.Process.Start($"https://www.wowhead.com/item={itemID}");
            Item_Report_Label.LinkVisited = true;
        }

        private void EU_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (EU_Checkbox.Checked)
            {
                InformationManager.Instance.Region = "EU";
                US_Checkbox.Checked = false;
            }
        }

        private void US_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (US_Checkbox.Checked)
            {
                InformationManager.Instance.Region = "US";
                EU_Checkbox.Checked = false;
            }
        }

        private void showRealmListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (InformationManager.Instance.RealmListEnabled)
            {
                Logger.HideRealmWindow();

                InformationManager.Instance.RealmListEnabled = false;
            }

            if (!InformationManager.Instance.RealmListEnabled)
            {
                Logger.ShowRealmWindow();

                InformationManager.Instance.RealmListEnabled = true;
            }

        }

        private void showItemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InformationManager.Instance.ItemListEnabled)
            {
                Logger.HideItemWindow();

                InformationManager.Instance.ItemListEnabled = false;
            }

            if (!InformationManager.Instance.ItemListEnabled)
            {
                Logger.ShowItemWindow();

                InformationManager.Instance.ItemListEnabled = true;
            }
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ItemID_Textbox.Text))
            {
                MessageBox.Show("Please Enter a Item ID");
                return;
            }

            if (InformationManager.Instance.ItemIDsToCompare.Contains(ItemID_Textbox.Text))
            {
                MessageBox.Show($"Item list already contains {ItemID_Textbox.Text}!");
            }
            else
            {
                InformationManager.Instance.ItemIDsToCompare.Add(ItemID_Textbox.Text);

                Logger.AddItem(ItemID_Textbox.Text);

                if (Display_Message_Checkbox.Checked)
                {
                    MessageBox.Show($"{ItemID_Textbox.Text} has been added to Item List.");
                }

            }

            ItemID_Textbox.Text = String.Empty;
        }

        private void RemoveItem_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ItemID_Textbox.Text))
            {
                MessageBox.Show("Please Enter a Item ID");
            }

            if (InformationManager.Instance.ItemIDsToCompare.Contains(ItemID_Textbox.Text))
            {
                InformationManager.Instance.ItemIDsToCompare.Remove(ItemID_Textbox.Text);

                Logger.RemoveItem(ItemID_Textbox.Text);

                if (Display_Message_Checkbox.Checked)
                {
                    MessageBox.Show($"{ItemID_Textbox.Text} has been removed from the Item List.");
                }
            }
            else
            {
                MessageBox.Show($"Cannot find {ItemID_Textbox.Text} in the Compare List!");
            }



            ItemID_Textbox.Text = String.Empty;
        }

        private void fromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Filter = "Text Document|*.txt",
                Title = "Choose your Item ID List",
                Multiselect = false,
                InitialDirectory = $"{System.Environment.SpecialFolder.MyDocuments}",
            };

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                LoadManager.Instance.ItemListFilePath = dialog.FileName;

                if (!String.IsNullOrWhiteSpace(LoadManager.Instance.ItemListFilePath))
                {
                    Loader.LoadItemList(LoadManager.Instance.ItemListFilePath);
                    Logger.UpdateItemList(InformationManager.Instance.ItemIDsToCompare);

                    MessageBox.Show($"Item List Loaded Successfully.");
                }
            }

         
        }

        private void tSMGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSMImport import = new TSMImport();
            import.Show();
        }

        private void loadRealmListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Filter = "Text Document|*.txt",
                Title = "Choose your Realm List",
                Multiselect = false,
                InitialDirectory = $"{System.Environment.SpecialFolder.MyDocuments}",
            };

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                LoadManager.Instance.RealmListFilePath = dialog.FileName;

                if(!String.IsNullOrWhiteSpace(LoadManager.Instance.RealmListFilePath))
                {
                    Loader.LoadRealmList(LoadManager.Instance.RealmListFilePath);
                    Logger.UpdateRealmList(InformationManager.Instance.RealmsToCompare);

                    MessageBox.Show($"Realm List Loaded Successfully.");
                }
            }
        }
    }
}
