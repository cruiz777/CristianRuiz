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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Iniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtContrasena.Text;
            if (usuario == "CristianRuiz" && clave == "uisrael2022")
            {
                await Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                _ = DisplayAlert("Advertencia", "Usuario o Clave Incorrecta", "Ok");
            }

        }
    }
}