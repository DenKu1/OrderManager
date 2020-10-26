using AutoMapper;
using OrderManager.Lib.BLL.DTO;
using OrderManager.Lib.BLL.Interfaces;
using OrderManager.Lib.DAL.Entities;
using OrderManager.Lib.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace OrderManager.Lib.BLL.Services
{
    public class DishService : IDishService
    {
        private IUnitOfWork _db;

        public DishService(IUnitOfWork uof)
        {
            _db = uof;
        }

        public IEnumerable<DishDTO> GetDishes()
        {
            var dishes = _db.DishRepository.GetAll();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Dish, DishDTO>()); 

            IEnumerable<DishDTO> dishesDTO = config.CreateMapper().Map<IEnumerable<DishDTO>>(dishes);

            return dishesDTO;
        }

        public Dish Find(int id)
        {
            return _db.DishRepository.Get(id);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

    }
}
