using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            IRenderer vector = new VectorRenderer();
            IRenderer raster = new RasterRenderer();

            Shape square = new Square(raster);
            square.Draw();

            Shape circle = new Circle(vector);
            circle.Draw();

            Shape triangle1 = new Triangle(vector);
            triangle1.Draw();

            Shape triangle2 = new Triangle(raster);
            triangle2.Draw();
        }
    }
}
