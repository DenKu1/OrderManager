using System;

namespace OrderManager.Model
{
    public enum DishType
    {
        Snack,
        Dessert,
        First,
        Cold,
        Salad
    }

    public class Dish 
    {
        private readonly string name;

        private readonly int weight;

        private readonly DishType dishType;

        public HeatingApplianceType HeatingApplianceType { get; }

        public TimeSpan CookingTime { get; }

        public Dish(string name, int weight, DishType dishType, HeatingApplianceType heatingApplianceType, TimeSpan cookingTime)
        {
            if (name is null)
                throw new NullReferenceException();

            if (weight <= 0)
                throw new Exception("Dish weight should be above zero!");

            if (cookingTime <= TimeSpan.Zero)
                throw new Exception("Time span must be above zero!");

            this.name = name;
            this.weight = weight;
            this.dishType = dishType;

            HeatingApplianceType = heatingApplianceType;
            CookingTime = cookingTime;
        }

        public override string ToString()
        {
            return $"Dish: {name}\nWeight: {weight.ToString()}\nDish type: {dishType.ToString()}\nHeating appliance type: {HeatingApplianceType.ToString()}\nCooking time: {CookingTime.ToString()}";
        }

    }
}
