using System;
using UnitOfShop.Models;


namespace UnitOfShop.Repositories {
    public interface ICustomerRepository {
        void Save (Customer customer);
    }

    public class CustomerRepository : ICustomerRepository
    {
        public void Save() {
            throw new System.NotImplementedException();
        }

        public void Save(Customer customer)
        {
        
        }
    }
}
