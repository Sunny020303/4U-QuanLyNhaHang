namespace QuanLyNhaHang.Forms
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnOption = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Name1 = new System.Windows.Forms.Label();
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Name2 = new System.Windows.Forms.Label();
            this.btnBanAn = new FontAwesome.Sharp.IconButton();
            this.btnMonAn = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.pnTitle = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnView = new System.Windows.Forms.Panel();
            this.pnOption.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1560, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1520, 0);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(40, 40);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // pnOption
            // 
            this.pnOption.Controls.Add(this.guna2GradientPanel1);
            this.pnOption.Controls.Add(this.btnBanAn);
            this.pnOption.Controls.Add(this.btnMonAn);
            this.pnOption.Controls.Add(this.btnNhanVien);
            this.pnOption.Controls.Add(this.btnThongKe);
            this.pnOption.Controls.Add(this.btnTaiKhoan);
            this.pnOption.Location = new System.Drawing.Point(0, 0);
            this.pnOption.Name = "pnOption";
            this.pnOption.Size = new System.Drawing.Size(200, 1000);
            this.pnOption.TabIndex = 5;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.Name1);
            this.guna2GradientPanel1.Controls.Add(this.logo);
            this.guna2GradientPanel1.Controls.Add(this.Name2);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 100);
            this.guna2GradientPanel1.TabIndex = 6;
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.Location = new System.Drawing.Point(77, 24);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(74, 26);
            this.Name1.TabIndex = 6;
            this.Name1.Text = "Cook";
            // 
            // logo
            // 
            this.logo.FillColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::QuanLyNhaHang.Properties.Resources._1672157227358;
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(0, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(94, 91);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name2.Location = new System.Drawing.Point(100, 50);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(74, 26);
            this.Name2.TabIndex = 7;
            this.Name2.Text = "Cook";
            // 
            // btnBanAn
            // 
            this.btnBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanAn.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnBanAn.IconColor = System.Drawing.Color.Black;
            this.btnBanAn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBanAn.Location = new System.Drawing.Point(0, 100);
            this.btnBanAn.Margin = new System.Windows.Forms.Padding(0);
            this.btnBanAn.Name = "btnBanAn";
            this.btnBanAn.Size = new System.Drawing.Size(200, 180);
            this.btnBanAn.TabIndex = 7;
            this.btnBanAn.Text = "Đặt món";
            this.btnBanAn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBanAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBanAn.UseVisualStyleBackColor = true;
            this.btnBanAn.Click += new System.EventHandler(this.btnBanAn_Click);
            // 
            // btnMonAn
            // 
            this.btnMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonAn.IconChar = FontAwesome.Sharp.IconChar.BowlRice;
            this.btnMonAn.IconColor = System.Drawing.Color.Black;
            this.btnMonAn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonAn.Location = new System.Drawing.Point(0, 280);
            this.btnMonAn.Margin = new System.Windows.Forms.Padding(0);
            this.btnMonAn.Name = "btnMonAn";
            this.btnMonAn.Size = new System.Drawing.Size(200, 180);
            this.btnMonAn.TabIndex = 8;
            this.btnMonAn.Text = "Món ăn";
            this.btnMonAn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMonAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMonAn.UseVisualStyleBackColor = true;
            this.btnMonAn.Click += new System.EventHandler(this.btnMonAn_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnNhanVien.IconColor = System.Drawing.Color.Black;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 460);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(200, 180);
            this.btnNhanVien.TabIndex = 9;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnThongKe.IconColor = System.Drawing.Color.Black;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.Location = new System.Drawing.Point(0, 640);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(200, 180);
            this.btnThongKe.TabIndex = 10;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnTaiKhoan.IconColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 820);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(200, 180);
            this.btnTaiKhoan.TabIndex = 11;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTitle.Controls.Add(this.guna2ControlBox1);
            this.pnTitle.Controls.Add(this.guna2ControlBox3);
            this.pnTitle.Location = new System.Drawing.Point(200, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1600, 100);
            this.pnTitle.TabIndex = 6;
            // 
            // pnView
            // 
            this.pnView.Location = new System.Drawing.Point(200, 100);
            this.pnView.Margin = new System.Windows.Forms.Padding(0);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(1600, 900);
            this.pnView.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1800, 1000);
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pnOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnOption.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.FlowLayoutPanel pnOption;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label Name1;
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private System.Windows.Forms.Label Name2;
        private FontAwesome.Sharp.IconButton btnBanAn;
        private FontAwesome.Sharp.IconButton btnMonAn;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private Guna.UI2.WinForms.Guna2GradientPanel pnTitle;
        private System.Windows.Forms.Panel pnView;
    }
}