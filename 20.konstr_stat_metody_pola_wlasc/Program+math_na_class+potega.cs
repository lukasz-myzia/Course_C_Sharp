using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20math
{
    class Program
    {
        static void Main(string[] args)
        {
            //clasy ale bez tworzenia obiektów

            Console.WriteLine(Matematyka.dodaj(9, 7));
            Console.WriteLine(Matematyka.PI);

            Console.Write("podaj podstawę potęgi: ");
            int podstawa = int.Parse(Console.ReadLine());

            Console.Write("podaj wykłądnik potęgi: ");
            int wykladnik = int.Parse(Console.ReadLine());

            Console.WriteLine(Matematyka.Potega(podstawa, wykladnik));

            Console.ReadKey();
        }
    }
    class Matematyka
    {
        public static int dodaj(int z, int y)
        {
            int x = z + y;
            return x;
        }

        public static readonly double PI = 3.14;

        public static int Potega(int a, int b)
        {
            int wynik = 1;
            while (b > 0)
            {
                wynik *= a;
                b--;
            }
            Console.Write("podniesiona liczba do potęgi: ");
            return wynik;
        }
    }
}
