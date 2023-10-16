// AboutViewModel.cs
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace TareaApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private double precio;
        private int cantidad;
        private double total;
        private double pagado;
        private double cambio;

        public double Precio
        {
            get => precio;
            set
            {
                SetProperty(ref precio, value);
                CalculateTotal();
            }
        }

        public int Cantidad
        {
            get => cantidad;
            set
            {
                SetProperty(ref cantidad, value);
                CalculateTotal();
            }
        }

        public double Total
        {
            get => total;
            set => SetProperty(ref total, value);
        }

        public double Pagado
        {
            get => pagado;
            set
            {
                SetProperty(ref pagado, value);
                CalculateChange();
            }
        }

        public double Cambio
        {
            get => cambio;
            set => SetProperty(ref cambio, value);
        }

        public ICommand CalculateCommand { get; private set; }

        public AboutViewModel()
        {
            CalculateCommand = new Command(CalculateChange);
            // Inicializa las propiedades a valores predeterminados si es necesario
            Precio = 0;
            Cantidad = 0;
            Total = 0;
            Pagado = 0;
            Cambio = 0;
        }

        private void CalculateTotal()
        {
            Total = Precio * Cantidad;
        }

        private void CalculateChange()
        {
            Cambio = Pagado - Total;
        }
    }
}
