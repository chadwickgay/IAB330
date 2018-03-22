using SQLite.Net.Attributes;
using wheresmystuff.Models;

namespace wheresmystuff.Models
{
    /// <summary>
    /// A Room contains Boxes
    /// </summary>
    public class Room
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}