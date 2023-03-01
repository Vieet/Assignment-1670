using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class CategoryRequest
    {
        public int Id { get; set; }
        [Required]
        public string Category { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
    }
}
