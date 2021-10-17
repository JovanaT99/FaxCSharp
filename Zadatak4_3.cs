using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;


namespace Zadata43
{
    public class ListaOsoba
    {
        public List<Osoba> Lista { get; set; }

        public ListaOsoba()
        {
            this.Lista = new List<Osoba>();
        }
    }
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string RadnoMesto { get; set; }
        public float GodisnjiPrihod { get; set; }

        public Osoba() { }
        public Osoba(string ime, string prezime, string radnoMesto, float godisnjiPrihod)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.RadnoMesto = radnoMesto;
            this.GodisnjiPrihod = godisnjiPrihod;
        }

        public float MesecniPrihod()
        {
            return this.GodisnjiPrihod / 12;
        }

        override public string ToString()
        {
            return Ime + " " + Prezime + ", " + RadnoMesto + ", " + MesecniPrihod().ToString("N0") + " dinara";
        }

        public static bool XmlSerijalizacija(string putanja, List<Osoba> lista)
        {
            ListaOsoba listaOsoba = new ListaOsoba();
            listaOsoba.Lista = lista;

            XmlSerializer serializer = new XmlSerializer(lista.GetType());
            using (TextWriter writer = new StreamWriter(putanja))
            {
                serializer.Serialize(writer, lista);
            }

            return true;
        }

        public static List<Osoba> XmlDeserijalizacija(string putanja)
        {
            List<Osoba> lista = new List<Osoba>();

            XmlSerializer serializer = new XmlSerializer(lista.GetType());

            using (System.Xml.XmlReader reader = System.Xml.XmlReader.Create(putanja))
            {
                lista = (List<Osoba>)serializer.Deserialize(reader);
            }

            return lista;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            string putanja = "fajl.xml";

            List<Osoba> lista = new List<Osoba>();

            lista.Add(new Osoba("Pera", "Peric", "pripravnik", 360000.0f));
            lista.Add(new Osoba("Marko", "Markovic", "it support", 480000));
            lista.Add(new Osoba("Jovana", "Blagojevic", "junior dev", 1200000));
            lista.Add(new Osoba("Jovana2", "Blagojevic2", "junior dev2", 2200000));
            lista.Add(new Osoba("Jovana3", "Blagojevic3", "junior dev3", 3200000));

            while (true)
            {
                Console.WriteLine("--------");
                Console.WriteLine("Unesi 's' za serijalizaciju ili 'd' za deserijalizacija, unesi 'k' za izlaz");
                string unos = Console.ReadLine();

                if (unos == "k")
                {
                    break;
                }

                if (unos == "s")
                {
                    Osoba.XmlSerijalizacija(putanja, lista);
                    Console.WriteLine("Lista je uspesno sacuvana u xml fajl, serijalizacija zavrsena.");
                }
                else if (unos == "d")
                {
                    if (!File.Exists(putanja))
                    {
                        Console.WriteLine("Fajl jos ne postoji, nije moguce izvrsiti deserijalizaciju");
                        continue;
                    }

                    List<Osoba> lista2 = Osoba.XmlDeserijalizacija(putanja);
                    Console.WriteLine("Lista je uspesno ucitana iz xml fajla, deserijalizacija zavrsena.");

                    foreach (Osoba osoba in lista2)
                    {
                        Console.WriteLine(osoba);
                    }
                }
            }

            Console.WriteLine("Kraj");
        }
    }
}
