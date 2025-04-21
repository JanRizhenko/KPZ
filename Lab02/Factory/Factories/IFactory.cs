using Factory.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public interface IFactory
    {
        IDevice CreateLaptop(string model);
        IDevice CreatePhone(string model);
        IDevice CreateTV(string model);
    }
}
