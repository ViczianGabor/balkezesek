using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace balkezesek
{
    class Program
    {
        static List<Balosok> lista = new List<Balosok>();
        static int szam = 0;
        public List<string> hatos = new List<string>();

        static void Beolvas()
        {
            StreamReader sr = new StreamReader("balkezesek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new Balosok(sr.ReadLine()));



            }


            sr.Close();


            

        }


        static void harmadik()
        {
            Console.Write("3. feladat: ");
            Console.WriteLine(lista.Count);


        }

        static void negyedik()
        {
            Console.Write("4. feladat: \n");
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].UtolsoDatum.Contains("1999-10"))
                {
                    Console.WriteLine($"\t{lista[i].Nev} {lista[i].Magassag*2.54:N1} cm");
                }
            }
        }

        static void otodik()
        {
            Console.WriteLine("5. feladat");
            Console.Write("Kérek egy 1990 és 1999 közötti évszámot!: ");
            szam = int.Parse(Console.ReadLine());
            bool helyes = false;
            while (!helyes)
            {
                if (szam <1990 || szam > 1999)
                {
                    Console.Write("Hibása adat! Kérek egy 1990 és 1999 közötti évszámot!: ");
                    szam = int.Parse(Console.ReadLine());
                }
                else
                {
                    helyes = true;
                }
            }
            




        }

        static void hatodik()
        {
            Console.Write("6. feladat:");
            double osszeg = 0;
            double db = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if (szam)
                {

                }
            }
            

            Console.WriteLine($"{atlag:N2}");


        }


        static void Main(string[] args)
        {

            Beolvas();
            harmadik();
            negyedik();
            otodik();
         
            hatodik();


            //Jim Abbott;1989-04-08;1999-07-21;200;75

            Console.ReadKey();
        }
    }
}
