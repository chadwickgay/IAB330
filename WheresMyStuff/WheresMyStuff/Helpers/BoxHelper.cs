using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using wheresmystuff.Models;
using System.Linq;

namespace wheresmystuff.Helpers
{
    public static class BoxHelper
    {

        public static ObservableCollection<Box> Boxes { get; set; }

        static BoxHelper()
        {

            Boxes = new ObservableCollection<Box>();
            Boxes.Add(new Box
            {
                BoxNumber = "1",
                Location = "Lounge",
                Description = "Lounge room items.",
                Image = "http://nwchurch.com/wp-content/uploads/2016/11/Open-Cardboard-Box-2400px.png"
            });

            Boxes.Add(new Box
            {
                BoxNumber = "2",
                Location = "Bedroom",
                Description = "Items from upstairs bedrrom.",
                Image = "http://dsmconsulting.com.au/wp-content/uploads/2015/02/cardboard-box-780x5821.png"
            });

            Boxes.Add(new Box
            {
                BoxNumber = "3",
                Location = "Kitchen",
                Description = "Kitchen utensils.",
                Image = "https://images-na.ssl-images-amazon.com/images/I/41s09SSBC3L._SL500_AC_SS350_.jpg"
            });


        }
    }
}