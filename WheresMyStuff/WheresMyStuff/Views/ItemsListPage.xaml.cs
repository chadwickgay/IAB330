using wheresmystuff.Models;
using wheresmystuff.ViewModels;
using Xamarin.Forms;

namespace wheresmystuff.Views
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
            var item = e.SelectedItem as Item;

            if (item == null)
            {
                return;
            }

            var itemsView = new ItemPage();
            itemsView.BindingContext = item;
            Navigation.PushAsync(itemsView);
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
