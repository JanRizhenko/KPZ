using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DemonstrateSubscriptionCreation(new WebSite(), "domestic");
            Console.WriteLine();

            DemonstrateSubscriptionCreation(new MobileApp(), "educational");
            Console.WriteLine();

            DemonstrateSubscriptionCreation(new ManagerCall(), "premium");
            Console.WriteLine();
        }
    

        static void DemonstrateSubscriptionCreation(ISubscriptionCreator creator, string subscriptionType)
        {
            try
            {
                ISubscription subscription = creator.CreateSubscription(subscriptionType);

                Console.WriteLine($"Тип підписки: {subscription.GetSubscriptionType()}");
                Console.WriteLine($"Щомісячна плата: {subscription.MonthlyFee} грн");
                Console.WriteLine($"Мінімальний період підписки: {subscription.MinPeriod} місяців");
                Console.WriteLine($"Канали: {string.Join(", ", subscription.Channels)}");
                Console.WriteLine($"Особливості підписки: {string.Join(", ", subscription.Features)}");

                bool paymentSuccess = creator.ProcessPayment(subscription.MonthlyFee);

                if (paymentSuccess)
                {
                    Console.WriteLine("Платіж успішно оброблено.");
                }
                else
                {
                    Console.WriteLine("Помилка при обробці платежу.");
                }
            }
            catch(Exception error)
            {
                Console.WriteLine($"Помилка: {error.Message}");
            }
        }
    }
}
