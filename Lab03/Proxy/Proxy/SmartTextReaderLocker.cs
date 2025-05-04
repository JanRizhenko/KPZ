using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private ISmartTextReader _reader;
        private Regex _denyPattern;

        public SmartTextReaderLocker(ISmartTextReader reader, string denyPattern)
        {
            _reader = reader;
            _denyPattern = new Regex(denyPattern, RegexOptions.IgnoreCase);
        }

        public char[][] ReadFile(string filePath)
        {
            Console.WriteLine($"[INFO] Opening file: {filePath}");
            if (_denyPattern.IsMatch(filePath))
            {
                Console.WriteLine("[ERROR] Access denied!");
                return Array.Empty<char[]>();
            }

            return _reader.ReadFile(filePath);
        }
    }

}
