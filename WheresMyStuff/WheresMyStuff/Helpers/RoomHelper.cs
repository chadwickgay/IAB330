﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using wheresmystuff.Models;
using System.Linq;

namespace wheresmystuff.Helpers
{
    public static class RoomHelper
    {
        public static ObservableCollection<Room> Rooms { get; set; }

        /// <summary>
        /// Setup some Rooms for debugging/sample
        /// </summary>
        static RoomHelper()
        {

            Rooms = new ObservableCollection<Room>();

            Rooms.Add(new Room
            {
                Name = "Main Bedroom",
                Description = "The main bedroom"
            });

            Rooms.Add(new Room
            {
                Name = "Lounge",
                Description = "The best place to relax (or nap)"
            });

            Rooms.Add(new Room
            {
                Name = "Kitchen",
                Description = "The place of food"
            });

            Rooms.Add(new Room
            {
                Name = "Bathroom",
                Description = "The main bathroom of the house"
            });


        }
    }
}