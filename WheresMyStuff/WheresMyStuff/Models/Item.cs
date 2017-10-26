using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite.Net.Attributes;

namespace WheresMyStuff.Models
                       
{
	public class Item
	{
        [PrimaryKey] [AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string BoxNumber { get; set; }
		public string Description { get; set; }
		//URL for our item image!
		public string Image { get; set; }
	}
}