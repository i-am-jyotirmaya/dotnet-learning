using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class ShoppingManager
    {
        public List<Item> Inventory { get; set; }

        public List<Item> ShoppingCart { get; set; }

        public List<Invoice> Invoices { get; set; }

        public ShoppingManager()
        {
            Inventory = new List<Item>();
            ShoppingCart = new List<Item>();
            Invoices = new List<Invoice>();
        }

        public Invoice CreateInvoice()
        {
            Invoice invoice = new Invoice(Invoices.Count + 1, ShoppingCart.ToArray());
            Invoices.Add(invoice);
            return invoice;
        }
    }
}
