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
    public partial class QuanLyDiem : Form
    {
        Main f1;
        QuanLiHocSinh f2;
        DBE_QLHS dbe = new DBE_QLHS();
        public QuanLyDiem()
        {
            InitializeComponent();
        }
        public QuanLyDiem(Main f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public QuanLyDiem(QuanLiHocSinh f2)
        {
            InitializeComponent();
            this.f2 = f2;
        }
        private void LoadDB()
        {
            var listDiem = from hs in dbe.Table_HocSinh
                           select new
                           {
                               MaHS = hs.MaHS,
                               TenHocSinh = hs.TenHocSinh,
                               TenLop = hs.Table_LopHoc.TenLop,
                               MaDiem = hs.MaDiem,
                               Toan = hs.Table_BangDiem.Toan,
                               Ly = hs.Table_BangDiem.Ly,
                               Hoa = hs.Table_BangDiem.Hoa,
                               TiengAnh = hs.Table_BangDiem.TiengAnh,
                               Gdcd = hs.Table_BangDiem.Gdcd,
                               Van = hs.Table_BangDiem.Van,
                               Su = hs.Table_BangDiem.Su,
                               Dia = hs.Table_BangDiem.Dia,
                               CongNghe = hs.Table_BangDiem.CongNghe,
                               TinHoc = hs.Table_BangDiem.TinHoc
                         };
            dataGridViewDiem.DataSource = listDiem.ToList();
            //Thông tin học sinh
            txbMaHs.DataBindings.Clear();
            txbMaHs.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "MaHS"));
            txbTenHs.DataBindings.Clear();
            txbTenHs.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "TenHocSinh"));
            txbLop.DataBindings.Clear();
            txbLop.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "TenLop"));
            //Điểm
            tbmadiem.DataBindings.Clear();
            tbmadiem.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "MaDiem"));
            txbNhapToan.DataBindings.Clear();
            txbNhapToan.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "Toan"));
            txbNhapLy.DataBindings.Clear();
            txbNhapLy.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "Ly"));
            txbNhapHoa.DataBindings.Clear();
            txbNhapHoa.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "Hoa"));
            txbNhapTA.DataBindings.Clear();
            txbNhapTA.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "TiengAnh"));
            txbNhapGdcd.DataBindings.Clear();
            txbNhapGdcd.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "Gdcd"));
            txbNhapVan.DataBindings.Clear();
            txbNhapVan.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "Van"));
            txbNhapSu.DataBindings.Clear();
            txbNhapSu.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "Su"));
            txbNhapDia.DataBindings.Clear();
            txbNhapDia.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "Dia"));
            txbNhapCN.DataBindings.Clear();
            txbNhapCN.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "CongNghe"));
            txbNhapTin.DataBindings.Clear();
            txbNhapTin.DataBindings.Add(new Binding("Text", dataGridViewDiem.DataSource, "TinHoc"));
        }

        private void QuanLiDiem_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            DBE_QLHS dbeupd = new DBE_QLHS();
            string mahs = txbMaHs.Text;
            string tenhs = txbTenHs.Text;
            string lop = txbLop.Text;
            string madiem = tbmadiem.Text;
            Table_HocSinh hs = dbeupd.Table_HocSinh.Where(ma => ma.MaHS == mahs).SingleOrDefault();
            if (hs != null)
            {
                if(madiem=="" && txbNhapToan.Text==""&& txbNhapLy.Text==""
                     &&txbNhapHoa.Text==""&&txbNhapTA.Text==""&&txbNhapGdcd.Text==""
                     && txbNhapVan.Text == "" && txbNhapSu.Text == "" && txbNhapDia.Text == "" && txbNhapCN.Text == "" && txbNhapTin.Text == "")
                     {
                          MessageBox.Show("Bạn chưa nhập điểm. \nHãy nhập điểm !");
                     }
                else
                {
                    hs.MaHS = mahs;
                    hs.TenHocSinh = tenhs;
                    hs.MaDiem = madiem;
                    dbeupd.SaveChanges();
                    LoadDB();
                    if(Content.status==false)
                        MessageBox.Show("Nhập điểm thành công !");
                    else
                        MessageBox.Show("Sửa điểm thành công !");
                }              
            }
            else
            {
                MessageBox.Show("Nhập điểm thất bại !");
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e) 
        {
            if (txbLop.Text == "")
            {
                MessageBox.Show("Học sinh này chưa có Lớp, không thể nhập điểm. \nHãy xếp lớp cho học sinh này !");
            }
            else
            {
                if (tbmadiem.Text == "")
                {
                    //set lại Content
                    Content.CMaDiem = "";
                    Content.CToan = "";
                    Content.CLy = "";
                    Content.CHoa = "";
                    Content.CTiengAnh = "";
                    Content.CGdcd = "";
                    Content.CVan = "";
                    Content.CSu = "";
                    Content.CDia = "";
                    Content.CCongNghe = "";
                    Content.CTinHoc = "";

                    //Show form nhập điểm
                    NhapDiem nd = new NhapDiem(this);
                    Content.CMaHS = txbMaHs.Text;
                    Content.CName = txbTenHs.Text;
                    Content.CTenLop = txbLop.Text;
                    Content.status = false;
                    nd.Show();
                }
                else
                {
                    MessageBox.Show("Học sinh này đã có Bảng điểm. \nHãy nhấn sửa điểm nếu muốn cập nhật Bảng điểm !");
                }
            }
            
        }

        private void QuanLyDiem_Activated(object sender, EventArgs e)
        {
            if (Content.CMaDiem != "")
            {
                tbmadiem.Text = Content.CMaDiem;
                txbNhapToan.Text = Content.CToan;
                txbNhapLy.Text = Content.CLy;
                txbNhapHoa.Text = Content.CHoa;
                txbNhapTA.Text = Content.CTiengAnh;
                txbNhapGdcd.Text = Content.CGdcd;
                txbNhapVan.Text = Content.CVan;
                txbNhapSu.Text = Content.CSu;
                txbNhapDia.Text = Content.CDia;
                txbNhapCN.Text = Content.CCongNghe;
                txbNhapTin.Text = Content.CTinHoc;
            }
        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            if (txbLop.Text == "")
            {
                MessageBox.Show("Học sinh này chưa có Lớp, không thể sửa điểm. \nHãy xếp lớp cho học sinh này !");
            }
            else
            {
                if (tbmadiem.Text != "")
                {
                    //set lại Content
                    Content.CMaDiem = tbmadiem.Text;
                    Content.CToan = txbNhapToan.Text;
                    Content.CLy = txbNhapLy.Text;
                    Content.CHoa = txbNhapHoa.Text;
                    Content.CTiengAnh = txbNhapTA.Text;
                    Content.CGdcd = txbNhapGdcd.Text;
                    Content.CVan = txbNhapVan.Text;
                    Content.CSu = txbNhapSu.Text;
                    Content.CDia = txbNhapDia.Text;
                    Content.CCongNghe = txbNhapCN.Text;
                    Content.CTinHoc = txbNhapTin.Text;

                    //Show form sửa điểm
                    NhapDiem nd = new NhapDiem(this);
                    Content.CMaHS = txbMaHs.Text;
                    Content.CName = txbTenHs.Text;
                    Content.CTenLop = txbLop.Text;
                    Content.status = true;
                    nd.Show();
                }
                else
                {
                    MessageBox.Show("Học sinh này chưa có Bảng điểm. \nHãy nhấn Nhập điểm để thêm mới một Bảng điểm !");
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            QuanLiHocSinh qlhs = new QuanLiHocSinh();
            qlhs.Show();
            this.Hide();
            
        }
    }
}
