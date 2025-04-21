using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Devices
{
    public interface IDevice
    {
        string GetDescription();
        string GetBrand();
        string GetModel();
    }
}
