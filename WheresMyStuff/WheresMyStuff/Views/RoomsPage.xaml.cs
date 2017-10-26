using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WheresMyStuff.Views
{
    public partial class RoomsPage : ContentPage
    {
        public RoomsPage()
        {
            InitializeComponent();
        }

        void Handle_Edit_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddRoomPage());
        }
    }
}
