using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriptions
{
    public abstract class AbstractSubscription : ISubscription
    {
        protected double monthlyFee;
        protected int minPeriod;
        protected List<string> channels;
        protected List<string> features;

        public double MonthlyFee => monthlyFee;
        public int MinPeriod => minPeriod;
        public List<string> Channels => channels;

        public List<string> Features => features;
        public abstract string GetSubscriptionType();
    }

    public class DomesticSubscription : AbstractSubscription
    {
        public DomesticSubscription() 
        {
            monthlyFee = 99.99;
            minPeriod = 1;
            channels = new List<string> { "Новини", "Фільми", "Серіали", "Розважальні" };
            features = new List<string> { "HD телебачення", "2 користувач" };
        }
        public override string GetSubscriptionType()
        {
            return "Домашня підписка";
        }

    }
    public class EducationalSubscription : AbstractSubscription
    {
        public EducationalSubscription()
        {
            monthlyFee = 149.99;
            minPeriod = 3;
            channels = new List<string> { "Наука", "Історія", "Документалістика", "Освітні програми", "Мови" };
            features = new List<string> { "Ad free", "1 користувач" };
        }

        public override string GetSubscriptionType()
        {
            return "Освітня підписка";
        }
    }

    public class PremiumSubscription : AbstractSubscription
    {
        public PremiumSubscription()
        {
            monthlyFee = 299.99;
            minPeriod = 6;
            channels = new List<string> { "Спорт", "Преміум фільми", "Серіали", "Дитячі", "Новини",
            "Документалістика", "4K контент", "Ексклюзивний контент" };
            features = new List<string> { "Все відкрито" };
        }
        public override string GetSubscriptionType()
        {
            return "Преміум підписка";
        }
    }

}
