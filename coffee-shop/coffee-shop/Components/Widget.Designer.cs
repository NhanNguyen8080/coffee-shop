namespace coffee_shop_test.Components
{
    partial class Widget
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
            pnWidget = new Guna.UI2.WinForms.Guna2Panel();
            imgImage = new PictureBox();
            lbPrice = new Label();
            lbTitle = new Label();
            pnWidget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgImage).BeginInit();
            SuspendLayout();
            // 
            // pnWidget
            // 
            pnWidget.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnWidget.BackColor = Color.White;
            pnWidget.Controls.Add(imgImage);
            pnWidget.Controls.Add(lbPrice);
            pnWidget.Controls.Add(lbTitle);
            pnWidget.Cursor = Cursors.Hand;
            pnWidget.CustomizableEdges = customizableEdges1;
            pnWidget.Location = new Point(3, 3);
            pnWidget.Name = "pnWidget";
            pnWidget.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnWidget.Size = new Size(241, 124);
            pnWidget.TabIndex = 0;
            pnWidget.Click += pnWidget_Click;
            // 
            // imgImage
            // 
            imgImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imgImage.Image = (Image)resources.GetObject("imgImage.Image");
            imgImage.Location = new Point(116, 21);
            imgImage.Name = "imgImage";
            imgImage.Size = new Size(112, 100);
            imgImage.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImage.TabIndex = 2;
            imgImage.TabStop = false;
            imgImage.Click += imgImage_Click;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbPrice.ForeColor = Color.Orange;
            lbPrice.Location = new Point(14, 83);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(68, 31);
            lbPrice.TabIndex = 1;
            lbPrice.Text = "$1.00";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTitle.Location = new Point(14, 15);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(96, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Capuchino";
            // 
            // Widget
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnWidget);
            Name = "Widget";
            Size = new Size(247, 130);
            pnWidget.ResumeLayout(false);
            pnWidget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnWidget;
        public Label lbPrice;
        public Label lbTitle;
        public PictureBox imgImage;
    }
}
