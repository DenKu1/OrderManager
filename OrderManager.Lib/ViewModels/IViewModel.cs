using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Lib.Model;

namespace OrderManager.Lib.ViewModels
{
    interface IModel
    {
        IEnumerable<Dish> GetDishes();

        string OrderDish(Dish dish);
    }
}

