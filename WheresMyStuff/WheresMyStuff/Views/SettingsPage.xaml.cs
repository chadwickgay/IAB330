using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WheresMyStuff.Views
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
