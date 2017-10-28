using System;
using System.Collections.Generic;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class BoxPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditBoxPage());
        }

        public BoxPage()
        {
            InitializeComponent();

            BindingContext = new BoxesViewModel();
        }

    }
}
