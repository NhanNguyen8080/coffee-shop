using coffee_shop_test.Components;
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

namespace coffee_shop_test
{
    public partial class SetSttForm : Form
    {
        ItemService _itemService = new ItemService();
        CategoryService _categoryService = new CategoryService();
        public SetSttForm()
        {
            InitializeComponent();

        }

        public void addItem(int ItemID, string ItemName, String ItemPrice, String icon, String category, String status)
        {
            SetSttWidget w = new SetSttWidget();
            //w.Size = new Size(320, 180);
            w.id = ItemID;
            w.PName = ItemName;
            w.PPrice = ItemPrice;
            w.PCategory = category;
            w.PImage = System.Drawing.Image.FromFile(icon);
            w.PStatus = status;
            LayoutPanel.Controls.Add(w);

        }

        private void SetSttForm_Load(object sender, EventArgs e)
        {
            List<Item> items = _itemService.GetAll();
            if (items != null)
            {
                foreach (Item item in items)
                {
                    var status = "False";
                    Category category = _categoryService.GetAll().Where(p => p.TypeId == item.TypeId).FirstOrDefault();
                    if (item.Status)
                    {
                        status = "True";
                    }
                    addItem(item.ItemId, item.ItemName, item.Price.ToString(), item.Image, category.TypeName, status);
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
