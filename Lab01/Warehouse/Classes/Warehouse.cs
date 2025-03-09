using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Warehouse
    {
        public string WarehouseName { get; set; }
        private readonly List<Product> products;
        public List<Product> Products => products;

        public Warehouse(string warehouseName)
        {
            WarehouseName = warehouseName;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        
        public void ReceiveGoods(string productName, int quantity)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                product.Quantity += quantity;
                product.LastArrivalDate = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
        public void ShipGoods(string productName, int quantity)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                if (product.Quantity >= quantity)
                {
                    product.Quantity -= quantity;
                }
                else
                {
                    Console.WriteLine("Not enough stock available for shipping.");
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}
