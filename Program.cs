//************** Tóth Ádám ********** adamtoth4@gmail.com ***********
using System;
using System.Text;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace Dolgozat_2021._03._24
{
    class Program
    {
        static Random rnd = new Random();

        static void Main()
        {
            Feladat01();
            Console.ReadKey();
        }

        private static void Feladat01()
        {
            int[] tomb = new int[100];

            for (int i = 0; i < tomb.Length; i++)
            {
                int randomszam = 0;
                do
                {
                    int generaltszam = rnd.Next(1000, 10000);
                    randomszam = generaltszam;

                } while (randomszam % 5 != 0);

                tomb[i] = randomszam;
            }

            Console.WriteLine("A létrehozott tömb: ");
            Console.Write("\n");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{tomb[i]}, ");
                if ((i + 1) % 10 == 0)
                {
                    Console.Write("\n");
 
                }

                else if ((i + 1) % 6 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                else Console.ResetColor();
                
            }

            Console.WriteLine("--------------------------------------------------");
            Console.Write("\n");
 
            long ossz = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                ossz += tomb[i];
            }

            Console.WriteLine($"A tömb elemeinek összege: {ossz}");

            Console.Write("\n");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("\n");

            int intervallum = 0;
            int c = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > 4000 && tomb[i] < 5000)
                {
                    intervallum += tomb[i];
                    c++;
                }
            }

            Console.WriteLine($"A tömb 4000-nél nem kisebb, de 5000-nél kisebb elemeinek átlaga: {intervallum / (float)c}");

            Console.Write("\n");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("\n");

            int tobbszoros = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 65 == 0)
                {
                    Console.WriteLine($"A 65 többszöröse szerepel a tömbben! A szám: {tomb[i]}, indexe: {i}");
                    tobbszoros++;
                    break;
                }                
            }

            if (tobbszoros == 0) Console.WriteLine("A 65 egyik többszöröse sem szerepel a tömbben!");

            Console.Write("\n");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("\n");

            string[] tomb2 = new string[100];

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb2[i] = tomb[i].ToString();
            }

            int harommalkezdodo = 0;
            for (int i = 0; i < tomb2.Length; i++)
            {
                if (tomb2[i].StartsWith("3"))
                {
                    harommalkezdodo++;
                }
            }

            Console.WriteLine($"A tömbnek {harommalkezdodo} db. hármas számmal kezdődő eleme van!");

            Console.Write("\n");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("\n");

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > 4000)
                {
                    Console.WriteLine("Az általam elfogadhatónak gondolt junior szoftverfejlesztői órabér indexe: " + i);
                    break;
                }
            }

            Console.Write("\n");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("\n");

            List<int> szazasok = new List<int>();

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 100 == 0)
                {
                    szazasok.Add(tomb[i]);
                }
            }

            int[] szazasok2 = new int[szazasok.Count];

            for (int i = 0; i < szazasok.Count; i++)
            {
                szazasok2[i] = szazasok[i];
            }

            for (int i = 0; i < szazasok2.Length; i++)
            {
                Console.Write($"{szazasok2[i]}, ");

                if ((i + 1) % 10 == 0)
                {
                    Console.Write("\n");
                }
            }

            Console.Write("\n");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("\n");

            Console.Write("Kérlek add meg a születési dátumod! Ha a dátum nem osztható öttel kerekíteni fogjuk! ");
            //A születési dátumom 1995, túl könnyű lett volna, ugyhogy kicsit módosítottam :D

            int datum = int.Parse(Console.ReadLine());
            int kerekitettdatum = 0;

            if (datum % 5 == 0)
            {
                kerekitettdatum = datum;
            }
            else
                do
                {
                    datum++;
                    kerekitettdatum = datum;
                } while (kerekitettdatum % 5 != 0);

            int szerepeleatombben = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == kerekitettdatum)
                {
                    Console.WriteLine($"A kerekített/megadott születési dátum({kerekitettdatum}) szerepel a tömbben! Indexe: {i}, helye: {i + 1}");
                    szerepeleatombben++;
                }
            }

            if (szerepeleatombben == 0) Console.WriteLine($"A kerekített/megadott születési dátum ({kerekitettdatum}) nem szerepel a tömbben!");
            
        }
    }
}
