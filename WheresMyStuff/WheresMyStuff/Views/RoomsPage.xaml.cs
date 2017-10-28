using System;
using System.Collections.Generic;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class RoomsPage : ContentPage
    {
        public RoomsPage()
        {
            InitializeComponent();

            BindingContext = new RoomsViewModel();
        }

        void Handle_Edit_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddRoomPage());
        }
    }
}
