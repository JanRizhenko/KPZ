using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new Character("Hero");
        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }
        public ICharacterBuilder SetHeight(string height)
        {
            _character.Height = height;
            return this;
        }
        public ICharacterBuilder SetBodyType(string bodyType)
        {
            _character.BodyType = bodyType;
            return this;
        }
        public ICharacterBuilder SetClothes(List<string> clothes)
        {
            _character.Clothes = clothes;
            return this;
        }
        public ICharacterBuilder SetInventory(List<string> inventory)
        {
            _character.Inventory = inventory;
            return this;
        }
        public ICharacterBuilder SetAbilities(List<string> abilities)
        {
            _character.Abilities = abilities;
            return this;
        }
        public HeroBuilder DoGoodDeed(string deed)
        {
            _character.GoodDeeds.Add(deed);
            return this;
        }
        public Character Build()
        {
            return _character;
        }
    }
}
