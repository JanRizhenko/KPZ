using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Devices
{
    public static class Brands
    {
        public static class Apple
        {
            public static class Phone
            {
                public const string iPhone14 = "iPhone 14";
                public const string iPhone14Pro = "iPhone 14 Pro";
                public const string iPhone14ProMax = "iPhone 14 Pro Max";

                public const string IPhone15 = "iPhone 15";
                public const string IPhone15Pro = "iPhone 15 Pro";
                public const string IPhone15ProMax = "iPhone 15 Pro Max";
            }
            public static class Laptop
            {
                public const string MacBookAir = "MacBook Air";
                public const string MacBookPro = "MacBook Pro";
            }
            public static class TV
            {
                public const string AppleTV4K = "Apple TV 4K";
                public const string AppleTVHD = "Apple TV HD";
            }
        }

        public static class Samsung
        {
            public static class Phone
            {
                public const string GalaxyS23 = "Galaxy S23";
                public const string GalaxyS23Plus = "Galaxy S23 Plus";
                public const string GalaxyS23Ultra = "Galaxy S23 Ultra";

                public const string GalaxyZFlip5 = "Galaxy Z Flip 5";

                public const string GalaxyS24 = "Galaxy S24";
                public const string GalaxyS24Plus = "Galaxy S24 Plus";
                public const string GalaxyS24Ultra = "Galaxy S24 Ultra";
            }
            public static class Laptop
            {
                public const string GalaxyBook3 = "Galaxy Book 3";
                public const string GalaxyBook3Ultra = "Galaxy Book 3 Ultra";
                public const string GalaxyBook3Pro = "Galaxy Book 3 Pro";
                public const string GalaxyLaptopGo = "Galaxy Laptop Go";
                public const string GalaxyBookGo = "Galaxy Book Go";
            }
            public static class TV
            {
                public const string NeoQLED8K = "Neo QLED 8K";
                public const string QLED8K = "QLED 8K";
                public const string QLED4K = "QLED 4K";
            }
        }
        public static class Google
        {
            public static class Phone
            {
                public const string Pixel7 = "Pixel 7";
                public const string Pixel7a = "Pixel 7a";
                public const string Pixel7Pro = "Pixel 7 Pro";
                public const string Pixel8 = "Pixel 8";
                public const string Pixel8Pro = "Pixel 8 Pro";
            }
            public static class Laptop
            {
                public const string PixelBook = "Pixel Book";
                public const string PixelBookGo = "Pixel Book Go";
                public const string PixelBookPro = "Pixel Book Pro";
            }
            public static class TV
            {
                public const string ChromecastWithGoogleTV = "Chromecast with Google TV";
                public const string ChromecastUltra = "Chromecast Ultra";
                public const string ChromecastHD = "Chromecast HD";
            }
        }
    }
}
