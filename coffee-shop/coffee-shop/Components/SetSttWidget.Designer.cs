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
            Toggle = new Toggle();
            lbStatus = new Label();
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
            // Toggle
            // 
            Toggle.BackgroundImage = (Image)resources.GetObject("Toggle.BackgroundImage");
            Toggle.BackgroundImageLayout = ImageLayout.Stretch;
            Toggle.Check = false;
            Toggle.Location = new Point(229, 42);
            Toggle.Name = "Toggle";
            Toggle.Size = new Size(111, 57);
            Toggle.TabIndex = 5;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(248, 10);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(50, 20);
            lbStatus.TabIndex = 6;
            lbStatus.Text = "label1";
            // 
            // SetSttWidget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbStatus);
            Controls.Add(Toggle);
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
        private Toggle Toggle;
        private Label lbStatus;
    }
}
