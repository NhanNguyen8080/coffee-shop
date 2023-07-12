namespace coffee_shop_test
{
    partial class CategoryManagementForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvCateogry = new Guna.UI2.WinForms.Guna2DataGridView();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            lbCategoryID = new Label();
            txtCategoryID = new TextBox();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCateogry).BeginInit();
            SuspendLayout();
            // 
            // dgvCateogry
            // 
            dgvCateogry.AllowUserToAddRows = false;
            dgvCateogry.AllowUserToDeleteRows = false;
            dgvCateogry.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCateogry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCateogry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Green;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.Green;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvCateogry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvCateogry.ColumnHeadersHeight = 40;
            dgvCateogry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvCateogry.DefaultCellStyle = dataGridViewCellStyle7;
            dgvCateogry.GridColor = Color.FromArgb(231, 229, 255);
            dgvCateogry.Location = new Point(68, 169);
            dgvCateogry.Margin = new Padding(3, 4, 3, 4);
            dgvCateogry.Name = "dgvCateogry";
            dgvCateogry.ReadOnly = true;
            dgvCateogry.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvCateogry.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvCateogry.RowHeadersVisible = false;
            dgvCateogry.RowHeadersWidth = 51;
            dgvCateogry.RowTemplate.Height = 25;
            dgvCateogry.Size = new Size(939, 362);
            dgvCateogry.TabIndex = 10;
            dgvCateogry.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCateogry.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCateogry.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCateogry.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCateogry.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCateogry.ThemeStyle.BackColor = Color.White;
            dgvCateogry.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCateogry.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCateogry.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCateogry.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCateogry.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCateogry.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCateogry.ThemeStyle.HeaderStyle.Height = 40;
            dgvCateogry.ThemeStyle.ReadOnly = true;
            dgvCateogry.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCateogry.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCateogry.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCateogry.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCateogry.ThemeStyle.RowsStyle.Height = 25;
            dgvCateogry.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCateogry.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCateogry.CellContentClick += dgvCateogry_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.CustomizableEdges = customizableEdges9;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(97, 168, 69);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(68, 73);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAdd.Size = new Size(99, 60);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.Click += btnAdd_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(68, 141);
            guna2Separator1.Margin = new Padding(3, 4, 3, 4);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(939, 20);
            guna2Separator1.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.CustomizableEdges = customizableEdges11;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(594, 85);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search Here";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtSearch.Size = new Size(291, 48);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSeatch_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.CustomizableEdges = customizableEdges13;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.FillColor = Color.FromArgb(97, 168, 69);
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(201, 73);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnUpdate.Size = new Size(116, 60);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "UPDATE";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbCategoryID
            // 
            lbCategoryID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(68, 565);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(88, 20);
            lbCategoryID.TabIndex = 25;
            lbCategoryID.Text = "Category ID";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtCategoryID.Location = new Point(167, 562);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(198, 27);
            txtCategoryID.TabIndex = 24;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.CustomizableEdges = customizableEdges15;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Maroon;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(234, 619);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnDelete.Size = new Size(131, 47);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Update Status";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(906, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 49);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // CategoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 737);
            Controls.Add(btnSearch);
            Controls.Add(lbCategoryID);
            Controls.Add(txtCategoryID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvCateogry);
            Controls.Add(btnAdd);
            Controls.Add(guna2Separator1);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryManagementForm";
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)dgvCateogry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvCateogry;
        public Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
        public Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Label lbCategoryID;
        private TextBox txtCategoryID;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Button btnSearch;
    }
}