using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS3_zadaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prvibr, drugibr, trecibr;

            Console.WriteLine("Unesite prvi broj: ");
            prvibr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite drui broj: ");
            drugibr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite treci broj: ");
            trecibr = Convert.ToInt32(Console.ReadLine());

            if (drugibr > prvibr && drugibr > trecibr)
            {
                Console.WriteLine("Najveci broj je {0}", drugibr);
            }
            else if (prvibr > trecibr)
            {
                Console.WriteLine("Najveci broj je {0}", prvibr);
            }
            else if (trecibr > prvibr)  
            {
                Console.WriteLine("Najveci  broj je {0}", trecibr);
            }
            else
            {
                Console.WriteLine("Svi brojevi su  jednaki");
            }
        }
    }
}
