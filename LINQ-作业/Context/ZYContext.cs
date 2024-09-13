using LINQ_作业.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_作业.Context
{
    public class ZYContext : DbContext
    {
        public ZYContext() : base("name=linq-zuoye-connstring")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
