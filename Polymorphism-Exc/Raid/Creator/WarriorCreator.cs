using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class WarriorCreator : HeroCreator
    {
        public string _name;

        public WarriorCreator(string name)
        {
            _name = name;
        }
        public override BaseHero GetHero() => new Warrior(_name);
    }
}
