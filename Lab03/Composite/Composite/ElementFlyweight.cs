using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class ElementFlyweight
    {
        public string TagName { get; set; }
        public DisplayType Display { get; set; }
        public TagType TagKind { get; set; }

        public ElementFlyweight(string tagName, DisplayType display, TagType tagKind) 
        {
            TagName = tagName;
            Display = display;
            TagKind = tagKind;
        }
    }
}
