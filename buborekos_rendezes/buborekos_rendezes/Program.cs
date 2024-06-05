using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace buborekos_rendezes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); int i, j, b;

            int[] letsz = new int[14];
            for ( i = 0; i<14;i++)
            {
                letsz[i] = r.Next(450, 601);
            }

            Console.WriteLine("A 14 iskola létszámai: ");

            for ( i = 0; i < letsz.Length; i++)
            {
                Console.Write(letsz[i] + " ");
            }

            Console.WriteLine();

            for (i = 13; i >= 1; i--)
            {
                for (j = 0; j <= i - 1; j++)
                {
                    if (letsz[j] > letsz[j+1])
                    {
                        b= letsz[j];
                        letsz[j] = letsz[j + 1];
                        letsz[j + 1] = b;
                    }
                }
            }

            Console.WriteLine("\nA 14 iskola létszámai, buborékos rendezéssel: ");

            for (i = 0; i < letsz.Length; i++)
            {
                Console.Write(letsz[i] + " ");
            }


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
