using System;
using System.Collections.Generic;
using WheresMyStuff.ViewModels;
using Xamarin.Forms;

namespace WheresMyStuff.Views
{
    public partial class ItemPage : ContentPage
    {

        void Handle_Edit_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddItemPage());
        }

        public ItemPage()
        {
            InitializeComponent();

            BindingContext = new ItemsViewModel();
        }
    }
}
