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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCateogry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCateogry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Green;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCateogry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCateogry.ColumnHeadersHeight = 40;
            dgvCateogry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCateogry.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCateogry.GridColor = Color.FromArgb(231, 229, 255);
            dgvCateogry.Location = new Point(68, 169);
            dgvCateogry.Margin = new Padding(3, 4, 3, 4);
            dgvCateogry.Name = "dgvCateogry";
            dgvCateogry.ReadOnly = true;
            dgvCateogry.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCateogry.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            btnAdd.CustomizableEdges = customizableEdges1;
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
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(99, 60);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.Click += btnAdd_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Separator1.Location = new Point(68, 141);
            guna2Separator1.Margin = new Padding(3, 4, 3, 4);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(939, 20);
            guna2Separator1.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.CustomizableEdges = customizableEdges3;
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
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearch.Size = new Size(291, 48);
            txtSearch.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.CustomizableEdges = customizableEdges5;
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
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            btnDelete.CustomizableEdges = customizableEdges7;
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
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnDelete.Size = new Size(131, 47);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
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