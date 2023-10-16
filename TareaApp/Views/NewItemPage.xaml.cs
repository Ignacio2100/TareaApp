using System;
using System.Collections.Generic;
using System.ComponentModel;
using TareaApp.Models;
using TareaApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}