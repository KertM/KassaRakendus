using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace KassaRakendus
{
    class Tšekk : MainWindow
    {
        public void Print(List<MyItem> list)
        {

            List<string> Tekst = new List<string>();
            double kokku = 0;
            foreach (var item in list)
            {
                Tekst.Add(string.Format("{0}x {1} - €{2}", item.Kogus, item.Toode, item.Hind));
                kokku += item.Hind * item.Kogus;
            }
            //File.WriteAllLines("Tšekk.txt", Tekst);
            File.AppendAllText("Tšekk.txt", "______________________" + Environment.NewLine + "Kokku: €" + kokku);

            Process.Start("Tšekk.txt");

            //double a = 0; //hind
            //string b = "0"; //toode
            //double c = 0; //kogus
            //string[] lines = { "{0}x {1} - €{2}", c.ToString(), b, a.ToString() };
            //System.IO.File.WriteAllLines("WriteLines.txt", lines);



        }
    }
}
