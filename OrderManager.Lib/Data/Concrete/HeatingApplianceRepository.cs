using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OrderManager.Lib.Data.Abstract;
using OrderManager.Lib.Data.Entities;

namespace OrderManager.Lib.Data.Concrete
{
    public class HeatingApplianceRepository : IRepository<EFHeatingAppliance>
    {
        private EFDbContext db;

        public HeatingApplianceRepository()
        {
            db = new EFDbContext();
        }

        public IEnumerable<EFHeatingAppliance> GetAll()
        {
            return db.HeatingApps.ToList();
        }

        public EFHeatingAppliance Get(int id)
        {
            return db.HeatingApps.Find(id);
        }

        public void Create(EFHeatingAppliance heatingAppliance)
        {
            db.HeatingApps.Add(heatingAppliance);
        }

        public void Update(EFHeatingAppliance heatingAppliance)
        {
            db.Entry(heatingAppliance).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            EFHeatingAppliance heatingAppliance = db.HeatingApps.Find(id);
            if (heatingAppliance != null)
                db.HeatingApps.Remove(heatingAppliance);
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

