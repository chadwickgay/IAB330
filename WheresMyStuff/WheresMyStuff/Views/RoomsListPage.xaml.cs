using wheresmystuff.Models;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
{
    public partial class RoomsListPage : ContentPage
    {
        void Handle_RoomSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var room = e.SelectedItem as Room;

            if (room == null)
            {
                return;
            }

            Navigation.PushAsync(new RoomsPage(room));
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
