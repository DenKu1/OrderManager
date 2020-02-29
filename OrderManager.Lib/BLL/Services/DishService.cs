using AutoMapper;
using OrderManager.Lib.BLL.DTO;
using OrderManager.Lib.BLL.Interfaces;
using OrderManager.Lib.DAL.EF;
using OrderManager.Lib.DAL.Entities;
using System;
using System.Collections.Generic;

namespace OrderManager.Lib.BLL.Services
{
    public class DishService : IDishService
    {
        private OrderContext _db;

        public DishService(OrderContext database)
        {
            _db = database;
        }

        public IEnumerable<DishDTO> GetDishes()
        {
            var dishes = _db.Dishes;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Dish, DishDTO>()); 

            IEnumerable<DishDTO> dishesDTO = config.CreateMapper().Map<IEnumerable<DishDTO>>(dishes);

            return dishesDTO;
        }

        public TimeSpan OrderDish(DishDTO dishDTO, ICookerService cookerSv, ICookService cookSv)
        {
            if (dishDTO == null)
                throw new NullReferenceException(); ;

            Dish dish = _db.Dishes.Find(dishDTO.Id) ?? throw new Exception();

            Cooker cooker = dish.CookerType == null 
                ? null
                : (cookerSv.FindCooker(dish)
                ?? throw new Exception("There is no appliance to cook this!"));

            Cook cook = cookSv.FindCook();

            TimeSpan cookerDelay = cookerSv.CookDish(dish, cooker);

            TimeSpan cookDelay = cookSv.CookDish(dish);

            return cookDelay + cookerDelay;


        }

        public void Dispose()
        {
            _db.Dispose();
        }
        /*
        private Cook FindFreeCook()
        {
            return cooks.Where(x => x.IsFree).OrderByDescending(x => x.SkillCoefficient).FirstOrDefault();
        }

        private Cook FindLeastBusyCook()
        {
            return cooks.OrderBy(x => x.FinishTime).ThenByDescending(x => x.SkillCoefficient).First();
        }

        private Cooker FindHeatingAppliance(HeatingApplianceType heatingApplianceType)
        {
            return heatingAppliances.Where(x => x.HeatingApplianceType == heatingApplianceType).FirstOrDefault();
        }*/
    }
}
