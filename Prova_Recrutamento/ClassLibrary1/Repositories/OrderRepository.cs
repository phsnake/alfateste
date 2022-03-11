﻿using System;
using UnityOfShop.Models;
using UnityOfShop.Data;

namespace UnityOfShop.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order customer);
    }

    public class OrderRepository : IOrderRepository
   {
        private readonly DataContext _context;

        public OrderRepository (DataContext context)
        {
            _context = context;
        }

        public void Save(Order order)
        {
            _context.Orders.add(order);
            
        }
    }
}
