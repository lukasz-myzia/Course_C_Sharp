using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        Czlowiek panNikt = new Czlowiek();

        Console.WriteLine("Stworzyłem Pana Nikt o imieniu domyśłnym");
        Console.WriteLine(panNikt.pobierzImie());

        Czlowiek adam = new Czlowiek();

        Console.WriteLine("Jest już Adam ale nie nadałem mu imienie");
        Console.WriteLine("Więc Adam ma na imię " + adam.pobierzImie());

        adam.zmienImie("ADAM");

        Console.WriteLine(adam.pobierzImie());

        Czlowiek ewa = new Czlowiek();

        Console.WriteLine("jest już Ewa, która ma na imię:");
        Console.WriteLine(ewa.pobierzImie());

        Console.WriteLine("Ewa przyjeła imię domyśłne, nie wie nic o Adamie. Zmieniam imię na EWA");

        ewa.zmienImie("EWA");

        Console.WriteLine("nowe imie dla kobiety: " + ewa.pobierzImie());

        Console.ReadKey();
    }
}

/*
 * OBIEKT - wszystko do okoła. OBIEKT ma cechy, coś co go określa, opisuje.
 * OBIEKT - ma nam służyć, ma mieć FUNKCJE, CZYNNOŚCI z ktrych będziemy korzystać
 *      MONITOR - typ: LCD, kineskop, kolor, wyjcia: HDMI, JACK, wyświetla
 *      KOMÓRKA - dotyk, klasyk, dzwoni, wysyła SMSy
 *      CZŁOWIEK - imie, nazwisko, kolor, student, nauczyciel, oddycha
 *      
 * CLASSA - forma, szablon do tworzenia "EGZEMPLARZA CLASSY" -->> OBIEKTU
 *          CLASSA coś co klasyfikuje wg cech...
 */

/*
 * INSTANCJA CLASSY - egzemplarz, kolejny elementy czyli OBIEKT wyprodukowany przez CLASSĘ
 *          Czlowiek -->>adamIewa<<-- = new Czlowiek();
 */

class Czlowiek     // Człowiek - nasz własny typ zmiennej
{
    string imie = "NO_Name"; //zmienna jest cechą mojego człowieka
    int wzrost;

    //Funkcje:

    /*
     *                                                     parametr = argument
     * [modyfikator] TYP_zwracana NAZWA_funkcji (typ_zm parametr1, typ_zm parametr2)
     *    {
     *    instrukcje funkcji
     *    Return TYP_zwracana
     *    }
     */

    //Przykład funcji pobierającej imię człowieka z CLASSY
    public string pobierzImie()
    {
        Console.WriteLine("pobieram imię z classy");
        return imie;
    }

    //Przykład procedury zmieniającej imię CLASSY
    public void zmienImie(string imie)
    {
        Console.WriteLine("wywołała się funckcja która zmieni mi domyśłne imię");
        this.imie = imie;
    }
}