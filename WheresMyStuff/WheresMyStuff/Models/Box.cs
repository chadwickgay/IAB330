using SQLite.Net.Attributes;

namespace wheresmystuff.Models
{
    /// <summary>
    /// A Box contains Items and is located in a Room.
    /// </summary>
    public class Box
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        public string BoxNumber { get; set; }
        public string Room { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

    }
}