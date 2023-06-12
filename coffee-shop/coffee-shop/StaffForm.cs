using coffee_shop_test.Components;
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
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Net.Mime.MediaTypeNames;

namespace coffee_shop_test
{
    public partial class StaffForm : Form
    {
        CoffeeShopDBContext _context;
        CategoryService _categoryService = new CategoryService();
        ItemService _itemService = new ItemService();
        public StaffForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void AddControls(Form form)
        {
            CategoryPanel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            CategoryPanel.Controls.Add(form);
            form.Show();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            addCategory();
            List<Item> items = _itemService.GetAll();
            if (items != null)
            {
                var status = "";
                foreach (Item item in items)
                {
                    Category category = _categoryService.GetAll().Where(p => p.TypeId == item.TypeId).FirstOrDefault();
                    if (!item.Status)
                    {
                        status = "Sold out";
                    }
                    addItem(item.ItemId, item.ItemName, item.Price.ToString(), item.Image, category.TypeName, status);
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

        //private void btnCategory_Click(object sender, EventArgs e)
        //{
        //    AddControls(new frmItem());
        //}

        public void addItem(int ItemID, string ItemName, String ItemPrice, String icon, String category, String status)
        {
            Widget w = new Widget();
            w.Size = new Size(320, 180);
            w.id = ItemID;
            w.PName = ItemName;
            w.PPrice = ItemPrice;
            w.PCategory = category;
            w.PImage = System.Drawing.Image.FromFile(icon);
            LayoutPanelItem.Controls.Add(w);
            w.PStatus = status;
            w.OnSelect += (ss, ee) =>
            {
                var wdg = (Widget)ss;
                foreach (DataGridViewRow item in dgvOrderList.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.lbTitle.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[2].Value = ((int.Parse(item.Cells[1].Value.ToString()))
                        * double.Parse(wdg.lbPrice.Text.Replace("$", ""))).ToString("C2");
                        lbMoneyTotal.Text = "$" + calculateTotal().ToString();
                        return;
                    }
                }
                dgvOrderList.Rows.Add(new object[] { wdg.lbTitle.Text, 1, wdg.lbPrice.Text });
                lbMoneyTotal.Text = "$" + calculateTotal().ToString();
            };


        }

        public double calculateTotal()
        {
            double total = 0;
            foreach (DataGridViewRow item in dgvOrderList.Rows)
            {
                total += double.Parse(item.Cells[2].Value.ToString().Replace("$", ""));
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
                var status = "";
                foreach (var item in items)
                {
                    status = "Sold out";
                    Category category = _categoryService.GetAll().Where(p => p.TypeId == item.TypeId).FirstOrDefault();
                    addItem(item.ItemId, item.ItemName, item.Price.ToString(), item.Image, category.TypeName, status);
                }
            }

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dgvOrderList.Rows.Clear();
            lbMoneyTotal.Text = "$0";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginForm = new Login();
            loginForm.ShowDialog();
        }
    }
}
