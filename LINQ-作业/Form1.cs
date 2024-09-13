using LINQ_作业.Context;
using LINQ_作业.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var c = new ZYContext())
            {
                if (c.Users.Count() > 0)
                {
                    MessageBox.Show("你已经初始化用户数据！请删除后，再重新初始化！");
                    return;
                }


                for (int i = 1; i <= 10; i++)
                {
                    User model = new User()
                    {
                        UserId = i,
                        UserName = "test" + i,
                        Password = "123456"
                    };
                    c.Entry(model).State = System.Data.Entity.EntityState.Added;
                    c.SaveChanges();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            using (var c = new ZYContext())
            {
                if (c.Products.Count() > 0)
                {
                    MessageBox.Show("你已经初始化产品数据！请删除后，再重新初始化！");
                    return;
                }

                for (int i = 1; i <= 10; i++)
                {
                    Product model = new Product()
                    {
                        ProductId = i,
                        ProductName = "产品" + i,
                        Price = random.Next(100, 1000)
                    };
                    c.Entry(model).State = System.Data.Entity.EntityState.Added;
                    c.SaveChanges();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            using (var c = new ZYContext())
            {
                if (c.Orders.Count() > 0)
                {
                    MessageBox.Show("你已经初始化订单数据！请删除后，再重新初始化！");
                    return;
                }

                for (int i = 1; i <= 10; i++)
                {
                    Order model = new Order()
                    {
                        OrderId = i,
                        OrderTime = DateTime.Now,
                        UserId = random.Next(1, 11),  // 总共10个用户
                        ProductId = random.Next(1, 11), // 总共10个产品
                        OrderCount = random.Next(1, 11) 
                    };
                    c.Entry(model).State = System.Data.Entity.EntityState.Added;
                    c.SaveChanges();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
