using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSMCSharp;


using TSMItem = TSMCSharp.Item;
namespace CrossRealmPriceCheck.Managers
{
    public class AuctionManager
    {


        public static AuctionManager Instance { get; set; }

        public TSMClient Client;

        public Dictionary<TSMItem, string> ItemDictionary;

        public List<TSMItem> ItemList;

        public List<Dictionary<TSMItem, string>> DictionaryList;

        public static void StartInstance()
        {
            if (Instance != null)
                return;

            Instance = new AuctionManager();
        }

        public void ConnectClient()
        {
            Client = new TSMClient(InformationManager.Instance.API_KEY);
            ItemList = new List<TSMItem>();
            DictionaryList = new List<Dictionary<TSMItem, string>>();

        }

        public void FetchAuctions(int itemID, List<string> realms)
        {
            ItemDictionary = new Dictionary<TSMItem, string>();

            foreach (string realm in realms)
            {
                TSMItem newItem = Client.TSM.RetrieveRealmItem(itemID, realm, InformationManager.Instance.Region);
                ItemDictionary.Add(newItem, realm);

                DictionaryList.Add(ItemDictionary);
            }
        }

        public void FetchSingleAuction(int itemID, string realm)
        {
            ItemDictionary = new Dictionary<TSMItem, string>();

            TSMItem item = Client.TSM.RetrieveRealmItem(itemID, realm, InformationManager.Instance.Region);

            ItemDictionary.Add(item, realm);
            DictionaryList.Add(ItemDictionary);
        }

        public void ClearDictionaryList()
        {
            DictionaryList.Clear();
        }

    }
}
