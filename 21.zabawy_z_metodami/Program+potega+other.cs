using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21jedziemy_dalej
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("oblicze wartosc bezwzgledna podaj swoja liczbe: ");
            int zmienna1 = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Abs(zmienna1));

            Console.WriteLine("podaj liczbe a ja zwieksza ją o 5: ");
            int zmienna2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.PowiekszO5(zmienna2));
            Console.WriteLine(zmienna2);
            Console.WriteLine(" działamy na kopi dlatego nie zwiekszyło");

            Console.WriteLine(Math.PowiekszO5(ref zmienna2));
            Console.WriteLine(zmienna2);
            Console.WriteLine(" przekazna przez referencje czyli zwiekszyło");

            //odwołanie się do adresu w pamięci - odwołanie przez referencje
            //ower load funkcje ma tę samąnazwę ale musi róznić się parametrami


            int zmienna3;
            // Console.WriteLine(zmienna3); // tu jest bląd

            Math.Zeruj(out zmienna3);
            Console.WriteLine("wyzerowana zmienna3 " + zmienna3);

            Console.WriteLine(Math.Dodaj(3, 4, 8, 8));

            Console.WriteLine(Math.Potega(2, -8));

            Console.ReadKey();

        }
    }

    class Math
    {
        public static int Abs(int a)
        {
            if (a < 0)
                return a * (-1);
            //else //ale nie konieczne
            return a;
        }

        public static int PowiekszO5(int q)
        {
            //q = q + 5;
            return q += 5;
        }

        public static int PowiekszO5(ref int q)
        {
            //q = q + 5;
            return q += 5;
        }

        public static void Zeruj(out int zmienna3)
        {
            zmienna3 = 6666;
        }

        public static int Dodaj(params int[] argumenty)
        {
            int suma = 0;
            for (int i = 0; i < argumenty.Length; i++)
            {
                suma += argumenty[i]; //suma = suma + argumenty[i];
            }
            return suma;
        }

        public static int Potega(int a, int b = 2) //przypisanie do argumentu wartości: - domyśłne parametry
        {
            int wynik = 1;

            if (b < 0)
            {
                Console.Write("wykladnik nie może być ujemny! ");
                return 0;
            }
            for (int i = 0; i < b; i++)
            {
                wynik *= a;
            }
            Console.Write("podniesiona liczba do potęgi: ");
            return wynik;
        }

    }
}
