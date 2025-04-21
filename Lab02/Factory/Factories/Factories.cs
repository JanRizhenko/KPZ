using Factory.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public class AppleFactory : IFactory
    {
        private const string _brand = "Apple";

        public IDevice CreateLaptop(string model)
        {
            return new Laptop(_brand, model);
        }
        public IDevice CreatePhone(string model)
        {
            return new Phone(_brand, model);
        }
        public IDevice CreateTV(string model)
        {
            return new TV(_brand, model);
        }
    }
    public class SamsungFactory : IFactory
    {
        private const string _brand = "Samsung";
        public IDevice CreateLaptop(string model)
        {
            return new Laptop(_brand, model);
        }
        public IDevice CreatePhone(string model)
        {
            return new Phone(_brand, model);
        }
        public IDevice CreateTV(string model)
        {
            return new TV(_brand, model);
        }
    }
    public class GoogleFactory : IFactory
    {
        private const string _brand = "Google";
        public IDevice CreateLaptop(string model)
        {
            return new Laptop(_brand, model);
        }
        public IDevice CreatePhone(string model)
        {
            return new Phone(_brand, model);
        }
        public IDevice CreateTV(string model)
        {
            return new TV(_brand, model);
        }
    }
}

