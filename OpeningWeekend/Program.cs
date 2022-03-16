using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OpeningWeekend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> marci = new List<Class1>();
            foreach (var fasz in File.ReadAllLines("nyitohetvege.txt").Skip(1))
            {
                marci.Add(new Class1(fasz));
            }
            Console.WriteLine("3. feladat: Filmek száma az állományban: " + marci.Count + " db");

            int osszeg = 0;

            foreach (var i in marci)
            {
                if (i.forgalmazo == "UIP")
                {
                    osszeg += i.bevel;
                }
            }
            Console.WriteLine(osszeg);
        }
    }
}
