﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Lib.Model
{
    public class MainModel 
    {
        private Kitchen kitchen;

        public MainModel(Cook[] cooks, Dish[] dishes, Cooker[] heatingApps)
        {
            kitchen = new Kitchen(cooks, dishes, heatingApps);
        }

        public IEnumerable<Dish> GetDishes()
        {
            return kitchen.Dishes;
        }

        public string OrderDish(Dish dish)
        {
            return kitchen.MakeOrder(dish);
        }
    }
}