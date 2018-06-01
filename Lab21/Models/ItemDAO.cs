﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab21.Models
{
    public class ItemDAO:ItemIDAO
    {
        private CoffeeEntities db;
        
        public ItemDAO()
        {
            db = new CoffeeEntities();
        }
        public Item GetItem(int id)
        {
            return db.Items.Find(id);
        }

        public List<Item> GetItemList()
        {
            return db.Items.ToList();
        }

        public void AddItem(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
        }

        public void EditItem(Item item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }





    }
}