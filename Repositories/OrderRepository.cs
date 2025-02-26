using System;
using UnitOfShop.Models;


namespace UnitOfShop.Repositories {
    public interface IOrderRepository {
        void Save (Order customer);
    }

    public class OrderRepository : IOrderRepository
    {
        public void Save() {
            throw new System.NotImplementedException();
        }

        public void Save(Order customer)
        {
        
        }
    }
}
