using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Warrior : IHero
    {
        public string GetDescription() => "Warrior";
        public int GetPower() => 10;
    }

    public class Mage : IHero
    {
        public string GetDescription() => "Mage";
        public int GetPower() => 8;
    }

    public class Paladin : IHero
    {
        public string GetDescription() => "Paladin";
        public int GetPower() => 9;
    }
}
