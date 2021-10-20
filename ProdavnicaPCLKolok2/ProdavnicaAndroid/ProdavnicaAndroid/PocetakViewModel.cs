using ProdavnicaPCL.Podaci;
using ProdavnicaPCL.Servis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProdavnicaAndroid
{
    class PocetakViewModel : BaseViewModel
    {

        string naziv = string.Empty;
        public string Naziv
        {
            get { return naziv; }
            set { SetProperty(ref naziv, value); }
        }

        string adresa = string.Empty;
        public string Adresa
        {
            get { return adresa; }
            set { SetProperty(ref adresa, value); }
        }

        string ukupno = string.Empty;
        public string Ukupno
        {
            get { return ukupno; }
            set { SetProperty(ref ukupno, value); }
        }

        string prosecno = string.Empty;
        public string Prosecno
        {
            get { return prosecno; }
            set { SetProperty(ref prosecno, value); }
        }

        public PocetakViewModel()
        {
            Prodavnica prodavnica = ProdavnicaServis.getInstance();
            Title = "Prodavnica";
            Naziv = prodavnica.Naziv;
            Adresa = prodavnica.Adresa;
            Ukupno = "Sve ukupno: " + prodavnica.ukupnaCenaSvihRacuna() + " dinara";
            Prosecno = "Prosecan iznos: " + prodavnica.procenaCenaRacuna() + " dinara";
        }

    }
}
