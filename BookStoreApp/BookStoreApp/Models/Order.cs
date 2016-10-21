using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models
{
    public class Order
    {
        public Order()
        {
            var OrderDetails = new List<OrderDetail>();
        }
        [Key]
        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }

        //Navigation
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}