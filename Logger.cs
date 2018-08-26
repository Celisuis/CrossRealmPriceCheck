using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossRealmPriceCheck
{
    public class Logger
    {
        public static RealmList RealmList;
        public static ItemList ItemList;
        public static void AddRealm(string realm)
        {
            RealmList.Realm_List.AppendText($"{realm}" + Environment.NewLine);
        }

        public static void AddItem(string itemID)
        {
            ItemList.ItemID_RichBox.AppendText($"{itemID}" + Environment.NewLine);
        }

        public static void RemoveRealm(string realm)
        {
            List<string> realms = RealmList.Realm_List.Lines.ToList();

            realms.Remove(realm);

            RealmList.Realm_List.Text = String.Empty;

            foreach(string srealm in realms)
            {
                RealmList.Realm_List.AppendText($"{srealm}" + Environment.NewLine);
            }
        }

        public static void RemoveItem(string itemID)
        {
            List<string> items = ItemList.ItemID_RichBox.Lines.ToList();

            items.Remove(itemID);

            RealmList.Realm_List.Text = String.Empty;

            foreach (string srealm in items)
            {
                RealmList.Realm_List.AppendText($"{srealm}" + Environment.NewLine);
            }
        }
        public static void InitializeRealmWindow()
        {
            RealmList = new RealmList();
            
        }

        public static void InitializeItemWindow()
        {
            ItemList = new ItemList();
        }

        public static void ShowRealmWindow()
        {
            RealmList.Show();
        }

        public static void ShowItemWindow()
        {
            ItemList.Show();
        }
        public static void HideRealmWindow()
        {
            RealmList.Hide();
        }

        public static void HideItemWindow()
        {
            ItemList.Hide();
        }
    }
}
