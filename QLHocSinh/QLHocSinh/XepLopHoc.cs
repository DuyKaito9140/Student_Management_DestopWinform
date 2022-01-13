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
    public partial class XepLopHoc : Form
    {
        QuanLiHocSinh f1;
        CacLop f2;
        DBE_QLHS dbe = new DBE_QLHS();
        public XepLopHoc()
        {
            InitializeComponent();
        }
        public XepLopHoc(QuanLiHocSinh f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public XepLopHoc(CacLop f2)
        {
            InitializeComponent();
            this.f2 = f2;
        }
        public void LoadingLop()
        {
            var xeplop = from lsp in dbe.Table_HocSinh
                         select new
                         {
                             MaHS = lsp.MaHS,
                             TenHocSinh = lsp.TenHocSinh,
                             Khoi = lsp.Table_LopHoc.Khoi,
                             MaLop = lsp.Table_LopHoc.MaLop,
                             TenLop = lsp.Table_LopHoc.TenLop,
                             GiaoVien = lsp.Table_LopHoc.GiaoVien
                         };
            dataGridViewXepLop.DataSource = xeplop.ToList();
            tbmahocsinh.DataBindings.Clear();
            tbmahocsinh.DataBindings.Add(new Binding("Text", dataGridViewXepLop.DataSource, "MaHS"));
            tbhoten.DataBindings.Clear();
            tbhoten.DataBindings.Add(new Binding("Text", dataGridViewXepLop.DataSource, "TenHocSinh"));
            tbmalop.DataBindings.Clear();
            tbmalop.DataBindings.Add(new Binding("Text", dataGridViewXepLop.DataSource, "MaLop"));
            tb_tenlop.DataBindings.Clear();
            tb_tenlop.DataBindings.Add(new Binding("Text", dataGridViewXepLop.DataSource, "TenLop"));
            tb_khoi.DataBindings.Clear();
            tb_khoi.DataBindings.Add(new Binding("Text", dataGridViewXepLop.DataSource, "Khoi"));
            tbgiaovien.DataBindings.Clear();
            tbgiaovien.DataBindings.Add(new Binding("Text", dataGridViewXepLop.DataSource, "GiaoVien"));

        }

        private void XepLopHoc_Load(object sender, EventArgs e)
        {            
            LoadingLop();           
        }

        private void btn_Chonlop_Click(object sender, EventArgs e) 
        {
            if (tbmalop.Text == "")
            {
                //set lại Content
                Content.CMaLop = "";
                Content.CTenLop = "";
                Content.CKhoi = "";
                Content.CGiaoVien = "";

                //Show form CacLop
                CacLop chonlop = new CacLop(this);
                Content.CName = tbhoten.Text;
                Content.status = false;
                chonlop.Show();
            }
            else
            {
                MessageBox.Show("Học sinh này đã có Lớp. \nHãy nhấn sửa lớp nếu muốn cập nhật Lớp!");
            }
                      
        }

        private void btn_Sualop_Click(object sender, EventArgs e)
        {
            //set lại Content
            Content.CMaLop = tbmalop.Text;
            Content.CTenLop = tb_tenlop.Text;
            Content.CKhoi = tb_khoi.Text;
            Content.CGiaoVien = tbgiaovien.Text;

            //Show form CacLop
            CacLop chonlop = new CacLop(this);
            Content.CName = tbhoten.Text;
            Content.status = true;
            chonlop.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            QuanLiHocSinh qlhs = new QuanLiHocSinh();            
            qlhs.Show();
            this.Hide();
        }

        private void XepLopHoc_Activated(object sender, EventArgs e)
        {
            if(Content.CMaLop != "")
            {
                tbmalop.Text = Content.CMaLop;
                tb_tenlop.Text = Content.CTenLop;
                tb_khoi.Text = Content.CKhoi;
                tbgiaovien.Text = Content.CGiaoVien;
            }
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            DBE_QLHS dbeup = new DBE_QLHS();
            string mahs = tbmahocsinh.Text;
            string tenhs = tbhoten.Text;
            string malop = tbmalop.Text;
            Table_HocSinh hs = dbeup.Table_HocSinh.Where(ma => ma.MaHS == mahs).SingleOrDefault();
            if (hs != null)
            {
                hs.MaHS = mahs;
                hs.TenHocSinh = tenhs;
                hs.MaLop = malop;
                dbeup.SaveChanges();
                LoadingLop();
                MessageBox.Show("Cập nhật thông tin lớp học thành công !");
            }            
        }
    }
}
