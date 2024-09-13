using LINQ_作业.Context;
using LINQ_作业.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_作业
{
    public partial class Form2 : Form
    {
        int currentPage = 1;
        public Form2()
        {
            InitializeComponent();
            this.ucPager1.PagerEvent += UcPager1_PagerEvent;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BindUsers();

            ucPager1.GetPagerData();
        }

        private void BindUsers()
        {
            using (var c = new ZYContext())
            {
                var query = from u in c.Users
                            select u;

                List<User> list = query.ToList();
                list.Insert(0, new User() { UserId = -1, UserName = "全部", Password = "123456" });


                comboBox1.DataSource = list;
                comboBox1.DisplayMember = "UserName";
                comboBox1.ValueMember = "UserId";
            }
        }

        private void UcPager1_PagerEvent(int currentPage, int pageSize, out int totalCount)
        {
            using (var c = new ZYContext())
            {
                var query = from o in c.Orders
                            join u in c.Users on o.UserId equals u.UserId
                            join p in c.Products on o.ProductId equals p.ProductId
                            orderby o.OrderId descending
                            select new OrderDTO()
                            {
                                订单编号 = o.OrderId,
                                下单时间 = o.OrderTime,
                                用户编号 = o.UserId,
                                所属用户 = u.UserName,
                                产品编号 = o.ProductId,
                                购买产品 = p.ProductName,
                                单价 = p.Price,
                                购买数量 = o.OrderCount,
                                金额 = o.OrderCount * p.Price
                            };

                #region 查询条件
                if (!string.IsNullOrWhiteSpace(dateTimePicker1.Text))
                {
                    DateTime dt = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00");
                    query = query.Where(o => o.下单时间 >= dt);
                }

                if (!string.IsNullOrWhiteSpace(dateTimePicker2.Text))
                {
                    DateTime dt = DateTime.Parse(dateTimePicker2.Value.ToString("yyyy-MM-dd") + " 23:59:59");
                    query = query.Where(o => o.下单时间 <= dt);
                }

                if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
                {
                    int userId = Convert.ToInt32(comboBox1.SelectedValue);
                    query = query.Where(o => o.用户编号 == userId);
                }
                #endregion

                totalCount = query.Count();

                dataGridView1.DataSource = query.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

                dataGridView1.Columns["用户编号"].Visible = false;
               //dataGridView1.Columns["产品编号"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucPager1.CurrentPage = 1;
            ucPager1.GetPagerData();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtProductId.Text = row.Cells["产品编号"].Value.ToString();
                txtPrice.Text = row.Cells["单价"].Value.ToString();
                txtCount.Text = row.Cells["购买数量"].Value.ToString();
                dtpOrderTime.Value = Convert.ToDateTime(row.Cells["下单时间"].Value);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var c = new ZYContext())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int orderId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["订单编号"].Value);
                    var order = (from o in c.Orders
                                 where o.OrderId == orderId
                                 select o).FirstOrDefault();
                    if (order != null)
                    {
                        order.ProductId = Convert.ToInt32(txtProductId.Text);
                        order.OrderCount = Convert.ToInt32(txtCount.Text);
                        order.OrderTime = dtpOrderTime.Value;
                        c.SaveChanges();
                        MessageBox.Show("订单成功更新！");
                        ucPager1.GetPagerData();
                    }
                    else {
                        MessageBox.Show("未找到订单，重试");
                    
                    }
                }
                else
                {
                    MessageBox.Show("请选择一个订单编辑");

                }


            }
        }
    }
}
