using System;
using TareaApp.Services;
using TareaApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            InitializeComponent();

            MainPage = new NavigationPage(new TareaApp.Views.LoginPage());
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
