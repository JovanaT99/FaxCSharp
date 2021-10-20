using System;
using System.Collections.Generic;

namespace ProdavnicaPCL
{
    namespace Modeli
    {
        public class Racun
        {
            public int RacunId { get; set; }
            public Dictionary<Artikal, float> Stavke { get; set; }
            private DateTime DatumIzdavanja { get; set; }

            public Racun()
            {
                Random rnd = new Random();
                RacunId = rnd.Next(1, 9999);
                Stavke = new Dictionary<Artikal, float>();
                DatumIzdavanja = DateTime.Now;
            }

            public int Dan()
            {
                return DatumIzdavanja.Day;
            }

            public int Mesec()
            {
                return DatumIzdavanja.Month;
            }

            public int Godina()
            {
                return DatumIzdavanja.Year;
            }

            public float Cena()
            {
                float sum = 0;
                foreach (KeyValuePair<Artikal, float> stavka in Stavke)
                {
                    Artikal artikal = stavka.Key;
                    float kolicina = stavka.Value;
                    sum += artikal.CenaPremaKolicini(kolicina);
                }
                return sum;
            }

            public override string ToString()
            {
                string racun = "Račun br. " + RacunId + "\n"
                + Mesec() + "." + Godina() + "\n";

                foreach (KeyValuePair<Artikal, float> stavka in Stavke)
                {
                    Artikal artikal = stavka.Key;
                    float kolicina = stavka.Value;
                    racun += "- " + artikal + "\t" + kolicina + "\t" + artikal.CenaPremaKolicini(kolicina) + "\n";

                }

                racun += "Ukupna cena: " + Cena() + " dinara";

                return racun;
            }
        }

        public abstract class Artikal
        {
            public string Naziv { get; set; }
            public abstract float CenaPremaKolicini(float komada);

            protected Artikal(string naziv)
            {
                Naziv = naziv;
            }
        }

        public class Povrce : Artikal
        {
            public float Cena { get; set; }
            public string JM { get; set; }

            public override float CenaPremaKolicini(float komada)
            {
                return Cena * komada;
            }

            public override string ToString()
            {
                return Naziv + " [" + Cena + "/" + JM + "]";
            }

            public Povrce(string naziv, float cena, string jM) : base(naziv)
            {
                Cena = cena;
                JM = jM;
            }
        }

        public class Voce : Artikal
        {
            public float Cena { get; set; }
            public string JM { get; set; }

            public string Tip { get; set; }

            public Voce(string naziv, string tip, float cena, string jM) : base(naziv)
            {
                Tip = tip;
                Cena = cena;
                JM = jM;
            }

            public override float CenaPremaKolicini(float komada)
            {
                return Cena * komada;
            }

            public override string ToString()
            {
                return Naziv + "-" + Tip + " [" + Cena + "/" + JM + "]";
            }
        }
    }
}
