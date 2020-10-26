using System;

namespace OrderManager.Lib.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICookerRepository CookerRepository { get; }

        ICookerTypeRepository CookerTypeRepository { get; }

        ICookRepository CookRepository { get; }

        IDishRepository DishRepository { get; }

        IOrderRepository OrderRepository { get; }

        void Save();
    }
}
