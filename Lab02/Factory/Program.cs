using Factory.Factories;
using Factory.Devices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = false;
            while (!exit)
            {
                var validBrands = new[] { "Apple", "Samsung", "Google" };
                IFactory factory = null;
                string brand;

                while (true)
                {
                    Console.WriteLine("Choose a brand:");
                    foreach (var b in validBrands)
                        Console.WriteLine($"- {b}");

                    brand = Console.ReadLine();

                    if (!validBrands.Contains(brand, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Invalid brand. Try again.\n");
                        continue;
                    }

                    try
                    {
                        factory = FactoryProducer.GetFactory(brand);
                        break;
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                var validTypes = new[] { "Laptop", "Phone", "TV" };
                string type;
                while (true)
                {
                    Console.WriteLine("\nChoose device type:");
                    foreach (var t in validTypes)
                        Console.WriteLine($"- {t}");

                    type = Console.ReadLine();

                    if (validTypes.Contains(type, StringComparer.OrdinalIgnoreCase))
                        break;

                    Console.WriteLine("Invalid device type. Try again.\n");
                }

                List<string> models = GetModels(brand, type);

                if (models.Count == 0)
                {
                    Console.WriteLine("No models available for this combination.");
                    return;
                }

                Console.WriteLine($"\nAvailable {type}s from {brand}:");
                foreach (var m in models)
                    Console.WriteLine($"- {m}");

                string model;
                while (true)
                {
                    Console.WriteLine("\nEnter model name exactly as shown:");
                    model = Console.ReadLine();

                    if (models.Any(m => string.Equals(m, model, StringComparison.OrdinalIgnoreCase)))
                    {
                        model = models.First(m => string.Equals(m, model, StringComparison.OrdinalIgnoreCase));
                        break;
                    }

                    Console.WriteLine("Invalid model name. Try again.\n");
                }

                var device = type.ToLower() switch
                {
                    "laptop" => factory.CreateLaptop(model),
                    "phone" => factory.CreatePhone(model),
                    "tv" => factory.CreateTV(model),
                    _ => null
                };

                Console.WriteLine($"\nCreated device:");
                Console.WriteLine($"- Brand: {device.GetBrand()}");
                Console.WriteLine($"- Model: {device.GetModel()}");
                Console.WriteLine($"- Description: {device.GetDescription()}");

                Console.WriteLine("\nWould you like to create another device? (Y/N)");
                var response = Console.ReadLine();
                if (response.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    exit = true;
                    Console.WriteLine();
                }

                else if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
                    Console.Clear();
            }

            Console.WriteLine("Goodbye!");

        }

        static List<string> GetModels(string brand, string type)
        {
            return (brand.ToLower(), type.ToLower()) switch
            {
                ("apple", "phone") => new List<string> {
                    Brands.Apple.Phone.iPhone14,
                    Brands.Apple.Phone.iPhone14Pro,
                    Brands.Apple.Phone.iPhone14ProMax,
                    Brands.Apple.Phone.IPhone15,
                    Brands.Apple.Phone.IPhone15Pro,
                    Brands.Apple.Phone.IPhone15ProMax
                },
                ("apple", "laptop") => new List<string> {
                    Brands.Apple.Laptop.MacBookAir,
                    Brands.Apple.Laptop.MacBookPro
                },
                ("apple", "tv") => new List<string> {
                    Brands.Apple.TV.AppleTV4K,
                    Brands.Apple.TV.AppleTVHD
                },

                ("samsung", "phone") => new List<string> {
                    Brands.Samsung.Phone.GalaxyS23,
                    Brands.Samsung.Phone.GalaxyS23Plus,
                    Brands.Samsung.Phone.GalaxyS23Ultra,
                    Brands.Samsung.Phone.GalaxyZFlip5,
                    Brands.Samsung.Phone.GalaxyS24,
                    Brands.Samsung.Phone.GalaxyS24Plus,
                    Brands.Samsung.Phone.GalaxyS24Ultra
                },
                ("samsung", "laptop") => new List<string> {
                    Brands.Samsung.Laptop.GalaxyBook3,
                    Brands.Samsung.Laptop.GalaxyBook3Ultra,
                    Brands.Samsung.Laptop.GalaxyBook3Pro,
                    Brands.Samsung.Laptop.GalaxyLaptopGo,
                    Brands.Samsung.Laptop.GalaxyBookGo
                },
                ("samsung", "tv") => new List<string> {
                    Brands.Samsung.TV.NeoQLED8K,
                    Brands.Samsung.TV.QLED8K,
                    Brands.Samsung.TV.QLED4K
                },

                ("google", "phone") => new List<string> {
                    Brands.Google.Phone.Pixel7,
                    Brands.Google.Phone.Pixel7a,
                    Brands.Google.Phone.Pixel7Pro,
                    Brands.Google.Phone.Pixel8,
                    Brands.Google.Phone.Pixel8Pro
                },
                ("google", "laptop") => new List<string> {
                    Brands.Google.Laptop.PixelBook,
                    Brands.Google.Laptop.PixelBookGo,
                    Brands.Google.Laptop.PixelBookPro
                },
                ("google", "tv") => new List<string> {
                    Brands.Google.TV.ChromecastWithGoogleTV,
                    Brands.Google.TV.ChromecastUltra,
                    Brands.Google.TV.ChromecastHD
                },

                _ => new List<string>()
            };
        }
    }
}
