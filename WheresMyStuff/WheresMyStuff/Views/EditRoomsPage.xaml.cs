using System;
using System.Collections.Generic;
using wheresmystuff.Models;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class EditRoomsPage : ContentPage
    {
        public EditRoomsPage(Room room)
        {
            RoomsViewModel vm = new RoomsViewModel();
            vm.Room = room;
            BindingContext = vm;

            InitializeComponent();


        }
        void Handle_Save_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
