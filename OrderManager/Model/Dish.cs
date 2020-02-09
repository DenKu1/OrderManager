using System;

namespace OrderManager.Model
{
    public enum Cuisine
    {
        Asian,
        Geaorgian,
        Russian,
        Ukrainian,
        American
    }

    class Dish
    {
        private readonly string name;

        public Cuisine Cuisine { get; }

        public TimeSpan CookingTime { get; }

        public Dish(string name, Cuisine cuisine, TimeSpan cookingTime)
        {
            this.name = name;
            Cuisine = cuisine;
            CookingTime = cookingTime;
        }

        public override string ToString()
        {
            return $"Dish: {name}\nCuisine: {Cuisine.ToString()}\nCookingTime: {CookingTime.ToString()}";
        }

    }
}
