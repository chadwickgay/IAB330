using System;
using System.Collections.Generic;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{

    public partial class EditBoxPage : ContentPage
    {
        void Handle_Save_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public EditBoxPage()
        {
            InitializeComponent();

            //BindingContext = new BoxesViewModel();
        }

    }
}
