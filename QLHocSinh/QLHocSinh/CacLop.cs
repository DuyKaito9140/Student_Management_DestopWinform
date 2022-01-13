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
    public partial class CacLop : Form
    {
        XepLopHoc f1;
        DBE_QLHS dbe = new DBE_QLHS();
        public CacLop()
        {
            InitializeComponent();
        }
        public CacLop(XepLopHoc f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public void Loadlophoc() 
        {
            var chonlop = from cl in dbe.Table_LopHocs
                          select new 
                          {
                              MaLop = cl.MaLop,
                              TenLop = cl.TenLop,
                              Khoi = cl.Khoi,
                              GiaoVien = cl.GiaoVien
                          };
            datagriewcaclop.DataSource = chonlop.ToList();

            tb_malop.DataBindings.Clear();
            tb_malop.DataBindings.Add(new Binding("Text", datagriewcaclop.DataSource, "MaLop"));
            tb_lop.DataBindings.Clear();
            tb_lop.DataBindings.Add(new Binding("Text", datagriewcaclop.DataSource, "TenLop"));
            tb_khoi.DataBindings.Clear();
            tb_khoi.DataBindings.Add(new Binding("Text", datagriewcaclop.DataSource, "Khoi"));
            tb_giaovien.DataBindings.Clear();
            tb_giaovien.DataBindings.Add(new Binding("Text", datagriewcaclop.DataSource, "GiaoVien"));
        }

        private void CacLop_Load(object sender, EventArgs e)
        {           
            Loadlophoc();
            tb_tenhocsinh.Text = Content.CName;
            if (Content.status == true)
            {
                tb_malop.Text = Content.CMaLop;
                tb_lop.Text = Content.CTenLop;
                tb_khoi.Text = Content.CKhoi;
                tb_giaovien.Text = Content.CGiaoVien;
            }
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            Content.CMaLop = tb_malop.Text;
            Content.CTenLop = tb_lop.Text;
            Content.CKhoi = tb_khoi.Text;
            Content.CGiaoVien = tb_giaovien.Text;
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
