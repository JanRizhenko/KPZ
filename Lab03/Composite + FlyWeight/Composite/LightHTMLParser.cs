using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LightHTMLParser
    {
        private ElementFlyweightFactory _factory = new ElementFlyweightFactory();

        public LightElementNode ConvertTextToHtml(string[] lines)
        {
            var root = new LightElementNode(_factory.GetFlyweight("div", DisplayType.Block, TagType.Paired));

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                ElementFlyweight flyweight;

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                if (i == 0)
                    flyweight = _factory.GetFlyweight("h1", DisplayType.Block, TagType.Paired);
                else if (char.IsWhiteSpace(line[0]))
                    flyweight = _factory.GetFlyweight("blockquote", DisplayType.Block, TagType.Paired);
                else if (line.Length < 20)
                    flyweight = _factory.GetFlyweight("h2", DisplayType.Block, TagType.Paired);
                else
                    flyweight = _factory.GetFlyweight("p", DisplayType.Block, TagType.Paired);


                var node = new LightElementNode(flyweight);
                node.AddChild(new LightTextNode(line.Trim()));
                root.AddChild(node);
            }

            return root;
        }

        public int FlyweightCount => _factory.Count;
    }
}
