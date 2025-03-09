using System;
using ClassLibrary;

namespace WarehouseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var laptop = new Product("Laptop", new USD(1200, 0), 10);
            var coffemachine = new Product("Coffemachine", new UAH(1500, 0), 15);
            var skateboard = new Product("Skateboard", new EUR(15, 50), 20);

            var warehouse = new Warehouse("Central Warehouse");
            warehouse.AddProduct(laptop);
            warehouse.AddProduct(coffemachine);
            warehouse.AddProduct(skateboard);

            var cart = new Cart();
            var reporting = new Reporting(warehouse);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Warehouse Management System");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Register Incoming Product");
                Console.WriteLine("3. Register Outgoing Product");
                Console.WriteLine("4. Reduce Product Price");
                Console.WriteLine("5. Convert Currency");
                Console.WriteLine("6. Add Product to Cart");
                Console.WriteLine("7. Remove Product from Cart");
                Console.WriteLine("8. View Cart");
                Console.WriteLine("9. Checkout (Calculate Total)");
                Console.WriteLine("10. Exit");
                Console.Write("Please choose an option (1-10): ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewInventory(reporting, warehouse);
                        break;
                    case "2":
                        RegisterIncoming(reporting, warehouse);
                        break;
                    case "3":
                        RegisterOutcoming(reporting, warehouse);
                        break;
                    case "4":
                        ReduceProductPrice(warehouse);
                        break;
                    case "5":
                        ConvertCurrency(warehouse);
                        break;
                    case "6":
                        AddProductToCart(cart, warehouse);
                        break;
                    case "7":
                        RemoveProductFromCart(cart);
                        break;
                    case "8":
                        ViewCart(cart);
                        break;
                    case "9":
                        Checkout(cart);
                        break;
                    case "10":
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
            }
        }

        static void ViewInventory(Reporting reporting, Warehouse warehouse)
        {
            reporting.InventoryReport(warehouse.WarehouseName);
        }

        static void RegisterIncoming(Reporting reporting, Warehouse warehouse)
        {
            Console.Write("\nEnter the product name: ");
            string productName = Console.ReadLine();

            int quantity = GetIntegerInput("\nEnter the quantity: ");
            float fullprice = GetFloatInput("\nEnter the price in USD: ");

            int wholeNums = (int)Math.Floor(fullprice);
            int floatNums = (int)((fullprice - wholeNums) * 100);

            var product = new Product(productName, new USD(wholeNums, floatNums), quantity);
            reporting.RegisterIncoming(warehouse, product, quantity);
        }

        static void RegisterOutcoming(Reporting reporting, Warehouse warehouse)
        {
            Console.Write("\nEnter the product name: ");
            string productName = Console.ReadLine();

            int quantity = GetIntegerInput("\nEnter the quantity: ");
            float fullprice = GetFloatInput("\nEnter the price in USD: ");

            int wholeNums = (int)Math.Floor(fullprice);
            int floatNums = (int)((fullprice - wholeNums) * 100);

            var product = new Product(productName, new USD(wholeNums, floatNums), quantity);
            try
            {
                reporting.RegisterOutcoming(warehouse, product, quantity);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ReduceProductPrice(Warehouse warehouse)
        {
            Console.Write("\nEnter the product name: ");
            string productName = Console.ReadLine();

            var product = warehouse.Products.FirstOrDefault(p => p.Name == productName);

            if (product == null)
            {
                Console.WriteLine("Product not found in the warehouse.");
                return;
            }

            Console.WriteLine("\nBefore price reduction:");
            product.DisplayPrice();

            double amount = GetDoubleInput("\nEnter the amount to reduce the price by: ");
            product.ReducePrice(amount);

            Console.WriteLine("\nAfter price reduction:");
            product.DisplayPrice();
        }

        static void ConvertCurrency(Warehouse warehouse)
        {
            Console.Write("\nEnter the product name: ");
            string productName = Console.ReadLine();

            var product = warehouse.Products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                Console.WriteLine("Product not found in the warehouse.");
                return;
            }

            Console.Write("\nEnter the currency to convert to (EUR, UAH, USD): ");
            string currency = Console.ReadLine().ToUpper();

            if (!Money.ExchangeRates.ContainsKey(currency))
            {
                Console.WriteLine("Invalid currency. Supported currencies are: EUR, UAH, USD.");
                return;
            }
            Console.Write("\n");
            product.DisplayPrice();
            Console.WriteLine($"\nProduct price in {currency}: {product.Price.ConvertToCurrency(currency):F2}");
        }


        static int GetIntegerInput(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        static float GetFloatInput(string prompt)
        {
            float result;
            while (true)
            {
                Console.Write(prompt);
                if (float.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid price.");
                }
            }
        }
        static double GetDoubleInput(string prompt)
        {
            double result;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
        static void AddProductToCart(Cart cart, Warehouse warehouse)
        {
            Console.Write("\nEnter the product name to add to the cart: ");
            string productName = Console.ReadLine();

            var product = warehouse.Products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                Console.WriteLine("Product not found in the warehouse.");
                return;
            }

            Console.Write("Enter the quantity to add to the cart: ");
            int quantity = int.Parse(Console.ReadLine());

            cart.AddItem(product, quantity);
            Console.WriteLine($"{quantity} {productName}(s) added to the cart.");
        }

        static void RemoveProductFromCart(Cart cart)
        {
            Console.Write("\nEnter the product name to remove from the cart: ");
            string productName = Console.ReadLine();
            cart.RemoveItem(productName);
        }

        static void ViewCart(Cart cart)
        {
            cart.ViewCart();
        }

        static void Checkout(Cart cart)
        {
            double total = cart.CalculateTotal();
            Console.WriteLine($"\nTotal amount for your order: {total:F2} USD.");
        }
    }
}
