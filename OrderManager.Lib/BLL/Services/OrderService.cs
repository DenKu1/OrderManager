using OrderManager.Lib.BLL.DTO;
using OrderManager.Lib.BLL.Interfaces;
using OrderManager.Lib.DAL.Entities;
using OrderManager.Lib.DAL.Interfaces;
using System;

namespace OrderManager.Lib.BLL.Services
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork _db;

        public OrderService(IUnitOfWork uof)
        {
            _db = uof;
        }

        public TimeSpan MakeOrder(DishDTO dishDTO, ICookerService cookerSv, ICookService cookSv, IDishService dishSv)
        {
            if (dishDTO == null)
            { 
                throw new NullReferenceException();
            }

            DateTime orderTime = DateTime.Now; 

            Dish dish = dishSv.Find(dishDTO.Id);               
          
            Cooker cooker = cookerSv.FindCooker(dish);
            Cook cook = cookSv.FindCook();

            TimeSpan cookerTimeToCook = cookerSv.TimeToCook(dish, cooker, orderTime);
            TimeSpan cookTimeToCook = cookSv.TimeToCook(dish, cook, orderTime);
            TimeSpan maxCookingTime = cookerTimeToCook >= cookTimeToCook ? cookerTimeToCook : cookTimeToCook;

            DateTime finishTime = orderTime.Add(maxCookingTime);

            cookerSv.Update(cooker, finishTime);
            cookSv.Update(cook, finishTime);

            AddOrder(orderTime, finishTime, dish, cook, cooker);
            _db.Save();

            return maxCookingTime;
        }

        private void AddOrder(DateTime orderTime, DateTime finishTime, Dish dish, Cook cook, Cooker cooker)
        {
            Order order = new Order()
            {
                OrderTime = orderTime,
                FinishTime = finishTime,
                DishId = dish.Id,
                CookId = cook.Id
            };

            if (cooker != null)
            {
                order.CookerId = cooker.Id;
            }

            _db.OrderRepository.Add(order);            
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}

