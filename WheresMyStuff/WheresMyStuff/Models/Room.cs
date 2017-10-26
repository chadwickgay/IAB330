﻿using SQLite.Net.Attributes;
using WheresMyStuff.Models;

namespace WheresMyStuff.Models
{
    public class Room
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Uncomment when we implement Box
        //public Box[] Boxes { get; set; }
    }
}