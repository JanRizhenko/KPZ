using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LightImageNode : LightNode
    {
        public string _src;
        private IImageLoadingStrategy _strategy;

        public LightImageNode(string src)
        {
            _src = src;
            _strategy = ChooseStrategy(src);
        }

        private IImageLoadingStrategy ChooseStrategy(string src)
        {
            return (src.StartsWith("http://") || src.StartsWith("https://"))
                ? (IImageLoadingStrategy)new NetworkLoadingStrategy()
                : new LocalFileLoadingStrategy();
        }

        public void LoadImage()
        {
            _strategy.Load(_src);
        }

        public override string InnerHTML => "";
        public override string OuterHTML => $"<img src=\"{_src}\" />";
    }
}
