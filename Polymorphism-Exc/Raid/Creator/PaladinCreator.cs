using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class PaladinCreator : HeroCreator
    {
        public string _name;

        public PaladinCreator(string name)
        {
            _name = name;
        }
        public override BaseHero GetHero() => new Paladin(_name);
    }
}
