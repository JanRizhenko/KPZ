using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            string filePath = "log.txt";
            Console.WriteLine("Writing to: " + Path.GetFullPath(filePath));

            ILogger logger = new FileLoggerAdapter(new FileWriter(filePath));

            logger.Log("Program is running.");
            logger.Warn("This is warning.");
            logger.Error("Error occures.");

            Logger consoleLogger = new Logger();
            consoleLogger.Log("Program is running.");
            consoleLogger.Warn("This is warning.");
            consoleLogger.Error("Error occures.");


            Console.WriteLine("Log written. Check the file.");
        }
    }

}
