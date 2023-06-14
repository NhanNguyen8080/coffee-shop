namespace coffee_shop_test.Components
{
    partial class SetSttWidget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetSttWidget));
            imgImage = new PictureBox();
            lbTitle = new Label();
            ckbSoldOut = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)imgImage).BeginInit();
            SuspendLayout();
            // 
            // imgImage
            // 
            imgImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imgImage.Image = (Image)resources.GetObject("imgImage.Image");
            imgImage.Location = new Point(12, 3);
            imgImage.Name = "imgImage";
            imgImage.Size = new Size(137, 110);
            imgImage.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImage.TabIndex = 3;
            imgImage.TabStop = false;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTitle.Location = new Point(24, 116);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(96, 25);
            lbTitle.TabIndex = 4;
            lbTitle.Text = "Capuchino";
            // 
            // ckbSoldOut
            // 
            ckbSoldOut.AutoSize = true;
            ckbSoldOut.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ckbSoldOut.ForeColor = Color.LightCoral;
            ckbSoldOut.Location = new Point(191, 55);
            ckbSoldOut.Name = "ckbSoldOut";
            ckbSoldOut.Size = new Size(142, 42);
            ckbSoldOut.TabIndex = 5;
            ckbSoldOut.Text = "Sold out";
            ckbSoldOut.UseVisualStyleBackColor = true;
            // 
            // SetSttWidget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ckbSoldOut);
            Controls.Add(lbTitle);
            Controls.Add(imgImage);
            DoubleBuffered = true;
            Name = "SetSttWidget";
            Size = new Size(352, 150);
            ((System.ComponentModel.ISupportInitialize)imgImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox imgImage;
        public Label lbTitle;
        private CheckBox ckbSoldOut;
    }
}
