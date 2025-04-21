using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriptions
{
    public interface ISubscriptionCreator
    {
        ISubscription CreateSubscription(string type);
        bool ProcessPayment(double amount);
    }
}
