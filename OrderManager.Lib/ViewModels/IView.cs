using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Lib.Model;

namespace OrderManager.Lib.ViewModels
{
    public interface IView
    {
        Dish Dish { set; get; }

        event EventHandler DishOrdered;

        event EventHandler Load;

        void SetDishes(IEnumerable<Dish> dishes);
    }
}
