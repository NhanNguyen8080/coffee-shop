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
    public partial class UpdateItem : Form
    {
        ItemService _itemService = new ItemService();
        CategoryService _categoryService = new CategoryService();
        public UpdateItem(int id)
        {
            InitializeComponent();
            var categoryList = _categoryService.GetAll().Select(p => new { Value = p.TypeId, Text = p.TypeName }).ToList();
            cbCat.ValueMember = "Value";
            cbCat.DisplayMember = "Text";
            cbCat.DataSource = categoryList;

            var item = _itemService.GetAll().Where(p => p.ItemId == id).FirstOrDefault();
            if (item != null)
            {
                txtID.Text = id.ToString();
                txtID.Enabled = false;
                txtName.Text = item.ItemName;
                numPrice.Value = item.Price;
                cbCat.SelectedValue = item.TypeId;
                if (item.InStock)
                {
                    rdInStockTrue.Checked = true;
                }
                else
                {
                    rdInStockFalse.Checked = true;
                }
                image.ImageLocation = item.Image;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtID.Text);
            var item = _itemService.GetAll().Where(p => p.ItemId == id).FirstOrDefault();
            if (item != null)
            {
                bool inStock = returnResult(pnlInStock, "Available");
                item.ItemName = txtName.Text;
                item.Price = numPrice.Value;
                item.TypeId = cbCat.SelectedValue.GetHashCode();
                item.InStock = inStock;
                if (imageLocation.Equals(""))
                {
                    imageLocation = item.Image;
                }
                item.Image = imageLocation;
                _itemService.Update(item);
            }
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
        private void btnBrowse_Click_1(object sender, EventArgs e)
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
