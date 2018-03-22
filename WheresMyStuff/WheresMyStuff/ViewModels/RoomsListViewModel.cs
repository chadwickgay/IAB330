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

    public class RoomsListViewModel : ViewModelBase
    {
        private readonly MyDatabase _db;
        private ObservableCollection<Room> _rooms;
        private string _searchText;

        /// <summary>
        /// Handle searching Rooms
        /// </summary>
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;

                //Not the most efficient way of doing this, but for now it works at least
                //Maybe revisit this if we have time at the end
                Rooms = new ObservableCollection<Room>(_db.GetAllRooms());

                if (!String.IsNullOrWhiteSpace(_searchText))
                {
                    Rooms = new ObservableCollection<Room>(_rooms.Where(i => i.Name.Contains(_searchText)
                                                                        || i.Description.Contains(_searchText)));
                }
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Room> Rooms
        {
            get { return _rooms; }
            set
            {
                _rooms = value;
                OnPropertyChanged();
            }
        }

        public void GetRooms()
        {
            Rooms = new ObservableCollection<Room>(_db.GetAllRooms());
        }

        public RoomsListViewModel()
        {
            _db = new MyDatabase();

            GetRooms();

            MessagingCenter.Subscribe<String>(this, "refresh", (room) => GetRooms());
        }
    }
}
