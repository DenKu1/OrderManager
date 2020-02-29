using OrderManager.Lib.BLL.DTO;
using OrderManager.Lib.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Lib.BLL.Interfaces
{
    public interface ICookerService : IDisposable
    {
        TimeSpan CookDish(Dish dish, Cooker cooker);

        Cooker FindCooker(Dish dish);
    }
}
