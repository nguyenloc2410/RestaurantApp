using Coffee_Manage.DTO;
using Coffee_Manage.Solu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manage
{
    public partial class Form1 : Form
    {
        bool checkthoat = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(checkthoat == false)
            {
                checkthoat = true;
                DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes) Application.Exit();
                else checkthoat = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(checkthoat == false)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        private bool login(string username,string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txbTaiKhoan.Text;
            string password = txbMatKhau.Text;
            if (login(username, password))
            {
                Account acc = AccountDAO.Instance.getacc(username);
                fManage f = new fManage(acc);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Sai tài khoản hoặc mật khẩu !","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
