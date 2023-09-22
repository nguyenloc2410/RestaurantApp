using Coffee_Manage.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manage
{
    public partial class fAccountDetail : Form
    {
        bool checkADThoat = false;
        private Account tk;
        public Account Tk
        {
            get => tk;
            set
            {
                tk = value;
                accdetail(tk);
            }
        }
        public fAccountDetail(Account loginaccount)
        {
            InitializeComponent();
            this.Tk = loginaccount;
        }

        
        private void accdetail(Account acc)
        {
            txbTenHienThi.Text = acc.Displayname;
            txbTaiKhoan.Text = acc.Username;
            if (acc.Type == 1) txbChucVu.Text = "Admin";
            else txbChucVu.Text = "Nhân viên";
        }
        private void fAccountDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(checkADThoat == false)
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn thoát ?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        private void txbTenHienThi_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
