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

    public class BoxesListViewModel : ViewModelBase
    {
        private readonly MyDatabase _db;
        private ObservableCollection<Box> _boxes;

        private string _searchText;

        /// <summary>
        /// Handle serching of Boxes
        /// </summary>
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;

                Boxes = new ObservableCollection<Box>(_db.GetAllBoxes());

                if (!String.IsNullOrWhiteSpace(_searchText))
                {
                    Boxes = new ObservableCollection<Box>(_boxes.Where(i => i.Description.Contains(_searchText)
                                                                       || i.BoxNumber.Contains(_searchText)
                                                                       || i.Room.Contains(_searchText)));
                }
                OnPropertyChanged();
            }
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

        /// <summary>
        /// Retrieves all Boxes from the database
        /// </summary>
        public void GetBoxes()
        {
            Boxes = new ObservableCollection<Box>(_db.GetAllBoxes());
        }

        public BoxesListViewModel()
        {
            _db = new MyDatabase();

            GetBoxes();

            MessagingCenter.Subscribe<String>(this, "refresh", (box) => GetBoxes());
        }
    }
}
