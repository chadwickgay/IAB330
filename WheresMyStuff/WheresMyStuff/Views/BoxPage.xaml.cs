using System;
using System.Collections.Generic;
using System.Diagnostics;
using wheresmystuff.Models;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class BoxPage : ContentPage
    {
        private Box _box;

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditBoxPage((Box)_box));
        }

        void Handle_Label_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BoxLabelPage((Box)_box));
        }

        public BoxPage(Box box)
        {
            _box = box;
            BoxesViewModel vm = new BoxesViewModel();
            vm.Box = _box;

            BindingContext = vm;

            InitializeComponent();

        }
    }
}
