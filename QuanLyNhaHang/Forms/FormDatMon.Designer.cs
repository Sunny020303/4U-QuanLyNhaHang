namespace QuanLyNhaHang.Forms
{
    partial class FormDatMon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTenBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDoiTen = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemBan = new Guna.UI2.WinForms.Guna2Button();
            this.flpBanAn = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbTenBan);
            this.panel1.Controls.Add(this.btnDoiTen);
            this.panel1.Controls.Add(this.btnXoaBan);
            this.panel1.Controls.Add(this.btnThemBan);
            this.panel1.Controls.Add(this.flpBanAn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 654);
            this.panel1.TabIndex = 5;
            // 
            // tbTenBan
            // 
            this.tbTenBan.BorderRadius = 10;
            this.tbTenBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTenBan.DefaultText = "";
            this.tbTenBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTenBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTenBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTenBan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTenBan.Location = new System.Drawing.Point(522, 19);
            this.tbTenBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenBan.Name = "tbTenBan";
            this.tbTenBan.PasswordChar = '\0';
            this.tbTenBan.PlaceholderText = "Nhập tên bàn ";
            this.tbTenBan.SelectedText = "";
            this.tbTenBan.Size = new System.Drawing.Size(413, 60);
            this.tbTenBan.TabIndex = 10;
            this.tbTenBan.Visible = false;
            // 
            // btnDoiTen
            // 
            this.btnDoiTen.BorderRadius = 10;
            this.btnDoiTen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiTen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiTen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiTen.ForeColor = System.Drawing.Color.White;
            this.btnDoiTen.Location = new System.Drawing.Point(359, 19);
            this.btnDoiTen.Margin = new System.Windows.Forms.Padding(10);
            this.btnDoiTen.Name = "btnDoiTen";
            this.btnDoiTen.Size = new System.Drawing.Size(150, 60);
            this.btnDoiTen.TabIndex = 9;
            this.btnDoiTen.Text = "Đổi tên";
            this.btnDoiTen.Click += new System.EventHandler(this.btnDoiTen_Click);
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.BorderRadius = 10;
            this.btnXoaBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaBan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBan.ForeColor = System.Drawing.Color.White;
            this.btnXoaBan.Location = new System.Drawing.Point(189, 19);
            this.btnXoaBan.Margin = new System.Windows.Forms.Padding(10);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(150, 60);
            this.btnXoaBan.TabIndex = 8;
            this.btnXoaBan.Text = "Xóa Bàn";
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click_1);
            // 
            // btnThemBan
            // 
            this.btnThemBan.BorderRadius = 10;
            this.btnThemBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemBan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBan.ForeColor = System.Drawing.Color.White;
            this.btnThemBan.Location = new System.Drawing.Point(19, 19);
            this.btnThemBan.Margin = new System.Windows.Forms.Padding(10);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(150, 60);
            this.btnThemBan.TabIndex = 7;
            this.btnThemBan.Text = "Thêm Bàn";
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // flpBanAn
            // 
            this.flpBanAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBanAn.AutoScroll = true;
            this.flpBanAn.BackColor = System.Drawing.SystemColors.Control;
            this.flpBanAn.Location = new System.Drawing.Point(12, 92);
            this.flpBanAn.Name = "flpBanAn";
            this.flpBanAn.Padding = new System.Windows.Forms.Padding(10);
            this.flpBanAn.Size = new System.Drawing.Size(1258, 549);
            this.flpBanAn.TabIndex = 6;
            // 
            // FormDatMon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.panel1);
            this.Name = "FormDatMon";
            this.Text = "FormBanAn";
            this.Load += new System.EventHandler(this.FormBanAn_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpBanAn;
        private Guna.UI2.WinForms.Guna2TextBox tbTenBan;
        private Guna.UI2.WinForms.Guna2Button btnDoiTen;
        private Guna.UI2.WinForms.Guna2Button btnXoaBan;
        private Guna.UI2.WinForms.Guna2Button btnThemBan;
    }
}