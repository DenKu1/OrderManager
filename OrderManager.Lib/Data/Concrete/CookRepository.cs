using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OrderManager.Lib.Data.Abstract;
using OrderManager.Lib.Data.Entities;

namespace OrderManager.Lib.Data.Concrete
{
    public class CookRepository : IRepository<EFCook>
    {
        private EFDbContext db;

        public CookRepository()
        {
            this.db = new EFDbContext();
        }

        public IEnumerable<EFCook> GetAll()
        {
            return db.Cooks.ToList();
        }

        public EFCook Get(int id)
        {
            return db.Cooks.Find(id);
        }

        public void Create(EFCook cook)
        {
            db.Cooks.Add(cook);
        }

        public void Update(EFCook cook)
        {
            db.Entry(cook).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            EFCook cook = db.Cooks.Find(id);
            if (cook != null)
                db.Cooks.Remove(cook);
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
