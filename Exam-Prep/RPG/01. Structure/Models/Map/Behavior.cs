using System;
using System.Collections.Generic;
using System.Text;
using Heroes.Models.Contracts;
using System.Linq;
using Heroes.Models.Heroes;

namespace Heroes.Models.Map
{
    class Behavior : IMap
    {
        public string Fight(ICollection<IHero> players)
        {
            var knights = new List<Knight>();
            var barbarians = new List<Barbarian>();
            foreach(var player in players)
            {
                if (player is Knight knight)
                {
                    knights.Add(knight);
                }
                else if (player is Barbarian barbarian)
                {
                    barbarians.Add(barbarian);
                }
                else
                {
                    throw new InvalidOperationException("Invalid player type.");
                }
            }
            while (knights.Any(x=>x.IsAlive)||barbarians.Any(x=>x.IsAlive))
            {
                foreach (var knight in knights)
                {
                    foreach (var barbarian in barbarians)
                    {
                        if (knight.IsAlive)
                        {
                            barbarian.TakeDamage(knight.Weapon.DoDamage());
                        }
                    }
                }
                foreach (var barbarian in barbarians)
                {
                    foreach (var knight in knights)
                    {
                        if (barbarian.IsAlive)
                        {
                            knight.TakeDamage(barbarian.Weapon.DoDamage());
                        }
                    }
                }
            }
            if (knights.Any(x=>x.IsAlive))
            {
                return $"The knights took {knights.Where(x => x.IsAlive).ToList().Count} casualties but won the battle.";
            }
            return $"The barbarians took {barbarians.Where(x => x.IsAlive).ToList().Count} casualties but won the battle.";
        }
    }
}
