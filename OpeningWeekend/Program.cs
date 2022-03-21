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
                if (i.latogato > vmax.latogato)
                {
                    vmax = i;
                }
            }
            Console.WriteLine("5. feladat: Legtöbb látogató az első  héten:");
            Console.WriteLine($"\tEredeti cím: {vmax.eredetiCim} másodperc");
            Console.WriteLine($"\tMagyar cím: {vmax.magyarCim}");
            Console.WriteLine($"\tForgalmazó: {vmax.forgalmazo}");
            Console.WriteLine($"\tBevétel az első héten: {vmax.bevel} Ft");
            Console.WriteLine($"\tLátogatók száma: {vmax.latogato}$");

            int van = 0;

            foreach (var i in marci)
            {
                if (i.eredetiCim.ElementAt(0) == 'W' || i.magyarCim.ElementAt(0) == 'W' || i.eredetiCim.ElementAt(0) == 'w' || i.magyarCim.ElementAt(0) == 'w')
                {
                    van++;
                }
            }
            if (van > 0)
            {
                Console.WriteLine("6. feladat: van ilyen film!");
            }
            else
            {
                Console.WriteLine("6. feladat: nincs ilyen film!");
            }

            

        }
    }
}
