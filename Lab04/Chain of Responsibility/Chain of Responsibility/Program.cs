using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var level1 = new Level1Support();
            var level2 = new Level2Support();
            var level3 = new Level3Support();
            var operatorLevel = new OperatorSupport();

            level1.SetNext(level2);
            level2.SetNext(level3);
            level3.SetNext(operatorLevel);

            bool resolved = false;

            do
            {
                Console.WriteLine("\nПочинаємо нову сесію підтримки:");
                resolved = level1.Handle();

                if (!resolved)
                {
                    Console.Clear();
                    Console.WriteLine("Не вдалося знайти відповідну підтримку. Спробуйте ще раз.\n");
                }

            } while (!resolved);
        }
    }
}
