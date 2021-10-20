using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProdavnicaAndroid
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());


            // App.Current.MainPage = new NavigationPage(new ListaRacunaPage());
        }



        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
