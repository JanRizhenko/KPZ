using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class Level1Support : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("Вітаємо у службі підтримки. Ви бажаєте дізнатись свій баланс? (так/ні)");
            string input = Console.ReadLine()?.ToLower();

            if(input == "так")
            {
                Console.WriteLine("Ваш баланс: 1000000 грн. Підтримка завершена.");
                return true;
            }
            return next?.Handle() ?? false;
        }
    }

    public class Level2Support : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("У вас технічна проблема з інтернетом? (так/ні)");
            string input = Console.ReadLine()?.ToLower();

            if (input == "так")
            {
                Console.WriteLine("Ми перезапустили ваш роутер віддалено. Підтримка завершена.");
                return true;
            }
            return next?.Handle() ?? false;
        }
    }

    public class Level3Support : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("У вас питання щодо рахунку або оплати? (так/ні)");
            string input = Console.ReadLine()?.ToLower();

            if (input == "так")
            {
                Console.WriteLine("Ми надіслали деталі платежу на вашу електронну пошту.");
                return true;
            }
            return next?.Handle() ?? false;
        }
    }

    public class OperatorSupport : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("Бажаєте поспілкуватися з оператором? (так/ні)");
            string input = Console.ReadLine()?.ToLower();

            if (input == "так")
            {
                Console.WriteLine("З'єднуємо з оператором... Будь ласка, зачекайте.");
                return true;
            }
            return next?.Handle() ?? false;
        }
    }
}
