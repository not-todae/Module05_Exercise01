using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module05_Exercise01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePicker : ContentPage
    {
        public DatePicker()
        {
            InitializeComponent();
        }
        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            var selectedDate = e.NewDate;
        }
    }
}