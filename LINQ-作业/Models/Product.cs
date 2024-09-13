using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_作业.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int  ProductId{ get; set; }

        [Required,Column(TypeName = "varchar"),StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

    }
}
