using System;
using System.Collections.Generic;
using WheresMyStuff.ViewModels;
using Xamarin.Forms;

namespace WheresMyStuff.Views
{
    public partial class AddBoxPage : ContentPage
    {
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
