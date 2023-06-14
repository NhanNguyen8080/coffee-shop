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
        public String PPrice { get; set; }
        public String PCategory { get; set; }
        public String PName
        {
            get { return lbTitle.Text; }
            set { lbTitle.Text = value; }
        }

        public Image PImage
        {
            get { return imgImage.Image; }
            set { imgImage.Image = value; }
        }

        public String PStatus
        {
            get { return lbStatus.Text; }
            set { lbStatus.Text = value; }
        }
    }
}
