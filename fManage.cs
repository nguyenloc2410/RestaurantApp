using Coffee_Manage.DAO;
using Coffee_Manage.DTO;
using Coffee_Manage.Solu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manage
{
    public partial class fManage : Form
    {
        private object flpTable;
        private Account tk;

        public Account Tk 
        { 
            get => tk;
            set
            {
                tk = value;
                quyenhanadmin(tk.Type);
            }
        }

        public fManage(Account loginaccount)
        {
            InitializeComponent(); 
            this.Tk = loginaccount;
            LoadTable();           
            LoadCategory();
            loadcombotable(cbbswitchtable);
        }
        #region Method
        void quyenhanadmin(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + Tk.Displayname + ")";

        }
        public void LoadTable()
        {
            flpBanAn.Controls.Clear();
            List<Table> listtable = TableDAO.Instance.LoadTableList();
            foreach (var table in listtable)
            {
                Button btn = new Button()
                {
                    Width = TableDAO.tablewidth,
                    Height = TableDAO.tableheight
                };
                flpBanAn.Controls.Add(btn);
                btn.Text = table.Name + "\n" + table.Status;
                btn.Click += Btn_Click;
                btn.Tag = table;
                if (table.Status == "Trống")
                {
                    btn.BackColor = Color.DimGray;
                }
                else
                {
                    btn.BackColor = Color.Chocolate;
                }
            }
        }
        public void showbill(int idTable)
        {
            double tong = 0;
            listBillInfo.Items.Clear();
            List<ThucDon> listbillinfo = MenuDAO.Instance.GetlisMenu(idTable);
            foreach (ThucDon billinfo in listbillinfo)
            {
                ListViewItem lsvitem = new ListViewItem(billinfo.Name.ToString());
                lsvitem.SubItems.Add(billinfo.Unit.ToString());
                lsvitem.SubItems.Add(billinfo.Quantity.ToString());
                lsvitem.SubItems.Add(billinfo.Price.ToString());
                tong += billinfo.Price * billinfo.Quantity;
                listBillInfo.Items.Add(lsvitem);
            }
            txtTongTien.Text = tong.ToString();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((Table)((Button)sender).Tag).Id;
            listBillInfo.Tag = ((Button)sender).Tag;
            showbill(tableID);
        }

        private void LoadCategory()
        {
            List<foodcategory> foodcategories = FoodCategoryDAO.Instance.GetListFoodCategory();
            cbbDanhMucMonAn.DataSource = foodcategories;
            cbbDanhMucMonAn.DisplayMember = "Name";
        }
        
        private void LoadFoodbyCategory(int idcategory)
        {
            List<Food> foodlist = FoodDAO.Instance.GetlisFood(idcategory);
            cbbMonAn.DataSource = foodlist;
            cbbMonAn.DisplayMember = "Name";
        }

        private void cbbDanhMucMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = (ComboBox)sender;
            foodcategory selected = (foodcategory)cb.SelectedItem;
            id = selected.Id;
            LoadFoodbyCategory(id);
        }
        #endregion

        #region Events
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chiTiếtTàiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountDetail fAccountDetail = new fAccountDetail(Tk);
            fAccountDetail.ShowDialog();
        }
        
        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePassWord fChangePassWord = new fChangePassWord();
            fChangePassWord.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.insertfood += Insert_Food;
            admin.updatefood += Update_Food;
            admin.deletefood += Delete_Food;
            admin.acc = tk;
            admin.ShowDialog();
        }
        public void Insert_Food(object sender, EventArgs e)
        {
            LoadFoodbyCategory(((foodcategory)(cbbDanhMucMonAn.SelectedItem)).Id);
        }

        public void Update_Food(object sender, EventArgs e)
        {
            if(listBillInfo.Tag != null)
            {
                showbill(((Table)listBillInfo.Tag).Id);
            }
        }

        public void Delete_Food(object sender, EventArgs e)
        {
            if (listBillInfo.Tag != null)
            {
                showbill(((Table)listBillInfo.Tag).Id);
                LoadTable();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất khỏi tài khoản này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }

        #endregion

        private void listBillInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            Table table = (Table)listBillInfo.Tag;
            if(table == null)
            {
               MessageBox.Show("Vui lòng chọn bàn !");
                return;
            }
            int idbill = BillDAO.Instance.GetidBillUncheck(table.Id);
            int idfood = ((Food)cbbMonAn.SelectedItem).Id;
            int quantity = (int)nmrSoLuongMonAn.Value;
            if (idbill == -1)
            {
                BillDAO.Instance.InsertBill(table.Id);
                BillInFoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), idfood, quantity);
            }
            else
            {
                BillInFoDAO.Instance.InsertBillInfo(idbill, idfood, quantity);
            }
            showbill(table.Id);
            LoadTable();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Table table = (Table)listBillInfo.Tag;
            if(table != null)
            {
                int idbill = BillDAO.Instance.GetidBillUncheck(table.Id);
                int discount = (int)nmrGiamGia.Value;
                float tiengoc = float.Parse(txtTongTien.Text);
                float tongtien = (tiengoc - (tiengoc * discount) / 100);
                if (idbill != -1)
                {
                    DialogResult kq = MessageBox.Show($"Bạn có chắc chắn muốn thanh toán {table.Name} \n Tổng tiền sau giảm giá = {tongtien}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        BillDAO.Instance.ThanhToan(idbill, discount, tongtien, tiengoc);
                        showbill(table.Id);
                    }
                    LoadTable();
                }
            }        
        }

        private void BtnChuyenBan_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show($"Bạn có chắc chắn muốn chuyển bàn {((Table)listBillInfo.Tag).Name} sang {((Table)cbbswitchtable.SelectedItem).Name}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                int table1 = ((Table)listBillInfo.Tag).Id;
                int table2 = ((Table)cbbswitchtable.SelectedItem).Id;
                TableDAO.Instance.switch_table(table1, table2);
            }
            LoadTable();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadcombotable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
    }
}

