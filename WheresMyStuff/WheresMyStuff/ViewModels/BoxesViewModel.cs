using wheresmystuff.Helpers;
using wheresmystuff.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using wheresmystuff.Databases;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace wheresmystuff.ViewModels
{
    public class BoxesViewModel : ViewModelBase
    {

        private readonly MyDatabase db;
        private ObservableCollection<Room> _rooms;
        List<string> room_list = new List<string>();

        private Box _box;
        public Box Box
        {
            get { return _box;  }
            set
            {
                _box = value;
                OnPropertyChanged("Box");
            }
        }

        public ICommand SubmitCommand { protected set; get; }
        /// <summary>
        /// Handle inserting a new Box
        /// </summary>
        public void Submit()
        {
            db.Insert(Box);
            MessagingCenter.Send<String>("insert", "refresh");
        }

        /// <summary>
        /// Handle updating a Box
        /// </summary>
        public ICommand UpdateCommand { protected set; get; }
        public void Update()
        {
            db.InsertOrUpdate(Box);
            MessagingCenter.Send<String>("update", "refresh");
        }

        public ObservableCollection<Item> Items
        {
            get
            {
                //Ignoring null values as it caused LINQ to crash
                //TODO: Add validation on items page
                if (!String.IsNullOrEmpty(_box.BoxNumber)) { 
                    return new ObservableCollection<Item>(db.GetAllItems()
                        .Where(i => i.BoxNumber != null && i.BoxNumber.Contains((string)_box.BoxNumber))
                    );
                }
                return null;
            }
        }

        // To get list of rooms 
        public ObservableCollection<Room> Rooms
        {
            get { return _rooms; }
            set
            {
                _rooms = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get a list of Rooms that the Box could be in
        /// </summary>
        public void GetListOfRooms()
        {
            Rooms = new ObservableCollection<Room>(db.GetAllRooms());

            foreach (var room in Rooms)
            {
                room_list.Add(room.Name);
            }
        }

        public List<string> Room_List => room_list;

        // Constructor 
        public BoxesViewModel()
        {
            db = new MyDatabase();

            SubmitCommand = new Command(Submit);
            UpdateCommand = new Command(Update);

            GetListOfRooms();
        }

    }
}
