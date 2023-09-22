namespace Coffee_Manage
{
    partial class fManage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtTàiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmrSoLuongMonAn = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.cbbMonAn = new System.Windows.Forms.ComboBox();
            this.cbbDanhMucMonAn = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBillInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.nmrGiamGia = new System.Windows.Forms.NumericUpDown();
            this.BtnChuyenBan = new System.Windows.Forms.Button();
            this.cbbswitchtable = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.flpBanAn = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuongMonAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtTàiKhoanToolStripMenuItem,
            this.thayĐổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";            // 
            // chiTiếtTàiKhoanToolStripMenuItem
            // 
            this.chiTiếtTàiKhoanToolStripMenuItem.Name = "chiTiếtTàiKhoanToolStripMenuItem";
            this.chiTiếtTàiKhoanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chiTiếtTàiKhoanToolStripMenuItem.Text = "Chi Tiết Tài Khoản";
            this.chiTiếtTàiKhoanToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtTàiKhoanToolStripMenuItem_Click);
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Thay Đổi Mật Khẩu";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmrSoLuongMonAn);
            this.panel2.Controls.Add(this.btnThemMon);
            this.panel2.Controls.Add(this.cbbMonAn);
            this.panel2.Controls.Add(this.cbbDanhMucMonAn);
            this.panel2.Location = new System.Drawing.Point(525, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 82);
            this.panel2.TabIndex = 2;
            // 
            // nmrSoLuongMonAn
            // 
            this.nmrSoLuongMonAn.Location = new System.Drawing.Point(305, 34);
            this.nmrSoLuongMonAn.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrSoLuongMonAn.Name = "nmrSoLuongMonAn";
            this.nmrSoLuongMonAn.Size = new System.Drawing.Size(44, 20);
            this.nmrSoLuongMonAn.TabIndex = 3;
            this.nmrSoLuongMonAn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(223, 12);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(75, 57);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // cbbMonAn
            // 
            this.cbbMonAn.FormattingEnabled = true;
            this.cbbMonAn.Location = new System.Drawing.Point(13, 48);
            this.cbbMonAn.Name = "cbbMonAn";
            this.cbbMonAn.Size = new System.Drawing.Size(203, 21);
            this.cbbMonAn.TabIndex = 1;
            // 
            // cbbDanhMucMonAn
            // 
            this.cbbDanhMucMonAn.FormattingEnabled = true;
            this.cbbDanhMucMonAn.Location = new System.Drawing.Point(13, 12);
            this.cbbDanhMucMonAn.Name = "cbbDanhMucMonAn";
            this.cbbDanhMucMonAn.Size = new System.Drawing.Size(203, 21);
            this.cbbDanhMucMonAn.TabIndex = 0;
            this.cbbDanhMucMonAn.SelectedIndexChanged += new System.EventHandler(this.cbbDanhMucMonAn_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBillInfo);
            this.panel1.Location = new System.Drawing.Point(524, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 329);
            this.panel1.TabIndex = 3;
            // 
            // listBillInfo
            // 
            this.listBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listBillInfo.GridLines = true;
            this.listBillInfo.HideSelection = false;
            this.listBillInfo.LabelWrap = false;
            this.listBillInfo.Location = new System.Drawing.Point(4, 4);
            this.listBillInfo.Name = "listBillInfo";
            this.listBillInfo.Size = new System.Drawing.Size(346, 322);
            this.listBillInfo.TabIndex = 0;
            this.listBillInfo.UseCompatibleStateImageBehavior = false;
            this.listBillInfo.View = System.Windows.Forms.View.Details;
            this.listBillInfo.SelectedIndexChanged += new System.EventHandler(this.listBillInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món Ăn";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn Vị";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 108;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.nmrGiamGia);
            this.panel3.Controls.Add(this.BtnChuyenBan);
            this.panel3.Controls.Add(this.cbbswitchtable);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(525, 451);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 89);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Giảm Giá";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(189, 33);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(78, 20);
            this.txtTongTien.TabIndex = 9;
            // 
            // nmrGiamGia
            // 
            this.nmrGiamGia.Location = new System.Drawing.Point(108, 51);
            this.nmrGiamGia.Name = "nmrGiamGia";
            this.nmrGiamGia.Size = new System.Drawing.Size(75, 20);
            this.nmrGiamGia.TabIndex = 8;
            this.nmrGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnChuyenBan
            // 
            this.BtnChuyenBan.Location = new System.Drawing.Point(13, 14);
            this.BtnChuyenBan.Name = "BtnChuyenBan";
            this.BtnChuyenBan.Size = new System.Drawing.Size(75, 30);
            this.BtnChuyenBan.TabIndex = 5;
            this.BtnChuyenBan.Text = "Chuyển Bàn";
            this.BtnChuyenBan.UseVisualStyleBackColor = true;
            this.BtnChuyenBan.Click += new System.EventHandler(this.BtnChuyenBan_Click);
            // 
            // cbbswitchtable
            // 
            this.cbbswitchtable.FormattingEnabled = true;
            this.cbbswitchtable.Location = new System.Drawing.Point(13, 50);
            this.cbbswitchtable.Name = "cbbswitchtable";
            this.cbbswitchtable.Size = new System.Drawing.Size(75, 21);
            this.cbbswitchtable.TabIndex = 4;
            this.cbbswitchtable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(274, 14);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 57);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // flpBanAn
            // 
            this.flpBanAn.AutoScroll = true;
            this.flpBanAn.Location = new System.Drawing.Point(12, 27);
            this.flpBanAn.Name = "flpBanAn";
            this.flpBanAn.Size = new System.Drawing.Size(506, 513);
            this.flpBanAn.TabIndex = 9;
            // 
            // fManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 552);
            this.Controls.Add(this.flpBanAn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuongMonAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtTàiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmrSoLuongMonAn;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cbbMonAn;
        private System.Windows.Forms.ComboBox cbbDanhMucMonAn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button BtnChuyenBan;
        private System.Windows.Forms.ComboBox cbbswitchtable;
        private System.Windows.Forms.NumericUpDown nmrGiamGia;
        private System.Windows.Forms.FlowLayoutPanel flpBanAn;
        private System.Windows.Forms.ListView listBillInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
    }
}