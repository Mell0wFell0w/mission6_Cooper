using System.ComponentModel.DataAnnotations;

namespace mission6_Cooper.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
    }
}
