using wheresmystuff.Helpers;
using wheresmystuff.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using wheresmystuff.Databases;
using Xamarin.Forms;
using System;

namespace wheresmystuff.ViewModels
{
    public class RoomsViewModel : ViewModelBase
    {

        private readonly MyDatabase db;

        private Room _room;
        public Room Room
        {
            get { return _room; }
            set
            {
                _room = value;
                OnPropertyChanged("Box");
            }
        }

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
            UpdateCommand = new Command(Update);
        }

        /// <summary>
        /// Handle inserting a new Room
        /// </summary>
        public void Submit()
        {
            db.Insert(new Room()
            {
                Name = this.Name,
                Description = Description
            });
            Name = String.Empty;
            Description = String.Empty;

            MessagingCenter.Send<String>("insert", "refresh");
        }

        /// <summary>
        /// Update a Room
        /// </summary>
        public ICommand UpdateCommand { protected set; get; }
        public void Update()
        {
            db.InsertOrUpdate(Room);
            MessagingCenter.Send<String>("update", "refresh");
        }

    }
}
