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
    public partial class AddCategory : Form
    {
        CategoryService _categoryService = new CategoryService();
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = new Category();
            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please complete full information!", "Notification", MessageBoxButtons.OK);
                return;
            }
            bool status = returnResult(pnlStatus, "Exist");
            category.TypeName = txtName.Text;
            category.Status = status;
            _categoryService.Add(category);
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
    }
}
