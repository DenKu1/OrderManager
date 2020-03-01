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
    public class CookerService : ICookerService
    {
        private OrderContext _db;

        public CookerService(OrderContext database)
        {
            _db = database;
        }
       
        public Cooker FindCooker(Dish dish)
        {
            if (dish == null)
            {
                throw new NullReferenceException();
            }

            if (dish.CookerType == null)
            {
                return null;
            }

            Cooker cooker =
                _db.Cookers
                .Where(x => (x.CookerType == dish.CookerType))
                .OrderBy(x => x.FinishTime)
                .FirstOrDefault()
                ?? throw new Exception("There is no appliance to prepare this");

            return cooker;
        }

        public TimeSpan TimeToCook(Dish dish, Cooker cooker, DateTime orderTime)
        {
            if (dish == null)
            {
                throw new NullReferenceException();
            }

            if (dish.CookerType == null)
            {
                return TimeSpan.Zero;
            }

            if (cooker == null)
            {
                throw new NullReferenceException();
            }

            if (cooker.CookerType != dish.CookerType)
            {
                throw new Exception("This applianceType can`t cook this dish!");
            }

            TimeSpan cookingTime =
                orderTime < cooker.FinishTime
                ? (cooker.FinishTime - orderTime) + dish.CookingTime
                : orderTime < (cooker.FinishTime + cooker.CoolingTime)
                ? dish.CookingTime
                : cooker.WarmUpTime + dish.CookingTime;

            return cookingTime;

        }

        public void Update(Cooker cooker, DateTime finishTime)
        {
            if (cooker == null)
            {
                return;
            }

            cooker.FinishTime = finishTime;           
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
