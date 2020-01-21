using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szablon_z_Id
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiek1 = new Czlowiek("Łukasz", "Myzia");

            Console.WriteLine(czlowiek1.imie + " " + czlowiek1.nazwisko);

            Console.WriteLine("Id: " + czlowiek1.Id);

            Czlowiek czlowiek2 = new Czlowiek(nazwisko: "Myzia", imie: "Kinga");

            Console.WriteLine(czlowiek2.imie + " " + czlowiek2.nazwisko);

            Console.WriteLine("Id: " + czlowiek2.Id);

            Console.ReadLine();
        }
    }

    class Czlowiek
    {
        //auto implementacja właściwości
        public string imie { get; private set; }
        public string nazwisko { get; private set; }
        public int Id {get; private set;}
        public static int startId=0;

        public Czlowiek(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            startId++;
            this.Id = startId;
            
        }
    }












}
