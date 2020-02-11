using System;

namespace OrderManager.Model
{
    public class Cook 
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

        public void AddDishToCook(Dish dish, HeatingAppliance appliance)
        {
            if (dish is null)
                throw new NullReferenceException();

            if (appliance != null && appliance.HeatingApplianceType != dish.HeatingApplianceType)
                throw new Exception("This applianceType can`t cook this dish!");           

            var cookingTime = dish.CookingTime;

            cookingTime = cookingTime.Divide(SkillCoefficient);            

            if (dish.HeatingApplianceType != HeatingApplianceType.None)
                cookingTime += appliance.CookDish(dish);

            FinishTime = 
                FinishTime < Clock.Current 
                ? Clock.Current.Add(cookingTime) 
                : FinishTime + dish.CookingTime;            
        }       
    }
}
