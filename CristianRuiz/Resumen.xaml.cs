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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario,string nombre, string cuota, string pago)
        {
            InitializeComponent();
            rusuario1.Text = usuario;
            nom.Text = nombre;
            double x = Convert.ToDouble(cuota) + (Convert.ToDouble(pago) * 5);
            tot.Text = Convert.ToString(x);
        }
    }
}