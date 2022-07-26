using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightGainPerUnitOfFood => 1.00;

        public override void Feed(Food food)
        {
            if (!(food is Meat))
            {
                throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }

            base.Feed(food);
        }
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
