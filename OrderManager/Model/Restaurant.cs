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
                new Dish("Plov", Cuisine.American, TimeSpan.FromMinutes(20)),
                new Dish("Borch", Cuisine.American, TimeSpan.FromMinutes(30)),
                new Dish("Soup", Cuisine.Russian, TimeSpan.FromMinutes(10)),
                new Dish("Omelet", Cuisine.Russian, TimeSpan.FromMinutes(5)),
                new Dish("Burger", Cuisine.American, TimeSpan.FromMinutes(25))
            };

            Cook[] cooks =
            {
                new Cook(new Cuisine[] {Cuisine.American, Cuisine.Asian, Cuisine.Geaorgian} ),
                new Cook(new Cuisine[] {Cuisine.Russian, Cuisine.Ukrainian } ),
                new Cook(new Cuisine[] { Cuisine.American, Cuisine.Asian,
                    Cuisine.Geaorgian, Cuisine.Russian, Cuisine.Ukrainian } )
            };

            Kitchen = new Kitchen(cooks, dishes);
        }
    }
}
