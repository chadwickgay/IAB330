using wheresmystuff.Models;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class BoxesListPage : ContentPage
    {
        public BoxesListPage()
        {
            InitializeComponent();

            BindingContext = new BoxesListViewModel();
        }

        void Handle_Add_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddBoxPage());
        }

        void Handle_BoxSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var box = e.SelectedItem as Box;

            if (box == null)
            {
                return;
            }

            Navigation.PushAsync(new BoxPage(box));
        }
    }
}
