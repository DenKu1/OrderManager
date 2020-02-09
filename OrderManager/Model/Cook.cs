using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManager.Model
{
    class Cook 
    {  
        public DateTime FinishTime { get; private set; }

        public float SkillCoefficient { get; }

        public bool IsFree => FinishTime < Clock.Current;

        public Cook(float skillCoefficient)
        {
            if (skillCoefficient < 1)            
                throw new Exception("Cook`s skill must be above or equals one!");            

            SkillCoefficient = skillCoefficient;            
        }       

        public void AddDishToCook(Dish dish, Equipment equipment)
        {
            if (dish is null)
                throw new NullReferenceException();

            if (dish.EquipmentType != equipment.EquipmentType)
                throw new Exception("This equipment can`t cook this dish!");           

            var cookingTime = dish.CookingTime;

            cookingTime = cookingTime.Divide(SkillCoefficient);            

            if (dish.EquipmentType != EquipmentType.None)
                cookingTime += equipment.CookDish(dish);

            FinishTime = 
                FinishTime < Clock.Current 
                ? Clock.Current.Add(cookingTime) 
                : FinishTime + dish.CookingTime;            
        }       
    }
}
