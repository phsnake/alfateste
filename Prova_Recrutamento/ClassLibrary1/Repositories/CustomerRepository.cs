using System;
using UnityOfShop.Models;
using UnityOfShop.Data;

namespace UnityOfShop.Repositories
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
    }

    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository (DataContext context)
        {
            _context = context;
        }

        public void Save(Customer customer)
        {
            _context.Customers.Add(customer);
            
        }
    }
}