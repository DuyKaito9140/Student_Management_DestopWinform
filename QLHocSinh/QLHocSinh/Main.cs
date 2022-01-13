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
    public partial class Main : Form
    {
        QuanLiHocSinh f1;
        QuanLiLop f3;
        QuanLyDiem f4;

        public Main()
        {
            InitializeComponent();
        }
        public Main(QuanLiHocSinh f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public Main(QuanLiLop f3)
        {
            InitializeComponent();
            this.f3 = f3;
        }
        public Main(QuanLyDiem f4)
        {
            InitializeComponent();
            this.f4 = f4;
        }
        private void btnThongTinHS_Click(object sender, EventArgs e)
        {
            QuanLiHocSinh qlhs = new QuanLiHocSinh(this);
           // this.Hide();
            qlhs.Show();
            this.Hide();
            
        }
        private void btnQuanLiLop_Click(object sender, EventArgs e)
        {
            QuanLiLop qll = new QuanLiLop(this);
            //this.Hide();
            qll.Show();
            this.Hide();
        }
    }
}
