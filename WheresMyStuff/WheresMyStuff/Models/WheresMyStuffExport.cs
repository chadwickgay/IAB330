using System.Collections.ObjectModel;
using wheresmystuff.Databases;
using System.Runtime.Serialization;

namespace wheresmystuff.Models
{
    /// <summary>
    /// Provides a simple class to serialise when exporting data into a JSON object. All properties are marked as 
    /// DataMember so that the serialiser will automatically serialise them.
    /// </summary>
    [DataContract]
    class WheresMyStuffExport
    {
        private readonly MyDatabase _db;

        [DataMember]
        public ObservableCollection<Item> items;

        [DataMember]
        public ObservableCollection<Box> boxes;

        [DataMember]
        public ObservableCollection<Room> rooms;

        /// <summary>
        /// On initiation, an instance of the object is prepopulated
        /// </summary>
        public WheresMyStuffExport()
        {
            _db = new MyDatabase();

            this.Refresh();
        }

        /// <summary>
        /// Updates the list of items, boxes and rooms from the database
        /// </summary>
        public void Refresh()
        {
            this.items = new ObservableCollection<Item>(_db.GetAllItems());
            this.boxes = new ObservableCollection<Box>(_db.GetAllBoxes());
            this.rooms = new ObservableCollection<Room>(_db.GetAllRooms());
        }
    }
}
