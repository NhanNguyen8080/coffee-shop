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
using static System.Net.Mime.MediaTypeNames;

namespace coffee_shop_test
{
    public partial class UpdateCategory : Form
    {
        CategoryService _categoryService = new CategoryService();
        public UpdateCategory(int id)
        {
            InitializeComponent();
            var category = _categoryService.GetAll().Where(p => p.TypeId == id).FirstOrDefault();
            if (category != null)
            {
                txtID.Text = id.ToString();
                txtID.Enabled = false;
                txtName.Text = category.TypeName;
                if (category.Status)
                {
                    rdStatusTrue.Checked = true;
                }
                else
                {
                    rdStatusFalse.Checked = true;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtID.Text);
            var category = _categoryService.GetAll().Where(p => p.TypeId == id).FirstOrDefault();
            if (category != null)
            {
                bool status = returnResult(pnlStatus, "Exist");
                category.TypeName = txtName.Text;
                category.Status = status;
                _categoryService.Update(category);
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
    }
}
