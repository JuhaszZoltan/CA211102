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
        static void Main(string[] args)
        {
            InitEmberek();
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
