using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models
{
    public class Repository : IRepository
    {
        private BookStoreAppContext db;

        public Repository(BookStoreAppContext db)
        {
            this.db = db;
        }

        public IQueryable<Order> GetAllOrders()
        {
            return db.Order;
        }

        public IQueryable<Order> GetAllOrdersWithDetails()
        {
            return db.Order.Include("OrderDetails");
        }

        public Order GetOrder(int id)
        {
            return db.Order.Include("OrderDetails.Book")
                .FirstOrDefault(o => o.Id == id);
        }
    }
}