using System;
using System.Collections.Generic;
using OrderManager.Model;

namespace OrderManager.Interfaces
{
    public interface IMainModel
    {
        IEnumerable<Dish> GetDishes();

        string OrderDish(Dish dish);
    }
}
