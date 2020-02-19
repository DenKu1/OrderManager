using System;
using System.Runtime.Serialization;

namespace OrderManager.Model
{
    [DataContract]
    public class Cook 
    {
        [IgnoreDataMember]
        public DateTime FinishTime { get; }
        [DataMember]
        public float SkillCoefficient { get; set; }
        
        public bool IsFree => FinishTime < Clock.Current;

        public Cook()
        {
        }

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
