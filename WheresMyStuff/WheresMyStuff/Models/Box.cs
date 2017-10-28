using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite.Net.Attributes;

namespace wheresmystuff.Models

{
    public class Box
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        public string BoxNumber { get; set; }
        public string Room { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        //URL for our item image!
        public string Image { get; set; }

    }
}