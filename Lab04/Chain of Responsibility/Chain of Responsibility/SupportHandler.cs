using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public abstract class SupportHandler
    {
        protected SupportHandler next;

        public void SetNext(SupportHandler nextHandlder)
        {
            this.next = nextHandlder;
        }
        public abstract bool Handle();
    }
}
