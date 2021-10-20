using ProdavnicaPCL.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaPCL
{
    namespace Servis
    {
        class ProdavnicaServis
        {
            private static Podaci.Prodavnica prodavnica;

            public static Podaci.Prodavnica getInstance()
            {
                if (prodavnica == null)
                {
                    prodavnica = new Podaci.Prodavnica("Maxi", "Glavna 1");
                }
                return prodavnica;
            }
        }
    }

    namespace Podaci
    {
        public class Prodavnica
        {
            public string Naziv { get; set; }
            public string Adresa { get; set; }
            public List<Racun> Racuni { get; set; }

            public Prodavnica(string naziv, string adresa)
            {
                Naziv = naziv;
                Adresa = adresa;
                Racuni = new List<Racun>();

                Racun r1 = new Racun();
                r1.Stavke.Add(new Povrce("Krompir", 129, "kg"), 2);
                r1.Stavke.Add(new Povrce("Paprika", 60, "kg"), 0.5f);

                Racun r2 = new Racun();
                r2.Stavke.Add(new Voce("Banana", "SVEZE", 100, "kg"), 2);
                r2.Stavke.Add(new Voce("Jabuke", "SUVO", 50, "kom"), 3);

                Racun r3 = new Racun();
                r3.Stavke.Add(new Povrce("Tikvice", 68, "kg"), 2);
                r3.Stavke.Add(new Povrce("Luk", 60, "kg"), 1);
                r3.Stavke.Add(new Voce("Limun", "SVEZE", 25, "kom"), 3);


                Racun r4 = new Racun();
                r4.Stavke.Add(new Voce("Banana", "SVEZE", 100, "kg"), 25);


                Racun r5 = new Racun();
                r5.Stavke.Add(new Voce("Jabuke", "SUVO", 50, "kom"), 10);

                Racuni.Add(r1);
                Racuni.Add(r2);
                Racuni.Add(r3);
                Racuni.Add(r4);
                Racuni.Add(r5);

            }

            public List<Racun> racuniSkupljiOd(float cena)
            {
                return Racuni.Where(racun => racun.Cena() > cena).ToList();
            }
            public List<Racun> racuniJeftinijiOd(float cena)
            {
                return Racuni.Where(racun => racun.Cena() < cena).ToList();
            }

            public Racun racunPoId(int id)
            {
                Racun racun = Racuni.Single(r => r.RacunId == id);

                if (racun == null)
                {
                    throw new NemaRacunaZaId();
                }

                return racun;
            }

            public Racun racunNajskuplji()
            {
                if (Racuni.Count == 0)
                {
                    throw new NemaNiJednogRacuna();
                }

                return Racuni.OrderByDescending(racun => racun.Cena()).First();
            }
            public Racun racunNajjeftiniji()
            {
                if (Racuni.Count == 0)
                {
                    throw new NemaNiJednogRacuna();
                }

                return Racuni.OrderByDescending(racun => racun.Cena()).Last();
            }

            public float procenaCenaRacuna()
            {
                float sum = ukupnaCenaSvihRacuna();

                return Racuni.Count != 0 ? sum / Racuni.Count : -1;
            }

            public float ukupnaCenaSvihRacuna()
            {
                float sum = 0;
                foreach (Racun racun in Racuni)
                {
                    sum += racun.Cena();
                }

                return sum;
            }
        }
    }
}
