using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reporting
    {
        private Warehouse warehouse;

        public Reporting (Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        public void InventoryReport(string warehouseName)
        {
            Console.WriteLine($"Inventory Report for {warehouseName}:");
            foreach (var product in warehouse.Products)
            {
                Console.WriteLine($"Product: {product.Name}, Quantity: {product.Quantity}, Last Arrival: {product.LastArrivalDate}");
            }
        }

        public void RegisterIncoming(Warehouse warehouse, Product product, int quantity)
        {
            var existingProduct = warehouse.Products.FirstOrDefault(p => p.Name == product.Name);

            if (existingProduct != null)
            {
                existingProduct.Quantity += quantity;
                existingProduct.LastArrivalDate = DateTime.Now;
                Console.WriteLine($"Added {quantity} units of {product.Name} to the warehouse.");
            }
            else
            {
                product.Quantity = quantity;
                product.LastArrivalDate = DateTime.Now;
                warehouse.Products.Add(product);
                Console.WriteLine($"Added new product {product.Name} with quantity {quantity} to the warehouse.");
            }
        }
        public void RegisterOutcoming(Warehouse warehouse, Product product, int quantity)
        {
            var existingProduct = warehouse.Products.FirstOrDefault(p => p.Name == product.Name);

            if (existingProduct != null)
            {
                if (existingProduct.Quantity > quantity) {
                    existingProduct.Quantity -= quantity;
                    Console.WriteLine($"Product {product.Name} has been shipped, remaining in the warehouse - {product.Quantity}");
                }
                else
                {
                    throw new InvalidOperationException("Not enough stock to complete the request.");
                }
            }
            else
            {
                throw new ArgumentException("Product not found in the warehouse.");
            }
        }
    }
}
