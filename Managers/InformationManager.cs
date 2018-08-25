using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossRealmPriceCheck.Managers
{
   public class InformationManager
    {
        public static InformationManager Instance { get; set; }

        public string API_KEY;

        public string Region;

        public List<string> RealmsToCompare;
        
        public static void StartInstance()
        {
            if (Instance != null)
                return;

            Instance = new InformationManager
            {
                RealmsToCompare = new List<string>()
            };
        }
    }
}
