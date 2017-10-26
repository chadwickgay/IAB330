using WheresMyStuff.ViewModels;
using Xamarin.Forms;

namespace WheresMyStuff.Views
{
    public partial class ItemsListPage : ContentPage
    {
        public ItemsListPage()
        {
            InitializeComponent();

            BindingContext = new ItemsListViewModel();
        }

        void Handle_Add_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddItemPage());
        }

		void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			Navigation.PushAsync(new ItemPage());
		}
    }
}
