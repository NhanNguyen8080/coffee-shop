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

        public void addItem(int ItemID, string ItemName, decimal ItemPrice, String image, int typeID, bool status)
        {

            SetSttWidget w = new SetSttWidget();
            //w.Size = new Size(320, 180);
            w.id = ItemID;
            w.PName = ItemName;
            w.PPrice = ItemPrice;
            w.TypeID = typeID;
            w.PImage = image;
            w.ImgSetup();
            w.PStatus = status;
            LayoutPanel.Controls.Add(w);
        }

        private void SetSttForm_Load(object sender, EventArgs e)
        {
            List<Item> items = _itemService.GetAll();
            if (items != null)
            {
                //var status = "False";
                foreach (Item item in items)
                {
                    //if (item.Status)
                    //{
                    //    status = "True";
                    //}
                    Category category = _categoryService.GetAll().Where(p => p.TypeId == item.TypeId).FirstOrDefault();
                    addItem(item.ItemId, item.ItemName, item.Price, item.Image, category.TypeId, item.Status);
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //List<SetSttWidget> setSttWidgets = new List<SetSttWidget>();
            //setSttWidgets = LayoutPanel.Controls.Cast<SetSttWidget>().ToList();
            //foreach(SetSttWidget setSttWidget in setSttWidgets)
            //{

            //}
            List<Item> items = new List<Item>();
            List<SetSttWidget> setSttWidgets = new List<SetSttWidget>();
            setSttWidgets = LayoutPanel.Controls.Cast<SetSttWidget>().ToList();
            foreach (SetSttWidget setSttWidget in setSttWidgets)
            {
                if (setSttWidget != null)
                {
                    Item item = new Item()
                    {
                        ItemId = setSttWidget.id,
                        ItemName = setSttWidget.PName,
                        TypeId = setSttWidget.TypeID,
                        Price = setSttWidget.PPrice,
                        Image = setSttWidget.PImage,
                        Status = !setSttWidget.GetCkb()
                    };
                    items.Add(item);
                }
            }
            foreach (Item item in items)
            {
                if (item != null)
                {
                    _itemService.updateStatus(item, item.Status);
                }
            }
            this.Close();    
        }
    }
}
