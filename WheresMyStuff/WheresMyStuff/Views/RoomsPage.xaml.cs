using System;
using System.Collections.Generic;
using wheresmystuff.Models;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class RoomsPage : ContentPage
    {
        private Room _room;

        public RoomsPage(Room room)
        {
            _room = room;
            RoomsViewModel vm = new RoomsViewModel();
            vm.Room = _room;

            BindingContext = vm;

            InitializeComponent();

        }

        void Handle_Edit_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditRoomsPage((Room)_room));
        }
    }
}
