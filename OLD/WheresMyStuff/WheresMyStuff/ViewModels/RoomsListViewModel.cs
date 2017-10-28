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
    public class RoomsListViewModel : ViewModelBase
    {
        private readonly MyDatabase db;
        private ObservableCollection<Room> rooms;

        public ObservableCollection<Room> Rooms
        {
            get { return rooms; }
            set
            {
                rooms = value;
                OnPropertyChanged();
            }
        }

        public RoomsListViewModel()
        {
            db = new MyDatabase();
            Rooms = new ObservableCollection<Room>(db.GetAllRooms());
        }
    }
}
