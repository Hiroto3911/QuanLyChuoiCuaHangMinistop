namespace GUI
{
    partial class frm_QuanLyLichSuThayDoiGiaSanPham
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
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.gbo_ThongTin = new System.Windows.Forms.GroupBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbo_NhapThongTin = new System.Windows.Forms.GroupBox();
            this.rtf_LyDo = new System.Windows.Forms.RichTextBox();
            this.txt_NguoiThayDoi = new System.Windows.Forms.TextBox();
            this.cbo_MaSP = new System.Windows.Forms.ComboBox();
            this.txt_MaLSG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_GiaMoi = new System.Windows.Forms.TextBox();
            this.dtp_TgianCapNhap = new System.Windows.Forms.DateTimePicker();
            this.cbo_MaCH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_GiaCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.gbo_ThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbo_NhapThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Data
            // 
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(16, 23);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.Size = new System.Drawing.Size(841, 233);
            this.dgv_Data.TabIndex = 54;
            this.dgv_Data.Click += new System.EventHandler(this.dgv_Data_Click);
            // 
            // gbo_ThongTin
            // 
            this.gbo_ThongTin.Controls.Add(this.btn_Sua);
            this.gbo_ThongTin.Controls.Add(this.btn_Xoa);
            this.gbo_ThongTin.Controls.Add(this.btn_HoanTat);
            this.gbo_ThongTin.Controls.Add(this.btn_LamMoi);
            this.gbo_ThongTin.Controls.Add(this.btn_Them);
            this.gbo_ThongTin.Controls.Add(this.dgv_Data);
            this.gbo_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_ThongTin.Location = new System.Drawing.Point(28, 244);
            this.gbo_ThongTin.Name = "gbo_ThongTin";
            this.gbo_ThongTin.Size = new System.Drawing.Size(875, 345);
            this.gbo_ThongTin.TabIndex = 119;
            this.gbo_ThongTin.TabStop = false;
            this.gbo_ThongTin.Text = "Lịch sử thay đổi";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Enabled = false;
            this.btn_Sua.Location = new System.Drawing.Point(130, 277);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(76, 49);
            this.btn_Sua.TabIndex = 130;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(249, 277);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(76, 49);
            this.btn_Xoa.TabIndex = 129;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.Enabled = false;
            this.btn_HoanTat.Location = new System.Drawing.Point(363, 277);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(84, 49);
            this.btn_HoanTat.TabIndex = 128;
            this.btn_HoanTat.Text = "Hoàn Tất";
            this.btn_HoanTat.UseVisualStyleBackColor = true;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(483, 277);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(76, 49);
            this.btn_LamMoi.TabIndex = 127;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(16, 277);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(76, 49);
            this.btn_Them.TabIndex = 124;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(219, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(538, 33);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Quản lý lịch sử thay đổi giá sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 52);
            this.panel1.TabIndex = 118;
            // 
            // gbo_NhapThongTin
            // 
            this.gbo_NhapThongTin.Controls.Add(this.rtf_LyDo);
            this.gbo_NhapThongTin.Controls.Add(this.txt_NguoiThayDoi);
            this.gbo_NhapThongTin.Controls.Add(this.cbo_MaSP);
            this.gbo_NhapThongTin.Controls.Add(this.txt_MaLSG);
            this.gbo_NhapThongTin.Controls.Add(this.label8);
            this.gbo_NhapThongTin.Controls.Add(this.label9);
            this.gbo_NhapThongTin.Controls.Add(this.label7);
            this.gbo_NhapThongTin.Controls.Add(this.label4);
            this.gbo_NhapThongTin.Controls.Add(this.txt_GiaMoi);
            this.gbo_NhapThongTin.Controls.Add(this.dtp_TgianCapNhap);
            this.gbo_NhapThongTin.Controls.Add(this.cbo_MaCH);
            this.gbo_NhapThongTin.Controls.Add(this.label5);
            this.gbo_NhapThongTin.Controls.Add(this.label2);
            this.gbo_NhapThongTin.Controls.Add(this.label1);
            this.gbo_NhapThongTin.Controls.Add(this.txt_GiaCu);
            this.gbo_NhapThongTin.Controls.Add(this.label3);
            this.gbo_NhapThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_NhapThongTin.Location = new System.Drawing.Point(28, 59);
            this.gbo_NhapThongTin.Name = "gbo_NhapThongTin";
            this.gbo_NhapThongTin.Size = new System.Drawing.Size(875, 179);
            this.gbo_NhapThongTin.TabIndex = 124;
            this.gbo_NhapThongTin.TabStop = false;
            this.gbo_NhapThongTin.Text = "Nhập thông tin";
            // 
            // rtf_LyDo
            // 
            this.rtf_LyDo.Location = new System.Drawing.Point(702, 81);
            this.rtf_LyDo.Name = "rtf_LyDo";
            this.rtf_LyDo.Size = new System.Drawing.Size(158, 56);
            this.rtf_LyDo.TabIndex = 172;
            this.rtf_LyDo.Text = "";
            // 
            // txt_NguoiThayDoi
            // 
            this.txt_NguoiThayDoi.Enabled = false;
            this.txt_NguoiThayDoi.Location = new System.Drawing.Point(702, 41);
            this.txt_NguoiThayDoi.Name = "txt_NguoiThayDoi";
            this.txt_NguoiThayDoi.Size = new System.Drawing.Size(158, 24);
            this.txt_NguoiThayDoi.TabIndex = 171;
            // 
            // cbo_MaSP
            // 
            this.cbo_MaSP.FormattingEnabled = true;
            this.cbo_MaSP.Location = new System.Drawing.Point(130, 81);
            this.cbo_MaSP.Name = "cbo_MaSP";
            this.cbo_MaSP.Size = new System.Drawing.Size(151, 26);
            this.cbo_MaSP.TabIndex = 170;
            this.cbo_MaSP.SelectedValueChanged += new System.EventHandler(this.cbo_MaSP_SelectedValueChanged);
            // 
            // txt_MaLSG
            // 
            this.txt_MaLSG.Enabled = false;
            this.txt_MaLSG.Location = new System.Drawing.Point(130, 120);
            this.txt_MaLSG.Name = "txt_MaLSG";
            this.txt_MaLSG.Size = new System.Drawing.Size(151, 24);
            this.txt_MaLSG.TabIndex = 169;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(596, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 168;
            this.label8.Text = "Lý do";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(312, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 167;
            this.label9.Text = "Tgian cập nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(596, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 166;
            this.label7.Text = "Người thay đổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 165;
            this.label4.Text = "Mã lịch sử giá";
            // 
            // txt_GiaMoi
            // 
            this.txt_GiaMoi.Location = new System.Drawing.Point(428, 77);
            this.txt_GiaMoi.Name = "txt_GiaMoi";
            this.txt_GiaMoi.Size = new System.Drawing.Size(151, 24);
            this.txt_GiaMoi.TabIndex = 164;
            // 
            // dtp_TgianCapNhap
            // 
            this.dtp_TgianCapNhap.Enabled = false;
            this.dtp_TgianCapNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_TgianCapNhap.Location = new System.Drawing.Point(428, 117);
            this.dtp_TgianCapNhap.Name = "dtp_TgianCapNhap";
            this.dtp_TgianCapNhap.Size = new System.Drawing.Size(151, 24);
            this.dtp_TgianCapNhap.TabIndex = 163;
            // 
            // cbo_MaCH
            // 
            this.cbo_MaCH.Enabled = false;
            this.cbo_MaCH.FormattingEnabled = true;
            this.cbo_MaCH.Location = new System.Drawing.Point(130, 40);
            this.cbo_MaCH.Name = "cbo_MaCH";
            this.cbo_MaCH.Size = new System.Drawing.Size(151, 26);
            this.cbo_MaCH.TabIndex = 157;
            this.cbo_MaCH.SelectedValueChanged += new System.EventHandler(this.cbo_MaCH_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 162;
            this.label5.Text = "giá mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 160;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 159;
            this.label1.Text = "Mã cửa hàng";
            // 
            // txt_GiaCu
            // 
            this.txt_GiaCu.Enabled = false;
            this.txt_GiaCu.Location = new System.Drawing.Point(428, 40);
            this.txt_GiaCu.Name = "txt_GiaCu";
            this.txt_GiaCu.Size = new System.Drawing.Size(151, 24);
            this.txt_GiaCu.TabIndex = 158;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 161;
            this.label3.Text = "giá cũ";
            // 
            // frm_QuanLyLichSuThayDoiGiaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.gbo_NhapThongTin);
            this.Controls.Add(this.gbo_ThongTin);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "frm_QuanLyLichSuThayDoiGiaSanPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_QuanLyLichSuThayDoiGiaSanPham_Load);
            this.Resize += new System.EventHandler(this.frm_QuanLyLichSuThayDoiGiaSanPham_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.gbo_ThongTin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbo_NhapThongTin.ResumeLayout(false);
            this.gbo_NhapThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.GroupBox gbo_ThongTin;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbo_NhapThongTin;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.RichTextBox rtf_LyDo;
        private System.Windows.Forms.TextBox txt_NguoiThayDoi;
        private System.Windows.Forms.ComboBox cbo_MaSP;
        private System.Windows.Forms.TextBox txt_MaLSG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_GiaMoi;
        private System.Windows.Forms.DateTimePicker dtp_TgianCapNhap;
        private System.Windows.Forms.ComboBox cbo_MaCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GiaCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_HoanTat;
    }
}