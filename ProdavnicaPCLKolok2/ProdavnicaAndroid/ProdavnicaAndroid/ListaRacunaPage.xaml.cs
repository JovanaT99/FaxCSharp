using ProdavnicaPCL.Modeli;
using ProdavnicaPCL.Servis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProdavnicaAndroid
{
    public partial class ListaRacunaPage : ContentPage
    {
        public static string filterRacuna;

        public ListaRacunaPage(string mod, float vrednost)
        {
            filterRacuna = mod;
            InitializeComponent();

            List<Racun> racuni = ProdavnicaServis.getInstance().Racuni;

            if (mod == "skuplji")
            {
                racuni = ProdavnicaServis.getInstance().racuniSkupljiOd(vrednost);
            } else if (mod == "jeftiniji")
            {
                racuni = ProdavnicaServis.getInstance().racuniJeftinijiOd(vrednost);
            } 

            foreach (Racun racun in racuni) {
                Label label = new Label { Text = racun.Cena().ToString(), Padding = 5 };
                TapGestureRecognizer tap = new TapGestureRecognizer();
                tap.Tapped += (s, e) =>
                {
                    Navigation.PushAsync(new RacunPage(racun.RacunId));

                };
                label.GestureRecognizers.Add(tap);
                listaStack.Children.Add(label);
            }
        }


    }
}
