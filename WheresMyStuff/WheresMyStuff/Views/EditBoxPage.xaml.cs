using System;
using System.Collections.Generic;
using System.Diagnostics;
using wheresmystuff.ViewModels;
using Xamarin.Forms;
using wheresmystuff.Models;

namespace wheresmystuff.Views
{

    public partial class EditBoxPage : ContentPage
    {
        void Handle_Save_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public EditBoxPage(Box box)
        {
            BoxesViewModel vm = new BoxesViewModel();
            vm.Box = box;
            BindingContext = vm;

            InitializeComponent();


        }
    }
}
