using Coffee_Manage.DAO;
using Coffee_Manage.DTO;
using Coffee_Manage.Solu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coffee_Manage
{
    public partial class Admin : Form
    {
        BindingSource foodlist = new BindingSource();
        BindingSource acclist = new BindingSource();
        public Account acc;
        public Admin()
        {
            InitializeComponent();
            load();
            insertacc += Admin_insertacc;
            updateacc += Admin_updateacc;
            deleteacc += Admin_deleteacc;
        }

        
        #region method

        private void load()
        {
            dtgvThucAn.DataSource = foodlist;
            dtgvTK.DataSource = acclist;
            loadtimepicker();
            loaddoanhthu(dtpkBeginDay.Value, dtpkEndDay.Value,1);
            loadfood();
            loadacc();
            loadcategory(cbbDanhMuc);
            loadfoodbinding();
            loadaccbinding();
        }

        private void Admin_updateacc(object sender, EventArgs e)
        {
            loadacc();
        }
        private void Admin_insertacc(object sender, EventArgs e)
        {
            loadacc();
        }
        private void Admin_deleteacc(object sender, EventArgs e)
        {
            loadacc();
        }

        private void loaddoanhthu(DateTime checkin,DateTime checkout,int pagenum)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetDoanhThuAndPage(checkin, checkout,pagenum);
        }
        private void loadtimepicker() {
            DateTime today = DateTime.Now;
            dtpkBeginDay.Value = new DateTime(today.Year, today.Month, 1);
            dtpkEndDay.Value = dtpkBeginDay.Value.AddMonths(1).AddDays(-1);
        }
        private void loadfood()
        {
            foodlist.DataSource = FoodDAO.Instance.GetallFood();
        }

        private void loadfoodbinding()
        {
            txbTAID.DataBindings.Add(new Binding("Text", dtgvThucAn.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbTATenMon.DataBindings.Add(new Binding("Text", dtgvThucAn.DataSource, "TenMonAn", true, DataSourceUpdateMode.Never));
            txbTAGia.DataBindings.Add(new Binding("Text", dtgvThucAn.DataSource, "Price", true, DataSourceUpdateMode.Never));
            txbDonVi.DataBindings.Add(new Binding("Text", dtgvThucAn.DataSource, "Unit", true, DataSourceUpdateMode.Never));
        }

        private void loadaccbinding()
        {
            txbTenTaiKhoan.DataBindings.Add(new Binding("Text", dtgvTK.DataSource, "id",true, DataSourceUpdateMode.Never));
            txbTenHienThi.DataBindings.Add(new Binding("Text", dtgvTK.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txbLoaiTaiKhoan.DataBindings.Add(new Binding("Text", dtgvTK.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        private void loadcategory(ComboBox cb)
        {
            cb.DataSource = FoodCategoryDAO.instance.GetListFoodCategory();
            cb.DisplayMember = "Name";
        }

        private DataTable GetFoodSearch(string name)
        {
            DataTable getlistfoodSearch = FoodDAO.Instance.GetFoodSearch(name);
            return getlistfoodSearch;
        }
        
        private void loadacc()
        {
            acclist.DataSource = AccountDAO.Instance.getlistacc();
        }
        #endregion

        #region event
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            loaddoanhthu(dtpkBeginDay.Value, dtpkEndDay.Value, Convert.ToInt32(txbCurrentPage.Text));
        }
        private void btnXemMonAn_Click(object sender, EventArgs e)
        {
            loadfood();
        }

        private void txbTAID_TextChanged(object sender, EventArgs e)
        {
            int id = 0;
            Int32.TryParse(txbTAID.Text, out id);
            foodcategory cate = FoodCategoryDAO.Instance.GetFoodCategory(id);
            if(cate != null)
            {
                int index = -1;
                int i = 0;
                foreach (foodcategory item in cbbDanhMuc.Items)
                {
                    if (item.Id == cate.Id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbbDanhMuc.SelectedIndex = index;
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string name = txbTATenMon.Text;
            float price = float.Parse(txbTAGia.Text);
            int idfoodcategory = ((foodcategory)(cbbDanhMuc.SelectedItem)).Id;
            string unit = txbDonVi.Text;
            if (FoodDAO.Instance.insertFood(name, idfoodcategory, price, unit))
            {
                MessageBox.Show("Thêm món thành công !");
                insertfood?.Invoke(this, new EventArgs());
                loadfood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món");
            }
        }

        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbTAID.Text);
            string name = txbTATenMon.Text;
            float price = float.Parse(txbTAGia.Text);
            int idfoodcategory = ((foodcategory)(cbbDanhMuc.SelectedItem)).Id;
            string unit = txbDonVi.Text;
            if (FoodDAO.Instance.updatefood(id, name, idfoodcategory, price, unit))
            {
                MessageBox.Show("Cập nhật thành công !");
                updatefood?.Invoke(this, new EventArgs());
                loadfood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật");
            }
        }

        private void BtnXoaMonAn_Click(object sender, EventArgs e)
        {
            int idfood = int.Parse(txbTAID.Text);
            if (FoodDAO.Instance.deletefood(idfood))
            {
                MessageBox.Show("Xóa món thành công");
                deletefood?.Invoke(this, new EventArgs());
                loadfood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món");
            }
        }

        public event EventHandler insertfood;
        public event EventHandler updatefood;
        public event EventHandler deletefood;
        private event EventHandler insertacc;
        private event EventHandler updateacc;
        private event EventHandler deleteacc;

        private void btnTimMonAn_Click(object sender, EventArgs e)
        {
            foodlist.DataSource =  GetFoodSearch(txbTAsearch.Text);
        }

        private void btnTKXem_Click(object sender, EventArgs e)
        {
            loadacc();
        }
        private void btnTKThem_Click_1(object sender, EventArgs e)
        {
            string taikhoan = txbTenTaiKhoan.Text;
            string displayname = txbTenHienThi.Text;
            int type = Int32.Parse(txbLoaiTaiKhoan.Text);
            if (AccountDAO.Instance.InsertAccount(taikhoan, displayname, type))
            {
                MessageBox.Show("Thêm tài khoản thành công !");
                insertacc?.Invoke(this, new EventArgs());
            }
        }

        private void btnTKSua_Click(object sender, EventArgs e)
        {
            string taikhoan = txbTenTaiKhoan.Text;
            string displayname = txbTenHienThi.Text;
            int type = Int32.Parse(txbLoaiTaiKhoan.Text);
            if (AccountDAO.Instance.UpdateAccount(taikhoan, displayname, type))
            {
                MessageBox.Show("Sửa tài khoản thành công !");
                updateacc?.Invoke(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Tài Khoản không tồn tại !");
            }
        }

        private void btnTKXoa_Click(object sender, EventArgs e)
        {
            string taikhoan = txbTenTaiKhoan.Text;
            if (acc.Username == taikhoan)
            {
                MessageBox.Show("Tính tự hủy hả ?");
                
            }
            else
            {
                if(AccountDAO.Instance.DeleteAccount(taikhoan)) 
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                    deleteacc?.Invoke(this, new EventArgs());
                }
            }
        }


        #endregion

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            txbCurrentPage.Text = "1";
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int sumpage = BillDAO.Instance.Gettongsoluongbill(dtpkBeginDay.Value, dtpkEndDay.Value);
            int pagequantity = sumpage / 10;
            if(pagequantity % 10 != 0) {
                pagequantity++;
            }
            txbCurrentPage.Text = pagequantity.ToString();
        }

        private void txbCurrentPage_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetDoanhThuAndPage(dtpkBeginDay.Value, dtpkEndDay.Value,Convert.ToInt32(txbCurrentPage.Text));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentpage = Int32.Parse(txbCurrentPage.Text);
            int tong = BillDAO.Instance.Gettongsoluongbill(dtpkBeginDay.Value, dtpkEndDay.Value);
            if(currentpage < tong)
            {
                currentpage++;
            }
            txbCurrentPage.Text = currentpage.ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int currentpage = Int32.Parse(txbCurrentPage.Text);
            int tong = BillDAO.Instance.Gettongsoluongbill(dtpkBeginDay.Value, dtpkEndDay.Value);
            if (currentpage > 0)
            {
                currentpage--;
            }
            txbCurrentPage.Text = currentpage.ToString();
        }
    }
}
