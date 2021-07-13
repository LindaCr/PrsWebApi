using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrsWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
        [StringLength(20), Required]
        public string PartNumber { get; set; }
        [StringLength(30), Required]
        public string Name { get; set; }
        [Column(TypeName="decimal (11,2)")]
        public decimal Price { get; set; }
        [StringLength(10), Required]
        public string Unit { get; set; } 
        [StringLength(255)]
        public string PhotoPath { get; set; }


    }
}
