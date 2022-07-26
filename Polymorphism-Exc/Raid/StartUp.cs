using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> RaidGroup = new List<BaseHero>();
            int CountOfHeroes = int.Parse(Console.ReadLine());
            while (RaidGroup.Count<CountOfHeroes)
            {
                HeroCreator heroCreator = null;
                string HeroName = Console.ReadLine();
                string HeroType = Console.ReadLine();
                switch (HeroType.ToLower())
                {
                    case "druid":
                        heroCreator = new DruidCreator(HeroName);break;
                    case "paladin":
                        heroCreator = new PaladinCreator(HeroName);break;
                    case "rogue":
                        heroCreator = new RogueCreator(HeroName); break;
                    case "warrior":
                        heroCreator = new WarriorCreator(HeroName); break;
                    default:
                        Console.WriteLine($"Invalid hero!");break;
                }
                if (heroCreator != null)
                {
                    BaseHero currentHero = heroCreator.GetHero();
                    RaidGroup.Add(currentHero);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            foreach (var hero in RaidGroup)
            {
                Console.WriteLine(hero.CastAbility());
            }
            Console.WriteLine(RaidGroup.Sum(h => h.Power) >= bossPower ? "Victory!" : "Defeat...");
        }
    }
}
