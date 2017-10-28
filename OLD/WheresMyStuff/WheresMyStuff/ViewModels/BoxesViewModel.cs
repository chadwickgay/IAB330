
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
    public class BoxesViewModel : ViewModelBase
    {

        private readonly MyDatabase db;

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

        private string location;

        public string Location
        {
            get { return location; }
            set
            {
                location = value;
                OnPropertyChanged();
            }
        }

        public ICommand SubmitCommand { protected set; get; }
        public BoxesViewModel()
        {

            db = new MyDatabase();

            SubmitCommand = new Command(Submit);
        }

        public void Submit()
        {
            db.Insert(new Box()
            {
                Location = Location,
                BoxNumber = BoxNumber,
                Description = Description
            });
            Location = String.Empty;
            BoxNumber = String.Empty;
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
	public class BoxesViewModel
	{
		public ObservableCollection<Box> Boxes { get; set; }

		public BoxesViewModel()
		{
            // This is just palceholder data
            Boxes = BoxHelper.Boxes;
		}

	}

}
*/