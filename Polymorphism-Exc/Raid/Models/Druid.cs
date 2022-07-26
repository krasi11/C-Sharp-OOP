using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
   public class Druid:BaseHero
    {
        private const int DefaultPower = 80;

        public Druid(string name) : base(name, DefaultPower)
        {

        }
        public override string CastAbility() => base.CastAbility() + $" healed for {Power}";
    }
}
