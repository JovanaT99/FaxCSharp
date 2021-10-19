using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace JovanaBlagojevic
{
    public class Autor
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int AutorId { get; set; }
        public int Godiste { get; set; }

        public Autor()
        {

        }

        public Autor(string ime, string prezime)
        {
            Random rnd = new Random();
            AutorId = rnd.Next();
            Godiste = rnd.Next(1700, 1999);
            Ime = ime;
            Prezime = prezime;
        }
    }

    public class Knjiga
    {
        public int KnjigaId { get; set; }
        public string Naziv { get; set; }
        public Autor Autor { get; set; }
        public int GodinaIzdanja { get; set; }
        public List<string> Zanrovi { get; set; }
        public List<int> Ocene { get; set; }

        public Knjiga()
        {

        }

        public Knjiga(string naziv, Autor autor, int godinaIzdanja)
        {
            Random rnd = new Random();
            KnjigaId = rnd.Next(1, 99999);
            Naziv = naziv;
            Autor = autor;
            GodinaIzdanja = godinaIzdanja;
        }

        public void ucitajZanrove(string zanrovi)
        {
            Zanrovi = razbiZanrove(zanrovi).ToList();
        }

        public string[] razbiZanrove(string zanrovi)
        {
            string[] niz = zanrovi.Split(',');

            for(int i=0; i < niz.Length; i++)
            {
                niz[i] = niz[i].Trim();
            }

            return niz;
        }

        //1,2,5,4
        public void ucitajOcene(string ocene)
        {
            Ocene = razbiOcene(ocene).ToList();
        }

        public int[] razbiOcene(string ocene)
        {
            string[] niz = ocene.Split(',');

            if (niz.Length == 0)
            {
                MessageBox.Show("Morate uneti bar jednu ocenu!");
                return new int[0];
            }

            int[] nizOcena = new int[niz.Length];

            try
            {
                for (int i = 0; i < niz.Length; i++)
                {
                    nizOcena[i] = int.Parse(niz[i]);
                    if (nizOcena[i] < 1 || nizOcena[i] > 5)
                    {
                        MessageBox.Show("Pogresana ocena!");
                        return new int[0];
                    } 

                }
            } catch(Exception e)
            {
                MessageBox.Show("Problem sa unosom ocena");
                return new int[0];
            }

            return nizOcena;
        }

        

        public float prosecnaOcena()
        {
            int sum = 0;
            foreach(int ocena in Ocene)
            {
                sum += ocena;
            }

            return Ocene.Count != 0 ? sum / Ocene.Count : -1;
        }

        public static void XmlSerijalizacija(string imeFajla, List<Knjiga> knjige)
        {
            knjige = knjige
                .OrderBy(knjiga => knjiga.prosecnaOcena())
                .ToList();

            XmlSerializer ser = new XmlSerializer(typeof(List<Knjiga>));

            TextWriter writer = new StreamWriter(imeFajla);
            ser.Serialize(writer, knjige);
            writer.Close();
            
        }

        public static List<Knjiga> XmlDeserijalizacija(string imeFajla)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Knjiga>));
            FileStream fs = new FileStream(imeFajla, FileMode.Open);
            List<Knjiga> ucitanjeKnjige = (List<Knjiga>)ser.Deserialize(fs);
            fs.Close();
            return ucitanjeKnjige;
        }
    }
}
