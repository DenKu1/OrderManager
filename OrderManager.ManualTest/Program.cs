using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Lib.BLL.Services;
using OrderManager.Lib.DAL.EF;


namespace OrderManager.ManualTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            using (EFDbContext db = new EFDbContext())
            {
                // создаем два объекта User
                EFCook cook1 = new EFCook { SkillCoefficient = 200 };
                EFCook cook2 = new EFCook { SkillCoefficient = 12 };

                // добавляем их в бд
               // db.Cooks.Add(cook1);
               // db.Cooks.Add(cook2);
                
                Console.WriteLine("Объекты успешно сохранены");

                //var cookToDelete = db.Cooks.Where(x => x.SkillCoefficient == 200).First();

                //db.Cooks.Remove(cookToDelete);

                //db.SaveChanges();

                Console.WriteLine("Список объектов:");
                foreach (var cook in db.Cooks)
                {
                    Console.WriteLine($"Cook: {cook.Id}, {cook.SkillCoefficient}.");
                }
            }  */

            Console.WriteLine("Starting...");
            
            using (DishService db = new DishService(new OrderContext()))
            {
                var a = db.GetDishes();

                foreach (var item in a)
                    Console.WriteLine($"Id: {item.Id} Name: {item.Name}");
            }
            




            Console.WriteLine("Finished");

            Console.Read();

        }
    }
}
