using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Sword : HeroDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override string GetDescription() => _hero.GetDescription() + " with Sword";
    }

    public class Armor : HeroDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override string GetDescription() => _hero.GetDescription() + " in Armor";
        public override int GetPower() => _hero.GetPower() + 3;
    }

    public class Artifact : HeroDecorator
    {
        public Artifact(IHero hero) : base(hero) { }

        public override string GetDescription() => _hero.GetDescription() + " using Artifact";
        public override int GetPower() => _hero.GetPower() + 7;
    }
}
