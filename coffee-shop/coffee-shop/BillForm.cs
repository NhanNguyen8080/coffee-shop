using Repository.Models;
using Repository.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_shop_test
{
    public partial class BillForm : Form
    {
        OrderDetailService _orderDetailService = new OrderDetailService();
        OrderService _orderService = new OrderService();
        ItemService _itemService = new ItemService();
        UserService _userService = new UserService();
        public int OrderID = 0;
        public BillForm()
        {
            InitializeComponent();
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (OrderID == 0)
                {
                    throw new Exception();
                }
                Decimal total = 0;
                lbDate.Text = _orderService.GetAll().Where(p => p.OrderId.Equals(OrderID)).FirstOrDefault().OrderDate.ToString();
                lbBillID.Text = OrderID.ToString();
                int staffID = _orderService.GetAll().Where(p => p.OrderId.Equals(OrderID)).FirstOrDefault().StaffId;
                lbStaffName.Text = _userService.GetAll().Where(p => p.UserId.Equals(staffID)).FirstOrDefault().Username.ToString();
                var orderDetail = _orderDetailService.GetAll().Where(p => p.OrderId.Equals(OrderID)).ToList();
                foreach (OrderDetail detail in orderDetail)
                {
                    var itemName = _itemService.GetAll().Where(p => p.ItemId.Equals(detail.ItemId)).FirstOrDefault().ItemName;
                    dgvBill.Rows.Add(new object[] { itemName, detail.Quantity, detail.Cost, detail.Quantity * detail.Cost });
                    total += detail.Quantity * detail.Cost;
                }
                lbTotalMoney.Text = total.ToString();
                dgvItem.ReadOnly = true;
                dgvPrice.ReadOnly = true;
                dgvQty.ReadOnly = true;
                dgvCost.ReadOnly = true;

            }
            catch
            {

            }


        }
    }
}
