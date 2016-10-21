﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int OrderId { get; set; }
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }
    }
}