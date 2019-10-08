using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Beer
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer b1 = new Beer()
            {   Navn = "Carlsberg",
                Slags = Beer.BeerType.Pilsner,
                Procent = (float)7.2,
                Volumen = 50
            };

            Beer b2 = new Beer()
            {
                Navn = "Tuborg",
                Slags = Beer.BeerType.Münchener,
                Procent = (float)4.1,
                Volumen = 33
            };

            Beer b3 = new Beer()
            {
                Navn = "Skagen",
                Slags = Beer.BeerType.Wiener,
                Procent = (float)10.9,
                Volumen = 50
            };

            Beer[] Beers = new Beer[3];
            Beers[0] = b1;
            Beers[1] = b2;
            Beers[2] = b3;

            Console.WriteLine("\n");
            int comp = b1.CompareTo(b2); //Hvis p1 er størst giver det et positivt tal || Hvis de er ens giver det 0 || Hvis p2 er størst giver det et negativt tal

            Array.Sort(Beers, new CompareBeer());
            foreach (Beer b in Beers)
            {
                Console.WriteLine($"{b}\n");
            }
            //Console.WriteLine("\n\nOvenover er de sorteret efter navn\nUnder er de ikke\n\n");
            //Console.WriteLine($"{b1}\n\n{b2}\n\n{b3}");

            //Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            //Beer blanding1 = b1 + b2;
            //Console.WriteLine(blanding1);

            //Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            //Array.Sort(Beers, new CompareBeerByVolumen());
            //foreach (Beer v in Beers)
            //{
            //    Console.WriteLine($"{v}\n");
            //}

            //Console.WriteLine("\n\n\n\n\n\n\n\n\n procent");
            //Array.Sort(Beers, new CompareBeerByProcent());
            //foreach (Beer p in Beers)
            //{
            //    Console.WriteLine($"{p}\n");
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
