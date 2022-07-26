using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        private const int DefaultPower = 100;

        public Warrior(string name) : base(name, DefaultPower)
        {

        }
        public override string CastAbility() => base.CastAbility() + $" hit for {Power} damage";
    }
}
