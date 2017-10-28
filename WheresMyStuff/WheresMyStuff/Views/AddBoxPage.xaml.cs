using System;
using System.Collections.Generic;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class AddBoxPage : ContentPage
    {
        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //var room = RoomPicker.Items[RoomPicker.SelectedIndex];

           // DisplayAlert(room, "selected value", "OK");
        }

        void Handle_Save_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public AddBoxPage()
        {
            InitializeComponent();

            BindingContext = new BoxesViewModel();

        }
    }
}
