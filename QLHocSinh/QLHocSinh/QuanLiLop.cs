using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHocSinh
{
    public partial class QuanLiLop : Form
    {
        Main f1;
        DBE_QLHS dbe = new DBE_QLHS();
        public QuanLiLop()
        {
            InitializeComponent();
        }
        public QuanLiLop(Main f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public void LoadLop()
        {
            var listLop = from lop in dbe.Table_LopHocs
                          select new
                          {
                              MaLop = lop.MaLop,
                              Khoi = lop.Khoi,
                              TenLop = lop.TenLop,
                              GiaoVien = lop.GiaoVien
                          };
            dataGridViewLopHoc.DataSource = listLop.ToList();

            txbMaLop.DataBindings.Clear();
            txbMaLop.DataBindings.Add(new Binding("Text", dataGridViewLopHoc.DataSource, "MaLop"));
            cbKhoi.DataBindings.Clear();
            cbKhoi.DataBindings.Add(new Binding("Text", dataGridViewLopHoc.DataSource, "Khoi"));
            txbTenLop.DataBindings.Clear();
            txbTenLop.DataBindings.Add(new Binding("Text", dataGridViewLopHoc.DataSource, "TenLop"));
            txbGiaoVien.DataBindings.Clear();
            txbGiaoVien.DataBindings.Add(new Binding("Text", dataGridViewLopHoc.DataSource, "GiaoVien"));
        }

        private void QuanLiLop_Load(object sender, EventArgs e)
        {
            LoadLop();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DBE_QLHS dbe_add = new DBE_QLHS();
            string malop = txbMaLop.Text;
            string tenlop = txbTenLop.Text;
            Table_LopHoc lop = dbe_add.Table_LopHocs.Where(ma => ma.MaLop == malop).SingleOrDefault();
            if (lop != null)
            {
                MessageBox.Show("Mã lớp học đã tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(malop) || string.IsNullOrEmpty(tenlop))
            {
                MessageBox.Show("Mã lớp hoặc tên lớp không được để trống");
                return;
            }
            else
            {
                lop = new Table_LopHoc();
                lop.MaLop = malop;
                lop.TenLop = tenlop;
                lop.Khoi = cbKhoi.Text;
                lop.GiaoVien = txbGiaoVien.Text;
                dbe_add.Table_LopHocs.Add(lop);
                dbe_add.SaveChanges();
                LoadLop();
                MessageBox.Show("Thêm mới lớp học thành công !");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maLop = txbMaLop.Text;
            string tenLop = txbTenLop.Text;
            Table_LopHoc lop = dbe.Table_LopHocs.Where(ma => ma.MaLop == maLop).SingleOrDefault();
            if (lop == null)
            {
                MessageBox.Show("Mã lớp học không tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Mã lớp cần xóa không được để trống");
                return;
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có chắc muốn xóa lớp này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dbe.Table_LopHocs.Remove(lop);
                    dbe.SaveChanges();
                    LoadLop();
                    MessageBox.Show("Xóa lớp học thành công !");
                }              
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DBE_QLHS dbe_sua = new DBE_QLHS();
            string maLop = txbMaLop.Text;
            string tenLop = txbTenLop.Text;
            Table_LopHoc lop = dbe_sua.Table_LopHocs.Where(ma => ma.MaLop == maLop).SingleOrDefault();
            if (lop == null)
            {
                MessageBox.Show("Mã lớp học không tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Mã lớp cần sửa không được để trống");
                return;
            }
            else
            {
                lop.MaLop = maLop;
                lop.TenLop = tenLop;
                lop.Khoi = cbKhoi.Text;
                lop.GiaoVien = txbGiaoVien.Text;
                dbe_sua.SaveChanges();
                LoadLop();
                MessageBox.Show("Cập nhật thông tin lớp học thành công !");
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            this.Hide();
                        
        }
    }
}
