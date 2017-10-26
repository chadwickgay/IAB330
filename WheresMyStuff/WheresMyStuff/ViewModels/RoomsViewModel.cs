using WheresMyStuff.Helpers;
using WheresMyStuff.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using WheresMyStuff.Databases;
using Xamarin.Forms;
using System;

namespace WheresMyStuff.ViewModels
{
    public class RoomsViewModel : ViewModelBase
    {

        private readonly MyDatabase db;

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
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
        public RoomsViewModel()
        {

            db = new MyDatabase();

            SubmitCommand = new Command(Submit);
        }

        public void Submit()
        {
            db.Insert(new Room()
            {
                Name = this.Name,
                Description = Description
            });
            Name = String.Empty;
            Description = String.Empty;
        }

    }
}

/*
using WheresMyStuff.Helpers;
using WheresMyStuff.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace WheresMyStuff.ViewModels
{
	public class RoomsViewModel
	{
		public ObservableCollection<Room> Rooms { get; set; }
		//public ObservableCollection<Grouping<string, Monkey>> MonkeysGrouped { get; set; }

		public RoomsViewModel()
		{
			Rooms = RoomHelper.Rooms;
		}
	}
}
*/