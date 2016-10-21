using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models
{
    public class BookStoreAppContextInitializer: System.Data.Entity.DropCreateDatabaseAlways<BookStoreAppContext>
    {
        protected override void Seed(BookStoreAppContext context)
        {
            // Books seed data
            var books = new List<Book>
            {
                new Book() { Name = "The Clean Coder", Author = "Robert Martin", Price = 19.95m },
                new Book() { Name = "The Mindset", Author="Dr Carol Dweck", Price=9.99m},
                new Book() { Name = "7 habits", Author="Dr Stephen R Covey", Price=9.97m},
                new Book() { Name = "Start With Why", Author="Simion Sinek", Price=11.50m }
            };
            //Lamda expression
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            //Order seed data
            var order = new Order() { Customer = "John Doe", OrderDate = new DateTime(2016, 10, 20)};
            // OrderDeails seed data 1
            var details = new List<OrderDetail>()
            {
                new OrderDetail() {Book = books[0], Quantity=1, Order= order },
                new OrderDetail() {Book = books[1], Quantity=2, Order= order },
                new OrderDetail() {Book = books[2], Quantity=3, Order= order },
            };

            context.Order.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order() { Customer = "Jane Doe", OrderDate = new DateTime(2016, 10, 15) };
            details = new List<OrderDetail>()
            {
                new OrderDetail() {Book = books[1], Quantity=1, Order= order },
                new OrderDetail() {Book = books[1], Quantity=2, Order= order },
                new OrderDetail() {Book = books[2], Quantity=12, Order= order },
            };
            context.Order.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order() { Customer = "John Smith", OrderDate = new DateTime(2016, 09, 15) };
            details = new List<OrderDetail>()
            {
                new OrderDetail() {Book = books[2], Quantity=9, Order= order },
                new OrderDetail() {Book = books[0], Quantity=4, Order= order },
                new OrderDetail() {Book = books[1], Quantity=3, Order= order },
            };
            context.Order.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
