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
        public BillForm()
        {
            InitializeComponent();
        }

        public double calculateTotal()
        {
            double total = 0;
            foreach (DataGridViewRow item in dgvBill.Rows)
            {
                total += double.Parse(item.Cells[2].Value.ToString().Replace("$", ""));
            }
            return total;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            //dgvBill = dgv;
            var itemList = dgvBill.Rows;
            dgvBill.DataSource = new BindingSource { DataSource = itemList };
            lbTotalMoney.Text = "$" + calculateTotal().ToString();
        }

        public void populatedatagridview(List<string[]> data)
        {

            foreach (var item in data)
            {
                dgvBill.Rows.Add(item);
            }

        }

        public void populateCashier(String data)
        {

        }
    }
}
