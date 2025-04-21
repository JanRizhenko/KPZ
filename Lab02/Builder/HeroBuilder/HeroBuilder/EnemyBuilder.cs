using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character("Enemy");

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
        public ICharacterBuilder SetInventory(List<string> items)
        {
            _character.Inventory = items;
            return this;
        }
        public ICharacterBuilder SetAbilities(List<string> abilities)
        {
            _character.Abilities = abilities;
            return this;
        }
        
        public EnemyBuilder DoEvilDeed(string deed)
        {
            _character.EvilDeeds.Add(deed);
            return this;
        }
        public Character Build()
        {
            return _character;
        }
    }
}
