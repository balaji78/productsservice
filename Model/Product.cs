
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProductService.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        [StringLength(200)]
        public string? Category { get; set; }

        public float Price { get; set; }

        [StringLength(50)]
        public string? Model { get; set; }

        [StringLength(3500)]
        public string? Tags { get; set; }

        [StringLength(650)]
        public string? Specifications { get; set; }

        [StringLength(20)]
        public string? ShippingWeight { get; set; }

        [StringLength(50)]
        public string? Dimensions { get; set; }

        [StringLength(255)]
        public string? ImageURL { get; set; }
    }
}