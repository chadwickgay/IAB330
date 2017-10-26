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
    public class ItemsViewModel : ViewModelBase
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
		public ItemsViewModel()
		{

            db = new MyDatabase();

            SubmitCommand = new Command(Submit);
		}

		public void Submit()
		{
			db.Insert(new Item()
			{
				Name = this.Name,
                BoxNumber = BoxNumber,
                Description = Description
			});
			Name = String.Empty;
			BoxNumber = String.Empty;
			Description = String.Empty;
		}

	}
}