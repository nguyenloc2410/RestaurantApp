namespace Coffee_Manage
{
    partial class fChangePassWord
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
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbMatkhauHienTai = new System.Windows.Forms.TextBox();
            this.lblMatKhauHienTai = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbMatKhauMoi1 = new System.Windows.Forms.TextBox();
            this.lbLMKMoi = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbMatKhauMoi2 = new System.Windows.Forms.TextBox();
            this.lblNhapLaiMK = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnCPThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTaiKhoan);
            this.panel1.Controls.Add(this.lblTaiKhoan);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 41);
            this.panel1.TabIndex = 0;
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(177, 11);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(308, 20);
            this.txbTaiKhoan.TabIndex = 1;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(3, 11);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(76, 17);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.Text = "Tài Khoản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbMatkhauHienTai);
            this.panel2.Controls.Add(this.lblMatKhauHienTai);
            this.panel2.Location = new System.Drawing.Point(13, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 41);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txbMatkhauHienTai
            // 
            this.txbMatkhauHienTai.Location = new System.Drawing.Point(177, 11);
            this.txbMatkhauHienTai.Name = "txbMatkhauHienTai";
            this.txbMatkhauHienTai.Size = new System.Drawing.Size(308, 20);
            this.txbMatkhauHienTai.TabIndex = 1;
            this.txbMatkhauHienTai.UseSystemPasswordChar = true;
            // 
            // lblMatKhauHienTai
            // 
            this.lblMatKhauHienTai.AutoSize = true;
            this.lblMatKhauHienTai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauHienTai.Location = new System.Drawing.Point(3, 11);
            this.lblMatKhauHienTai.Name = "lblMatKhauHienTai";
            this.lblMatKhauHienTai.Size = new System.Drawing.Size(135, 17);
            this.lblMatKhauHienTai.TabIndex = 0;
            this.lblMatKhauHienTai.Text = "Mật Khẩu Hiện Tại";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbMatKhauMoi1);
            this.panel3.Controls.Add(this.lbLMKMoi);
            this.panel3.Location = new System.Drawing.Point(13, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 41);
            this.panel3.TabIndex = 3;
            // 
            // txbMatKhauMoi1
            // 
            this.txbMatKhauMoi1.Location = new System.Drawing.Point(177, 10);
            this.txbMatKhauMoi1.Name = "txbMatKhauMoi1";
            this.txbMatKhauMoi1.Size = new System.Drawing.Size(308, 20);
            this.txbMatKhauMoi1.TabIndex = 1;
            this.txbMatKhauMoi1.UseSystemPasswordChar = true;
            // 
            // lbLMKMoi
            // 
            this.lbLMKMoi.AutoSize = true;
            this.lbLMKMoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLMKMoi.Location = new System.Drawing.Point(3, 10);
            this.lbLMKMoi.Name = "lbLMKMoi";
            this.lbLMKMoi.Size = new System.Drawing.Size(105, 17);
            this.lbLMKMoi.TabIndex = 0;
            this.lbLMKMoi.Text = "Mật Khẩu Mới";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbMatKhauMoi2);
            this.panel4.Controls.Add(this.lblNhapLaiMK);
            this.panel4.Location = new System.Drawing.Point(13, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(523, 41);
            this.panel4.TabIndex = 2;
            // 
            // txbMatKhauMoi2
            // 
            this.txbMatKhauMoi2.Location = new System.Drawing.Point(177, 10);
            this.txbMatKhauMoi2.Name = "txbMatKhauMoi2";
            this.txbMatKhauMoi2.Size = new System.Drawing.Size(308, 20);
            this.txbMatKhauMoi2.TabIndex = 1;
            this.txbMatKhauMoi2.UseSystemPasswordChar = true;
            // 
            // lblNhapLaiMK
            // 
            this.lblNhapLaiMK.AutoSize = true;
            this.lblNhapLaiMK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapLaiMK.Location = new System.Drawing.Point(3, 10);
            this.lblNhapLaiMK.Name = "lblNhapLaiMK";
            this.lblNhapLaiMK.Size = new System.Drawing.Size(168, 17);
            this.lblNhapLaiMK.TabIndex = 0;
            this.lblNhapLaiMK.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(319, 219);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 47);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnCPThoat
            // 
            this.btnCPThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCPThoat.Location = new System.Drawing.Point(423, 219);
            this.btnCPThoat.Name = "btnCPThoat";
            this.btnCPThoat.Size = new System.Drawing.Size(75, 47);
            this.btnCPThoat.TabIndex = 5;
            this.btnCPThoat.Text = "Thoát";
            this.btnCPThoat.UseVisualStyleBackColor = true;
            // 
            // fChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCPThoat;
            this.ClientSize = new System.Drawing.Size(548, 280);
            this.Controls.Add(this.btnCPThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fChangePassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi mật khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fChangePassWord_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbMatkhauHienTai;
        private System.Windows.Forms.Label lblMatKhauHienTai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbMatKhauMoi1;
        private System.Windows.Forms.Label lbLMKMoi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbMatKhauMoi2;
        private System.Windows.Forms.Label lblNhapLaiMK;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnCPThoat;
    }
}