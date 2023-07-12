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
    public partial class CategoryManagementForm : Form
    {
        CategoryService _categoryService = new CategoryService();
        ItemService _itemService = new ItemService();
        public CategoryManagementForm()
        {
            InitializeComponent();
            var categories = _categoryService.GetAll();
            dgvCateogry.DataSource = new BindingSource { DataSource = categories };
            dgvCateogry.ReadOnly = true;
        }

        private void txtSeatch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            dgvCateogry.DataSource = new BindingSource { DataSource = _categoryService.GetAll() };
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCategoryID.Text);
                UpdateCategory update = new UpdateCategory(id);
                update.ShowDialog();
                dgvCateogry.Refresh();
                dgvCateogry.DataSource = new BindingSource { DataSource = _categoryService.GetAll() };
            } catch (Exception ex)
            {
                MessageBox.Show("Please choose a category you want to update", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var categoryList = _categoryService.GetAll();
            string searchValue = txtSearch.Text.Trim();
            if (searchValue != null)
            {
                categoryList = categoryList.Where(p => p.TypeName.ToLower().Contains(searchValue.ToLower())).ToList();
            }
            dgvCateogry.DataSource = new BindingSource { DataSource = categoryList };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = txtCategoryID.Text;
            var category = _categoryService.GetAll().Where(p => p.TypeId == int.Parse(id)).FirstOrDefault();
            var items = _itemService.GetAll().Where(p => p.TypeId == int.Parse(id)).ToList();
            if (category.Status)
            {
                category.Status = false;
                foreach (var item in items)
                {
                    item.Status = false;
                    _itemService.Update(item);
                }
            }
            else
            {
                category.Status = true;
                foreach (var item in items)
                {
                    item.Status = true;
                    _itemService.Update(item);
                }
            }
            _categoryService.Update(category);
            dgvCateogry.DataSource = new BindingSource { DataSource = _categoryService.GetAll() };
        }

        private void dgvCateogry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int categoryID = (int)dgvCateogry.Rows[e.RowIndex].Cells[0].Value;
            var category = _categoryService.GetAll().Where(p => p.TypeId == categoryID).FirstOrDefault();
            if (category != null)
            {
                txtCategoryID.Text = category.TypeId.ToString();
            }
        }
    }
}
