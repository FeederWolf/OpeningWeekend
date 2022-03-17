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

            long osszeg = 0;

            foreach (var i in marci)
            {
                if (i.forgalmazo == "UIP")
                {
                    osszeg += i.bevel;
                }
            }
            Console.WriteLine("4. feladat: UIP Duna Film forgalmazó 1. hetes bevételeinek összege: " + osszeg + " Ft");

            Class1 vmax = marci[0];
            foreach (var i in marci)
            {
                if (i.idotartalom > vmax.idotartalom)
                {
                    vmax = i;
                }
            }
            Console.WriteLine("7. feladat: Leghosszabb fuvar:");
            Console.WriteLine($"\tFuvar hossza: {vmax.idotartalom} másodperc");
            Console.WriteLine($"\tTaxi azonosító: {vmax.id}");
            Console.WriteLine($"\tMegtett távolság: {vmax.tavolsag} km");
            Console.WriteLine($"\tViteldíj: {vmax.viteldij}$");

        }
    }
}
