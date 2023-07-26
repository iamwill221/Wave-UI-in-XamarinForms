using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Wave
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           codeTxt.Text+= btn.Text;
            if (codeTxt.Text.Length >= 4)
            {
                if (codeTxt.Text == "1234")
                {
                    Navigation.PushAsync(new WavePage());
                }
                else
                {
                    codeTxt.Text = "";
                }
            }

        }

        protected override void OnAppearing()
        {
            codeTxt.Text = "";
        }

        private void Effacer(object sender, EventArgs e)
        {
            if (codeTxt.Text.Length>0)
            {
                string txt = codeTxt.Text.Remove(codeTxt.Text.Length - 1);
                codeTxt.Text = txt;
            }

        }

        private void mdp_oublie(object sender, EventArgs e)
        {
           var resultat = DisplayAlert("Oublié votre code secret?", "Appelez le service client pour réinitialiser votre code secret", "APPELER", "ANNULER");
           Console.WriteLine(resultat);
        }
    }
}
