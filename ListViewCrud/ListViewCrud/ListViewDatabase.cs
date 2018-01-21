﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ListViewCrud
{
    public class ListViewDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ListViewDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Item>().Wait();
        }

        public Task<List<Item>> GetItemsAsync()
        {
            return database.Table<Item>().ToListAsync();
        }

        public Task<Item> GetItemAsync(int id)
        {
            return database.Table<Item>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Item item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Item item)
        {
            return database.DeleteAsync(item);
        }
    }
}
