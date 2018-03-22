using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using SQLite.Net.Interop;
using wheresmystuff.Interfaces;
using wheresmystuff.Models;
using Xamarin.Forms;

namespace wheresmystuff.Databases
{
    public class MyDatabase
    {
        static SQLiteConnection database;

        /// <summary>
        /// Init a MyDatabase object
        /// </summary>
        public MyDatabase()
        {
            database = new SQLiteConnection(DependencyService.Get<ISQLitePlatform>(),
            DependencyService.Get<IFileHelper>().GetLocalPath("wheresmystuffSqlite.db3"));
            database.CreateTable<Item>();
            database.CreateTable<Room>();
            database.CreateTable<Box>();
        }
        
        /// <summary>
        /// Insert override for Item
        /// </summary>
        /// <param name="item">The Item object to insert</param>
        /// <returns>The number of rows inserted</returns>
        public int Insert(Item item)
        {
            var db_item = database.Insert((item));
            database.Commit();
            return db_item;
        }

        /// <summary>
        /// Insert or update ovverride for Item
        /// </summary>
        /// <param name="item">The Item to insert or update</param>
        /// <returns>Returns the number of updated/inserted rows</returns>
        public int InsertOrUpdate(Item item)
        {
            int num;
            if (database.Table<Item>().Any(x => x.Id == item.Id))
            {
                num = database.Update(item);
            }
            else
            {
                num = database.Insert((item));
            }
            database.Commit();
            return num;
        }

        /// <summary>
        /// Override for deleting Items
        /// </summary>
        /// <param name="item">The Item to delete</param>
        /// <returns>The number of rows deleted</returns>
        public int Delete(Item item)
        {
            int num;
            num = database.Delete<Item>(item.Id);
            database.Commit();
            return num;
        }

        /// <summary>
        /// Returns all Items from the database
        /// </summary>
        /// <returns>A list of Items</returns>
        public List<Item> GetAllItems()
        {
            //Added sorting here
            return database.Table<Item>().OrderBy(n => n.Name).ToList();
        }

        /// <summary>
        /// Gets an Item by key
        /// </summary>
        /// <param name="key">The key of the Item</param>
        /// <returns>Returns an Item object populated with the data</returns>
        public Item GetItem(int key)
        {
            return database.Table<Item>().Where(x => x.Id == key).FirstOrDefault();
        }
        
        /// <summary>
        /// Insert a box
        /// </summary>
        /// <param name="box">The Box object to insert</param>
        /// <returns>The number of rows inserted</returns>
        public int Insert(Box box)
        {
            var db_box = database.Insert((box));
            database.Commit();
            return db_box;
        }

        /// <summary>
        /// Insert or update a Box
        /// </summary>
        /// <param name="box">The Box object to insert or update</param>
        /// <returns>The number of rows inserted or updated</returns>
        public int InsertOrUpdate(Box box)
        {
            int num;
            if (database.Table<Box>().Any(x => x.Id == box.Id))
            {
                num = database.Update(box);
            } else
            {
                num = database.Insert((box));
            }
            database.Commit();
            return num;
        }

        /// <summary>
        /// Delete a Box
        /// </summary>
        /// <param name="box">The Box object to delete</param>
        /// <returns>The number of Boxes deleted</returns>
        public int Delete(Box box)
        {
            int num;
            num = database.Delete<Box>(box.Id);
            database.Commit();
            return num;
        }

        /// <summary>
        /// Returns all the Boxes in the database
        /// </summary>
        /// <returns>Returns a list of Boxes</returns>
        public List<Box> GetAllBoxes()
        {
            return database.Table<Box>().ToList();
        }

        /// <summary>
        /// Gets a Box
        /// </summary>
        /// <param name="key">The key of the Box to select</param>
        /// <returns>Returns an instane of Box with the populated data</returns>
        public Box GetBox(int key)
        {
            return database.Table<Box>().Where(x => x.Id == key).FirstOrDefault();
        }

        /// <summary>
        /// Insert a Room
        /// </summary>
        /// <param name="room">The Room to insert</param>
        /// <returns>The number of rows inserted</returns>
        public int Insert(Room room)
        {
            var db_room = database.Insert((room));
            database.Commit();
            return db_room;
        }

        /// <summary>
        /// Insert or update a Room
        /// </summary>
        /// <param name="room">The Room to insert or update</param>
        /// <returns>Returns the number of rows inserted or updated</returns>
        public int InsertOrUpdate(Room room)
        {
            int num;
            if (database.Table<Room>().Any(x => x.Id == room.Id))
            {
                num = database.Update(room);
            }
            else
            {
                num = database.Insert((room));
            }
            database.Commit();
            return num;
        }

        /// <summary>
        /// Delete a Room
        /// </summary>
        /// <param name="room">The Room object to delete</param>
        /// <returns>The number of rows deleted</returns>
        public int Delete(Room room)
        {
            int num;
            num = database.Delete<Room>(room.Id);
            database.Commit();
            return num;
        }

        /// <summary>
        /// Returns all Rooms
        /// </summary>
        /// <returns>A list of Rooms</returns>
        public List<Room> GetAllRooms()
        {
            return database.Table<Room>().ToList();
        }

        /// <summary>
        /// Gets a Room from the database
        /// </summary>
        /// <param name="key">The key of the Room</param>
        /// <returns>Returns a populated Room object</returns>
        public Room GetRoom(int key)
        {
            return database.Table<Room>().Where(x => x.Id == key).FirstOrDefault();
        }
    }
}
