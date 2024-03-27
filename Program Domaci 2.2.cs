using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DomaciSB2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj, fcifra, lcifra, cifre, sbroj;
            Console.WriteLine("Unesite broj:");
            broj = Convert.ToInt32(Console.ReadLine()); 

            lcifra = broj % 10; //pronalazi poslednju cifru unetog broja
            cifre = (int) Math.Log10 (broj); // pronalazi broj cifara unetog broja
            fcifra = (int) (broj / Math.Pow (10, cifre));

            sbroj = lcifra;
            sbroj *= (int) Math.Round(Math.Pow (10, cifre));// math round = zaokruzuje broj u zavisnosti od cifara
            sbroj += broj % ((int)Math.Round(Math.Pow(10, cifre)));// dodaje prvobitan broj na zaokruzen broj
            sbroj -= lcifra;//skida poslednju cifru
            sbroj += fcifra;//dodaje prvu cifru kao poslednju cifru

            Console.Write("Trazeni broj je: " + sbroj);
            Console.ReadKey();
        }
    }
}
