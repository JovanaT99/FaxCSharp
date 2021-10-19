using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    public partial class FormProdaja : Form
    {
        List<Button> kategorijeDugmici;
        List<Button> artikliDugmici;
        List<Kategorija> kategorije;
        List<Artikal> artikli;

        Kategorija izabranaKategorija;
        Artikal izabraniArtikal;
        Stavka izabranaStavka;
        float kolicina;
        string kolicinaUnos;
        bool unos;

        List<Stavka> stavke;

        public FormProdaja()
        {
            InitializeComponent();
            listajKategorije();

            stavke = new List<Stavka>();
            buttonArtikalTemp.Hide();
            buttonKategorijaTemp.Hide();
            izaberiArtikal(null);

        }
       

        private void listajStavke()
        {
            float ukupnaCena = 0;
            listStavke.Items.Clear();
            listRacun.Items.Clear();
            foreach(Stavka stavka in stavke)
            {
                listStavke.Items.Add(stavka);
                listRacun.Items.Add(stavka.Artikal.Naziv + "    " + stavka.Cena);
                ukupnaCena += stavka.Cena;
            }
            listRacun.Items.Add("---------");
            listRacun.Items.Add("Ukupno:");
            listRacun.Items.Add(ukupnaCena);

            labelCena.Text = ukupnaCena + " rsd";
        }

        private void listajKategorije()
        {

            if (kategorijeDugmici != null)
            {
                foreach (Button dugme in kategorijeDugmici)
                {
                    dugme.Dispose();
                }
            }

            kategorijeDugmici = new List<Button>();


            using (var db = new BazaContext())
            {
                kategorije = db.Kategorije
                                    .ToList();

                foreach (Kategorija k in kategorije)
                {
                    Button dugme = new Button();
                    dugme.Text = k.Ime;
                    dugme.BackColor = Color.RosyBrown;
                    dugme.Size = new Size(100, 75);
                    dugme.TabIndex = 12;
                    dugme.Click += new EventHandler(this.kategorijaDugme_click);
                    flowPanelKategorije.Controls.Add(dugme);
                    kategorijeDugmici.Add(dugme);
                }
            }
        }

        private void listajArtikle()
        {
            

            if (artikliDugmici != null)
            {
                foreach(Button dugme in artikliDugmici)
                {
                    dugme.Dispose();
                }
            }

            if (izabranaKategorija == null)
            {
                return;
            }

            artikliDugmici = new List<Button>();

            using (var db = new BazaContext())
            {
                artikli = db.Artikli
                                    .Where(a => a.KategorijaId == izabranaKategorija.KategorijaId)
                                    .ToList();

                foreach (Artikal a in artikli)
                {
                    Button dugme = new Button();
                    dugme.Text = a.Naziv;
                    dugme.BackColor = Color.Orange;
                    dugme.Size = new Size(120, 75);
                    dugme.TabIndex = 12;
                    flowPanelArtikli.Controls.Add(dugme);
                    dugme.Click += new EventHandler(this.artikalDugme_click);
                    artikliDugmici.Add(dugme);
                }
            }
        }

        private void kategorijaDugme_click(object sender, EventArgs e)
        {
            Button dugmeKategorije = (Button)sender;
            Kategorija kategorija = kategorije.Single(k => k.Ime == dugmeKategorije.Text);

            foreach (Button dugme in kategorijeDugmici)
            {
                if (dugme.Text == kategorija.Ime)
                {
                    dugme.BackColor = Color.Red;
                } else
                {
                    dugme.BackColor = Color.RosyBrown;
                }
            }

            izabranaKategorija = kategorija;
            listajArtikle();
            izabraniArtikal = null;
            obojiArtikalDugmice();
        }

        private void artikalDugme_click(object sender, EventArgs e)
        {
            Button dugmeArtikla = (Button)sender;
            Artikal artikal = artikli.Single(a => a.Naziv == dugmeArtikla.Text);

            if (izabranaKategorija.Ime.Contains("Alkohol"))
            {
                if (DateTime.Now.Hour >= 22 || DateTime.Now.Hour <= 7)
                {
                    MessageBox.Show("Alkohol nije moguce kupiti u periodu od 22h do 7h");
                    return;
                }
            }

            izaberiArtikal(artikal);
            obojiArtikalDugmice();
        }

        private void obojiArtikalDugmice()
        {
            foreach (Button dugme in artikliDugmici)
            {
                if (izabraniArtikal != null && dugme.Text == izabraniArtikal.Naziv)
                {
                    dugme.BackColor = Color.DarkRed;

                }
                else
                {
                    dugme.BackColor = Color.Orange;
                }
            }
        }

        private void unosDugmici()
        {
            button0D.Enabled = unos;
            button00.Enabled = unos;
            button01.Enabled = unos;
            button02.Enabled = unos;
            button03.Enabled = unos;
            button04.Enabled = unos;
            button05.Enabled = unos;
            button06.Enabled = unos;
            button07.Enabled = unos;
            button08.Enabled = unos;
            button09.Enabled = unos;
        }

        private void izaberiArtikal(Artikal artikal)
        {
            if (artikal != null)
            {
                izabraniArtikal = artikal;
                kolicina = 0;
                textIzabraniArtikal.Text = izabraniArtikal.Naziv;
                buttonX.Enabled = true;
                buttonPonisti.Enabled = true;
                buttonUnesi.Enabled = true;
            } else
            {
                buttonX.Enabled = false;
                kolicinaUnos = "";
                unos = false;
                kolicina = 0;
                izabraniArtikal = null;
                textIzabraniArtikal.Text = "";

                buttonPonisti.Enabled = false;
                buttonUnesi.Enabled = false;

            }

            unosDugmici();
            listajArtikle();
        }

        private void FormProdaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            izaberiArtikal(null);
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            if (kolicina == 0)
            {
                kolicina = 1;
            }

            float cena = izabraniArtikal.Cena * kolicina;

            stavke.Add(new Stavka (izabraniArtikal.KategorijaId, kolicina, cena, izabraniArtikal));

            izaberiArtikal(null);
            listajStavke();

        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (izabranaStavka == null)
            {
                return;
            }

            listStavke.ClearSelected();
            stavke.Remove(izabranaStavka);
            listajStavke();
        }

        private void listStavke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStavke.SelectedIndex == -1)
            {
                buttonObrisi.Enabled = false;
                return;
            }
            buttonObrisi.Enabled = true;
            Stavka stavka = (Stavka) listStavke.SelectedItem;
            izabranaStavka = stavka;

       
        }

        private void buttonDalje_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRacun;
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            if (stavke.Count == 0)
            {
                return;
            }

            foreach (Stavka stavka in stavke)
            {
                stavka.Artikal = null;
            }

            Racun racun = new Racun();
            racun.Stavke = stavke;
            using (var db = new BazaContext())
            {
                db.Racun.Add(racun);
                db.SaveChanges();
            }

            MessageBox.Show("Racun sacuvan");
            novaTransakcija();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            if (izabraniArtikal == null)
            {
                return;
            }

            unos = true;
            unosDugmici();
            prikaziKolicinu();
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            Button dugme = (Button)sender;

            String tekst = kolicinaUnos;
            tekst += dugme.Text == "," ? "." : dugme.Text;

            try
            {
                kolicina = float.Parse(tekst);
                kolicinaUnos = tekst;
            } catch(Exception)
            {

            }

            prikaziKolicinu();

        }

        private void prikaziKolicinu()
        {
            textIzabraniArtikal.Text = izabraniArtikal.Naziv + " x " + kolicinaUnos;
        }

        private void novaTransakcija()
        {
            stavke = new List<Stavka>();
            izabranaKategorija = null;
            izabraniArtikal = null;
            izaberiArtikal(null);
            listajKategorije();
            listajArtikle();
            listajStavke();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            novaTransakcija();
        }
    }
}
