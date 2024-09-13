using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_作业.Models
{
    public class OrderDTO
    {
        public int 订单编号 { get; set; }

        public DateTime 下单时间 { get; set; }

        public int 用户编号 { get; set; }

        public string 所属用户 { get; set; }

        public int 产品编号 { get; set; }

        public string 购买产品 { get; set; }

        public decimal 单价 { get; set; }

        public int 购买数量 { get; set; }

        public decimal 金额 { get; set; }
    }
}
