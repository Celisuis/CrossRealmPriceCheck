using CrossRealmPriceCheck.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossRealmPriceCheck
{
    public class Loader
    {
        public static void LoadItemList(string filePath)
        {
            try
            {
                var fileText = File.ReadAllLines(filePath);

                InformationManager.Instance.ItemIDsToCompare = fileText.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show($"ERROR: Loading Item IDs from File. {e.Message}");
            }
        }

        public static void LoadRealmList(string filePath)
        {
            try
            {
                var fileText = File.ReadAllLines(filePath);

                InformationManager.Instance.RealmsToCompare = fileText.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show($"ERROR: Loading Realm List from File. {e.Message}");
            }
        }
        
    }
}
