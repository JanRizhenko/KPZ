using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Devices
{
    public abstract class DeviceBase : IDevice
    {
        protected string _brand;
        protected string _model;

        public DeviceBase(string brand, string model)
        {
            _brand = brand;
            _model = model;
        }
        public abstract string GetDescription();
        public string GetBrand()
        {
            return _brand;
        }
        public string GetModel()
        {
            return _model;
        }

        public override string ToString()
        {
            return $"{GetDescription()} - Brand: {_brand}, Model: {_model}";
        }
    }

    public class Phone : DeviceBase
    {

        public Phone(string brand, string model) : base(brand, model)
        {

        }

        public override string GetDescription()
        {
            return "Phone";
        }
    }

    public class Laptop : DeviceBase
    {
        public Laptop(string brand, string model) : base(brand, model)
        {
        }
        public override string GetDescription()
        {
            return "Laptop";
        }
    }

    public class TV : DeviceBase
    {
        public TV(string brand, string model) : base(brand, model)
        {

        }

        public override string GetDescription()
        {
            return "TV";
        }
    }
}
