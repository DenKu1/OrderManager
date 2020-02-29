using OrderManager.Lib.BLL.DTO;
using System;
using System.Collections.Generic;

namespace OrderManager.Lib.BLL.Interfaces
{
    public interface IDishService : IDisposable
    {      
        IEnumerable<DishDTO> GetDishes();

        TimeSpan OrderDish(DishDTO dishDTO, ICookerService cookerSv, ICookService cookSv);
    }
}
