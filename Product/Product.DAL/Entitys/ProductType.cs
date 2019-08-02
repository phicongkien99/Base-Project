using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Product.DAL.Entity
{
    [Table("ProductTypes")]
    public class ProductType
    {
        public ProductType()
        {

        }

        public ProductType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string Name { get; set; }

        public virtual ICollection<Products> Prds { get; set; }
    }
}
