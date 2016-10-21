using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models
{
    public class BookStoreAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BookStoreAppContext() : base("name=BookStoreAppContext")
        {
        }

        public DbSet<BookStoreApp.Models.Book> Books { get; set; }
        public DbSet<BookStoreApp.Models.Order> Order { get; set; }
        public DbSet<BookStoreApp.Models.OrderDetail> OrderDetails { get; set; }

    }
}
