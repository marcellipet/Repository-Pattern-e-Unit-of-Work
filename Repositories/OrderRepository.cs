using System;
using UnitOfShop.Data;
using UnitOfShop.Models;


namespace UnitOfShop.Repositories {
    public interface IOrderRepository {
        void Save (Order customer);
    }

    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Order customer)
        {
            _context.Orders.Add(customer);
            _context.SaveChanges();
        }
    }
}
