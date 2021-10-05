using System;
using System.Collections.Generic;
using System.IO;

namespace Zadatak4_1
{
    class Program
    {

        public static int PronadjiSrednje(List<int> lista)
        {

            int sum = 0;

            for (int i = 0; i < lista.Count; i++)
            {

                sum += lista[i];
            }


            return sum / lista.Count;
        }

        public static int PronadjiNajmanje(List<int> lista)
        {
            int vrednost = lista[0];

            for (int i = 0; i < lista.Count; i++)
            {

                if (lista[i] < vrednost)
                {

                    vrednost = lista[i];

                }
            }


            return vrednost;
        }


        public static int PronadjiNajveci(List<int> lista)
        {
            int vrednost = lista[0];

            for (int i = 0; i < lista.Count; i++)
            {

                if (lista[i] > vrednost)
                {

                    vrednost = lista[i];

                }
            }

            return vrednost;

        }



        static void Main(string[] args)
        {
            List<int> lista = new List<int>();


            int donjaGranica;
            int gornjaGranica;
            int brojBrojeva;


            Console.WriteLine("Unesi  broj brojeva:");
            string broj = Console.ReadLine();



            Console.WriteLine("Unesi donju granicu:");
            string donja = Console.ReadLine();



            Console.WriteLine("Unesi gornju granicu:");
            string gornja = Console.ReadLine();
            Console.WriteLine("------------------");



            try
            {

                brojBrojeva = Int32.Parse(broj);
                donjaGranica = Int32.Parse(donja);
                gornjaGranica = Int32.Parse(gornja);
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska pri unosu");
                return;
            }

            for (int i = 0; i < brojBrojeva; i++)
            {

                lista.Add(new Random().Next(donjaGranica, gornjaGranica));


            }

            for (int i = 0; i < brojBrojeva; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine("------------------");

            // Program program = new Program();
            //Console.WriteLine(program.PronadjiNajmanje(lista));


            StreamWriter writer = new StreamWriter("C:\\Users\\Mac\\Desktop\\Zadatak4.txt");
            for (int i = 0; i < lista.Count; i++)
            {
                writer.Write(lista[i] + " ");

            }
            writer.Close();


            string text = File.ReadAllText("C:\\Users\\Mac\\Desktop\\Zadatak4.txt");
            string[] niz = text.Split(" ");

            List<int> lista2 = new List<int>();

            foreach (string s in niz)
            {
                if (s.Length == 0)
                {
                    continue;
                }

                int g = Int32.Parse(s);
                lista2.Add(g);


            }

            Console.WriteLine(text);



            Console.WriteLine("------------------");

            Console.WriteLine("Srednja vrednost: " + Program.PronadjiSrednje(lista2));
            Console.WriteLine("Najmanja vrednost: " + Program.PronadjiNajmanje(lista2));
            Console.WriteLine("Najveci: " + Program.PronadjiNajveci(lista2));

        }
    }
}
