using OrderManager.Lib.DAL.EF;
using OrderManager.Lib.DAL.Entities;
using OrderManager.Lib.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private OrderContext _db;

        public OrderRepository(OrderContext db)
        {
            _db = db;
        }

        public IEnumerable<Order> GetAll()
        {
            return _db.Orders;
        }

        public Order Get(int id)
        {
            return _db.Orders.Find(id);
        }

        public void Add(Order item)
        {
            _db.Orders.Add(item);
        }

        public void Update(Order item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Order item = _db.Orders.Find(id);
            if (item != null)
                _db.Orders.Remove(item);
        }
    }
}