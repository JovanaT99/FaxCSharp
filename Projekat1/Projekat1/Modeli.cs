using System;
using System.Collections.Generic;

namespace Projekat1
{
    public class Kategorija
    {
        public int KategorijaId { get; set; }
        public string Ime { get; set; }
        public List<Artikal> Artikli { get; } = new List<Artikal>();

        public override string ToString()
        {
            return KategorijaId+"|"+Ime;
        }
    }
    public class Artikal
    {
        public int ArtikalId { get; set; }
        public string Naziv { get; set; }
        public string Mera { get; set; }
        public int Cena { get; set; }

        public int KategorijaId { get; set; }

        public Kategorija Kategorija { get; set; }

        public override string ToString()
        {
            return Naziv + " " + Cena + "rsd/"+Mera;
        }
    }

    public class Racun
    {
        public int RacunId { get; set; }
        public List<Stavka> Stavke { get; set; } = new List<Stavka>();

    }

    public class Stavka
    {
        public int RacunId { get; set; }
        public int StavkaId { get; set; }

        public int ArtikalId { get; set; }
        public int KategorijaId { get; set; }

        public float Kolicna { get; set; }
        public float Cena { get; set; }

        public long Vreme { get; set; }

        public Racun Racun { get; set; }

        public Kategorija Kategorija { get; set; }
        public Artikal Artikal { get; set; }

        public override string ToString()
        {
            return Artikal.Naziv + " (" + Kolicna + " " + Artikal.Mera + ")";
        }

        public Stavka()
        {
        }


        public Stavka(int kategorijaId, float kolicna, float cena, Artikal artikal)
        {
            KategorijaId = kategorijaId;
            Kolicna = kolicna;
            Cena = cena;
            ArtikalId = artikal.ArtikalId;
            Artikal = artikal;
            Vreme = DateTimeOffset.Now.ToUnixTimeSeconds();
        }
    }
}
