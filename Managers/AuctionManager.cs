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

        public Dictionary<string, TSMItem> ItemList;

        public static void StartInstance()
        {
            if (Instance != null)
                return;

            Instance = new AuctionManager();
        }

        public void ConnectClient()
        {
            Client = new TSMClient(InformationManager.Instance.API_KEY);
        }

        public void FetchAuctions(int itemID, List<string> realms)
        {
            ItemList = new Dictionary<string, TSMItem>();

            foreach(string realm in realms)
            {
                TSMItem newItem = Client.TSM.RetrieveRealmItem(itemID, realm, InformationManager.Instance.Region);
                ItemList.Add(realm, newItem);
            }
        }
    }
}
