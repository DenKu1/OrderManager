using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace OrderManager.Model
{
    class Kitchen
    {
        private readonly Cook[] cooks;
        private readonly Dish[] dishes;

        public Dish[] Dishes
        {                
            get
            {
                return dishes;
            }
        }

        public Kitchen(Cook[] cooks, Dish[] dishes) 
        {
            this.cooks = cooks;
            this.dishes = dishes;
        }

        public string MakeOrder(Order order)
        {                       
            if (order.orderedDishes.Count == 0)
                return "Order can`t contain no dishes!";

            DateTime orderFinishTime = DateTime.Now;

            foreach (var dish in order.orderedDishes)
            {
                DateTime dishFinishTime;

                bool freeCookFound = FindFreeCook(dish, out dishFinishTime);

                if (!freeCookFound)
                {
                    FindLeastBusyCook(dish, out dishFinishTime);
                }

                if (orderFinishTime < dishFinishTime)
                    orderFinishTime = dishFinishTime;
            }
           
            order.SetFinishTime(orderFinishTime);

            return order.ToString();
        }
      
        private bool FindFreeCook(Dish dish, out DateTime finishTime)
        {
            var choosedCooks = CooksCanCookDish(dish);

            foreach (var cook in choosedCooks)
            {
                if (cook.IsFree)
                {
                    cook.AddDishToCook(dish);

                    finishTime = cook.FinishTime;

                    return true;
                }
            }

            finishTime = DateTime.Now;
            return false;
        }

        private void FindLeastBusyCook(Dish dish, out DateTime finishTime)
        {
            var choosedCooks = CooksCanCookDish(dish);

            choosedCooks.Sort();   

            cooks[0].AddDishToCook(dish);

            finishTime = cooks[0].FinishTime;
        }

        private List<Cook> CooksCanCookDish(Dish dish)
        {
            var CooksCanCookDish = cooks.Select(x => x).Where(x => x.CanCookThisCuisine(dish.Cuisine) == true).ToList();

            if (CooksCanCookDish.Count == 0)
            {
                throw new Exception("There is no cook than can cook this dish!");
            }

            return CooksCanCookDish;
        }

    }
}
