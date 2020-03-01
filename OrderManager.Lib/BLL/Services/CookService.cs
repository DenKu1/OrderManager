using OrderManager.Lib.BLL.Infrastructure;
using OrderManager.Lib.BLL.Interfaces;
using OrderManager.Lib.DAL.Entities;
using OrderManager.Lib.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Lib.BLL.Services
{
    public class CookService : ICookService
    {
        private IUnitOfWork _db;

        public CookService(IUnitOfWork uof)
        {
            _db = uof;
        }

        public Cook FindCook()
        {          
           Cook cook = 
                _db.CookRepository
                .GetAll()
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

            TimeSpan defaultCookingTime = dish.CookingTime.Divide(cook.SkillCoefficient);

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

            _db.CookRepository.Update(cook);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
