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

            Cook c1 = new Cook
            {
                SkillCoefficient = 1.2f,
                FinishTime = DateTime.Now.AddHours(1)
            };

            Cooker cr1 = new Cooker
            {
                CookerType = dt1,
                CoolingTime = TimeSpan.FromHours(1),
                WarmUpTime = TimeSpan.FromHours(2),
                FinishTime = DateTime.Now.AddHours(-2)  
            };

            db.CookerTypes.Add(dt1);

            db.Dishes.Add(d1);
            db.Dishes.Add(d2);
            db.Cooks.Add(c1);
            db.Cookers.Add(cr1);
            //db.Dishes.Add(d5);

            db.SaveChanges();
        }
    }
}
