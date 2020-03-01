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

            CookerType dt2 = new CookerType
            {
                Name = "Microwave"
            };

            Dish d1 = new Dish
            {
                Name = "Cola",
                CookingTime = TimeSpan.FromSeconds(10),                
                Weight = 100
            };

            Dish d2 = new Dish
            {
                Name = "Borch2",
                CookingTime = TimeSpan.FromMinutes(5),
                CookerType = dt2,
                Weight = 200
            };

            Cook c1 = new Cook
            {
                SkillCoefficient = 1.2f,
                FinishTime = DateTime.Now.AddHours(1)
            };

            Cook c2 = new Cook
            {
                SkillCoefficient = 1.5f,
                FinishTime = DateTime.Now.AddHours(1)
            };

            Cooker cr1 = new Cooker
            {
                CookerType = dt1,
                CoolingTime = TimeSpan.FromHours(1),
                WarmUpTime = TimeSpan.FromHours(2),
                FinishTime = DateTime.Now.AddHours(-2)  
            };

            Cooker cr2 = new Cooker
            {
                CookerType = dt2,
                CoolingTime = TimeSpan.FromSeconds(30),
                WarmUpTime = TimeSpan.FromSeconds(30),
                FinishTime = DateTime.Now
            };

            db.CookerTypes.Add(dt1);
            db.CookerTypes.Add(dt2);

            db.Dishes.Add(d1);
            db.Dishes.Add(d2);

            db.Cooks.Add(c1);
            db.Cooks.Add(c2);

            db.Cookers.Add(cr1);
            db.Cookers.Add(cr2);

            db.SaveChanges();
        }
    }
}
