using OrderManager.Lib.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Lib.BLL.Interfaces
{
    public interface IOrderService : IDisposable
    {
        TimeSpan MakeOrder(DishDTO dishDTO, ICookerService cookerSv, ICookService cookSv, IDishService dishSv);

    }
}
