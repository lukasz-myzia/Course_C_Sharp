using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22b
{
    class Program
    {
        static void Main(string[] args)
        {

            Samochod samochod1 = new Samochod(opis: "mój pierwszy własny samochód z 5kołami");

            Console.WriteLine(samochod1.Opis);
            Console.WriteLine(samochod1.LiczbaKol);
            Console.WriteLine();

            //Samochod samochod2 = samochod1;


            //konstruktor kopiujący
            Samochod samochod2 = new Samochod(samochod1);

            samochod2.Opis = "Mój drugi samochód z 3 kołami";
            //samochod2.liczbaKol = 3;
            Console.WriteLine(samochod2.Opis);
            Console.WriteLine(samochod2.LiczbaKol);

            Console.WriteLine(samochod1.Opis);
            Console.WriteLine(samochod1.LiczbaKol);


            Samochod samochod3 = new Samochod(opis: "ddd", 9);
            samochod3.LiczbaKol = 7;



            Console.ReadKey();

        }
    }




    class Samochod
    {
        public string Opis { get; set; }
        public int LiczbaKol { get; set; }

        public Samochod(string opis, int liczbaKol)
        {
            this.Opis = opis;
            this.LiczbaKol = liczbaKol;
        }
        //Przeciążenie konstruktora:
        public Samochod(string opis) : this(opis, 5)
        {
            Console.WriteLine("Wartość domyśłna z tego konstruktora");
        }

        //Konstruktor kopiujący
        public Samochod(Samochod samochod)
        {
            this.Opis = samochod.Opis;
            this.LiczbaKol = samochod.LiczbaKol;
        }

    }




}
