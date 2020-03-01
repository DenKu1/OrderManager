using OrderManager.Lib.BLL.Infrastructure;
using OrderManager.Lib.BLL.Interfaces;
using OrderManager.Lib.DAL.EF;
using OrderManager.Lib.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Lib.BLL.Services
{
    public class CookService : ICookService
    {
        private OrderContext _db;

        public CookService(OrderContext database)
        {
            _db = database;
        }

        public Cook FindCook()
        {          
           Cook cook = 
                _db.Cooks
                .OrderBy(x => x.FinishTime)
                .ThenByDescending(x => x.SkillCoefficient)
                .FirstOrDefault()
                ?? throw new Exception("There is no cooks");

            return cook;
        }

        public TimeSpan TimeToCook(Dish dish, Cook cook, DateTime orderTime)
        {
            if (dish == null || cook == null)
            { 
                throw new NullReferenceException();
            }

            TimeSpan defaultCookingTime = dish.CookingTime.Multiply(cook.SkillCoefficient);

            TimeSpan cookingTime =
            orderTime < cook.FinishTime
            ? (cook.FinishTime - orderTime) + defaultCookingTime
            : defaultCookingTime;

            return cookingTime;
        }

        public void Update(Cook cook, DateTime finishTime)
        {
            if (cook == null)
            {
                return;
            }

            cook.FinishTime = finishTime;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
