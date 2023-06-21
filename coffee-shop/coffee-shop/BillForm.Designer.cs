namespace coffee_shop_test
{
    partial class BillForm
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
            pictureBox1 = new PictureBox();
            lbAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            lbHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbPhone = new Label();
            lbDate = new Label();
            label1 = new Label();
            lbStaff = new Label();
            lbStaffName = new Label();
            dgvBill = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            lbTotal = new Label();
            lbTotalMoney = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            lbThank = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._85ad31423a2f46088371f76bde18d181;
            pictureBox1.Location = new Point(119, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = false;
            lbAddress.BackColor = Color.Transparent;
            lbAddress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbAddress.Location = new Point(45, 156);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(364, 46);
            lbAddress.TabIndex = 2;
            lbAddress.Text = "Nhà văn hóa sinh viên ĐHQG, Đ. Quảng Trường Sáng Tạo, Đông Hoà, Dĩ An, Bình Dương";
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.Black;
            guna2Separator1.Location = new Point(12, 219);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(397, 12);
            guna2Separator1.TabIndex = 3;
            // 
            // lbHeader
            // 
            lbHeader.BackColor = Color.Transparent;
            lbHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbHeader.Location = new Point(183, 237);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(41, 30);
            lbHeader.TabIndex = 4;
            lbHeader.Text = "BILL";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPhone.Location = new Point(153, 205);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(123, 20);
            lbPhone.TabIndex = 5;
            lbPhone.Text = "Tel: 01239875645";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(23, 283);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(151, 20);
            lbDate.TabIndex = 6;
            lbDate.Text = "Billing date and time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 283);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 7;
            label1.Text = "21/06/2023 21:00:00";
            // 
            // lbStaff
            // 
            lbStaff.AutoSize = true;
            lbStaff.Location = new Point(23, 318);
            lbStaff.Name = "lbStaff";
            lbStaff.Size = new Size(60, 20);
            lbStaff.TabIndex = 8;
            lbStaff.Text = "Cashier:";
            // 
            // lbStaffName
            // 
            lbStaffName.AutoSize = true;
            lbStaffName.Location = new Point(211, 318);
            lbStaffName.Name = "lbStaffName";
            lbStaffName.Size = new Size(83, 20);
            lbStaffName.TabIndex = 9;
            lbStaffName.Text = "Quốc Nhân";
            // 
            // dgvBill
            // 
            dgvBill.AllowUserToAddRows = false;
            dgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBill.BackgroundColor = SystemColors.Control;
            dgvBill.BorderStyle = BorderStyle.None;
            dgvBill.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBill.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBill.ColumnHeadersHeight = 28;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { Item, Quantity, Price, Cost });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBill.EnableHeadersVisualStyles = false;
            dgvBill.Location = new Point(12, 358);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvBill.RowHeadersWidth = 51;
            dgvBill.RowTemplate.Height = 29;
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBill.Size = new Size(408, 152);
            dgvBill.TabIndex = 10;
            // 
            // Item
            // 
            Item.HeaderText = "Item";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Qty";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            // 
            // guna2Separator2
            // 
            guna2Separator2.FillColor = Color.Black;
            guna2Separator2.Location = new Point(12, 516);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(397, 12);
            guna2Separator2.TabIndex = 11;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.Location = new Point(12, 558);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(119, 39);
            lbTotal.TabIndex = 14;
            lbTotal.Text = "TOTAL";
            // 
            // lbTotalMoney
            // 
            lbTotalMoney.AutoSize = true;
            lbTotalMoney.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalMoney.ForeColor = Color.Orange;
            lbTotalMoney.Location = new Point(303, 558);
            lbTotalMoney.Name = "lbTotalMoney";
            lbTotalMoney.Size = new Size(106, 39);
            lbTotalMoney.TabIndex = 15;
            lbTotalMoney.Text = "$10.00";
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BackColor = Color.Black;
            guna2ControlBox1.Cursor = Cursors.Hand;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = SystemColors.Control;
            guna2ControlBox1.IconColor = Color.Black;
            guna2ControlBox1.Location = new Point(396, 2);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(33, 28);
            guna2ControlBox1.TabIndex = 16;
            // 
            // lbThank
            // 
            lbThank.AutoSize = true;
            lbThank.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbThank.Location = new Point(119, 631);
            lbThank.Name = "lbThank";
            lbThank.Size = new Size(209, 20);
            lbThank.TabIndex = 17;
            lbThank.Text = "Thank you and see you again";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(145, 668);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 18;
            label2.Text = "Pass Wifi: 88888888";
            // 
            // BillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(432, 739);
            Controls.Add(label2);
            Controls.Add(lbThank);
            Controls.Add(guna2ControlBox1);
            Controls.Add(lbTotalMoney);
            Controls.Add(lbTotal);
            Controls.Add(guna2Separator2);
            Controls.Add(dgvBill);
            Controls.Add(lbStaffName);
            Controls.Add(lbStaff);
            Controls.Add(label1);
            Controls.Add(lbDate);
            Controls.Add(lbPhone);
            Controls.Add(lbHeader);
            Controls.Add(guna2Separator1);
            Controls.Add(lbAddress);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BillForm";
            Text = "BillForm";
            Load += BillForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbAddress;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbHeader;
        private Label lbPhone;
        private Label lbDate;
        private Label label1;
        private Label lbStaff;
        private Label lbStaffName;
        private DataGridView dgvBill;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Cost;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Label lbTotal;
        private Label lbTotalMoney;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label lbThank;
        private Label label2;
    }
}