using OrderManager.Lib.DAL.Entities;
using System;
using System.Data.Entity;


namespace OrderManager.Lib.DAL.EF
{
    class OrderContextInitializer : DropCreateDatabaseAlways<OrderContext>
    {
        protected override void Seed(OrderContext db)
        {
            CookerType ct1 = new CookerType
            {
                Name = "Oven"
            };

            CookerType ct2 = new CookerType
            {
                Name = "Microwave"
            };

            Dish d1 = new Dish
            {
                Name = "Salad",
                CookingTime = TimeSpan.FromSeconds(45),                
                Weight = 500
            };

            Dish d2 = new Dish
            {
                Name = "Soup",
                CookingTime = TimeSpan.FromMinutes(5),
                CookerType = ct1,
                Weight = 450
            };

            Dish d3 = new Dish
            {
                Name = "Pizza",
                CookingTime = TimeSpan.FromMinutes(3),
                CookerType = ct2,
                Weight = 600
            };

            Dish d4 = new Dish
            {
                Name = "Pasta",
                CookingTime = TimeSpan.FromMinutes(10),
                CookerType = ct1,
                Weight = 250
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
                CookerType = ct1,
                CoolingTime = TimeSpan.FromHours(1),
                WarmUpTime = TimeSpan.FromHours(2),
                FinishTime = DateTime.Now.AddHours(-2)  
            };

            Cooker cr2 = new Cooker
            {
                CookerType = ct2,
                CoolingTime = TimeSpan.FromSeconds(30),
                WarmUpTime = TimeSpan.FromSeconds(30),
                FinishTime = DateTime.Now
            };

            db.CookerTypes.Add(ct1);
            db.CookerTypes.Add(ct2);

            db.Dishes.Add(d1);
            db.Dishes.Add(d2);
            db.Dishes.Add(d3);
            db.Dishes.Add(d4);

            db.Cooks.Add(c1);
            db.Cooks.Add(c2);

            db.Cookers.Add(cr1);
            db.Cookers.Add(cr2);

            db.SaveChanges();
        }
    }
}
