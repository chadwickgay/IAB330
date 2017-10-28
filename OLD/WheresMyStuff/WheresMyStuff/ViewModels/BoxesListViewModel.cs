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
    public class BoxesListViewModel : ViewModelBase
    {
        private readonly MyDatabase db;
        private ObservableCollection<Box> boxes;

        public ObservableCollection<Box> Boxes
        {
            get { return boxes; }
            set
            {
                boxes = value;
                OnPropertyChanged();
            }
        }

        public BoxesListViewModel()
        {
            db = new MyDatabase();
            Boxes = new ObservableCollection<Box>(db.GetAllBoxes());
        }
    }
}
