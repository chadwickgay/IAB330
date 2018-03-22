using System;
using System.Collections.Generic;
using wheresmystuff.Models;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class ItemPage : ContentPage
    {
        private Item _item;

        void Handle_Edit_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditItemPage((Item)_item));
        }

        public ItemPage(Item item)
        {
            _item = item;
            ItemsViewModel vm = new ItemsViewModel();
            vm.Item = _item;

            BindingContext = vm;

            InitializeComponent();
        }


    }
}
