using ECommerce.Entity.Base;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Entity.Entity
{
    public class Category:BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string CategoryName { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }


        public List<Product> Products { get; set; }


    }
}
