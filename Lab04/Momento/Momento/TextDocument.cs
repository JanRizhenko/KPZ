using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content = "") 
        {
            Content = content;
        }

        public void Append(string text)
        {
            Content += text;
        }

        public void EraseLast(int count)
        {
            if (count <= Content.Length)
                Content = Content.Substring(0, Content.Length - count);
        }

        public override string ToString() => Content;
    }
}
