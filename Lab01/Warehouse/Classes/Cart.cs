using ClassLibrary;
using System;
using System.Collections.Generic;

namespace WarehouseApp
{
    public class Cart
    {
        private List<CartItem> items;

        public Cart()
        {
            items = new List<CartItem>();
        }

        public void AddItem(Product product, int quantity)
        {
            var existingItem = items.Find(item => item.Product.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase));

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                items.Add(new CartItem(product, quantity));
            }
        }
        public void RemoveItem(string productName)
        {
            var item = items.Find(i => i.Product.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                items.Remove(item);
                Console.WriteLine($"{productName} has been removed from the cart.");
            }
            else
            {
                Console.WriteLine("Product not found in the cart.");
            }
        }

        public void ViewCart()
        {
            Console.WriteLine("\nCart Contents:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Product.Name} - Quantity: {item.Quantity}, Price per unit: {item.Product.Price.ConvertToCurrency("USD"):F2}, Total: {item.TotalPrice():F2}");
            }
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.TotalPrice();
            }
            return total;
        }
    }
    public class CartItem
    {
        public Product Product { get; }
        public int Quantity { get; set; }

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public double TotalPrice()
        {
            return Product.Price.ConvertToCurrency("USD") * Quantity;
        }
    }
}
