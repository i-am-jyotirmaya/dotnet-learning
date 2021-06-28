using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Invoice
    {
        public int Id { get; set; }
        public Item[] Items { get; set; }
        public double TotalPrice { get; }

        public Invoice(int id, Item[] items)
        {
            Id = id;
            Items = items;
            foreach (var item in Items)
            {
                TotalPrice += item.Price;
            }
        }

        public override string ToString()
        {
            string text = $"Invoice no. {Id}\n\n";
            foreach(var item in Items)
            {
                text += $"{item.Id} -- {item.Name}: Rs1.{item.Price}\n";
            }
            text += $"\nTotal: Rs.{TotalPrice}";
            return text;
        }
    }
}
