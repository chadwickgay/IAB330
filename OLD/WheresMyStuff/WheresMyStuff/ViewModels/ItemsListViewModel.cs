using WheresMyStuff.Databases;
using WheresMyStuff.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Diagnostics;

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

            //SearchCommand = new Command(() => Debug.WriteLine("Command executed"));
		}

        public ICommand SearchCommand
        {
            get
            {
                return new Command(() => {
                    var tempRecords = items.Where(c => c.Name.Contains(SearchedText));
                    Items.Clear();
                    foreach (var item in tempRecords)
                    {
                        Items.Add(item);
                    }
                });
            }
        }

        private string _searchedText;
        public string SearchedText
        {
            get { return _searchedText; }
            set { _searchedText = value; OnPropertyChanged(); }
        }

    }
}
