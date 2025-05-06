using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public enum DisplayType
    {
        Block,
        Inline
    }

    public enum TagType
    {
        Single,
        Paired
    }

    public class LightElementNode : LightNode
    {

        private ElementFlyweight _flyweight;
        private List<LightNode> _childrens = new List<LightNode>();
        private List<string> _cssClasses = new List<string>();
        private Dictionary<string, List<IEventListener>> _eventListeners = new Dictionary<string, List<IEventListener>>();

        public LightElementNode(ElementFlyweight flyweight)
        {
            _flyweight = flyweight;
        }

        public void AddClass(string css) => _cssClasses.Add(css);
        public void AddChild(LightNode node) => _childrens.Add(node);

        public override string InnerHTML => string.Join("", _childrens.Select(c => c.OuterHTML));

        public override string OuterHTML
        {
            get
            {
                string classes = _cssClasses.Count > 0 ? $" class=\"{string.Join(" ", _cssClasses)}\"" : "";
                if (_flyweight.TagKind == TagType.Single)
                {
                    return $"<{_flyweight.TagName}{classes}/>";
                }
                else
                {
                    return $"<{_flyweight.TagName}{classes}>{InnerHTML}</{_flyweight.TagName}>";
                }
            }
        }

        public void AddEventListener(string eventType, IEventListener listener)
        {
            if (!_eventListeners.ContainsKey(eventType))
                _eventListeners[eventType] = new List<IEventListener>();

            _eventListeners[eventType].Add(listener);
        }

        public void TriggerEvent(string eventType)
        {
            Console.WriteLine($"Triggering \"{eventType}\" on <{_flyweight.TagName}>");

            if (_eventListeners.TryGetValue(eventType, out var listeners))
            {
                foreach (var listener in listeners)
                    listener.HandleEvent(eventType, this);
            }
            else
            {
                Console.WriteLine("No listeners for this event.");
            }
        }


    }
}
