using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Interfaces;

namespace OrderManager.Model
{
    public class MainModel : IMainModel
    {
        private Restaurant restaurant;

        public MainModel()
        {
            restaurant = new Restaurant();
        }

        public IEnumerable<Dish> GetDishes()
        {
           return restaurant.Kitchen.Dishes;
        }

        public string OrderDish(Dish dish)
        {
            return restaurant.Kitchen.MakeOrder(dish);
        }
    }
}
