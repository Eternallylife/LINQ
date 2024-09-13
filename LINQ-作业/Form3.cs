using LINQ_作业.Context;
using LINQ_作业.Controls;
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
    public partial class Form3 : Form
    {
        int currentPage = 1;
      
        public Form3()
        {
            InitializeComponent();
          
        }

     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var c = new ZYContext())
            {
                /*var newOrder = new Order()
                {
                    UserId = Convert.ToInt32(txtUserId.Text),
                    ProductId = Convert.ToInt32(txtProduct.Text),
                    OrderCount = Convert.ToInt32(txtCount.Text),
                    OrderTime = DateTime.Now
                };
                c.Orders.Add(newOrder);
                c.SaveChanges();*/
                int selectedUserId = Convert.ToInt32(txtUserId.Text);
                int selectedProductId = Convert.ToInt32(txtUserId.Text);
                var selectedUser=(from u in c.Users
                                 where u.UserId == selectedUserId
                                 select u).FirstOrDefault();
                var selectedProduct =(from p in c.Products
                                      where p.ProductId == selectedProductId
                                      select p).FirstOrDefault();
                if (selectedProduct != null && selectedUser != null)
                {
                    var newOrder = new Order()
                    {
                        UserId = selectedUserId,
                        ProductId = selectedProductId,
                        OrderCount = Convert.ToInt32(txtCount.Text),
                        OrderTime = DateTime.Now

                    };
                    c.Orders.Add(newOrder);
                    c.SaveChanges();
                    MessageBox.Show("订单添加成功！");
                    this.Close();

                }
                else {
                    MessageBox.Show("未找到选中的用户或产品，请重试");
                
                
                }


            }
        }
    }
}
