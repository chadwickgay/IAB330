using NavigationMasterDetail.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace wheresmystuff
{
    public partial class wheresmystuffPage : MasterDetailPage
    {
        public List<MasterPageItem> _menuList { get; set; }

        public wheresmystuffPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new Views.ItemsListPage());

            _menuList = new List<MasterPageItem>();

            _menuList.Add(new MasterPageItem() { Title = "Items", TargetType = typeof(Views.ItemsListPage) });
            _menuList.Add(new MasterPageItem() { Title = "Boxes", TargetType = typeof(Views.BoxesListPage) });
            _menuList.Add(new MasterPageItem() { Title = "Rooms", TargetType = typeof(Views.RoomsListPage) });
            _menuList.Add(new MasterPageItem() { Title = "Data Export", TargetType = typeof(Views.DataExportPage) });
            _menuList.Add(new MasterPageItem() { Title = "Settings", TargetType = typeof(Views.SettingsPage) });

            navigationDrawerList.ItemsSource = _menuList;
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
