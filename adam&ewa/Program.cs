using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_przyklad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ile na Ziemi jest ludzi?. Niech to będzie liczba całkowita i mała: ");
            int ludnosc = int.Parse(Console.ReadLine());
            Czlowiek.poczatkoweId = ludnosc;
            Console.WriteLine();

            Czlowiek[] czlowiek = new Czlowiek[3];

            czlowiek[0] = new Czlowiek(imie: "Adam", nazwisko: "Kowalski", plec: true);
            czlowiek[1] = new Czlowiek(imie: "Ewa", nazwisko: "Panieńskie", plec: false); // zmiana płci
            czlowiek[2] = new Czlowiek(imie: "Córka", nazwisko: "Kowalska", plec: false, wiek: 1);

            Console.WriteLine("Stworzyełem ludzi o takich parametrach:");


            Console.WriteLine();
            for (int i = 0; i < czlowiek.Length; i++)
            {
                Console.WriteLine("\tCzłowiek {0} imię: {1}, nazwisko: {2}", i + 1, czlowiek[i].Imie, czlowiek[i].nazwisko);
                Console.WriteLine("\t\tMa {0} lat i jest {1}", czlowiek[i].Wiek, Czlowiek.MenOrWomen(czlowiek[i].Plec));
                Console.WriteLine("\tWartość id stworzonego człowieka {0}", czlowiek[i].Id);
                Console.WriteLine();
            }

            Console.WriteLine("Wiek jest zmienny dlatego modifikator dostępu jest public \"set\"");

            Console.WriteLine("dziecko miało {0} lat", czlowiek[2].Wiek);
            czlowiek[2].Wiek = 4;
            Console.WriteLine("a teraz ma {0} lat", czlowiek[2].Wiek);

            Console.WriteLine();

            Console.WriteLine("Nazwisko dla KOBIET (gdy pleć = false) też powinno być zmienne");

            czlowiek[1].nazwisko = "KOWALSKA";

            if (czlowiek[1].nazwisko == "KOWALSKA")
                Console.WriteLine("a teraz nazywa się {0} ", czlowiek[1].nazwisko);



            Console.ReadKey();

        }
    }



    class Czlowiek
    {
        public string Imie { get; private set; }
        string Nazwisko; //get i set ustawiony na końcu classy Czlowiek
        public int Wiek { get; set; }
        public bool Plec { get; private set; }
        public int Id { get; private set; }
        public static int poczatkoweId; //wartość przyjmowana z głównego MAINa

        public Czlowiek(string imie, string nazwisko, bool plec, int wiek = 19) //parametry z domyśłną wartością zawsze na końcu
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
            this.Plec = plec;
            poczatkoweId++; //zwiększamy statyczne id (zawsze isniejące)
            this.Id = poczatkoweId;
        }

        public static string MenOrWomen(bool plec)  // musi być STSTIC bo wtedy to istnieje, jeśli nie ma static to to coś nie istnieje czyli nie można się odwołać, chyba że stworzymy instancje w MAIN wg tego przepisu
        {
            if (plec == false)
                return "KOBIETA";
            return "MĘŻCZYZNA";
        }

        public string nazwisko
        {
            get { return this.Nazwisko; }
            set
            {
                if (Plec == false)
                {
                    this.Nazwisko = value;
                }
                else
                    Console.WriteLine("zmiana dostęna tylko dla Kobiety, zmień płeć");
            }
        }

    }

}
