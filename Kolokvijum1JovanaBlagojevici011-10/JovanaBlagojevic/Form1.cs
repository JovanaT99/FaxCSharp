using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace JovanaBlagojevic
{
    public partial class Form1 : Form
    {

        List<Knjiga> knjige;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            knjige = new List<Knjiga>();
        }

        private void buttonUbaci_Click(object sender, EventArgs e)
        {
            string naziv = textNaziv.Text;
            string autorString = textAutor.Text;
            string godinaString = textGodina.Text;
            string zanrovi = textZanorvi.Text;
            string ocene = textOcene.Text;

            if (naziv.Length == 0 
                || autorString.Length == 0 
                || godinaString.Length == 0 
                || zanrovi.Length == 0 
                || ocene.Length == 0)
            {
                MessageBox.Show("Morate popuniti sva polja");
                return;
            }

            string[] niz = autorString.Split(" ");
            string ime = niz[0];
            string prezime = niz.Length > 1 ? niz[1] : "";

            Autor autor = new Autor(ime, prezime);
            int godina = 0;
            try
            {
                godina = int.Parse(godinaString);
            } 
            catch(Exception)
            {
                MessageBox.Show("Godina izdavanja nije validna");
                return;
            }

            Knjiga knjiga = new Knjiga(naziv, autor, godina);

            knjiga.ucitajZanrove(zanrovi);
            knjiga.ucitajOcene(ocene);

            if (knjiga.Ocene.Count == 0)
            {
                return;
            }


            knjige.Add(knjiga);
            MessageBox.Show("Knjiga dodata u listu");

            textNaziv.Text = "";
            textAutor.Text = "";
            textGodina.Text = "";
            textOcene.Text = "";
            textZanorvi.Text = "";
        }

        private async void buttonUpisi_Click(object sender, EventArgs e)
        {
            if (textFajl.Text.Length == 0)
            {
                return;
            }

            string imeFajla = textFajl.Text;

            await Task.Run(() =>
            {
                Knjiga.XmlSerijalizacija(imeFajla, knjige);
                MessageBox.Show("Knjige upisane u XML fajl: " + imeFajla);
            }
            );
            
        }

        private async void buttonUcitaj_Click(object sender, EventArgs e)
        {
            if (textFajl.Text.Length == 0)
            {
                return;
            }

            string imeFajla = textFajl.Text;

            await Task.Run(() =>
            {
                List<Knjiga> ucitanjeKnjige = Knjiga.XmlDeserijalizacija(imeFajla); ;
                listBox1.Items.Clear();

                listBox1.Items.Add("id \t Naziv \t Autor \t Godina izdanja \t Zanrovi \t Prosecna ocena");

                foreach (Knjiga knjiga in ucitanjeKnjige)
                {
                    listBox1.Items.Add(
                        knjiga.KnjigaId + "\t"
                        + knjiga.Naziv + "\t"
                        + knjiga.Autor.Ime + " " + knjiga.Autor.Prezime + "\t"
                        + knjiga.GodinaIzdanja.ToString() + "\t"
                        + String.Join(", ", knjiga.Zanrovi.ToArray()) + "\t"
                        + knjiga.prosecnaOcena().ToString()


                        );
                }
                MessageBox.Show("Ucitanje knjige iz XML fajla: " + imeFajla);
                knjige = ucitanjeKnjige;
            });

            
        }
    }
}
