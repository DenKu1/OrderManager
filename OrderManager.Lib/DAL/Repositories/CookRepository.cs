using OrderManager.Lib.DAL.EF;
using OrderManager.Lib.DAL.Entities;
using OrderManager.Lib.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class CookRepository : ICookRepository
    {
        private OrderContext _db;

        public CookRepository(OrderContext db)
        {
            _db = db;
        }

        public IEnumerable<Cook> GetAll()
        {
            return _db.Cooks;
        }

        public Cook Get(int id)
        {
            return _db.Cooks.Find(id);
        }

        public void Add(Cook item)
        {
            _db.Cooks.Add(item);
        }

        public void Update(Cook item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Cook item = _db.Cooks.Find(id);
            if (item != null)
                _db.Cooks.Remove(item);
        }
    }
}