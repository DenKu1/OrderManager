using OrderManager.Lib.DAL.EF;
using OrderManager.Lib.DAL.Entities;
using OrderManager.Lib.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class DishRepository : IDishRepository
    {
        private OrderContext _db;

            public DishRepository(OrderContext db)
        {
            _db = db;
        }

        public IEnumerable<Dish> GetAll()
        {
            return _db.Dishes;
        }

        public Dish Get(int id)
        {
            return _db.Dishes.Find(id);
        }

        public void Add(Dish item)
        {
            _db.Dishes.Add(item);
        }

        public void Update(Dish item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Dish item = _db.Dishes.Find(id);
            if (item != null)
                _db.Dishes.Remove(item);
        }
    }
}