using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Composite
{
    public class Program
    {
        public static void Main()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "book.txt");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("book.txt not found at " + filePath);
                return;
            }

            Console.WriteLine("Creating a HTML code...\n");

            string[] lines = File.ReadAllLines(filePath);


            var parser = new LightHTMLParser();

            long before = GetMemoryUsageInBytes();

            var htmlTree = parser.ConvertTextToHtml(lines);
            Console.WriteLine(htmlTree.OuterHTML);

            long after = GetMemoryUsageInBytes();

            Console.WriteLine($"\nFlyweight objects used: {parser.FlyweightCount}");
            Console.WriteLine($"Memory used by HTML tree: {(after - before) / 1024.0:F2} KB\n");


            var localImage = new LightImageNode("images/logo.png");
            var webImage = new LightImageNode("https://example.com/image.jpg");

            localImage.LoadImage();
            Console.WriteLine(localImage.OuterHTML);
            
            Console.WriteLine();

            webImage.LoadImage();
            Console.WriteLine(webImage.OuterHTML);
            
        }



        public static long GetMemoryUsageInBytes()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            return GC.GetTotalMemory(true);
        }
    }
}
