﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WheresMyStuff.Views
{
    public partial class BoxPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddBoxPage());
        }

        public BoxPage()
        {
            InitializeComponent();
        }

    }
}
