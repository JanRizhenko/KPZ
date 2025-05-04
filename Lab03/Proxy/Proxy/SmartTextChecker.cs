using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextChecker : ISmartTextReader
    {
        private ISmartTextReader _reader;

        public SmartTextChecker(ISmartTextReader reader)
        {
            _reader = reader;
        }

        public char[][] ReadFile(string path)
        {

            char[][] content = _reader.ReadFile(path);

            Console.WriteLine("[INFO] File read successfully");
            Console.WriteLine($"[INFO] Closing file: {path}");

            int totalLines = content.Length;
            int totalCharacters = 0;

            foreach (var line in content)
                totalCharacters += line.Length;

            Console.WriteLine($"[STATS] Total lines: {totalLines}");
            Console.WriteLine($"[STATS] Total characters: {totalCharacters}");

            return content;
        }

    }
}
