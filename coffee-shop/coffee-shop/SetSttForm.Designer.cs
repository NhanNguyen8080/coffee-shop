namespace coffee_shop_test
{
    partial class SetSttForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LayoutPanel = new FlowLayoutPanel();
            lbSetStt = new Label();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            SuspendLayout();
            // 
            // LayoutPanel
            // 
            LayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LayoutPanel.AutoScroll = true;
            LayoutPanel.Location = new Point(3, 96);
            LayoutPanel.Name = "LayoutPanel";
            LayoutPanel.Size = new Size(483, 646);
            LayoutPanel.TabIndex = 0;
            // 
            // lbSetStt
            // 
            lbSetStt.AutoSize = true;
            lbSetStt.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbSetStt.ForeColor = SystemColors.Highlight;
            lbSetStt.Location = new Point(150, 32);
            lbSetStt.Name = "lbSetStt";
            lbSetStt.Size = new Size(179, 46);
            lbSetStt.TabIndex = 1;
            lbSetStt.Text = "Set Status";
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 20;
            btnSave.CustomizableEdges = customizableEdges1;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.Tomato;
            btnSave.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(169, 748);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Size = new Size(160, 41);
            btnSave.TabIndex = 2;
            btnSave.Text = "SAVE";
            btnSave.Click += btnSave_Click;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(422, 12);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 3;
            guna2ControlBox1.Click += guna2ControlBox1_Click;
            // 
            // SetSttForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 801);
            Controls.Add(guna2ControlBox1);
            Controls.Add(btnSave);
            Controls.Add(lbSetStt);
            Controls.Add(LayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SetSttForm";
            Text = "SetSttForm";
            Load += SetSttForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel LayoutPanel;
        private Label lbSetStt;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}