using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossRealmPriceCheck
{
    public class Saver
    {
        public static void SaveFile(List<string> data)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Text Document|*.txt",
                Title = "Save File",

            };
            dialog.ShowDialog();

            if(!String.IsNullOrWhiteSpace(dialog.FileName))
            {
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    foreach(string info in data)
                    {
                        writer.WriteLine(info);
                    }
                }
            }

            MessageBox.Show($"File Saved Successfully.");
        }
    }
}
