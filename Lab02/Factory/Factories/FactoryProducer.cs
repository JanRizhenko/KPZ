using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public static class FactoryProducer
    {
        public static IFactory GetFactory(string factoryType)
        {

            if (factoryType.Equals("Apple", StringComparison.OrdinalIgnoreCase))
            {
                return new AppleFactory();
            }
            else if (factoryType.Equals("Samsung", StringComparison.OrdinalIgnoreCase))
            {
                return new SamsungFactory();
            }
            else if (factoryType.Equals("Google", StringComparison.OrdinalIgnoreCase))
            {
                return new GoogleFactory();
            }
            else
            {
                throw new ArgumentException("Invalid factory type");
            }
        }
    }
}
