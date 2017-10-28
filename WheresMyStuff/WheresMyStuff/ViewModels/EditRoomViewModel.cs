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
    public class EditBoxesViewModel : ViewModelBase
    {

        private readonly MyDatabase db;
        private ObservableCollection<Room> _rooms;
        private ObservableCollection<Item> _items;
        List<string> room_list = new List<string>();

        private string room;
        public string Room
        {
            get { return room; }
            set
            {
                room = value;
                OnPropertyChanged();
            }
        }

        private string boxNumber;
        public string BoxNumber
        {
            get { return boxNumber; }
            set
            {
                boxNumber = value;
                OnPropertyChanged();
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }

        public ICommand SubmitCommand { protected set; get; }

        public void Submit()
        {
            db.Insert(new Box()
            {
                BoxNumber = BoxNumber,
                Description = Description,
                Room = Room
            });
            BoxNumber = String.Empty;
            Description = String.Empty;
            Room = String.Empty;

            MessagingCenter.Send<String>("insert", "refresh");
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

        public void GetListOfRooms()
        {
            Rooms = new ObservableCollection<Room>(db.GetAllRooms());

            foreach (var room in Rooms)
            {
                room_list.Add(room.Name);
            }
        }

        public List<string> Room_List => room_list;

        // To display respective items on the page

        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        public void GetItemsInsideBox()
        {
            // Just trying to display all items in the db on the box page
            Items = new ObservableCollection<Item>(db.GetAllItems());

            OnPropertyChanged();
        }

        // Constructor 

        public EditBoxesViewModel()
        {

            db = new MyDatabase();

            SubmitCommand = new Command(Submit);
            UpdateCommand = new Command(Update);

            GetListOfRooms();

            GetItemsInsideBox();
        }

        public EditBoxesViewModel(INavigation navigation) : base(navigation)
        {

            db = new MyDatabase();

        }

        // Update box

        public ICommand UpdateCommand { protected set; get; }

        public void Update()
        {
            db.InsertOrUpdate(new Box()
            {
                BoxNumber = BoxNumber,
                Description = Description,
                Room = Room
            });

            MessagingCenter.Send<String>("insert", "refresh");
        }

    }
}
