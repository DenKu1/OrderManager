using System;
using System.ComponentModel.DataAnnotations;

namespace OrderManager.Lib.DAL.Entities
{
    public class Dish
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int Weight { get; set; }
        
        public TimeSpan CookingTime { get; set; }

        public int? CookerTypeId { get; set; }
        public virtual CookerType CookerType { get; set; }
        
    }
}
