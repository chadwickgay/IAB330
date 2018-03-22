using wheresmystuff.Databases;
using wheresmystuff.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Diagnostics;
using System.ComponentModel;

namespace wheresmystuff.ViewModels
{
    public class ItemsListViewModel : ViewModelBase
    {
        private readonly MyDatabase _db;
        private ObservableCollection<Item> _items;
        private string _searchText;

        /// <summary>
        /// Handle searching Items
        /// </summary>
        public string SearchText
        {
            get { return _searchText; }
            set {
                _searchText = value;

                //Not the most efficient way of doing this, but for now it works at least
                //Maybe revisit this if we have time at the end
                Items = new ObservableCollection<Item>(_db.GetAllItems());

                if (!String.IsNullOrWhiteSpace(_searchText))
                {
                    Items = new ObservableCollection<Item>(_items.Where(i => i.Name.Contains(_searchText)
                                                                        || i.Description.Contains(_searchText)));
                } 
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        public void GetItems()
        {
            Items = new ObservableCollection<Item>(_db.GetAllItems());
        }

        public ItemsListViewModel()
        {
            _db = new MyDatabase();

            GetItems();

            MessagingCenter.Subscribe<String>(this, "refresh", (item) => GetItems());
        }
    }
}
