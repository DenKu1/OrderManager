using System;
using OrderManager.Lib.Model;

namespace OrderManager.Lib.Data.Entities
{
    public class EFDish
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Weight { get; set; }

        public DishType DishType { get; set; }

        public HeatingApplianceType HeatingApplianceType { get; set; }

        public TimeSpan CookingTime { get; set; }
    }
}
