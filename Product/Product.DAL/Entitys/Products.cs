using Product.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Product.DAL.Entity
{
    [Table("Product")]
    public class Products
    {
        public Products()
        {

        }

        public Products(int id, string name, int typeId, string typeName ,decimal price, Status status)
        {
            Id = id;
            Name = name;
            TypeId = typeId;
            TypeName = typeName;
            Price = price;
            Status = status;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int TypeId { get; set; }

        [StringLength(40, MinimumLength = 2)]
        public string TypeName { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 2)]
        public string Name { get; set; }

        [Range(500, 100000000)]
        public decimal Price { get; set; }

        [Range(0, 1)]
        public Status Status { get; set; }

        [ForeignKey("TypeId")]
        public virtual ProductType PrdType { get; set; }
    }
}
