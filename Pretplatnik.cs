using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

namespace Zadatak42
{
    class Pretplatnik
    {
        private string ime, prezime, radnoMesto;

        public Pretplatnik(string ime, string prezime, string radnoMesto)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.radnoMesto = radnoMesto;
        }

        public string ImePrezime()
        {
            return ime + "_" + prezime;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            //kreiranje praznog fajla pretplanik.txt
            StreamWriter swf = File.CreateText("pretplatnik.txt");
            swf.Close();

            string prethodnePogodnosti = "";

            List<Pretplatnik> lista = new List<Pretplatnik>();

            lista.Add(new Pretplatnik("Pera", "Peric", "pripravnik"));
            lista.Add(new Pretplatnik("Marko", "Markovic", "it support"));
            lista.Add(new Pretplatnik("Jovana", "Blagojevic", "junior dev"));

            foreach (Pretplatnik pretplatnik in lista)
            {
                Console.WriteLine(pretplatnik.ImePrezime());
            }

            while (true)
            {
                string pogodonsti = "";


                try
                {
                    pogodonsti = File.ReadAllText("pretplatnik.txt");
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Fajl pretplatnik.txt nije pronadjen");
                }


                if (pogodonsti != "" && pogodonsti != prethodnePogodnosti)
                {
                    Console.WriteLine("Nova pogodnost, upisujem");

                    prethodnePogodnosti = pogodonsti;

                    foreach (Pretplatnik pretplatnik in lista)
                    {
                        string imeFajla = pretplatnik.ImePrezime() + ".txt";

                        StreamWriter sw = File.AppendText(imeFajla);
                        sw.WriteLine(pogodonsti);
                        sw.Close();

                    }

                }

                Console.WriteLine("Cekam 60sec");
                Thread.Sleep(60 * 1000);
            }

        }
    }
}
