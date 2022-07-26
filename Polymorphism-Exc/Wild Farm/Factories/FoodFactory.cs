using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{

    static class FoodFactory
    {
        public static Food CreateFood(string type, int quantity)
        {
            switch (type)
            {
                case "Meat":
                    return new Meat(quantity);
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Fruit":
                    return new Fruit(quantity);
                case "Seeds":
                    return new Seeds(quantity);
                default: return null;
            }
        }
    }
}
