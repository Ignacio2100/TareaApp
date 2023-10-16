using System.ComponentModel;
using TareaApp.ViewModels;
using Xamarin.Forms;

namespace TareaApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}