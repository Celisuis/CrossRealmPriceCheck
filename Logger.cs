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

        public static void AddRealm(string realm)
        {
            RealmList.Realm_List.AppendText($"{realm}" + Environment.NewLine);
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

        public static void InitializeWindow()
        {
            RealmList = new RealmList();
            
        }

        public static void ShowWindow()
        {
            RealmList.Show();
        }

        public static void HideWindow()
        {
            RealmList.Visible = false;
        }
    }
}
