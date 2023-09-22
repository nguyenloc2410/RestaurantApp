using Coffee_Manage.Solu;
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
    public partial class fChangePassWord : Form
    {
        public fChangePassWord()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void update()
        {
            string taikhoan = txbTaiKhoan.Text;
            string pass = txbMatkhauHienTai.Text;
            string newpass1 = txbMatKhauMoi1.Text;
            string newpass2 = txbMatKhauMoi2.Text;
            if(!newpass1.Equals(newpass2))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu khớp với mật khẩu mới !");
            }
            else
            {
                if (AccountDAO.Instance.updatepassword(taikhoan, pass, newpass1)) MessageBox.Show("Cập nhật thành công");
                else MessageBox.Show("Vui lòng điền đúng mật khẩu hiện tại");
            }
        }

        private void fChangePassWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát ?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
