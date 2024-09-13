using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_作业.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, Column(TypeName ="varchar"),StringLength(20)]
        public string UserName { get; set; }

        [Required, Column(TypeName = "varchar"), StringLength(50)]
        public string Password { get; set; }

    }
}
