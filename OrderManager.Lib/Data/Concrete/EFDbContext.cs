using System;
using System.Collections.Generic;
using System.Data.Entity;
using OrderManager.Lib.Data.Entities;

namespace OrderManager.Lib.Data.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet<EFDish> Dishes { get; set; }
        public DbSet<EFCook> Cooks { get; set; }
        public DbSet<EFHeatingAppliance> HeatingApps { get; set; }
    }
}
