using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine("Drawing a " + shape + " as lines.");
        }
    }

    public class RasterRenderer : IRenderer 
    {
        public void Render(string shape)
        {
            Console.WriteLine("Drawing a " + shape + " as pixels.");
        }
    }

}
