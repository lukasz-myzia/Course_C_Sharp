using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21bbbb
{
    class Program
    {
        static void Main(string[] args)
        {
            Obywatel czlowiek = new Obywatel("Łukasz", "Myzia");

            Console.WriteLine(czlowiek.imie + " " + czlowiek.nazwisko);

            Obywatel czlowiek2 = new Obywatel(nazwisko:"Myzia", imie:"Kinga");

            Console.WriteLine(czlowiek2.imie + " " + czlowiek2.nazwisko);

            Console.ReadLine();
        }
    }

    class Obywatel
    {
        //auto implementacja właściwości
        public string imie { get; private set; }
        public string nazwisko { get; private set; }

        public Obywatel(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }


}
