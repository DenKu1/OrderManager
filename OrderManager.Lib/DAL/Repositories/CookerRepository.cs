using OrderManager.Lib.DAL.EF;
using OrderManager.Lib.DAL.Entities;
using OrderManager.Lib.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class CookerRepository : ICookerRepository
    {
        private OrderContext _db;

        public CookerRepository(OrderContext db)
        {
            _db = db;
        }

        public IEnumerable<Cooker> GetAll()
        {
            return _db.Cookers;
        }

        public Cooker Get(int id)
        {
            return _db.Cookers.Find(id);
        }

        public void Add(Cooker item)
        {
            _db.Cookers.Add(item);
        }

        public void Update(Cooker item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Cooker item = _db.Cookers.Find(id);
            if (item != null)
                _db.Cookers.Remove(item);
        }
    }
}