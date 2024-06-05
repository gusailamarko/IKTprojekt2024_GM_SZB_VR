using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatAKod
{
    internal class Program
    {
        //TÖMB ELEMEINEK SZÁMA
        static public int n = 13;
        //TÖMB DEFINIÁLÁSA (ÜRES)
        static public int[] homersekletek = new int[n];

        static public void feltoltes(int[] homersekletek)
        {
            //ESZTÉTIKA
            Console.WriteLine("13 nap hőmérsékletei (eredeti/rendezetlen sorrendben):");
            Console.Write("\t");
            //RANDOM SZÁMOK HASZNÁLATA
            Random r = new Random();
            //CIKLUS, AMI ÁTMEGY AZ ÜRES TÖMB HELYEIN
            for(int i=0;i<homersekletek.Length;i++)
            {
                //CIKLUS FELTÖLTÉSE 10-30 KÖZÖTTI RANDOM SZÁMOKKAL
                homersekletek[i] = r.Next(10, 31);
                //TÖMB ELEMEINKE KIIRATÁSA
                Console.Write(homersekletek[i] + "°C ");
            }
        }

        static public int[] egyszeruCseresRendezes(int[] homersekletek)
        {
            //ESZTÉTIKA
            Console.WriteLine("Ugyanannak a 13 napnak hőmérsékletei (rendezetten):");
            Console.Write("\t");
            //SEGÉD VÁLTOZÓ AZ EGYSZERŰ CSERÉS RENDEZÉSHEZ
            int seged = 0;
            //EZZEL HASONLÍTUNK
            for (int i = 0; i < homersekletek.Length; i++)
            {
                //EHHEZ HASONLÍTUNK
                for (int j = 0; j < homersekletek.Length; j++)
                {
                    //LOGIKAI BLOKK HASZNÁLATÁVAL MEGÁLLAPÍTJUK, HOGY MELYIK ELEM A NAGYOBB
                    if (homersekletek[i] < homersekletek[j])
                    {
                        //NÖVEKVŐ SORRENDBE HELYEZZÜK AZ ELEMEKET, ÚGY, HOGY ADDIG HASONLÍTGATJUK A TÖMB ELEMEIT,
                        //AMÍG KI NEM JÖN A HELYES SORREND
                        seged = homersekletek[i];
                        homersekletek[i] = homersekletek[j];
                        homersekletek[j] = seged;
                    }
                }
            }
            //RENDEZETT TÖMB KIIRATÁSA
            for (int i = 0; i < homersekletek.Length; i++)
            {
                Console.Write(homersekletek[i] + "°C ");
            }
            //RENDEZETT TÖMB LEHÍVÁSA, HISZEN FÜGGVÉNYT ALKALMAZTAM
            return homersekletek;
        }

        static void Main(string[] args)
        {
            //METÓDUS, FÜGGVÉNY HÍVÁSA/MEGJELENÍTÉSE (+ ÜRES SOR AZ ESZTÉTIKA MIATT)
            feltoltes(homersekletek);
            Console.WriteLine("\n");
            egyszeruCseresRendezes(homersekletek);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
