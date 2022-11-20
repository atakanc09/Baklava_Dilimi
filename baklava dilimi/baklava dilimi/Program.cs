using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baklava_dilimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int satir, bosluk, yildiz = 1;

            Console.Write("Kaç satırlık bir baklava dilimi istiyorsunuz = ");
            satir = int.Parse(Console.ReadLine());
            bosluk = satir / 2;

            for(int i = 0; i < satir; i++)
            {
                for(int j = 0; j < bosluk; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < yildiz; k++)
                {
                    Console.Write("*");
                }
                if (i < satir / 2)
                {
                    bosluk--;
                    yildiz += 2;
                }
                else
                {
                    bosluk++;
                    yildiz -= 2;
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}
