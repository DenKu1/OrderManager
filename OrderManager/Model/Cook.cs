using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManager.Model
{
    class Cook : IComparable
    {
        private readonly Cuisine[] cuisinesCanCook;

        private List<Dish> dishesToCook = new List<Dish>();

        public DateTime FinishTime { get; private set; }

        public bool IsFree 
        {
            get
            {
                return dishesToCook.Count > 0 ? false : true;
            }
        }        

        public Cook(Cuisine[] cuisines)
        {
            if (cuisines.Length == 0)
            {
                throw new Exception("Cook must specialize on at least one cuisine!");
            }

            cuisinesCanCook = cuisines;

            FinishTime = DateTime.Now;
        }

        public bool CanCookThisCuisine(Cuisine cuisine)
        {
            return cuisinesCanCook.Contains(cuisine);
        }

        public void AddDishToCook(Dish dish)
        {
            if (!CanCookThisCuisine(dish.Cuisine))
            {
                throw new Exception("Cook cannot cook dish of this cuisine!");
            }

            dishesToCook.Add(dish);
            
            if (FinishTime < DateTime.Now)
            {
                FinishTime = DateTime.Now.Add(dish.CookingTime);
            }
            else
            {
                FinishTime += dish.CookingTime;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is Cook cook)
                return FinishTime.CompareTo(cook.FinishTime);
            else
                throw new Exception("Unable to compare two objects");
        }
    }
}
