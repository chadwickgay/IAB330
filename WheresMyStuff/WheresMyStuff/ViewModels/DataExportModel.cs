using wheresmystuff.Helpers;
using wheresmystuff.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using wheresmystuff.Databases;
using Xamarin.Forms;
using System.Text;
using System.Xml.Serialization;

using System.Runtime.Serialization.Json;using System.IO;
using wheresmystuff.Interfaces;

namespace wheresmystuff.ViewModels
{
    public class DataExportModel : ViewModelBase
    {

        private readonly MyDatabase _db;

        public ICommand SubmitCommand { protected set; get; }
        public DataExportModel()
        {
            _db = new MyDatabase();
        }
    }
}