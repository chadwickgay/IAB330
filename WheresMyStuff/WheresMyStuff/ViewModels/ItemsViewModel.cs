using wheresmystuff.Helpers;
using wheresmystuff.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using wheresmystuff.Databases;
using Xamarin.Forms;
using System;
using System.Collections.Generic;

namespace wheresmystuff.ViewModels
{
    public class ItemsViewModel : ViewModelBase
    {

        private readonly MyDatabase _db;
        private ObservableCollection<Box> _boxes;
        List<string> box_list = new List<string>();

        private Item _item;
        public Item Item
        {
            get { return _item; }
            set
            {
                _item = value;
                OnPropertyChanged("Item");
            }
        }

        private string box;
        public string Box
        {
            get { return box; }
            set
            {
                box = value;
                OnPropertyChanged();
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _boxNumber;

        public string BoxNumber
        {
            get { return _boxNumber; }
            set
            {
                _boxNumber = value;
                OnPropertyChanged();
            }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        public ICommand SubmitCommand { protected set; get; }
        public ItemsViewModel()
        {
            _db = new MyDatabase();
            SubmitCommand = new Command(Submit);
            UpdateCommand = new Command(Update);
            GetListOfBoxNumbers();
        }

        /// <summary>
        /// Handle inserting a new Item
        /// </summary>
        public void Submit()
        {
            _db.Insert(new Item()
            {
                Name = this.Name,
                BoxNumber = BoxNumber,
                Description = Description
            });

            Name = String.Empty;
            BoxNumber = String.Empty;
            Description = String.Empty;

            MessagingCenter.Send<String>("insert", "refresh");
        }

        /// <summary>
        /// Handle updating an Item
        /// </summary>
        public ICommand UpdateCommand { protected set; get; }
        public void Update()
        {
            _db.InsertOrUpdate(Item);
            MessagingCenter.Send<String>("update", "refresh");
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

        public void GetListOfBoxNumbers()
        {
            Boxes = new ObservableCollection<Box>(_db.GetAllBoxes());

            foreach (var box in Boxes)
            {
                box_list.Add(box.BoxNumber);
            }
        }

        public List<string> Box_List => box_list;

    }
}