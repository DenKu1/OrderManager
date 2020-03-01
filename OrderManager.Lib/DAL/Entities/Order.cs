    using System;

namespace OrderManager.Lib.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderTime { get; set; }
        public DateTime FinishTime { get; set; }

        public int DishId { get; set; }        
        public Dish Dish { get; set; }

        public int CookId { get; set; }
        public Cook Cook { get; set; }

        public int? CookerId { get; set; }
        public Cooker Cooker { get; set; }

    }
}
