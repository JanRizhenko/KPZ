using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LocalFileLoadingStrategy : IImageLoadingStrategy
    {
        public void Load(string path)
        {
            Console.WriteLine($"Loading image from local file: {path}");
        }
    }

    public class NetworkLoadingStrategy : IImageLoadingStrategy
    {
        public void Load(string path)
        {
            Console.WriteLine($"Downloading image from web: {path}");
        }
    }
}
