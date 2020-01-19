using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowe_bez_komentarzy
{
    class Program
    {
        static void Main(string[] args)
        {

            Czlowiek osoba_1 = new Czlowiek();
            Console.WriteLine(osoba_1.getImie());
            Console.WriteLine(osoba_1.getWiek());

            osoba_1.setWiek(9);
            Console.WriteLine(osoba_1.getWiek());

            Console.ReadKey();

        }
    }

    class Czlowiek
    {
        string imie = "No_Name";
        int wiek;

        public string getImie()
        {
            return imie;
        }

        public int getWiek()
        {
            return wiek;
        }

        public void setWiek(int wiek)
        {
            this.wiek = wiek;
        }

    }

}
