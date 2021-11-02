using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA211102
{
    class Program
    {
        static List<Ember> emberek = new List<Ember>();
        static void Main()
        {
            InitEmberek();

            //Összegzés
            //pl: listában lévők összsúlya:
            float res_01 = emberek.Sum(x => x.Suly);

            //Átlag
            //pl: átlagos magasság:
            double res_02 = emberek.Average(x => x.Magassag);

            //Megszámlálás
            //pl. verebélyesek száma:
            int res_03 = emberek.Count(x => x.Iskola == "Verebély");

            //Minimum/Maximum érték
            //legkisebb magasság:
            int res_04 = emberek.Min(x => x.Magassag);
            //legnagyobb súly
            float res_05 = emberek.Max(x => x.Suly);

            //Első/Utolsó <T>-nek megfelelő elem
            //pl: első UMSZKIs
            //ha nincs ilyen elem, akkor exception
            Ember res_06 = emberek.First(x => x.Iskola == "UMSzKI");
            //ha nincs ilyen elem akkor a res null:
            Ember res_16 = emberek.FirstOrDefault(x => x.Iskola == "UMSzKI");

            //pl: utolsó 180cmnél alacsonyabb
            Ember res_07 = emberek.Last(x => x.Magassag < 180);
            Ember res_17 = emberek.LastOrDefault(x => x.Magassag < 180);

            //<T>nek megfelelők listája
            //pl: összes verebélyes
            IEnumerable<Ember> res_08 = emberek.Where(x => x.Iskola == "Verebély");
            //ha ebből szeretnék egy "normál" listát:
            List<Ember> res_09 = res_08.ToList();

            //"csak" adott tulajdonságok listája
            IEnumerable<string> res_10 = emberek.Select(x => x.Nev);
            //ezt is lehet listává alakítani:
            List<string> res_11 = res_10.ToList();

            //Rendezés
            //születési dátum szerint növekvőbe:
            IOrderedEnumerable<Ember> res_12 = emberek.OrderBy(x => x.Szul);
            //súly szerint csökkenőbe:
            IOrderedEnumerable<Ember> res_13 = emberek.OrderByDescending(x => x.Suly);

            //Tartalmaz <T>?
            bool res_14 = emberek.Any(x => x.Nev == "Kiss Pista");

            //csoportosítás
            IEnumerable<IGrouping<string, Ember>> res_15 = emberek.GroupBy(x => x.Iskola);

            Console.ReadKey(true);
        }

        private static void InitEmberek()
        {
            emberek.Add(new Ember()
            {
                Nev = "Kiss Pista",
                Szul = new DateTime(2000, 05, 11),
                Iskola = "Verebély",
                Magassag = 174,
                Suly = 68.3F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Füty Imre",
                Szul = new DateTime(1997, 11, 01),
                Iskola = "Verebély",
                Magassag = 182,
                Suly = 102F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Fá Zoltán",
                Szul = new DateTime(1999, 09, 02),
                Iskola = "Neumann",
                Magassag = 162,
                Suly = 82.6F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kiss Pista",
                Szul = new DateTime(2000, 03, 20),
                Iskola = "Verebély",
                Magassag = 190,
                Suly = 88F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kiss Pista",
                Szul = new DateTime(2001, 05, 16),
                Iskola = "Neumann",
                Magassag = 178,
                Suly = 73.5F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kiss Pista",
                Szul = new DateTime(2001, 10, 06),
                Iskola = "Verebély",
                Magassag = 158,
                Suly = 81.2F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kiss Pista",
                Szul = new DateTime(2000, 12, 10),
                Iskola = "UMSzKI",
                Magassag = 170,
                Suly = 93.7F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kiss Pista",
                Szul = new DateTime(1997, 01, 05),
                Iskola = "Neumann",
                Magassag = 201,
                Suly = 120F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kiss Pista",
                Szul = new DateTime(1990, 06, 04),
                Iskola = "UMSzKI",
                Magassag = 162,
                Suly = 92.1F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kiss Pista",
                Szul = new DateTime(2001, 05, 26),
                Iskola = "Neumann",
                Magassag = 185,
                Suly = 80F,
            });
        }
    }
}
