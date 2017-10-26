using WheresMyStuff.ViewModels;
using Xamarin.Forms;

namespace WheresMyStuff.Views
{
    public partial class RoomsListPage : ContentPage
    {
        void Handle_RoomSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new RoomsPage());
        }

        public RoomsListPage()
        {
            InitializeComponent();

            BindingContext = new RoomsListViewModel();
        }

        void Handle_Add_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddRoomPage());
        }

    }
}
