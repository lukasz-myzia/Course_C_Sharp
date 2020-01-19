using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wlasna_funkcja
{
    class Program
    {
        static void Main(string[] args)
        {

            Procedura();
            double zmienna = double.Parse(Console.ReadLine());

            Console.WriteLine("Wynik z funkcji: " + Przelicznik(zmienna));

            double zmienna1 = Przelicznik(zmienna);

            Console.Write("wynik z procedury: ");
            Procedura1(zmienna1);
            Console.ReadKey();

        }


        public static double Przelicznik(double z)
        {
            double wynik = z * 36.6;
            return wynik;
        }

        public static void Procedura()
        {
            Console.Write("podaj liczbę: ");
        }

        public static void Procedura1(double z)
        {
            Console.WriteLine(z += 10);
        }



    }
}
