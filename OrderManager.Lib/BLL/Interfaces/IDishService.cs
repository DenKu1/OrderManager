using OrderManager.Lib.BLL.DTO;
using OrderManager.Lib.DAL.Entities;
using System;
using System.Collections.Generic;

namespace OrderManager.Lib.BLL.Interfaces
{
    public interface IDishService : IDisposable
    {      
        IEnumerable<DishDTO> GetDishes();        

        Dish Find(int id);
    }
}
