using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriptions
{
    public class WebSite : ISubscriptionCreator
    {
        public ISubscription CreateSubscription(string type)
        {
            Console.WriteLine("Створення підписки через веб-сайт...");

            return type.ToLower() switch
            {
                "domestic" => new DomesticSubscription(),
                "educational" => new EducationalSubscription(),
                "premium" => new PremiumSubscription(),
                _ => throw new ArgumentException("Невідомий тип підписки")

            };
        }
            public bool ProcessPayment(double amount)
        {
            Console.WriteLine($"Обробка платежу на суму {amount} грн через платіжну систему веб-сайту");
            return true;
        }
    }

    public class MobileApp : ISubscriptionCreator
    {
        public ISubscription CreateSubscription(string type)
        {
            Console.WriteLine("Створення підписки через мобільний додаток...");
            return type.ToLower() switch
            {
                "domestic" => new DomesticSubscription(),
                "educational" => new EducationalSubscription(),
                "premium" => new PremiumSubscription(),
                _ => throw new ArgumentException("Невідомий тип підписки")
            };
        }
        public bool ProcessPayment(double amount)
        {
            Console.WriteLine($"Обробка платежу на суму {amount} грн через платіжну систему мобільного додатку");
            return true;
        }
    }

    public class ManagerCall : ISubscriptionCreator
    {
        public ISubscription CreateSubscription(string type)
        {
            Console.WriteLine("Створення підписки через дзвінок менеджеру...");
            return type.ToLower() switch
            {
                "domestic" => new DomesticSubscription(),
                "educational" => new EducationalSubscription(),
                "premium" => new PremiumSubscription(),
                _ => throw new ArgumentException("Невідомий тип підписки")
            };
        }
        public bool ProcessPayment(double amount)
        {
            Console.WriteLine($"Обробка платежу на суму {amount} грн через платіжну систему дзвінка менеджеру");
            return true;
        }
    }
}
