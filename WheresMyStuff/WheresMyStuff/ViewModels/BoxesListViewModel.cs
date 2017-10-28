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

    //https://www.davidbritch.com/2016/02/behaviours-library-for-xamarinforms_24.html

    public class BoxesListViewModel : ViewModelBase
    {
        private readonly MyDatabase _db;
        private ObservableCollection<Box> _boxes;
        private ObservableCollection<Item> _items;
        List<string> items_list = new List<string>();

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;

                //Not the most efficient way of doing this, but for now it works at least
                //Maybe revisit this if we have time at the end
                Boxes = new ObservableCollection<Box>(_db.GetAllBoxes());

                if (!String.IsNullOrWhiteSpace(_searchText))
                {
                    Boxes = new ObservableCollection<Box>(_boxes.Where(i => i.Description.Contains(_searchText)));
                }
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Box> Boxes
        {
            get { return _boxes; }
            set
            {
                _boxes = value;
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

        public void GetBoxes()
        {
            Boxes = new ObservableCollection<Box>(_db.GetAllBoxes());
        }

        public void GetListItemsInBox(string boxNumber)
        {
            Items = new ObservableCollection<Item>(_db.GetAllItems());

            foreach (var item in Items)
            {
                if (item.BoxNumber == boxNumber){
                    items_list.Add(item.Name);
                }
            }
        }

        public List<string> Item_List => items_list;

        public BoxesListViewModel()
        {
            _db = new MyDatabase();

            GetBoxes();
            GetListItemsInBox("6");

            MessagingCenter.Subscribe<String>(this, "refresh", (box) => GetBoxes());
        }
    }
}
