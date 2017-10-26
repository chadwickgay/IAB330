using WheresMyStuff.Databases;
using WheresMyStuff.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheresMyStuff.ViewModels
{
    public class ItemsListViewModel : ViewModelBase
    {
		private readonly MyDatabase db;
		private ObservableCollection<Item> items;

		public ObservableCollection<Item> Items
		{
			get { return items; }
			set
			{
				items = value;
				OnPropertyChanged();
			}
		}

        public ItemsListViewModel()
		{
			db = new MyDatabase();
			Items = new ObservableCollection<Item>(db.GetAllItems());
		}
    }
}
