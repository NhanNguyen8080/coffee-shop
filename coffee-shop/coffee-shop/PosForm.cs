using Repository.Models.Services;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coffee_shop_test.Components;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Guna.UI2.Native.WinApi;

namespace coffee_shop_test
{
    public partial class PosForm : Form
    {
        CoffeeShopDBContext _context;
        CategoryService _categoryService = new CategoryService();
        ItemService _itemService = new ItemService();
        OrderDetailService _orderDetailService = new OrderDetailService();
        OrderService _orderService = new OrderService();
        public int userID { get; set; }
        public PosForm()
        {
            InitializeComponent();

        }
        private void PosForm_Load(object sender, EventArgs e)
        {
            addCategory();
            List<Item> items = _itemService.GetAll();
            if (items != null)
            {
                foreach (Item item in items)
                {
                    var status = "Sold out";
                    Category category = _categoryService.GetAll().Where(p => p.TypeId == item.TypeId).FirstOrDefault();
                    if (item.InStock)
                    {
                        status = "";
                    }
                    if (item.Status)
                    {
                        addItem(item.ItemId, item.ItemName, item.Price.ToString(), item.Image, category.TypeName, status);
                    }
                }
            }
        }

        public void addCategory()
        {
                List<Category> categories = _categoryService.GetAll();
                //CategoryPanel.Controls.Clear();
                if (categories != null)
                {
                    var location = 90;
                    foreach (Category category in categories)
                    {
                        Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                        b.FillColor = Color.White;
                        b.BackColor = Color.White;
                        b.Font = new Font("Segoe UI Bold", 10);
                        b.Size = new Size(207, 47);
                        b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                        b.TextAlign = (HorizontalAlignment)ContentAlignment.MiddleLeft;
                        b.Text = category.TypeName.ToString();
                        b.Location = new Point(0, location);
                        b.Cursor = Cursors.Hand;
                        //b.Image = category.Icon.ToString();
                        b.ForeColor = Color.Black;

                        b.Click += new EventHandler(b_Click);
                        CategoryPanel.Controls.Add(b);
                        location += 70;
                    }
                }

        }

        private void b_Click(object? sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in LayoutPanelItem.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        public void addItem(int ItemID, string ItemName, String ItemPrice, String icon, String category, String inStock)
        {
            Widget w = new Widget();
            w.Size = new Size(320, 180);
            w.id = ItemID;
            w.PName = ItemName;
            w.PPrice = ItemPrice;
            w.PCategory = category;
            w.PImage = System.Drawing.Image.FromFile(icon);
            w.PStatus = inStock;
            if (w.PStatus.Equals("Sold out"))
            {
                w.Enabled = false;
            }
            LayoutPanelItem.Controls.Add(w);
            w.OnSelect += (ss, ee) =>
            {
                var wdg = (Widget)ss;
                foreach (DataGridViewRow item in dgvOrderList.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.lbTitle.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[3].Value = double.Parse(((int.Parse(item.Cells[1].Value.ToString()))
                        * double.Parse(wdg.lbPrice.Text.Replace("$", ""))).ToString()).ToString("C2");
                        lbMoneyTotal.Text = "$" + calculateTotal().ToString();
                        return;
                    }
                    //string[] row = { "" + wdg.lbTitle.Text, "" + item.Cells[1].Value, "" + wdg.lbPrice.Text, "" + 5 };
                    //data.Add(row);
                }
                dgvOrderList.Rows.Add(new object[] { wdg.lbTitle.Text, 1, wdg.lbPrice.Text, wdg.lbPrice.Text });
                lbMoneyTotal.Text = "$" + calculateTotal().ToString();
            };
        }

        public double calculateTotal()
        {
            double total = 0;
            foreach (DataGridViewRow item in dgvOrderList.Rows)
            {
                total += double.Parse(item.Cells[3].Value.ToString().Replace("$", ""));
            }
            return total;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in LayoutPanelItem.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.lbTitle.Text.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void btnAllItems_Click(object sender, EventArgs e)
        {
            LayoutPanelItem.Controls.Clear();
            List<Item> items = _itemService.GetAll();
            if (items != null)
            {
                foreach (Item item in items)
                {
                    var status = "Sold out";
                    Category category = _categoryService.GetAll().Where(p => p.TypeId == item.TypeId).FirstOrDefault();
                    if (item.InStock)
                    {
                        status = "";
                    }
                    if (item.Status)
                    {
                        addItem(item.ItemId, item.ItemName, item.Price.ToString(), item.Image, category.TypeName, status);
                    }
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dgvOrderList.Rows.Clear();
            lbMoneyTotal.Text = "$0";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.Rows.Count == 0)
            {
                MessageBox.Show("Order List is empty", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                int indexRow = dgvOrderList.CurrentCell.RowIndex;
                dgvOrderList.Rows.RemoveAt(indexRow);
            }
        }

        private void btnSetStatus_Click(object sender, EventArgs e)
        {
            var SetSttForm = new SetSttForm();
            SetSttForm.ShowDialog();


        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.Rows.Count == 0)
            {
                MessageBox.Show("Order List is empty", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                int staffID = userID;
                Order order = new Order();
                order.StaffId = staffID;
                order.OrderDate = DateTime.Now;
                order.Status = true;
                _orderService.Add(order);
                var orderID = _orderService.GetAll().Last().OrderId;
                foreach (DataGridViewRow item in dgvOrderList.Rows)
                {
                    var itemID = _itemService.GetAll().Where(p => p.ItemName.Equals(item.Cells[0].Value)).FirstOrDefault().ItemId;
                    var quantity = item.Cells[1].Value.ToString();
                    var cost = item.Cells[2].Value.ToString();
                    var newCost = cost.Substring(1);
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.OrderId = orderID;
                    orderDetail.ItemId = itemID;
                    orderDetail.Quantity = int.Parse(quantity);
                    orderDetail.Cost = Decimal.Parse(newCost);
                    _orderDetailService.Add(orderDetail);
                }

                BillForm billForm = new BillForm();
                billForm.OrderID = orderID;
                billForm.ShowDialog();
                dgvOrderList.Rows.Clear();
            }

        }

    }
}
