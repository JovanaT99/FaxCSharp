using ProdavnicaPCL.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProdavnicaAndroid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnRacuniSvi(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ListaRacunaPage("svi", 0));
        }
        void OnRacuniSkupljiOd(object sender, EventArgs args)
        {
            try
            {
                float vrednost = float.Parse(iznos.Text);
                Navigation.PushAsync(new ListaRacunaPage("skuplji", vrednost));

            }
            catch (Exception)
            {
                return;
            }
        }

        void OnRacuniJeftinijiOd(object sender, EventArgs args)
        {
            try
            {
                float vrednost = float.Parse(iznos.Text);
                Navigation.PushAsync(new ListaRacunaPage("jeftiniji", vrednost));

            }
            catch (Exception)
            {
                return;
            }
        }

        void najjeftiniji(object sender, EventArgs args)
        {
            Racun racun = ProdavnicaPCL.Servis.ProdavnicaServis.getInstance().racunNajjeftiniji();

            Navigation.PushAsync(new RacunPage(racun.RacunId));
        }

        void najskuplji(object sender, EventArgs args)
        {
            Racun racun = ProdavnicaPCL.Servis.ProdavnicaServis.getInstance().racunNajskuplji();

            Navigation.PushAsync(new RacunPage(racun.RacunId));
        }

    }
}
