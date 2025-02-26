using System;


namespace UnitOfShop.Repositories {
    public interface ICustomerRepository {
        void Save ();
    }

    public class CustomerRepository : ICustomerRepository{
        public void Save() {
            throw new System.NotImplementedException();
        }
    }
}
