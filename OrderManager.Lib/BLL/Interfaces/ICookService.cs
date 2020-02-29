using OrderManager.Lib.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Lib.BLL.Interfaces
{
    public interface ICookService : IDisposable
    {
        Cook FindCook();

        TimeSpan CookDish(Dish dish);
    }
}
