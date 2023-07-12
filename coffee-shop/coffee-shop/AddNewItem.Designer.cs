namespace coffee_shop_test
{
    partial class AddNewItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            cbCat = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            rdInStockTrue = new RadioButton();
            rdInStockFalse = new RadioButton();
            rdStatusFalse = new RadioButton();
            rdStatusTrue = new RadioButton();
            pnlInStock = new Panel();
            pnlStatus = new Panel();
            image = new PictureBox();
            numPrice = new NumericUpDown();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            pnlInStock.SuspendLayout();
            pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges15;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(97, 168, 69);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel1.Size = new Size(553, 109);
            guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(184, 35);
            label1.Name = "label1";
            label1.Size = new Size(185, 41);
            label1.TabIndex = 1;
            label1.Text = "Add Product";
            // 
            // btnBrowse
            // 
            btnBrowse.AutoRoundedCorners = true;
            btnBrowse.BorderRadius = 29;
            btnBrowse.CustomizableEdges = customizableEdges17;
            btnBrowse.DisabledState.BorderColor = Color.DarkGray;
            btnBrowse.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBrowse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBrowse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(370, 402);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnBrowse.Size = new Size(133, 60);
            btnBrowse.TabIndex = 31;
            btnBrowse.Text = "Browse";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 333);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 29;
            label6.Text = "Category";
            // 
            // cbCat
            // 
            cbCat.BackColor = Color.Transparent;
            cbCat.CustomizableEdges = customizableEdges19;
            cbCat.DrawMode = DrawMode.OwnerDrawFixed;
            cbCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCat.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCat.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCat.ForeColor = Color.FromArgb(68, 88, 112);
            cbCat.ItemHeight = 30;
            cbCat.Location = new Point(18, 357);
            cbCat.Margin = new Padding(3, 4, 3, 4);
            cbCat.Name = "cbCat";
            cbCat.ShadowDecoration.CustomizableEdges = customizableEdges20;
            cbCat.Size = new Size(228, 36);
            cbCat.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 430);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 27;
            label5.Text = "InStock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 536);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 26;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 230);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 23;
            label3.Text = "Price";
            // 
            // txtName
            // 
            txtName.CustomizableEdges = customizableEdges21;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(18, 158);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtName.Size = new Size(229, 48);
            txtName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 121);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(btnClose);
            guna2Panel2.Controls.Add(btnSave);
            guna2Panel2.CustomizableEdges = customizableEdges27;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.FillColor = Color.Gainsboro;
            guna2Panel2.Location = new Point(0, 637);
            guna2Panel2.Margin = new Padding(3, 4, 3, 4);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges28;
            guna2Panel2.Size = new Size(553, 109);
            guna2Panel2.TabIndex = 32;
            // 
            // btnClose
            // 
            btnClose.AutoRoundedCorners = true;
            btnClose.BackColor = Color.Gainsboro;
            btnClose.BorderRadius = 29;
            btnClose.CustomizableEdges = customizableEdges23;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Maroon;
            btnClose.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(385, 17);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnClose.Size = new Size(135, 60);
            btnClose.TabIndex = 1;
            btnClose.Text = "CLOSE";
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.AutoRoundedCorners = true;
            btnSave.BackColor = Color.Gainsboro;
            btnSave.BorderRadius = 29;
            btnSave.CustomizableEdges = customizableEdges25;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(97, 168, 69);
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(14, 17);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnSave.Size = new Size(135, 60);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.Click += btnSave_Click;
            // 
            // rdInStockTrue
            // 
            rdInStockTrue.AutoSize = true;
            rdInStockTrue.Location = new Point(3, 3);
            rdInStockTrue.Name = "rdInStockTrue";
            rdInStockTrue.Size = new Size(92, 24);
            rdInStockTrue.TabIndex = 33;
            rdInStockTrue.TabStop = true;
            rdInStockTrue.Text = "Available";
            rdInStockTrue.UseVisualStyleBackColor = true;
            // 
            // rdInStockFalse
            // 
            rdInStockFalse.AutoSize = true;
            rdInStockFalse.Location = new Point(144, 3);
            rdInStockFalse.Name = "rdInStockFalse";
            rdInStockFalse.Size = new Size(86, 24);
            rdInStockFalse.TabIndex = 34;
            rdInStockFalse.TabStop = true;
            rdInStockFalse.Text = "Sold out";
            rdInStockFalse.UseVisualStyleBackColor = true;
            // 
            // rdStatusFalse
            // 
            rdStatusFalse.AutoSize = true;
            rdStatusFalse.Location = new Point(141, 3);
            rdStatusFalse.Name = "rdStatusFalse";
            rdStatusFalse.Size = new Size(89, 24);
            rdStatusFalse.TabIndex = 35;
            rdStatusFalse.TabStop = true;
            rdStatusFalse.Text = "Not Exist";
            rdStatusFalse.UseVisualStyleBackColor = true;
            // 
            // rdStatusTrue
            // 
            rdStatusTrue.AutoSize = true;
            rdStatusTrue.Location = new Point(6, 3);
            rdStatusTrue.Name = "rdStatusTrue";
            rdStatusTrue.Size = new Size(60, 24);
            rdStatusTrue.TabIndex = 36;
            rdStatusTrue.TabStop = true;
            rdStatusTrue.Text = "Exist";
            rdStatusTrue.UseVisualStyleBackColor = true;
            // 
            // pnlInStock
            // 
            pnlInStock.Controls.Add(rdInStockFalse);
            pnlInStock.Controls.Add(rdInStockTrue);
            pnlInStock.Location = new Point(17, 468);
            pnlInStock.Name = "pnlInStock";
            pnlInStock.Size = new Size(250, 50);
            pnlInStock.TabIndex = 37;
            // 
            // pnlStatus
            // 
            pnlStatus.Controls.Add(rdStatusFalse);
            pnlStatus.Controls.Add(rdStatusTrue);
            pnlStatus.Location = new Point(20, 571);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(250, 42);
            pnlStatus.TabIndex = 38;
            // 
            // image
            // 
            image.Location = new Point(354, 208);
            image.Name = "image";
            image.Size = new Size(166, 166);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 39;
            image.TabStop = false;
            // 
            // numPrice
            // 
            numPrice.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numPrice.Location = new Point(18, 272);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(229, 27);
            numPrice.TabIndex = 40;
            // 
            // AddNewItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 746);
            Controls.Add(numPrice);
            Controls.Add(image);
            Controls.Add(pnlStatus);
            Controls.Add(pnlInStock);
            Controls.Add(guna2Panel2);
            Controls.Add(btnBrowse);
            Controls.Add(label6);
            Controls.Add(cbCat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewItem";
            Text = "AddNewItem";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            pnlInStock.ResumeLayout(false);
            pnlInStock.PerformLayout();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbCat;
        private Label label5;
        private Label label4;
        private Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txtPrice;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        private Label label2;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private RadioButton rdInStockTrue;
        private RadioButton rdInStockFalse;
        private RadioButton rdStatusFalse;
        private RadioButton rdStatusTrue;
        private Panel pnlInStock;
        private Panel pnlStatus;
        private PictureBox image;
        private NumericUpDown numPrice;
    }
}