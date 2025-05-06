using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    public class Program
    {
        static void Main(string[] args)
        {
            var doc = new TextDocument();
            var editor = new TextEditor(doc);

            editor.Type("Hello, ");
            editor.Save();

            editor.Type("world!");
            editor.Save();

            Console.WriteLine("Current content: " + editor.GetContent());

            editor.Undo();
            Console.WriteLine("After undo: " + editor.GetContent());

            editor.Undo();
            Console.WriteLine("After second undo: " + editor.GetContent());

            editor.Type("Hello ");
            editor.Save();

            editor.Type("World");
            editor.Save();

            editor.Type("!!!");
            editor.Save();

            Console.WriteLine("\nCurrent content 2: " + editor.GetContent());

            editor.Undo(2);

            Console.WriteLine("After undo(2): " + editor.GetContent());
        }
    }
}
