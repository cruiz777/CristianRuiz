using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CristianRuiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            rusuario.Text = usuario;
        }

        private void calculo_Clicked(object sender, EventArgs e)
        {
           double valor = Convert.ToDouble(txtcuotar.Text);
            double curso=Convert.ToDouble(3000);
            if (valor >=0 && valor<3000)
            {
                double p = ( (3000-valor) / 5 )+ (((3000 - valor) / 5)*5/100);
                txtpago.Text = p.ToString();
            }
            else
            {
                DisplayAlert("Advertencia", "Valor Incorrecto", "OK");
            }
            
        }

        private async void resumen_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resumen(rusuario.Text, txtnombrer.Text,txtcuotar.Text, txtpago.Text));
        }
    }
}