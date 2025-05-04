using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class ElementFlyweightFactory
    {
        private Dictionary<string, ElementFlyweight> _flyweights = new Dictionary<string, ElementFlyweight>();

        public ElementFlyweight GetFlyweight(string tagName, DisplayType display, TagType tagKind) 
        {
            string key = ($"{tagName}:{display}:{tagKind}");

            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new ElementFlyweight(tagName, display, tagKind);
            }

            return _flyweights[key];
        }

        public int Count => _flyweights.Count;
    }
}
