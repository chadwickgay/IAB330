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

        // Constructor 
        public EditBoxesViewModel()
        {
            db = new MyDatabase();
            UpdateCommand = new Command(Update);
        }

        // Update box

        public ICommand UpdateCommand { protected set; get; }

        /// <summary>
        /// Handle updating the box
        /// </summary>
        public void Update()
        {
            db.InsertOrUpdate(new Box
            {
                BoxNumber = BoxNumber,
                Description = Description,
                Room = Room
            });

            MessagingCenter.Send<String>("update", "refresh");
        }

    }
}
