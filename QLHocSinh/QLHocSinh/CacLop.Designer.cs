namespace QLHocSinh
{
    partial class CacLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagriewcaclop = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_malop = new System.Windows.Forms.TextBox();
            this.tb_khoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_giaovien = new System.Windows.Forms.TextBox();
            this.gt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnchon = new System.Windows.Forms.Button();
            this.tb_lop = new System.Windows.Forms.TextBox();
            this.tb_tenhocsinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagriewcaclop)).BeginInit();
            this.SuspendLayout();
            // 
            // datagriewcaclop
            // 
            this.datagriewcaclop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriewcaclop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.Khoi,
            this.GiaoVien});
            this.datagriewcaclop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagriewcaclop.Location = new System.Drawing.Point(0, 369);
            this.datagriewcaclop.Name = "datagriewcaclop";
            this.datagriewcaclop.RowHeadersWidth = 51;
            this.datagriewcaclop.RowTemplate.Height = 24;
            this.datagriewcaclop.Size = new System.Drawing.Size(672, 242);
            this.datagriewcaclop.TabIndex = 0;
            // 
            // MaLop
            // 
            this.MaLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 79;
            // 
            // TenLop
            // 
            this.TenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên lớp";
            this.TenLop.MinimumWidth = 6;
            this.TenLop.Name = "TenLop";
            this.TenLop.Width = 85;
            // 
            // Khoi
            // 
            this.Khoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Khoi.DataPropertyName = "Khoi";
            this.Khoi.HeaderText = "Khối";
            this.Khoi.MinimumWidth = 6;
            this.Khoi.Name = "Khoi";
            this.Khoi.Width = 65;
            // 
            // GiaoVien
            // 
            this.GiaoVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaoVien.DataPropertyName = "GiaoVien";
            this.GiaoVien.HeaderText = "Giáo viên";
            this.GiaoVien.MinimumWidth = 6;
            this.GiaoVien.Name = "GiaoVien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(200, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 55);
            this.label3.TabIndex = 56;
            this.label3.Text = "CHỌN LỚP";
            // 
            // tb_malop
            // 
            this.tb_malop.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_malop.Location = new System.Drawing.Point(189, 135);
            this.tb_malop.Margin = new System.Windows.Forms.Padding(4);
            this.tb_malop.Name = "tb_malop";
            this.tb_malop.ReadOnly = true;
            this.tb_malop.Size = new System.Drawing.Size(324, 31);
            this.tb_malop.TabIndex = 67;
            // 
            // tb_khoi
            // 
            this.tb_khoi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_khoi.Location = new System.Drawing.Point(189, 222);
            this.tb_khoi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_khoi.Name = "tb_khoi";
            this.tb_khoi.ReadOnly = true;
            this.tb_khoi.Size = new System.Drawing.Size(324, 31);
            this.tb_khoi.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Giáo viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "Khối: ";
            // 
            // tb_giaovien
            // 
            this.tb_giaovien.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giaovien.Location = new System.Drawing.Point(189, 267);
            this.tb_giaovien.Margin = new System.Windows.Forms.Padding(4);
            this.tb_giaovien.Name = "tb_giaovien";
            this.tb_giaovien.ReadOnly = true;
            this.tb_giaovien.Size = new System.Drawing.Size(324, 31);
            this.tb_giaovien.TabIndex = 62;
            // 
            // gt
            // 
            this.gt.AutoSize = true;
            this.gt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gt.Location = new System.Drawing.Point(51, 137);
            this.gt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(82, 25);
            this.gt.TabIndex = 60;
            this.gt.Text = "Mã lớp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(51, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 83;
            this.label7.Text = "Chọn Lớp:";
            // 
            // btnchon
            // 
            this.btnchon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnchon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.Location = new System.Drawing.Point(199, 314);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(130, 39);
            this.btnchon.TabIndex = 85;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = false;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // tb_lop
            // 
            this.tb_lop.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lop.Location = new System.Drawing.Point(189, 178);
            this.tb_lop.Margin = new System.Windows.Forms.Padding(4);
            this.tb_lop.Name = "tb_lop";
            this.tb_lop.ReadOnly = true;
            this.tb_lop.Size = new System.Drawing.Size(324, 31);
            this.tb_lop.TabIndex = 86;
            // 
            // tb_tenhocsinh
            // 
            this.tb_tenhocsinh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_tenhocsinh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenhocsinh.Location = new System.Drawing.Point(189, 92);
            this.tb_tenhocsinh.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tenhocsinh.Name = "tb_tenhocsinh";
            this.tb_tenhocsinh.ReadOnly = true;
            this.tb_tenhocsinh.Size = new System.Drawing.Size(324, 31);
            this.tb_tenhocsinh.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "Tên học sinh:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(364, 312);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 43);
            this.btnThoat.TabIndex = 89;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // CacLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(672, 611);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tb_tenhocsinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_lop);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_malop);
            this.Controls.Add(this.tb_khoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_giaovien);
            this.Controls.Add(this.gt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagriewcaclop);
            this.Name = "CacLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ HỌC SINH THPT";
            this.Load += new System.EventHandler(this.CacLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagriewcaclop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagriewcaclop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaoVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_malop;
        private System.Windows.Forms.TextBox tb_khoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_giaovien;
        private System.Windows.Forms.Label gt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.TextBox tb_lop;
        private System.Windows.Forms.TextBox tb_tenhocsinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}