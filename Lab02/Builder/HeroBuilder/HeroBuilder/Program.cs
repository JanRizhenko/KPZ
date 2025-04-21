using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        public Character CreateHero(HeroBuilder builder)
        {
            return ((HeroBuilder)builder
                .SetName("Vladick")
                .SetHeight("1.45")
                .SetBodyType("Slim")
                .SetClothes(new List<string> { "T-Shirt", "Jeans", "Green Hoody" })
                .SetInventory(new List<string> { "15 Billion Dollars", "Shield", "Potion" })
                .SetAbilities(new List<string> { "Forest Walk", "Card Shuffle", "Finger consumption" }))
                .DoGoodDeed("Killed Sasha")
                .DoGoodDeed("Saved the world")
                .Build();
        }

        public Character CreateNemesis(EnemyBuilder builder)
        {
            return ((EnemyBuilder)builder
                .SetName("Janchik")
                .SetHeight("3.12")
                .SetBodyType("Fat")
                .SetClothes(new List<string> { "T-Shirt", "Black Pants", "Black Hoddy" })
                .SetInventory(new List<string> { "11k hours in Dota", "Sword", "Potion" })
                .SetAbilities(new List<string> { "Prime", "Card Shuffle", "Ribs destroyer" }))
                .DoEvilDeed("Killed Vladick")
                .DoEvilDeed("Become software engineer")
                .Build();
        }

        static void Main(string[] args)
        {
            var program = new Program();

            var heroBuilder = new HeroBuilder();
            var enemyBuilder = new EnemyBuilder();

            Character hero = program.CreateHero(heroBuilder);
            Character enemy = program.CreateNemesis(enemyBuilder);

            Console.WriteLine("Hero Created:");
            Console.WriteLine(hero);
            Console.WriteLine("\nEnemy Created:");
            Console.WriteLine(enemy);
        }
    }
}
