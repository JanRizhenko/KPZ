using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class ClickLogger : IEventListener
    {
        public void HandleEvent(string eventType, LightElementNode sender)
        {
            Console.WriteLine($"[{eventType}] event received on <{sender.OuterHTML}>");
        }
    }
}
