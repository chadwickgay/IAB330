using Xamarin.Forms;

namespace WheresMyStuff
{
    public partial class WheresMyStuffPage : MasterDetailPage
    {
		void Handle_Items_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Views.ItemsListPage());
			// Hide the master page
			IsPresented = false;
		}

		void Handle_Boxes_Clicked(object sender, System.EventArgs e)
		{
		    Detail = new NavigationPage(new Views.BoxesListPage());
			// Hide the master page
			IsPresented = false;
		}

		void Handle_Rooms_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Views.RoomsListPage());
			// Hide the master page
			IsPresented = false;
		}

		void Handle_DataExport_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Views.DataExportPage());
			// Hide the master page
			IsPresented = false;
		}

		void Handle_Settings_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Views.SettingsPage());
			// Hide the master page
			IsPresented = false;
		}

        public WheresMyStuffPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new Views.ItemsListPage());
        }
    }
}
