using OrderManager.Lib.BLL.Interfaces;
using OrderManager.Lib.DAL.Entities;
using OrderManager.Lib.DAL.Interfaces;
using System;
using System.Linq;

namespace OrderManager.Lib.BLL.Services
{
    public class CookerService : ICookerService
    {
        private IUnitOfWork _db;

        public CookerService(IUnitOfWork uof)
        {
            _db = uof;
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
                _db.CookerRepository
                .GetAll()
                .Where(x => (x.CookerType.Id == dish.CookerType.Id))
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

            _db.CookerRepository.Update(cooker); //!

        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
