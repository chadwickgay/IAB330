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

        public MyDatabase()
        {
            database = new SQLiteConnection(DependencyService.Get<ISQLitePlatform>(),
            DependencyService.Get<IFileHelper>().GetLocalPath("wheresmystuffSqlite.db3"));
            database.CreateTable<Item>();
            database.CreateTable<Room>();
            database.CreateTable<Box>();
        }
        // Items
        public int Insert(Item item)
        {
            var db_item = database.Insert((item));
            database.Commit();
            return db_item;
        }

        public int InsertOrUpdate(Item item)
        {
            int num;
            if (database.Table<Item>().Any(x => x.Id == item.Id))
            {
                num = database.Update(item);
            }
            num = database.Insert((item));
            database.Commit();
            return num;
        }

        public int Delete(Item item)
        {
            int num;
            num = database.Delete<Item>(item.Id);
            database.Commit();
            return num;
        }

        public List<Item> GetAllItems()
        {
            //Added sorting here
            return database.Table<Item>().OrderBy(n => n.Name).ToList();
        }

        public Item GetItem(int key)
        {
            return database.Table<Item>().Where(x => x.Id == key).FirstOrDefault();
        }
        // Boxes
        public int Insert(Box box)
        {
            var db_box = database.Insert((box));
            database.Commit();
            return db_box;
        }

        public int InsertOrUpdate(Box box)
        {
            int num;
            if (database.Table<Box>().Any(x => x.Id == box.Id))
            {
                num = database.Update(box);
            }
            num = database.Insert((box));
            database.Commit();
            return num;
        }

        public int Delete(Box box)
        {
            int num;
            num = database.Delete<Box>(box.Id);
            database.Commit();
            return num;
        }

        public List<Box> GetAllBoxes()
        {
            return database.Table<Box>().ToList();
        }

        public Box GetBox(int key)
        {
            return database.Table<Box>().Where(x => x.Id == key).FirstOrDefault();
        }
        // Rooms
        public int Insert(Room room)
        {
            var db_room = database.Insert((room));
            database.Commit();
            return db_room;
        }

        public int InsertOrUpdate(Room room)
        {
            int num;
            if (database.Table<Room>().Any(x => x.Id == room.Id))
            {
                num = database.Update(room);
            }
            num = database.Insert((room));
            database.Commit();
            return num;
        }

        public int Delete(Room room)
        {
            int num;
            num = database.Delete<Room>(room.Id);
            database.Commit();
            return num;
        }

        public List<Room> GetAllRooms()
        {
            return database.Table<Room>().ToList();
        }

        public Room GetRoom(int key)
        {
            return database.Table<Room>().Where(x => x.Id == key).FirstOrDefault();
        }
    }
}
