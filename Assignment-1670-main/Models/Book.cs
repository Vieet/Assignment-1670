using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Publisher { get; set; }
        [Required]
        public string Author { get; set; }
        [Range(1000,2022)]
        public int YearPublished { get; set; }
        [Url]
        public string Image { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        [Range(1,1000)]
        public int Quantity { get; set; }
        [Display(Name = "Category name")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
