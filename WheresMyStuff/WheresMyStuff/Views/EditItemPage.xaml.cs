using System;
using System.Collections.Generic;
using wheresmystuff.Models;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class EditItemPage : ContentPage
    {
        void Handle_Save_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public EditItemPage(Item item)
        {
            ItemsViewModel vm = new ItemsViewModel();
            vm.Item = item;
            BindingContext = vm;

            InitializeComponent();


        }
    }
}
