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
    public partial class AddNewItem : Form
    {
        ItemService _itemService = new ItemService();
        CategoryService _categoryService = new CategoryService();

        public AddNewItem()
        {
            InitializeComponent();
            var categoryList = _categoryService.GetAll().Select(p => new { Value = p.TypeId, Text = p.TypeName }).ToList();
            cbCat.ValueMember = "Value";
            cbCat.DisplayMember = "Text";
            cbCat.DataSource = categoryList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var item = new Item();
            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please complete full information!", "Notification", MessageBoxButtons.OK);
                return;
            }
            bool inStock = returnResult(pnlInStock, "Available");
            bool status = true;
            item.ItemName = txtName.Text;
            item.Price = numPrice.Value;
            item.Status = status;
            item.InStock = inStock;
            item.Image = imageLocation;
            item.TypeId = (int)cbCat.SelectedValue;
            _itemService.Add(item);
            this.Close();
        }

        private bool returnResult(Panel pnl, String text)
        {
            RadioButton rdb = null;

            foreach (RadioButton item in pnl.Controls)
            {
                if (item.Checked)
                {
                    rdb = item;
                }
            }
            if (rdb != null)
            {
                if (rdb.Text.Equals(text))
                {
                    return true;
                }
            }
            return false;
        }

        String imageLocation = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    image.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
