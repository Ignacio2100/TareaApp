using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaApp.Models;
using TareaApp.ViewModels;
using TareaApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();

            
        }
        private void CalculateLoanAmount_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(SalaryEntry.Text, out double salary) && int.TryParse(YearsWorkedEntry.Text, out int yearsWorked))
            {
                double loanAmount = 0;

                if (yearsWorked >= 10)
                {
                    loanAmount = salary * 5;
                }
                else if (yearsWorked >= 4)
                {
                    loanAmount = salary * 4;
                }
                else if (yearsWorked >= 2)
                {
                    loanAmount = salary * 2;
                }
                else if (yearsWorked >= 1)
                {
                    loanAmount = salary * 1;
                }

                LoanAmountLabel.Text = $"Monto a Prestar: {loanAmount}";
            }
            else
            {
                DisplayAlert("Error", "Ingrese valores válidos en salario y años trabajados.", "OK");
            }
        }

    }
}