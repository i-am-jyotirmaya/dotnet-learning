using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingManager manager = new ShoppingManager();
            AddItemsToInventory(manager);

            Console.WriteLine("Items in Inventory:\n");
            foreach(var items in manager.Inventory)
            {
                Console.WriteLine($"{items.Id} -- ${items.Name} -- Rs.{items.Price}\n");
            }
            Console.WriteLine("Choose items (Enter Id separated by comma):");
            string input = Console.ReadLine();
            string[] itemIds = input.Split(','); // "2,4,5" ==> "2", "3", "4"
            foreach(string itemId in itemIds)
            {
                int Id = Convert.ToInt32(itemId.Trim());
                Item item = manager.Inventory.FirstOrDefault(e => e.Id == Id);
                manager.ShoppingCart.Add(item);
            }

            Invoice invoice = manager.CreateInvoice();
            Console.WriteLine(invoice);
            Console.ReadLine();
        }

        static void AddItemsToInventory(ShoppingManager manager)
        {
            Item[] items = new Item[]
            {
                new Item(1, "Toothpaste", 20),
                new Item(2, "Car", 2000),
                new Item(3, "Deo", 100),
                new Item(4, "Ice Cream", 10),
                new Item(5, "Pan", 500)
            };
            manager.Inventory.AddRange(items);
        }
    }
}
