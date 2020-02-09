using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Model
{
    class Restaurant
    {
        public Kitchen Kitchen { get; }

        public Restaurant()
        {
            Dish[] dishes =
            {
                new Dish("Plov", 100, DishType.Cold, HeatingApplianceType.BackeryOven, TimeSpan.FromMinutes(10)),
                new Dish("Borch", 200, DishType.First, HeatingApplianceType.None, TimeSpan.FromMinutes(20)),
                new Dish("Soup", 300, DishType.First, HeatingApplianceType.None, TimeSpan.FromMinutes(30)),
                new Dish("Omelet", 400, DishType.Snack, HeatingApplianceType.Brazier, TimeSpan.FromMinutes(40)),
                new Dish("Burger", 500, DishType.Snack, HeatingApplianceType.Campfire, TimeSpan.FromMinutes(50))
            };

            Cook[] cooks =
            {
                new Cook(1.1f),
                new Cook(1.5f)
            };

            HeatingAppliance[] heatingAppliances =
            {
                new HeatingAppliance(TimeSpan.FromMinutes(11), TimeSpan.FromMinutes(21), HeatingApplianceType.BackeryOven),
                new HeatingAppliance(TimeSpan.FromMinutes(12), TimeSpan.FromMinutes(22), HeatingApplianceType.Brazier)
            };

            Kitchen = new Kitchen(cooks, dishes, heatingAppliances);
        }
    }
}
