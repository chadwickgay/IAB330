using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class SettingsPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CloudSync());
        }

        public SettingsPage()
        {
            InitializeComponent();
        }
    }
}
