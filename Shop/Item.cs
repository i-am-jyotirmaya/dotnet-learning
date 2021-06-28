﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Item()
        {

        }

        public Item(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
