using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public double Total { get; set; }
        public int Status { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
