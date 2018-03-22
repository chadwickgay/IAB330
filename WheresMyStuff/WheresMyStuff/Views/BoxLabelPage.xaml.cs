using System;
using System.Collections.Generic;
using System.Diagnostics;
using wheresmystuff.Models;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class BoxLabelPage : ContentPage
    {
        private Box _box;

        public BoxLabelPage(Box box)
        {
            _box = box;
            BoxesViewModel vm = new BoxesViewModel();
            vm.Box = _box;

            BindingContext = vm;

            InitializeComponent();

        }
    }
}
