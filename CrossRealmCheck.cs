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
            AuctionManager.Instance.FetchAuctions(int.Parse(ItemID_Textbox.Text), InformationManager.Instance.RealmsToCompare);
            BuildTable();
            PopulateTable();
        }

        private void BuildTable()
        {

            DataGridViewTextBoxColumn realmCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Realm Name",
                Name = "Realm",
                Width = 100,
            };

            Report_DataGrid.Columns.Insert(0, realmCol);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Market Average",
                Name = "DBMarket",
                Width = 80
            };

            Report_DataGrid.Columns.Insert(1, priceColumn);

            DataGridViewTextBoxColumn minCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Minimum Buyout",
                Name = "MinBuyout",
                Width = 80
            };

            Report_DataGrid.Columns.Insert(2, minCol);

            DataGridViewTextBoxColumn quanCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Realm Quantity",
                Name = "RealmQuantity",
                Width = 80,
            };

            Report_DataGrid.Columns.Insert(3, quanCol);
        }

        private void PopulateTable()
        {
            string itemName = AuctionManager.Instance.ItemList[InformationManager.Instance.RealmsToCompare.First()].Name;

            Item_Report_Label.Text = $"Item Report for - {itemName}";
            Item_Report_Label.Visible = true;

            foreach (KeyValuePair<string, TSMItem> kvp in AuctionManager.Instance.ItemList)
            {
                Report_DataGrid.Rows.Add($"{kvp.Key}", $"{PriceHelper.ReturnGoldValue(kvp.Value.MarketValue)}", $"{PriceHelper.ReturnGoldValue(kvp.Value.MinimumBuyoutPrice)}", $"{kvp.Value.Quantity}");
                
            }
        }

        private void Display_Message_Checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void Item_Report_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                TryWowHeadLink(AuctionManager.Instance.ItemList.First().Value.ID);
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
            if(EU_Checkbox.Checked)
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
                Logger.HideWindow();

                InformationManager.Instance.RealmListEnabled = false;
            }

            if (!InformationManager.Instance.RealmListEnabled)
            {
                Logger.ShowWindow();

                InformationManager.Instance.RealmListEnabled = true;
            }

        }
    }
}
