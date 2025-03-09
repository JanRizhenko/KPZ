using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }
        public int Quantity { get; set; }
        public DateTime LastArrivalDate;

        public Product(string name, Money price, int quantity, DateTime lastArrivalDate = default)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            LastArrivalDate = lastArrivalDate == default ? DateTime.Now : lastArrivalDate;
        }

        public void DisplayPrice()
        {
            Console.WriteLine($"Price of {Name} -  {Price.WholePart}.{Price.FractionalPart:D2} {Price.Currency}");
        }

        public void ReducePrice(double amount)
        {
            double availableAmount = Price.WholePart + Price.FractionalPart / 100.0;

            if (amount > availableAmount)
            {
                throw new InvalidOperationException("Error: Cannot reduce price below zero.");
            }

            int reduceWhole = (int)amount;
            int reduceFractional = (int)Math.Round((amount - reduceWhole) * 100);

            int newWhole = Price.WholePart - reduceWhole;
            int newFractional = Price.FractionalPart - reduceFractional;

            if (newFractional < 0)
            {
                newWhole--;
                newFractional += 100;
            }

            Price.SetMoney(newWhole, newFractional);
        }
    }
}
