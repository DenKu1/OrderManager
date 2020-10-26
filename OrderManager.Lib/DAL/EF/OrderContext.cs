using System;
using System.Data.Entity;
using OrderManager.Lib.DAL.Entities;

namespace OrderManager.Lib.DAL.EF
{
    public class OrderContext : DbContext
    {
        static OrderContext()
        {
            Database.SetInitializer(new OrderContextInitializer());
        }

        public OrderContext() : base("name=DbConnection")
        {
        }        

        public DbSet<Cook> Cooks { get; set; }
        public DbSet<Cooker> Cookers { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<CookerType> CookerTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
