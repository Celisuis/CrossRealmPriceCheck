using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossRealmPriceCheck.Managers
{
    public class LoadManager
    {
        public static LoadManager Instance { get; set; }

        public string ItemListFilePath;

        public string RealmListFilePath;
        public static void StartInstance()
        {
            if (Instance != null)
                return;

            Instance = new LoadManager();
        }
    }
}
