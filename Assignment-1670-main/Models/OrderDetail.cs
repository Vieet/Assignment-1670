using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        public double Total { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public Order Order { get; set; }
        public Book Book { get; set; }
    }
}
