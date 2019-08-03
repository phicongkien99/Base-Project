using Product.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Product.DAL.ViewModels
{
    public class ProductViewModel
    {
        
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

    
    }
}
