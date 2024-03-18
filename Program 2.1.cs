using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_SB_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prvi zadatak
            Console.WriteLine("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj > 100)
            {
                if (broj % 2 == 0)
                {
                    Console.WriteLine("Broj {0} je paran i veci od 100", broj);
                }
                else
                {
                    Console.WriteLine("Broj {0} je neparan i veci od 100", broj);
                }
            }
            if (broj < 100)
            {
                if (broj %2 == 0)
                {
                    Console.WriteLine("Broj {0} je paran i manji od 100", broj);
                }
                else
                {
                    Console.WriteLine("Broj {0} je neparan i manji od 100", broj);
                }
            }

            // Drugi zadatak
            double a, b, c, x, x1, x2, D;
            Console.WriteLine("Unesite parametar jednacine");
            Console.WriteLine("Unesite parametar a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite parametar b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite parametar c: ");
            c = double.Parse(Console.ReadLine());

            D = b * b - 4 * a * c;
            
            if (D < 0)
            {
                Console.WriteLine("Kvadratna jednacina nema resenja");
            }
            else if (D == 0)
            {
                x = (-b) / (2 * a);
                Console.WriteLine("Kvadratna jednacina" + a + "x^2" + b + "x+" + c + "=0 ima jedno resenje x = " + x);
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Kvadratna jednacina" + a + "x^2" + b + "x+" + c + "=0 ima dva resenja x1 = " + x1 + "i x2 = " + x2);
            }
            Console.ReadLine();
        }
    }
}
