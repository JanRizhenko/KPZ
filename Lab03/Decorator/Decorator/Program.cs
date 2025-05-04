using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            IHero warrior = new Warrior();
            warrior = new Sword(warrior);
            warrior = new Artifact(warrior);
            warrior = new Armor(warrior);

            Console.WriteLine(warrior.GetDescription());
            Console.WriteLine("Power: " + warrior.GetPower());

            Console.WriteLine();

            IHero mage = new Mage();
            mage = new Artifact(mage);
            mage = new Artifact(mage);

            Console.WriteLine(mage.GetDescription());
            Console.WriteLine("Power: " + mage.GetPower());

            Console.WriteLine();

            IHero paladin = new Paladin();
            paladin = new Armor(paladin);
            paladin = new Sword(paladin);

            Console.WriteLine(paladin.GetDescription());
            Console.WriteLine("Power: " + paladin.GetPower());
        }
    }
}
