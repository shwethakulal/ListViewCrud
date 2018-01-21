using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewCrud
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { set; get; }
        public string ItemName { set; get; }
    }
}
