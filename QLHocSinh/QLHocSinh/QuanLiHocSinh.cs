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
    public partial class QuanLiHocSinh : Form
    {
        Main f1;
        DBE_QLHS dbe = new DBE_QLHS();
        public QuanLiHocSinh()
        {
            InitializeComponent();
        }
        public QuanLiHocSinh(Main f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void LoadDB()
        {
            var listHS = from hss in dbe.Table_HocSinh
                         select new 
                         {
                             MaHS = hss.MaHS,
                             TenHocSinh = hss.TenHocSinh,
                             GioiTinh = hss.GioiTinh,
                             NgaySinh = hss.NgaySinh,
                             Sdt = hss.Sdt,
                             DiaChi = hss.DiaChi,
                             Khoi = hss.Table_LopHoc.Khoi,
                             TenLop = hss.Table_LopHoc.TenLop,
                             GiaoVien = hss.Table_LopHoc.GiaoVien,
                             Toan = hss.Table_BangDiem.Toan,
                             Ly = hss.Table_BangDiem.Ly,
                             Hoa = hss.Table_BangDiem.Hoa,
                             TiengAnh = hss.Table_BangDiem.TiengAnh,
                             Gdcd = hss.Table_BangDiem.Gdcd,
                             Van = hss.Table_BangDiem.Van,
                             Su = hss.Table_BangDiem.Su,
                             Dia = hss.Table_BangDiem.Dia,
                             CongNghe = hss.Table_BangDiem.CongNghe,
                             TinHoc = hss.Table_BangDiem.TinHoc


                         };
            datagridvewHocSinh.DataSource = listHS.ToList();
            //DataBindings thông tin học sinh
            tbMaHs.DataBindings.Clear();
            tbMaHs.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "MaHS"));
            tbTenHs.DataBindings.Clear();
            tbTenHs.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "TenHocSinh"));
            CbGioiTinh.DataBindings.Clear();
            CbGioiTinh.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "GioiTinh"));
            dateNgaySinh.DataBindings.Clear();
            dateNgaySinh.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "NgaySinh"));
            tbSdt.DataBindings.Clear();
            tbSdt.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "Sdt"));
            tbDiaChi.DataBindings.Clear();
            tbDiaChi.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "DiaChi"));
            //DataBindings thông tin lớp học
            txtKhoi.DataBindings.Clear();
            txtKhoi.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "Khoi"));
            txtLop.DataBindings.Clear();
            txtLop.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "TenLop"));
            tbGV.DataBindings.Clear();
            tbGV.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "GiaoVien"));
            //DataBindings thông tin điểm
            tbToan.DataBindings.Clear();
            tbToan.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "Toan"));
            tbLy.DataBindings.Clear();
            tbLy.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "Ly"));
            tbHoa.DataBindings.Clear();
            tbHoa.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "Hoa"));
            tbTiengAnh.DataBindings.Clear();
            tbTiengAnh.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "TiengAnh"));
            tbGdcd.DataBindings.Clear();
            tbGdcd.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "Gdcd"));
            tbVan.DataBindings.Clear();
            tbVan.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "Van"));
            tbSu.DataBindings.Clear();
            tbSu.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "Su"));
            tbDia.DataBindings.Clear();
            tbDia.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "Dia"));
            tbCongNghe.DataBindings.Clear();
            tbCongNghe.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "CongNghe"));
            tbTinHoc.DataBindings.Clear();
            tbTinHoc.DataBindings.Add(new Binding("Text", datagridvewHocSinh.DataSource, "TinHoc"));
            
        }

        private double TinhDiemTB()
        {
            double toan = double.Parse(tbToan.Text);
            double ly = double.Parse(tbLy.Text);
            double hoa = double.Parse(tbHoa.Text);
            double ta = double.Parse(tbTiengAnh.Text);
            double gdcd = double.Parse(tbGdcd.Text);
            double van = double.Parse(tbVan.Text);
            double su = double.Parse(tbSu.Text);
            double dia = double.Parse(tbDia.Text);
            double cn = double.Parse(tbCongNghe.Text);
            double tin = double.Parse(tbTinHoc.Text);

            return (toan + ly + hoa + ta + gdcd + van + su + dia + cn + tin) / 10;
        }
        private void QuanLiHocSinh_Load(object sender, EventArgs e)
        {
            LoadDB();
            tbDiemTB.Text = TinhDiemTB().ToString();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            QuanLyDiem qld = new QuanLyDiem(this);
            qld.Show();
            this.Hide();           
        }

        private void datagridvewHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(tbToan.Text!="" && tbVan.Text!=""&& tbTiengAnh.Text!="" && tbLy.Text!="" && tbHoa.Text!=""
                && tbSu.Text!=""&& tbDia.Text!=""&& tbCongNghe.Text!="" && tbGdcd.Text!="" && tbTinHoc.Text!="")
            {
                tbDiemTB.Text = TinhDiemTB().ToString();
            }
            else
            {
                tbDiemTB.Text = "Thiếu điểm !";
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DBE_QLHS dbe_add_hs = new DBE_QLHS(); 
            string mahs = tbMaHs.Text;
            string tenhs = tbTenHs.Text;
            string gioitinh = CbGioiTinh.Text;
            string sodt = tbSdt.Text;
            string diachi = tbDiaChi.Text;
            Table_HocSinh hs = dbe_add_hs.Table_HocSinh.Where(mah => mah.MaHS == mahs).SingleOrDefault();
            if (hs != null)
            {
                MessageBox.Show("Mã học sinh đã tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(mahs))
            {
                MessageBox.Show("Mã học sinh không được để trống !");
                return;
            }
            else if (string.IsNullOrEmpty(tenhs))
            {
                MessageBox.Show("Tên học sinh không được để trống !");
                return;
            }
            else if (string.IsNullOrEmpty(gioitinh))
            {
                MessageBox.Show("Yêu cầu chọn giới tính !");
                return;
            }
            else if (string.IsNullOrEmpty(sodt) || sodt.Length < 10 || sodt.Length > 10)
            {
                MessageBox.Show("Kiểm tra lại số điện thoại ! \nBạn chưa nhập hoặc nhập sai số điện thoại.");
                return;
            }
            else if (string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Hãy nhập địa chỉ !");
                return;
            }                      
            else
            {
                hs = new Table_HocSinh();
                hs.MaHS = mahs;
                hs.TenHocSinh = tenhs;
                hs.GioiTinh = gioitinh;
                hs.NgaySinh = dateNgaySinh.Value;
                hs.Sdt = sodt;
                hs.DiaChi = diachi;
                dbe_add_hs.Table_HocSinh.Add(hs);
                dbe_add_hs.SaveChanges();
                LoadDB();
                MessageBox.Show("Thêm mới học sinh thành công !");
            }
        }

        private void btnXepLop_Click(object sender, EventArgs e)
        {
            XepLopHoc xl = new XepLopHoc(this);
            xl.Show();
            this.Hide();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
                Main f1 = new Main();
                f1.Show();
                this.Hide();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DBE_QLHS dbe_edit_hs = new DBE_QLHS();
            string mahs = tbMaHs.Text;
            string tenhs = tbTenHs.Text;
            string gioitinh = CbGioiTinh.Text;
            string sodt = tbSdt.Text;
            string diachi = tbDiaChi.Text;
            Table_HocSinh hss = dbe_edit_hs.Table_HocSinh.Where(ma => ma.MaHS == mahs).SingleOrDefault();
            if (hss == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(mahs))
            {
                MessageBox.Show("Mã sinh viên cần sửa không được trống");
                return;
            }
            else
            {
                hss.TenHocSinh = tenhs;
                hss.GioiTinh = gioitinh;
                hss.NgaySinh = dateNgaySinh.Value;
                hss.Sdt = sodt;
                hss.DiaChi = diachi;
                dbe_edit_hs.SaveChanges();
                LoadDB();
                MessageBox.Show("Cập nhật thông tin sinh viên thành công !");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DBE_QLHS dbe_remove_hs = new DBE_QLHS();
            string mahs = tbMaHs.Text;
            string tenhs = tbTenHs.Text;
            string gioitinh = CbGioiTinh.Text;
            string sodt = tbSdt.Text;
            string diachi = tbDiaChi.Text;
            Table_HocSinh hss = dbe_remove_hs.Table_HocSinh.Where(ma => ma.MaHS == mahs).SingleOrDefault();
            if (hss == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(mahs))
            {
                MessageBox.Show("Mã sinh viên cần sửa không được trống");
                return;
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dbe_remove_hs.Table_HocSinh.Remove(hss);
                    dbe_remove_hs.SaveChanges();
                    LoadDB();
                    MessageBox.Show("Xóa sinh viên thành công !");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DBE_QLHS dbe_search = new DBE_QLHS();
            if(txbsearch.Text == "all" || txbsearch.Text == "AL" || txbsearch.Text == "tat ca" || txbsearch.Text == "tất cả" || txbsearch.Text == "TAT CA" || txbsearch.Text == "TẤT CẢ" || txbsearch.Text == "tatca" || txbsearch.Text == "TATCA" || txbsearch.Text == "tc" || txbsearch.Text == "TC")
            {
                LoadDB();
            }
            else if (txbsearch.Text[0] == '1')
            {
                var timlop = from hss in dbe_search.Table_HocSinh
                          where hss.Table_LopHoc.TenLop == txbsearch.Text
                          select new
                          {
                              MaHS = hss.MaHS,
                              TenHocSinh = hss.TenHocSinh,
                              GioiTinh = hss.GioiTinh,
                              NgaySinh = hss.NgaySinh,
                              Sdt = hss.Sdt,
                              DiaChi = hss.DiaChi,
                              Khoi = hss.Table_LopHoc.Khoi,
                              TenLop = hss.Table_LopHoc.TenLop,
                              GiaoVien = hss.Table_LopHoc.GiaoVien,
                              Toan = hss.Table_BangDiem.Toan,
                              Ly = hss.Table_BangDiem.Ly,
                              Hoa = hss.Table_BangDiem.Hoa,
                              TiengAnh = hss.Table_BangDiem.TiengAnh,
                              Gdcd = hss.Table_BangDiem.Gdcd,
                              Van = hss.Table_BangDiem.Van,
                              Su = hss.Table_BangDiem.Su,
                              Dia = hss.Table_BangDiem.Dia,
                              CongNghe = hss.Table_BangDiem.CongNghe,
                              TinHoc = hss.Table_BangDiem.TinHoc

                          };
                Table_HocSinh hs = dbe_search.Table_HocSinh.Where(h => h.Table_LopHoc.TenLop == txbsearch.Text).FirstOrDefault();
                if (hs == null)
                {
                    MessageBox.Show("Lớp học không tồn tại !");
                    return;
                }
                datagridvewHocSinh.DataSource = timlop.ToList();
            }
            else if (txbsearch.Text[0] == 'H' && txbsearch.Text[1] == 'S')
            {
                var mahss = from hss in dbe_search.Table_HocSinh
                            where hss.MaHS == txbsearch.Text
                            select new
                            {
                                MaHS = hss.MaHS,
                                TenHocSinh = hss.TenHocSinh,
                                GioiTinh = hss.GioiTinh,
                                NgaySinh = hss.NgaySinh,
                                Sdt = hss.Sdt,
                                DiaChi = hss.DiaChi,
                                Khoi = hss.Table_LopHoc.Khoi,
                                TenLop = hss.Table_LopHoc.TenLop,
                                GiaoVien = hss.Table_LopHoc.GiaoVien,
                                Toan = hss.Table_BangDiem.Toan,
                                Ly = hss.Table_BangDiem.Ly,
                                Hoa = hss.Table_BangDiem.Hoa,
                                TiengAnh = hss.Table_BangDiem.TiengAnh,
                                Gdcd = hss.Table_BangDiem.Gdcd,
                                Van = hss.Table_BangDiem.Van,
                                Su = hss.Table_BangDiem.Su,
                                Dia = hss.Table_BangDiem.Dia,
                                CongNghe = hss.Table_BangDiem.CongNghe,
                                TinHoc = hss.Table_BangDiem.TinHoc


                            };

                Table_HocSinh hs = dbe_search.Table_HocSinh.Where(h => h.MaHS == txbsearch.Text).SingleOrDefault();
                if (hs == null)
                {
                    MessageBox.Show("Học sinh không tồn tại");
                    return;
                }
                datagridvewHocSinh.DataSource = mahss.ToList();
            }
            else
            {
                var tenhss = from hss in dbe_search.Table_HocSinh
                            where hss.TenHocSinh == txbsearch.Text
                            select new
                            {
                                MaHS = hss.MaHS,
                                TenHocSinh = hss.TenHocSinh,
                                GioiTinh = hss.GioiTinh,
                                NgaySinh = hss.NgaySinh,
                                Sdt = hss.Sdt,
                                DiaChi = hss.DiaChi,
                                Khoi = hss.Table_LopHoc.Khoi,
                                TenLop = hss.Table_LopHoc.TenLop,
                                GiaoVien = hss.Table_LopHoc.GiaoVien,
                                Toan = hss.Table_BangDiem.Toan,
                                Ly = hss.Table_BangDiem.Ly,
                                Hoa = hss.Table_BangDiem.Hoa,
                                TiengAnh = hss.Table_BangDiem.TiengAnh,
                                Gdcd = hss.Table_BangDiem.Gdcd,
                                Van = hss.Table_BangDiem.Van,
                                Su = hss.Table_BangDiem.Su,
                                Dia = hss.Table_BangDiem.Dia,
                                CongNghe = hss.Table_BangDiem.CongNghe,
                                TinHoc = hss.Table_BangDiem.TinHoc


                            };

                Table_HocSinh hs = dbe_search.Table_HocSinh.Where(h => h.TenHocSinh == txbsearch.Text).FirstOrDefault();
                if (hs == null)
                {
                    MessageBox.Show("Học sinh không tồn tại");
                    return;
                }
                datagridvewHocSinh.DataSource = tenhss.ToList();
            }
        }
    }
}
