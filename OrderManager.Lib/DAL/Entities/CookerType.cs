using System;
using System.ComponentModel.DataAnnotations;

namespace OrderManager.Lib.DAL.Entities
{
    public class CookerType
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
