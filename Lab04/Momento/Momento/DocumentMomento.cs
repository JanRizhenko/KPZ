using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    public class DocumentMomento
    {
        public string Content { get; }

        public DocumentMomento(string content)
        {
            Content = content;
        }
    }
}
