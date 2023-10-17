using System;
using System.ComponentModel;
using TareaApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        double precio;
        double cantidad;
        double Total;
        double pagado;
        double Cambio;
        double resul;

        private void Calcular()
        {
            precio = Convert.ToDouble(Precio.Text);
            cantidad = Convert.ToDouble(Cantidad.Text);

            resul = precio * cantidad;
            lbltotal.Text = resul.ToString();
        }

        private void CalcularCambio()
        {
            if (!string.IsNullOrEmpty(Pagado.Text))
            {
                pagado = Convert.ToDouble(Pagado.Text);
                if (pagado >= resul)
                {
                    Cambio = pagado - resul;
                    lblcambio.Text = Cambio.ToString();
                }
                else
                {
                    DisplayAlert("Error", "El monto pagado debe ser  mayor al total.", "OK");
                    lblcambio.Text = "0.0";
                }
            }
            else
            {
                DisplayAlert("Error", "Ingrese el monto pagado", "OK");
                lblcambio.Text = "0.0";
            }
        }

        private void validar()
        {
            if (!string.IsNullOrEmpty(Precio.Text))
            {
                Calcular();
                CalcularCambio();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }

        public AboutPage()
        {
            InitializeComponent();
        }
    }
}
