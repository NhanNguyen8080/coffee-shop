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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            lbAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            lbHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbPhone = new Label();
            lb = new Label();
            lbDate = new Label();
            lbStaff = new Label();
            lbStaffName = new Label();
            dgvBill = new DataGridView();
            dgvItem = new DataGridViewTextBoxColumn();
            dgvQty = new DataGridViewTextBoxColumn();
            dgvPrice = new DataGridViewTextBoxColumn();
            dgvCost = new DataGridViewTextBoxColumn();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            lbTotal = new Label();
            lbTotalMoney = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            lbThank = new Label();
            label2 = new Label();
            lbOrderID = new Label();
            lbBillID = new Label();
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
            lbHeader.Location = new Point(192, 228);
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
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(23, 304);
            lb.Name = "lb";
            lb.Size = new Size(151, 20);
            lb.TabIndex = 6;
            lb.Text = "Billing date and time:";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(245, 304);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(143, 20);
            lbDate.TabIndex = 7;
            lbDate.Text = "21/06/2023 21:00:00";
            // 
            // lbStaff
            // 
            lbStaff.AutoSize = true;
            lbStaff.Location = new Point(23, 335);
            lbStaff.Name = "lbStaff";
            lbStaff.Size = new Size(60, 20);
            lbStaff.TabIndex = 8;
            lbStaff.Text = "Cashier:";
            // 
            // lbStaffName
            // 
            lbStaffName.AutoSize = true;
            lbStaffName.Location = new Point(245, 335);
            lbStaffName.Name = "lbStaffName";
            lbStaffName.Size = new Size(83, 20);
            lbStaffName.TabIndex = 9;
            lbStaffName.Text = "Quốc Nhân";
            // 
            // dgvBill
            // 
            dgvBill.AllowUserToAddRows = false;
            dgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBill.BackgroundColor = SystemColors.Control;
            dgvBill.BorderStyle = BorderStyle.None;
            dgvBill.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBill.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvBill.ColumnHeadersHeight = 28;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { dgvItem, dgvQty, dgvPrice, dgvCost });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvBill.DefaultCellStyle = dataGridViewCellStyle7;
            dgvBill.EnableHeadersVisualStyles = false;
            dgvBill.Location = new Point(12, 371);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvBill.RowHeadersWidth = 51;
            dgvBill.RowTemplate.Height = 29;
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBill.Size = new Size(408, 152);
            dgvBill.TabIndex = 10;
            // 
            // dgvItem
            // 
            dgvItem.HeaderText = "Item";
            dgvItem.MinimumWidth = 6;
            dgvItem.Name = "dgvItem";
            // 
            // dgvQty
            // 
            dgvQty.HeaderText = "Qty";
            dgvQty.MinimumWidth = 6;
            dgvQty.Name = "dgvQty";
            // 
            // dgvPrice
            // 
            dgvPrice.HeaderText = "Price";
            dgvPrice.MinimumWidth = 6;
            dgvPrice.Name = "dgvPrice";
            // 
            // dgvCost
            // 
            dgvCost.HeaderText = "Cost";
            dgvCost.MinimumWidth = 6;
            dgvCost.Name = "dgvCost";
            // 
            // guna2Separator2
            // 
            guna2Separator2.FillColor = Color.Black;
            guna2Separator2.Location = new Point(12, 529);
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
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.FillColor = SystemColors.Control;
            guna2ControlBox1.IconColor = Color.Black;
            guna2ControlBox1.Location = new Point(396, 2);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(23, 270);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(52, 20);
            lbOrderID.TabIndex = 19;
            lbOrderID.Text = "Bill ID:";
            // 
            // lbBillID
            // 
            lbBillID.AutoSize = true;
            lbBillID.Location = new Point(245, 270);
            lbBillID.Name = "lbBillID";
            lbBillID.Size = new Size(50, 20);
            lbBillID.TabIndex = 20;
            lbBillID.Text = "label3";
            // 
            // BillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(432, 739);
            Controls.Add(lbBillID);
            Controls.Add(lbOrderID);
            Controls.Add(label2);
            Controls.Add(lbThank);
            Controls.Add(guna2ControlBox1);
            Controls.Add(lbTotalMoney);
            Controls.Add(lbTotal);
            Controls.Add(guna2Separator2);
            Controls.Add(dgvBill);
            Controls.Add(lbStaffName);
            Controls.Add(lbStaff);
            Controls.Add(lbDate);
            Controls.Add(lb);
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
        private Label lb;
        private Label lbDate;
        private Label lbStaff;
        private Label lbStaffName;
        private DataGridView dgvBill;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Label lbTotal;
        private Label lbTotalMoney;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label lbThank;
        private Label label2;
        private Label lbOrderID;
        private Label lbBillID;
        private DataGridViewTextBoxColumn dgvItem;
        private DataGridViewTextBoxColumn dgvQty;
        private DataGridViewTextBoxColumn dgvPrice;
        private DataGridViewTextBoxColumn dgvCost;
    }
}