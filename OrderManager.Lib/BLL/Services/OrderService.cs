using OrderManager.Lib.BLL.DTO;
using OrderManager.Lib.BLL.Interfaces;
using OrderManager.Lib.DAL.EF;
using OrderManager.Lib.DAL.Entities;
using System;

namespace OrderManager.Lib.BLL.Services
{
    public class OrderService : IOrderService
    {
        private OrderContext _db;

        public OrderService(OrderContext database)
        {
            _db = database;
        }

        public TimeSpan MakeOrder(DishDTO dishDTO, ICookerService cookerSv, ICookService cookSv, IDishService dishSv)
        {
            if (dishDTO == null)
            { 
                throw new NullReferenceException(); ;
            }

            DateTime orderTime = DateTime.Now; //!

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

            return maxCookingTime;
        }

        private void AddOrder(DateTime orderTime, DateTime finishTime, Dish Dish, Cook cook, Cooker cooker)
        {
            Order order = new Order()
            {
                OrderTime = orderTime,
                FinishTime = finishTime,
                Dish = Dish,
                Cook = cook,
                Cooker = cooker                
            };

            _db.Orders.Add(order);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}

