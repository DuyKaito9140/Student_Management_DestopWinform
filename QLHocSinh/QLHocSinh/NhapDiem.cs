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
    public partial class NhapDiem : Form
    {
        QuanLyDiem f1;
        DBE_QLHS dbe = new DBE_QLHS();
        public NhapDiem()
        {
            InitializeComponent();
        }
        public NhapDiem(QuanLyDiem f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        private void NhapDiem_Load(object sender, EventArgs e)
        {
            LoadNhapDiem();
            if (Content.status == false)
            {
                txbMaHs.Text = Content.CMaHS;
                txbTenHs.Text = Content.CName;
                txbLop.Text = Content.CTenLop;
                tbNhapmadiem.Text = "";
                txbNhapToan.Text = "";
                txbNhapLy.Text = "";
                txbNhapHoa.Text = "";
                txbNhapTA.Text = "";
                txbNhapGdcd.Text = "";
                txbNhapVan.Text = "";
                txbNhapSu.Text = "";
                txbNhapDia.Text = "";
                txbNhapCN.Text = "";
                txbNhapTin.Text = "";
                txtNhapSuaDiem.Text = "NHẬP ĐIỂM";
            }
            else
            {
                txbMaHs.Text = Content.CMaHS;
                txbTenHs.Text = Content.CName;
                txbLop.Text = Content.CTenLop;
                tbNhapmadiem.Text = Content.CMaDiem;
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
                txtNhapSuaDiem.Text = "SỬA ĐIỂM";
            }             
        }
        public void LoadNhapDiem()
        {
            var listNhapDiem = from diem in dbe.Table_BangDiem
                               select new 
                               {
                                   MaDiem = diem.MaDiem,
                                   Toan = diem.Toan,
                                   Ly = diem.Ly,
                                   Hoa = diem.Hoa,
                                   TiengAnh = diem.TiengAnh,
                                   Gdcd = diem.Gdcd,
                                   Van = diem.Van,
                                   Su = diem.Su,
                                   Dia = diem.Dia,
                                   CongNghe = diem.CongNghe,
                                   TinHoc = diem.TinHoc
                               };
            dataGridViewNhapDiem.DataSource = listNhapDiem.ToList();

            tbNhapmadiem.DataBindings.Clear();
            tbNhapmadiem.DataBindings.Add(new Binding("Text", dataGridViewNhapDiem.DataSource, "MaDiem"));
            txbNhapToan.DataBindings.Clear();
            txbNhapToan.DataBindings.Add(new Binding("Text", dataGridViewNhapDiem.DataSource, "Toan"));
            txbNhapLy.DataBindings.Clear();
            txbNhapLy.DataBindings.Add(new Binding("Text", dataGridViewNhapDiem.DataSource, "Ly"));
            txbNhapHoa.DataBindings.Clear();
            txbNhapHoa.DataBindings.Add(new Binding("Text", dataGridViewNhapDiem.DataSource, "Hoa"));
            txbNhapTA.DataBindings.Clear();
            txbNhapTA.DataBindings.Add(new Binding("Text", dataGridViewNhapDiem.DataSource, "TiengAnh"));
            txbNhapGdcd.DataBindings.Clear();
            txbNhapGdcd.DataBindings.Add(new Binding("Text", dataGridViewNhapDiem.DataSource, "Gdcd"));
            txbNhapVan.DataBindings.Clear();
            txbNhapVan.DataBindings.Add(new Binding("Text", dataGridViewNhapDiem.DataSource, "Van"));
            txbNhapSu.DataBindings.Clear();
            txbNhapSu.DataBindings.Add(new Binding("Text", dataGridViewNhapDiem.DataSource, "Su"));
            txbNhapDia.DataBindings.Clear();
            txbNhapDia.DataBindings.Add(new Binding("Text", dataGridViewNhapDiem.DataSource, "Dia"));
            txbNhapCN.DataBindings.Clear();
            txbNhapCN.DataBindings.Add(new Binding("Text", dataGridViewNhapDiem.DataSource, "CongNghe"));
            txbNhapTin.DataBindings.Clear();
            txbNhapTin.DataBindings.Add(new Binding("Text", dataGridViewNhapDiem.DataSource, "TinHoc"));
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            DBE_QLHS dbe_add = new DBE_QLHS();
            string madiem = tbNhapmadiem.Text;
            Table_BangDiem diem = dbe_add.Table_BangDiem.Where(ma => ma.MaDiem == madiem).SingleOrDefault();
            if (Content.status==false)
            {
                if (diem != null)
                {
                    MessageBox.Show("Mã bảng điểm đã tồn tại");
                    return;
                }
            }
            if (string.IsNullOrEmpty(madiem))
            {
                MessageBox.Show("Mã điểm không được để trống !");
                return;
            }
            else
            {
                //Lưu dữ liệu vào Content
                Content.CMaDiem = tbNhapmadiem.Text;
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
                //Add dữ liệu vào bảng  
                diem = new Table_BangDiem();
                diem.Toan = txbNhapToan.Text;
                diem.Ly = txbNhapLy.Text;
                diem.Hoa = txbNhapHoa.Text;
                diem.TiengAnh = txbNhapTA.Text;
                diem.Gdcd = txbNhapGdcd.Text;
                diem.Van = txbNhapVan.Text;
                diem.Su = txbNhapVan.Text;
                diem.Dia = txbNhapDia.Text;
                diem.CongNghe = txbNhapCN.Text;
                diem.TinHoc = txbNhapTin.Text;
                diem.MaDiem = madiem;
                dbe_add.Table_BangDiem.Add(diem);
                dbe_add.SaveChanges();
                LoadNhapDiem();
                this.Hide();
            }
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
