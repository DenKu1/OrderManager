using OrderManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Interfaces
{
    public interface IMainView
    {
        Dish Dish { set; get; }

        event EventHandler DishOrdered;

        event EventHandler Load;

        void SetDishes(IEnumerable<Dish> dishes);
    }
}
