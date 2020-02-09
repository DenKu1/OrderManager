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
                new Dish("Plov", 100, DishType.Cold, EquipmentType.BackeryOven, TimeSpan.FromMinutes(10)),
                new Dish("Borch", 200, DishType.First, EquipmentType.None, TimeSpan.FromMinutes(20)),
                new Dish("Soup", 300, DishType.First, EquipmentType.None, TimeSpan.FromMinutes(30)),
                new Dish("Omelet", 400, DishType.Snack, EquipmentType.Brazier, TimeSpan.FromMinutes(40)),
                new Dish("Burger", 500, DishType.Snack, EquipmentType.Campfire, TimeSpan.FromMinutes(50))
            };

            Cook[] cooks =
            {
                new Cook(1f),
                new Cook(1.1f),
                new Cook(1.5f)
            };

            Equipment[] equipment =
            {
                new Equipment(TimeSpan.FromMinutes(11), TimeSpan.FromMinutes(21), EquipmentType.BackeryOven),
                new Equipment(TimeSpan.FromMinutes(12), TimeSpan.FromMinutes(22), EquipmentType.Brazier)
            };

            Kitchen = new Kitchen(cooks, dishes, equipment);
        }
    }
}
