using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Interfaces
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();


        private void Clicked_login(object sender, EventArgs e)


        {
            if (txtusuario.Text == "admin" && txtcontrasena.Text == "admin")
            {

                Navigation.PushModalAsync(new Menu());

            }

            else
            {
                DisplayAlert("Usuario No Registrado", "OK");
            }
        }

        private void DisplayAlert(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}




