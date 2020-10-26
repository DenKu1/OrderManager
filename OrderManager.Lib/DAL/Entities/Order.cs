    using System;

namespace OrderManager.Lib.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderTime { get; set; }
        public DateTime FinishTime { get; set; }

        public int DishId { get; set; }        
        public virtual Dish Dish { get; set; }

        public int CookId { get; set; }
        public virtual Cook Cook { get; set; }

        public int? CookerId { get; set; }
        public virtual Cooker Cooker { get; set; }

    }
}
