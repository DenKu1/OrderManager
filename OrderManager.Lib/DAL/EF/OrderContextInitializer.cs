using OrderManager.Lib.DAL.Entities;
using System;
using System.Data.Entity;


namespace OrderManager.Lib.DAL.EF
{
    class OrderContextInitializer : DropCreateDatabaseAlways<OrderContext>
    {
        protected override void Seed(OrderContext db)
        {
            CookerType dt1 = new CookerType
            {
                Name = "Oven"
            };

            Dish d1 = new Dish
            {
                Name = "Borch",
                CookingTime = TimeSpan.FromMinutes(5),
                CookerType = dt1,
                Weight = 200
            };

            Dish d2 = new Dish
            {
                Name = "Borch2",
                CookingTime = TimeSpan.FromMinutes(5),
                CookerType = dt1,
                Weight = 200
            };

            Dish d3 = new Dish
            {
                Name = "Borch3",
                CookingTime = TimeSpan.FromMinutes(5),
                CookerType = dt1,
                Weight = 200
            };

            Dish d4 = new Dish
            {
                Name = "Borch4",
                CookingTime = TimeSpan.FromMinutes(5),
                CookerType = dt1,
                Weight = 200
            };

            Dish d5 = new Dish
            {
                Name = "Borch5",
                CookingTime = TimeSpan.FromMinutes(5),
                CookerType = dt1,
                Weight = 200
            };

            db.CookerTypes.Add(dt1);

            db.Dishes.Add(d1);
            db.Dishes.Add(d2);
            db.Dishes.Add(d3);
            db.Dishes.Add(d4);
            db.Dishes.Add(d5);

            db.SaveChanges();
        }
    }
}
