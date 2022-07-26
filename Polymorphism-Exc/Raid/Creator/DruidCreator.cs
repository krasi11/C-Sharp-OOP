using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class DruidCreator : HeroCreator
    {
        public string _name;

        public DruidCreator(string name)
        {
            _name = name;
        }
        public override BaseHero GetHero() => new Druid(_name);
    }
}
