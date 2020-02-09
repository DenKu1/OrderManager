using System;
using System.Collections.Generic;

namespace OrderManager.Model
{
    class Order
    {
        public List<Dish> orderedDishes { get; }

        private DateTime orderTime;

        private DateTime finishTime;

        public Order()
        {
            orderedDishes = new List<Dish>();
            orderTime = DateTime.Now;
            finishTime = DateTime.Now;
        }

        public void AddDish(Dish dish)
        {
            orderedDishes.Add(dish);
        }

        public void RemoveDish(Dish dish)
        {
            orderedDishes.Remove(dish);
        }

        public void SetFinishTime(DateTime finishTime)
        {
            this.finishTime = finishTime;
        }

        public override string ToString()
        {
            return $"Your order was accepted!\nOrder time: {orderTime.ToString()}\nFinish time: {finishTime.ToString()}";
        }

    }
}
