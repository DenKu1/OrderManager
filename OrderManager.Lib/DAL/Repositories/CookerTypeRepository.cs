using OrderManager.Lib.DAL.EF;
using OrderManager.Lib.DAL.Entities;
using OrderManager.Lib.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class CookerTypeRepository : ICookerTypeRepository
    {
        private OrderContext _db;

        public CookerTypeRepository(OrderContext db)
        {
            _db = db;
        }

        public IEnumerable<CookerType> GetAll()
        {
            return _db.CookerTypes;
        }

        public CookerType Get(int id)
        {
            return _db.CookerTypes.Find(id);
        }

        public void Add(CookerType item)
        {
            _db.CookerTypes.Add(item);
        }

        public void Update(CookerType item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            CookerType item = _db.CookerTypes.Find(id);
            if (item != null)
                _db.CookerTypes.Remove(item);
        }
    }
}