using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class CartItem
    {
        [Range(1, 10)]
        public int quantity { get; set; }
        public Book book { get; set; }
    }
}
