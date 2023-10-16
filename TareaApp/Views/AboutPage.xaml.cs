using System;
using System.ComponentModel;
using TareaApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();
        }
    }
}