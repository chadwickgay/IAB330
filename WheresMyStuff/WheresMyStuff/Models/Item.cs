using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite.Net.Attributes;

namespace wheresmystuff.Models
{
    /// <summary>
    /// An Item is placed in a Box
    /// </summary>
    public class Item
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string BoxNumber { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}