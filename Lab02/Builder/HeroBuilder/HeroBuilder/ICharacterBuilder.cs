using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHeight(string height);
        ICharacterBuilder SetBodyType(string bodyType);
        ICharacterBuilder SetClothes(List<string> clothes);
        ICharacterBuilder SetInventory(List<string> items);
        ICharacterBuilder SetAbilities(List<string> abilities);
        Character Build();


    }
}
