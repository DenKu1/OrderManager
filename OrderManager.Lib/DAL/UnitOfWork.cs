using DAL.Repositories;
using OrderManager.Lib.DAL.EF;
using OrderManager.Lib.DAL.Interfaces;

namespace OrderManager.Lib.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private OrderContext context;

        private ICookerRepository cookerRepository;
        private ICookerTypeRepository cookerTypeRepository;
        private ICookRepository cookRepository;
        private IDishRepository dishRepository;
        private IOrderRepository orderRepository;

        public UnitOfWork()
        {
            context = new OrderContext();
        }

        public ICookerRepository CookerRepository
        {
            get
            {
                if (cookerRepository == null)
                {
                    cookerRepository = new CookerRepository(context);
                }
                return cookerRepository;
            }
        }

        public ICookerTypeRepository CookerTypeRepository
        {
            get
            {
                if (cookerTypeRepository == null)
                {
                    cookerTypeRepository = new CookerTypeRepository(context);
                }
                return cookerTypeRepository;
            }
        }

        public ICookRepository CookRepository
        {
            get
            {
                if (cookRepository == null)
                {
                    cookRepository = new CookRepository(context);
                }
                return cookRepository;
            }
        }

        public IDishRepository DishRepository
        {
            get
            {
                if (dishRepository == null)
                {
                    dishRepository = new DishRepository(context);
                }
                return dishRepository;
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new OrderRepository(context);
                }
                return orderRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}