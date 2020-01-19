using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20lekcja
{
    class Program
    {
        static void Main(string[] args)
        {

            Gracz gracz1 = new Gracz("ADAM");
            Console.WriteLine(gracz1.Nick);
            Console.WriteLine(gracz1.Id);
            // 1! ---   gracz1.Nick = "Łukaszek";
            //Console.WriteLine(gracz1.Nick);



            Gracz gracz2 = new Gracz("EWA");
            Console.WriteLine(gracz2.Nick);
            Console.WriteLine(gracz2.Id);


            Gracz[] swiezy = new Gracz[3];

            swiezy[0] = new Gracz("wolny");
            swiezy[1] = new Gracz("szybki");
            swiezy[2] = new Gracz("umiarkowany");

            for (int i = 0; i < swiezy.Length; i++)
            {
                Console.WriteLine(swiezy[i].Nick);
            }

            for (int i = 0; i < swiezy.Length; i++)
            {
                Console.WriteLine(swiezy[i].Id);
            }

            Console.WriteLine("sprawdzam id "+ Gracz.NastepneId);


            Console.ReadKey();

        }
    }

    class Gracz
    {
        string nick;
        int id;
        static int nastepneId=0;

        public Gracz(string nick)
        {
            this.nick = nick;
            nastepneId++;
            this.id = nastepneId;
        }

        public string Nick //nie funkcja tylko właściwość
        {
            get
            {
                return this.nick;
            }

            /*
            set
            {
                this.nick = value; //pozowli na zmiane nicku, komentarz z "1!"
            }
            */

        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public static int NastepneId
        {
            get
            {
                return nastepneId;
            }
        }
    }
}
