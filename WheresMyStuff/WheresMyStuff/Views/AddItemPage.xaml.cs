using wheresmystuff.Interfaces;
using wheresmystuff.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class AddItemPage : ContentPage
    {
        public AddItemPage()
        {
            InitializeComponent();

            BindingContext = new ItemsViewModel();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
             //var room = BoxPicker.Items[BoxPicker.SelectedIndex];

             //DisplayAlert(room, "selected value", "OK");
        }
    }
}
