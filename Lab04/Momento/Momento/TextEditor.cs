using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Momento
{
    public class TextEditor
    {
        private Stack<DocumentMomento> _history = new Stack<DocumentMomento>();
        private TextDocument _document;

        public TextEditor(TextDocument document)
        {
            _document = document;
            Save();
        }

        public void Type(string text)
        {
            _document.Append(text);
        }

        public void Save()
        {
            _history.Push(new DocumentMomento(_document.Content));
        }

        public void Undo()
        {
            if (_history.Count > 1)
            {
                _history.Pop();
                var previous = _history.Peek();
                _document.Content = previous.Content;
            }
        }
        public void Undo(int count)
        {
            if(count < _history.Count)
            {
                for (int i = 0; i < count; i++)
                {
                    _history.Pop();
                }
                var previous = _history.Peek();
                _document.Content = previous.Content;
            }
            else
            {
                Console.WriteLine($"Cannot undo {count} steps. Only {_history.Count - 1} undo steps available.");
            }
        }

        public string GetContent() => _document.ToString();
    }
}
