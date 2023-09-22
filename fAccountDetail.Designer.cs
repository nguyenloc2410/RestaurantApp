namespace Coffee_Manage
{
    partial class fAccountDetail
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
            this.lblTenHienThi = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txbTenHienThi = new System.Windows.Forms.TextBox();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.txbChucVu = new System.Windows.Forms.TextBox();
            this.btnACDTthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenHienThi
            // 
            this.lblTenHienThi.AutoSize = true;
            this.lblTenHienThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHienThi.Location = new System.Drawing.Point(32, 16);
            this.lblTenHienThi.Name = "lblTenHienThi";
            this.lblTenHienThi.Size = new System.Drawing.Size(102, 19);
            this.lblTenHienThi.TabIndex = 0;
            this.lblTenHienThi.Text = "Tên Hiển Thị:";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(32, 76);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(84, 19);
            this.lblTaiKhoan.TabIndex = 1;
            this.lblTaiKhoan.Text = "Tài Khoản:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(32, 140);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(73, 19);
            this.lblChucVu.TabIndex = 2;
            this.lblChucVu.Text = "Chức Vụ:";
            // 
            // txbTenHienThi
            // 
            this.txbTenHienThi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenHienThi.Location = new System.Drawing.Point(159, 13);
            this.txbTenHienThi.Name = "txbTenHienThi";
            this.txbTenHienThi.ReadOnly = true;
            this.txbTenHienThi.Size = new System.Drawing.Size(252, 22);
            this.txbTenHienThi.TabIndex = 3;
            this.txbTenHienThi.TextChanged += new System.EventHandler(this.txbTenHienThi_TextChanged);
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaiKhoan.Location = new System.Drawing.Point(159, 75);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.ReadOnly = true;
            this.txbTaiKhoan.Size = new System.Drawing.Size(252, 22);
            this.txbTaiKhoan.TabIndex = 4;
            // 
            // txbChucVu
            // 
            this.txbChucVu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbChucVu.Location = new System.Drawing.Point(159, 140);
            this.txbChucVu.Name = "txbChucVu";
            this.txbChucVu.ReadOnly = true;
            this.txbChucVu.Size = new System.Drawing.Size(252, 22);
            this.txbChucVu.TabIndex = 5;
            // 
            // btnACDTthoat
            // 
            this.btnACDTthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnACDTthoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACDTthoat.Location = new System.Drawing.Point(336, 184);
            this.btnACDTthoat.Name = "btnACDTthoat";
            this.btnACDTthoat.Size = new System.Drawing.Size(75, 40);
            this.btnACDTthoat.TabIndex = 6;
            this.btnACDTthoat.Text = "Thoát";
            this.btnACDTthoat.UseVisualStyleBackColor = true;
            // 
            // fAccountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnACDTthoat;
            this.ClientSize = new System.Drawing.Size(452, 236);
            this.Controls.Add(this.btnACDTthoat);
            this.Controls.Add(this.txbChucVu);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.txbTenHienThi);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.lblTenHienThi);
            this.Name = "fAccountDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAccountDetail_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenHienThi;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txbTenHienThi;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.TextBox txbChucVu;
        private System.Windows.Forms.Button btnACDTthoat;
    }
}