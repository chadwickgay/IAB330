using WheresMyStuff.ViewModels;
using Xamarin.Forms;

namespace WheresMyStuff.Views
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
            Navigation.PushAsync(new BoxPage());
        }
    }
}
