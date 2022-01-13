namespace QLHocSinh
{
    partial class XepLopHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sualop = new System.Windows.Forms.Button();
            this.btn_Chonlop = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.dataGridViewXepLop = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tbhoten = new System.Windows.Forms.TextBox();
            this.tbmahocsinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sv = new System.Windows.Forms.Label();
            this.tb_khoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbgiaovien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tenlop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbmalop = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXepLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(759, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 65;
            // 
            // btn_Sualop
            // 
            this.btn_Sualop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Sualop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sualop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sualop.Location = new System.Drawing.Point(318, 251);
            this.btn_Sualop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sualop.Name = "btn_Sualop";
            this.btn_Sualop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_Sualop.Size = new System.Drawing.Size(150, 43);
            this.btn_Sualop.TabIndex = 61;
            this.btn_Sualop.Text = "Sửa lớp";
            this.btn_Sualop.UseVisualStyleBackColor = false;
            this.btn_Sualop.Click += new System.EventHandler(this.btn_Sualop_Click);
            // 
            // btn_Chonlop
            // 
            this.btn_Chonlop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Chonlop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Chonlop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chonlop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Chonlop.Location = new System.Drawing.Point(136, 251);
            this.btn_Chonlop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Chonlop.Name = "btn_Chonlop";
            this.btn_Chonlop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_Chonlop.Size = new System.Drawing.Size(150, 43);
            this.btn_Chonlop.TabIndex = 59;
            this.btn_Chonlop.Text = "Chọn lớp";
            this.btn_Chonlop.UseVisualStyleBackColor = false;
            this.btn_Chonlop.Click += new System.EventHandler(this.btn_Chonlop_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(687, 251);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(150, 43);
            this.btnOut.TabIndex = 58;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // dataGridViewXepLop
            // 
            this.dataGridViewXepLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXepLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.TenHocSinh,
            this.Khoi,
            this.MaLop,
            this.TenLop,
            this.GiaoVien});
            this.dataGridViewXepLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewXepLop.Location = new System.Drawing.Point(0, 313);
            this.dataGridViewXepLop.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewXepLop.Name = "dataGridViewXepLop";
            this.dataGridViewXepLop.RowHeadersWidth = 51;
            this.dataGridViewXepLop.Size = new System.Drawing.Size(932, 261);
            this.dataGridViewXepLop.TabIndex = 56;
            // 
            // MaHS
            // 
            this.MaHS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.MinimumWidth = 6;
            this.MaHS.Name = "MaHS";
            this.MaHS.Width = 113;
            // 
            // TenHocSinh
            // 
            this.TenHocSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenHocSinh.DataPropertyName = "TenHocSinh";
            this.TenHocSinh.HeaderText = "Tên học sinh";
            this.TenHocSinh.MinimumWidth = 6;
            this.TenHocSinh.Name = "TenHocSinh";
            this.TenHocSinh.Width = 119;
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
            this.label3.Location = new System.Drawing.Point(308, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 55);
            this.label3.TabIndex = 55;
            this.label3.Text = "XẾP LỚP HỌC";
            // 
            // tbhoten
            // 
            this.tbhoten.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhoten.Location = new System.Drawing.Point(172, 130);
            this.tbhoten.Margin = new System.Windows.Forms.Padding(4);
            this.tbhoten.Name = "tbhoten";
            this.tbhoten.Size = new System.Drawing.Size(278, 31);
            this.tbhoten.TabIndex = 74;
            // 
            // tbmahocsinh
            // 
            this.tbmahocsinh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmahocsinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbmahocsinh.Location = new System.Drawing.Point(172, 83);
            this.tbmahocsinh.Margin = new System.Windows.Forms.Padding(4);
            this.tbmahocsinh.Name = "tbmahocsinh";
            this.tbmahocsinh.Size = new System.Drawing.Size(278, 31);
            this.tbmahocsinh.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "Họ và tên:";
            // 
            // sv
            // 
            this.sv.AutoSize = true;
            this.sv.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sv.Location = new System.Drawing.Point(34, 85);
            this.sv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sv.Name = "sv";
            this.sv.Size = new System.Drawing.Size(125, 25);
            this.sv.TabIndex = 71;
            this.sv.Text = "Mã học sinh:";
            // 
            // tb_khoi
            // 
            this.tb_khoi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_khoi.Location = new System.Drawing.Point(619, 133);
            this.tb_khoi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_khoi.Name = "tb_khoi";
            this.tb_khoi.Size = new System.Drawing.Size(278, 31);
            this.tb_khoi.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "Khối:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "Mã lớp học:";
            // 
            // tbgiaovien
            // 
            this.tbgiaovien.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgiaovien.Location = new System.Drawing.Point(619, 180);
            this.tbgiaovien.Margin = new System.Windows.Forms.Padding(4);
            this.tbgiaovien.Name = "tbgiaovien";
            this.tbgiaovien.Size = new System.Drawing.Size(278, 31);
            this.tbgiaovien.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 79;
            this.label6.Text = "Giáo viên:";
            // 
            // tb_tenlop
            // 
            this.tb_tenlop.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenlop.Location = new System.Drawing.Point(619, 85);
            this.tb_tenlop.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tenlop.Name = "tb_tenlop";
            this.tb_tenlop.Size = new System.Drawing.Size(278, 31);
            this.tb_tenlop.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 81;
            this.label7.Text = "Tên lớp:";
            // 
            // tbmalop
            // 
            this.tbmalop.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmalop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbmalop.Location = new System.Drawing.Point(172, 182);
            this.tbmalop.Margin = new System.Windows.Forms.Padding(4);
            this.tbmalop.Name = "tbmalop";
            this.tbmalop.Size = new System.Drawing.Size(278, 31);
            this.tbmalop.TabIndex = 77;
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(503, 251);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnluu.Size = new System.Drawing.Size(150, 43);
            this.btnluu.TabIndex = 83;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // XepLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(932, 574);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.tb_tenlop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbgiaovien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_khoi);
            this.Controls.Add(this.tbmalop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbhoten);
            this.Controls.Add(this.tbmahocsinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sualop);
            this.Controls.Add(this.btn_Chonlop);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.dataGridViewXepLop);
            this.Controls.Add(this.label3);
            this.Name = "XepLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ HỌC SINH THPT";
            this.Activated += new System.EventHandler(this.XepLopHoc_Activated);
            this.Load += new System.EventHandler(this.XepLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXepLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sualop;
        private System.Windows.Forms.Button btn_Chonlop;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.DataGridView dataGridViewXepLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbhoten;
        private System.Windows.Forms.TextBox tbmahocsinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sv;
        private System.Windows.Forms.TextBox tb_khoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbgiaovien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tenlop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbmalop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaoVien;
        private System.Windows.Forms.Button btnluu;
    }
}