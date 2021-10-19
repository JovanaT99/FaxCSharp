using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Projekat1
{
    public partial class FormAdmin : Form
    {

        private Kategorija izabranaKategorija = null;
        private Artikal izabranArtikal = null;

        private DateTime izabranoVreme = DateTime.Now;

        public FormAdmin()
        {
            InitializeComponent();
            listajKategorije();
            listajArtikle();
            prikaziStatistiku();
        }

        private void listajKategorije()
        {
            listKategorije.Items.Clear();
            comboKategorija.Items.Clear();
            using (var db = new BazaContext())
            {
                List<Kategorija> kategorije = db.Kategorije
                                    .ToList();

                foreach (Kategorija k in kategorije)
                {
                    listKategorije.Items.Add(k);
                    comboKategorija.Items.Add(k.Ime);
                }
            }
        }

        private void listajArtikle()
        {
            listArtikli.Items.Clear();
            using (var db = new BazaContext())
            {
                List<Artikal> artikli = db.Artikli
                                    .ToList();

                foreach (Artikal a in artikli)
                {
                    listArtikli.Items.Add(a);
                }
            }
        }

        private void buttonKategorijaDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new BazaContext())
            {

                if (!proveriUnosKategorije())
                {
                    return;
                }

                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");

                // Create
                Console.WriteLine("Dodata kategorija");
                db.Add(new Kategorija { Ime = textKategorija.Text });
                db.SaveChanges();

                textKategorija.Text = "";
                listajKategorije();

            }
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listKategorije.SelectedIndex == -1)
            {
                if (izabranaKategorija != null)
                {
                    textKategorija.Text = "";
                    izabranaKategorija = null;
                    buttonKategorijaDodaj.Enabled = true;
                    buttonKategorijaIzmeni.Enabled = false;
                    buttonKategorijaObrisi.Enabled = false;

                }
                return;
            }

            izabranaKategorija = (Kategorija) listKategorije.SelectedItem;
            textKategorija.Text = izabranaKategorija.Ime;
            buttonKategorijaIzmeni.Enabled = true;
            buttonKategorijaObrisi.Enabled = true;
            buttonKategorijaDodaj.Enabled = false;
        }

        private void buttonKategorijaIzmeni_Click(object sender, EventArgs e)
        {
            if (!proveriUnosKategorije())
            {
                return;
            } 

            izabranaKategorija.Ime = textKategorija.Text;
            using (var db = new BazaContext())
            {
                db.Kategorije.Update(izabranaKategorija);
                db.SaveChanges();
            }

            listKategorije.ClearSelected();
            listajKategorije();
        }

        private void buttonKategorijaObrisi_Click(object sender, EventArgs e)
        {
           


            using (var db = new BazaContext())
            {
                int brojArtikala = db.Artikli
                    .Where(a => a.KategorijaId == izabranaKategorija.KategorijaId)
                    .Count();

                int brojStavki = db.Stavke
                    .Where(s => s.KategorijaId == izabranaKategorija.KategorijaId)
                    .Count();

                if (brojArtikala+brojStavki > 0)
                {
                    MessageBox.Show("Nije moguce obrisati kategoriju koja ima artikle ili je prodato nesto iz nje");
                    return;
                }

                db.Kategorije.Remove(izabranaKategorija);
                db.SaveChanges();
            }

            listKategorije.ClearSelected();
            listajKategorije();
        }

        private void buttonArtikalDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new BazaContext())
            {

                if (!proveriUnosArtikla())
                {
                    return;
                }

                int cena = int.Parse(textArtikalCena.Text);
                Kategorija k = db.Kategorije
                        .Single(kategorija => kategorija.Ime == comboKategorija.SelectedItem.ToString());

                


                // Create
                Console.WriteLine("Dodat artikal");
                db.Add(new Artikal { 
                    Naziv = textArtikal.Text,
                    KategorijaId = k.KategorijaId,
                    Cena = cena,
                    Mera = textArtikalMera.Text
                });
                db.SaveChanges();

                textArtikal.Text = textArtikalCena.Text = textArtikalMera.Text = "";
                

                listajArtikle();
                MessageBox.Show("Dodat artikal");
            }
        }

        private void listArtikli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listArtikli.SelectedIndex == -1)
            {
                if (izabranArtikal != null)
                {
                 
                    textArtikal.Text = textArtikalCena.Text = textArtikalMera.Text = "";

                    izabranArtikal = null;
                    buttonArtikalDodaj.Enabled = true;
                    buttonArtikalIzmeni.Enabled = false;
                    buttonArtikalObrisi.Enabled = false;

                }
                return;
            }

            izabranArtikal = (Artikal)listArtikli.SelectedItem;


            using (var db = new BazaContext())
            {
                Kategorija kategorija = db.Kategorije
                    .Single(k => k.KategorijaId == izabranArtikal.KategorijaId);
            
                textArtikal.Text = izabranArtikal.Naziv;

                comboKategorija.SelectedIndex = comboKategorija.FindStringExact(kategorija.Ime);
                textArtikalCena.Text = izabranArtikal.Cena.ToString();
                textArtikalMera.Text = izabranArtikal.Mera;

            }
            buttonArtikalDodaj.Enabled = false;
            buttonArtikalIzmeni.Enabled = true;
            buttonArtikalObrisi.Enabled = true;
        }

        private void buttonArtikalIzmeni_Click(object sender, EventArgs e)
        {

            if (!proveriUnosArtikla())
            {
                return;
            }

            int cena = int.Parse(textArtikalCena.Text);
            Kategorija k = null;
            using (var db = new BazaContext())
            {
                k = db.Kategorije
                    .Single(kategorija => kategorija.Ime == comboKategorija.SelectedItem.ToString());
                
            }

            izabranArtikal.Naziv = textArtikal.Text;
            izabranArtikal.Cena = cena;
            izabranArtikal.KategorijaId = k.KategorijaId;
            izabranArtikal.Mera = textArtikalMera.Text;
           
            using (var db = new BazaContext())
            {
                db.Artikli.Update(izabranArtikal);
                db.SaveChanges();
            }

            listArtikli.ClearSelected();
            listajArtikle();
        }

        private void buttonArtikalObrisi_Click(object sender, EventArgs e)
        {
            using (var db = new BazaContext())
            {

                db.Stavke
                    .RemoveRange(db.Stavke.Where(s => s.ArtikalId == izabranArtikal.ArtikalId));

    
                db.Artikli.Remove(izabranArtikal);
                db.SaveChanges();
            }

            listArtikli.ClearSelected();
            listajArtikle();
            prikaziStatistiku();
        }

        private bool proveriUnosKategorije()
        {
            if (textKategorija.TextLength == 0)
            {
                return false;
            }

            return true;
        }

        private bool proveriUnosArtikla()
        {
            if (comboKategorija.SelectedItem == null || textArtikal.Text.Length == 0 || textArtikalCena.Text.Length == 0 || textArtikalMera.Text.Length == 0)
            {
                return false;
            }

            int cena = 0;

            try
            {
                cena = int.Parse(textArtikalCena.Text);
            }
            catch (Exception)
            {
                return false;
            }

            if (cena == 0)
            {
                return false;
            }

            return true;
        }

        private void prikaziStatistiku()
        {
            Dictionary<Artikal, float> statistikaArtikla = new Dictionary<Artikal, float>();

            DateTime pocetakDana = izabranoVreme.Date;
            DateTime krajDana = izabranoVreme.Date.AddDays(1).AddTicks(-1);


            long pocetakDanaSekunde = (long)(pocetakDana - DateTime.UnixEpoch).TotalSeconds;
            long krajDanaSekunde = (long)(krajDana - DateTime.UnixEpoch).TotalSeconds;

            float max = 100;

            using (var db = new BazaContext())
            {
                max = db.Stavke.Sum(stavke => stavke.Kolicna);
                List<Stavka> stavke = db.Stavke
                    .Include(stavka => stavka.Artikal)
                    .Where(stavka => stavka.Vreme >= pocetakDanaSekunde && stavka.Vreme <= krajDanaSekunde)
                    .ToList();

                label4.Text = db.DbPath;


                foreach (Stavka stavka in stavke)
                {
                    if (statistikaArtikla.ContainsKey(stavka.Artikal))
                    {
                        statistikaArtikla[stavka.Artikal] += stavka.Kolicna;
                    } else
                    {
                        statistikaArtikla.Add(stavka.Artikal, stavka.Kolicna);
                    }
                }
            }


            statistikaArtikla = statistikaArtikla.OrderByDescending(a => a.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            flowStat.Controls.Clear();

            foreach (KeyValuePair<Artikal,float> element in statistikaArtikla)
            {


                Panel panel = new Panel();
                Label broj = new Label();
                Label naziv = new Label();
                ProgressBar progress = new ProgressBar();


                panel.Controls.Add(broj);
                panel.Controls.Add(naziv);
                panel.Controls.Add(progress);
                panel.Margin = new Padding(5, 6, 5, 6);
                panel.Location = new System.Drawing.Point(5, 6);        
                panel.Size = new System.Drawing.Size(995, 66);
                panel.TabIndex = 3;

                broj.AutoSize = true;
                broj.Location = new System.Drawing.Point(835, 18);
                broj.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
                broj.Size = new System.Drawing.Size(68, 30);
                broj.TabIndex = 2;
                broj.Text = element.Value.ToString();

                naziv.AutoSize = true;
                naziv.Location = new System.Drawing.Point(26, 18);
                naziv.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
                naziv.Size = new System.Drawing.Size(68, 30);
                naziv.TabIndex = 1;
                naziv.Text = element.Key.Naziv;

                progress.Location = new System.Drawing.Point(437, 10);
                progress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
                progress.Size = new System.Drawing.Size(387, 46);
                progress.TabIndex = 0;
                progress.Value = (int) element.Value;
                progress.Maximum = (int) max;
                progress.Show();


                flowStat.Controls.Add(panel);


            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            izabranoVreme = dateTimePicker1.Value;
            prikaziStatistiku();
        }
    }
}
