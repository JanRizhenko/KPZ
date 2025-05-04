using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adapter
{
    public class FileLoggerAdapter : ILogger
    {
        private readonly FileWriter _fileWriter;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public void Log(string message)
        {
            _fileWriter.WriteLine($"{DateTime.Now} [INFO] {message}");
        }

        public void Error(string message)
        {
            _fileWriter.WriteLine($"{DateTime.Now} [ERROR] {message}");
        }

        public void Warn(string message)
        {
            _fileWriter.WriteLine($"{DateTime.Now} [WARN] {message}");
        }
    }
}
