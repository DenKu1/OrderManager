using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OrderManager.Lib.Data.Abstract;
using OrderManager.Lib.Data.Entities;

namespace OrderManager.Lib.Data.Concrete
{
    public class DishRepository : IRepository<EFDish>
    {
        private EFDbContext db;

        public DishRepository()
        {
            this.db = new EFDbContext();
        }

        public IEnumerable<EFDish> GetAll()
        {
            return db.Dishes.ToList();
        }

        public EFDish Get(int id)
        {
            return db.Dishes.Find(id);
        }

        public void Create(EFDish dish)
        {
            db.Dishes.Add(dish);
        }

        public void Update(EFDish dish)
        {
            db.Entry(dish).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            EFDish dish = db.Dishes.Find(id);
            if (dish != null)
                db.Dishes.Remove(dish);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
