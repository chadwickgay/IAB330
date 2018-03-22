using System;
using System.Collections.Generic;
using wheresmystuff.ViewModels;
using Xamarin.Forms;
using wheresmystuff.Models;

namespace wheresmystuff.Views
{
    public partial class AddBoxPage : ContentPage
    {
        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        }

        void Handle_Save_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public AddBoxPage()
        {
            BoxesViewModel vm = new BoxesViewModel();
            vm.Box = new Box();
            BindingContext = vm;

            InitializeComponent();
        }
    }
}
