using coffee_shop_test.Components;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace coffee_shop_test
{
    public partial class ItemManagementForm : Form
    {
        ItemService _itemService = new ItemService();
        List<Repository.Models.Item> items = new List<Repository.Models.Item>();
        public ItemManagementForm()
        {
            InitializeComponent();
            items = _itemService.GetAll().Where(p => p.Status).ToList();
            dgvItems.DataSource = new BindingSource { DataSource = items };
            dgvItems.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewItem addNewItem = new AddNewItem();
            addNewItem.ShowDialog();
            dgvItems.DataSource = new BindingSource { DataSource = _itemService.GetAll() };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var itemList = _itemService.GetAll();
            string searchValue = txtSearch.Text.Trim();
            if (searchValue != null)
            {
                itemList = itemList.Where(p => p.ItemName.ToLower().Contains(searchValue.ToLower())).ToList();
            }
            dgvItems.DataSource = new BindingSource { DataSource = itemList }; 
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int itemID = (int)dgvItems.Rows[e.RowIndex].Cells[0].Value;
            var item = _itemService.GetAll().Where(p => p.ItemId == itemID).FirstOrDefault();
            if (item != null)
            {
                txtItemID.Text = item.ItemId.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = txtItemID.Text;
            var item = _itemService.GetAll().Where(p => p.ItemId == int.Parse(id)).FirstOrDefault();
            if (item.Status)
            {
                item.Status = false;
            }
            else
            {
                MessageBox.Show("This item was deleted", "Notification", MessageBoxButtons.OK);
            }
            _itemService.Update(item);
            dgvItems.DataSource = new BindingSource { DataSource = _itemService.GetAll() };
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtItemID.Text);
                UpdateItem updateItem = new UpdateItem(id);
                updateItem.ShowDialog();
                items = _itemService.GetAll();
                dgvItems.DataSource = new BindingSource { DataSource = items };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose an item you want to update", "Error", MessageBoxButtons.OK);
            }
        }
    }

    class ItemView
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int TypeId { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
    }
}
