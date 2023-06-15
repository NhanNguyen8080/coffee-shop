using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_shop_test.Components
{
    public partial class SetSttWidget : UserControl
    {
        public SetSttWidget()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public String PName
        {
            get { return lbTitle.Text; }
            set { lbTitle.Text = value; }
        }

        public int TypeID { get; set; }

        public String PImage { get; set; }

        public void ImgSetup()
        {
            imgImage.Image = System.Drawing.Image.FromFile(PImage);
        }

        public decimal PPrice { get; set; }

        public bool PStatus
        {
            get { return ckbSoldOut.Checked; }
            set
            {
                if (value)
                {
                    ckbSoldOut.CheckState = CheckState.Unchecked;
                }
                else
                {
                    ckbSoldOut.CheckState = CheckState.Checked;
                }
            }
        }

        public bool GetCkb()
        {
            return ckbSoldOut.Checked;
        }

    }
}
