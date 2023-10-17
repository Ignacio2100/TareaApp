using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        private async void Ejercicio1Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        private async void Ejercicio2Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsPage());
        }
    }
}