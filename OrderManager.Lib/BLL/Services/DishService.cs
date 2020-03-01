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

        public Dish Find(int id)
        {
            return _db.Dishes.Find(id);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

    }
}
