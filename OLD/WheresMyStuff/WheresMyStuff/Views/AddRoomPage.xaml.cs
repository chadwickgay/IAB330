using System;
using System.Collections.Generic;
using WheresMyStuff.ViewModels;
using Xamarin.Forms;

namespace WheresMyStuff.Views
{
    public partial class AddRoomPage : ContentPage
    {
        public AddRoomPage()
        {
            InitializeComponent();

            BindingContext = new RoomsViewModel();
        }

        void Handle_Save_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
