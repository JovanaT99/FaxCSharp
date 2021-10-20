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
    public partial class RacunPage : ContentPage
    {

        public RacunPage(int id)
        {
            InitializeComponent();

            Racun racun = ProdavnicaServis.getInstance().racunPoId(id);

            
            listaStack.Children.Add(
                new Label { Text = racun.ToString() }
            );
            
        }


    }
}
