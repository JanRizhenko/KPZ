using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriptions
{
    public interface ISubscription
    {
        double MonthlyFee { get; }
        int MinPeriod { get; }
        List<string> Channels { get; }
        List<string> Features { get; }

        string GetSubscriptionType();
    }
}
