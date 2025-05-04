using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Program
    {
        public static void Main()
        {
            string fullPath1 = @"C:\Users\Admin\Desktop\VisualStudio\KPZ\Lab03\Proxy\Proxy\example.txt";
            string fullPath2 = @"C:\Users\Admin\Desktop\VisualStudio\KPZ\Lab03\Proxy\Proxy\secret_data.txt";

            ISmartTextReader baseReader = new SmartTextReader();

            ISmartTextReader checker = new SmartTextChecker(baseReader);

            ISmartTextReader locker = new SmartTextReaderLocker(checker, ".*secret.*");

            var content1 = locker.ReadFile(fullPath1);
                foreach (var line in content1)
                Console.WriteLine(new string(line));

            var content2 = locker.ReadFile(fullPath2);
            foreach (var line in content2)
                Console.WriteLine(new string(line));
        }
    }

}
