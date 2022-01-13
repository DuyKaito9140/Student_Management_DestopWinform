namespace QLHocSinh
{
    partial class Main
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
            this.btnThongTinHS = new System.Windows.Forms.Button();
            this.btnQuanLiLop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ HỌC SINH THPT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThongTinHS
            // 
            this.btnThongTinHS.BackColor = System.Drawing.SystemColors.Control;
            this.btnThongTinHS.BackgroundImage = global::QLHocSinh.Properties.Resources.btn;
            this.btnThongTinHS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTinHS.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinHS.ForeColor = System.Drawing.Color.White;
            this.btnThongTinHS.Location = new System.Drawing.Point(211, 187);
            this.btnThongTinHS.Name = "btnThongTinHS";
            this.btnThongTinHS.Size = new System.Drawing.Size(408, 77);
            this.btnThongTinHS.TabIndex = 3;
            this.btnThongTinHS.Text = "THÔNG TIN HỌC SINH";
            this.btnThongTinHS.UseVisualStyleBackColor = false;
            this.btnThongTinHS.Click += new System.EventHandler(this.btnThongTinHS_Click);
            // 
            // btnQuanLiLop
            // 
            this.btnQuanLiLop.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuanLiLop.BackgroundImage = global::QLHocSinh.Properties.Resources.btn;
            this.btnQuanLiLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLiLop.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLiLop.ForeColor = System.Drawing.Color.White;
            this.btnQuanLiLop.Location = new System.Drawing.Point(211, 300);
            this.btnQuanLiLop.Name = "btnQuanLiLop";
            this.btnQuanLiLop.Size = new System.Drawing.Size(408, 77);
            this.btnQuanLiLop.TabIndex = 6;
            this.btnQuanLiLop.Text = "QUẢN LÝ LỚP";
            this.btnQuanLiLop.UseVisualStyleBackColor = false;
            this.btnQuanLiLop.Click += new System.EventHandler(this.btnQuanLiLop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::QLHocSinh.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(841, 466);
            this.Controls.Add(this.btnQuanLiLop);
            this.Controls.Add(this.btnThongTinHS);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ HỌC SINH THPT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThongTinHS;
        private System.Windows.Forms.Button btnQuanLiLop;
    }
}

