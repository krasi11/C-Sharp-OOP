using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class RogueCreator : HeroCreator
    {
        public string _name;

        public RogueCreator(string name)
        {
            _name = name;
        }
        public override BaseHero GetHero() => new Rogue(_name);
    }
}
