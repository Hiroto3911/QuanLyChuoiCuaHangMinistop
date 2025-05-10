namespace GUI
{
    partial class frm_NhapKho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.cbo_MaCH = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_MaNH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbo_NhapThongTin = new System.Windows.Forms.GroupBox();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.btn_InPhieuNhap = new System.Windows.Forms.Button();
            this.cbo_NCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.gbo_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.btn_LamMoiChiTiet = new System.Windows.Forms.Button();
            this.btn_SuaChiTiet = new System.Windows.Forms.Button();
            this.btn_XoaChiTiet = new System.Windows.Forms.Button();
            this.btn_ThemChiTiet = new System.Windows.Forms.Button();
            this.dgv_DataChiTiet = new System.Windows.Forms.DataGridView();
            this.rtf_GhiChu = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.cbo_MaSP = new System.Windows.Forms.ComboBox();
            this.txt_SLNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbo_NhapThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.gbo_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 52);
            this.panel1.TabIndex = 64;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(408, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(170, 33);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Nhập Hàng";
            // 
            // cbo_MaCH
            // 
            this.cbo_MaCH.Enabled = false;
            this.cbo_MaCH.FormattingEnabled = true;
            this.cbo_MaCH.Location = new System.Drawing.Point(126, 21);
            this.cbo_MaCH.Name = "cbo_MaCH";
            this.cbo_MaCH.Size = new System.Drawing.Size(151, 26);
            this.cbo_MaCH.TabIndex = 48;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(614, 20);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 49);
            this.btn_Them.TabIndex = 42;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Enabled = false;
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(423, 89);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(151, 24);
            this.dtp_NgayNhap.TabIndex = 57;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(732, 21);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 48);
            this.btn_Xoa.TabIndex = 43;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_MaNH
            // 
            this.txt_MaNH.Enabled = false;
            this.txt_MaNH.Location = new System.Drawing.Point(126, 55);
            this.txt_MaNH.Name = "txt_MaNH";
            this.txt_MaNH.Size = new System.Drawing.Size(151, 24);
            this.txt_MaNH.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ngày nhập";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(20, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 16);
            this.label.TabIndex = 51;
            this.label.Text = "Mã nhập hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã cửa hàng ";
            // 
            // gbo_NhapThongTin
            // 
            this.gbo_NhapThongTin.Controls.Add(this.btn_HoanTat);
            this.gbo_NhapThongTin.Controls.Add(this.btn_InPhieuNhap);
            this.gbo_NhapThongTin.Controls.Add(this.cbo_NCC);
            this.gbo_NhapThongTin.Controls.Add(this.label1);
            this.gbo_NhapThongTin.Controls.Add(this.dgv_Data);
            this.gbo_NhapThongTin.Controls.Add(this.txt_MaNV);
            this.gbo_NhapThongTin.Controls.Add(this.cbo_MaCH);
            this.gbo_NhapThongTin.Controls.Add(this.btn_Them);
            this.gbo_NhapThongTin.Controls.Add(this.dtp_NgayNhap);
            this.gbo_NhapThongTin.Controls.Add(this.btn_Xoa);
            this.gbo_NhapThongTin.Controls.Add(this.txt_MaNH);
            this.gbo_NhapThongTin.Controls.Add(this.label5);
            this.gbo_NhapThongTin.Controls.Add(this.label);
            this.gbo_NhapThongTin.Controls.Add(this.label3);
            this.gbo_NhapThongTin.Controls.Add(this.label2);
            this.gbo_NhapThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_NhapThongTin.Location = new System.Drawing.Point(60, 77);
            this.gbo_NhapThongTin.Name = "gbo_NhapThongTin";
            this.gbo_NhapThongTin.Size = new System.Drawing.Size(872, 274);
            this.gbo_NhapThongTin.TabIndex = 65;
            this.gbo_NhapThongTin.TabStop = false;
            this.gbo_NhapThongTin.Text = "Thông tin nhập hàng";
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.Location = new System.Drawing.Point(614, 79);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(75, 49);
            this.btn_HoanTat.TabIndex = 68;
            this.btn_HoanTat.Text = "Hoàn tất";
            this.btn_HoanTat.UseVisualStyleBackColor = true;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // btn_InPhieuNhap
            // 
            this.btn_InPhieuNhap.Location = new System.Drawing.Point(732, 79);
            this.btn_InPhieuNhap.Name = "btn_InPhieuNhap";
            this.btn_InPhieuNhap.Size = new System.Drawing.Size(75, 49);
            this.btn_InPhieuNhap.TabIndex = 67;
            this.btn_InPhieuNhap.Text = "In phiếu nhập";
            this.btn_InPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // cbo_NCC
            // 
            this.cbo_NCC.FormattingEnabled = true;
            this.cbo_NCC.Location = new System.Drawing.Point(423, 54);
            this.cbo_NCC.Name = "cbo_NCC";
            this.cbo_NCC.Size = new System.Drawing.Size(151, 26);
            this.cbo_NCC.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nhà cung cấp";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(23, 133);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.Size = new System.Drawing.Size(815, 135);
            this.dgv_Data.TabIndex = 62;
            this.dgv_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Data_CellClick);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(423, 20);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(151, 24);
            this.txt_MaNV.TabIndex = 58;
            // 
            // gbo_ThongTin
            // 
            this.gbo_ThongTin.Controls.Add(this.txt_GiaNhap);
            this.gbo_ThongTin.Controls.Add(this.btn_LamMoiChiTiet);
            this.gbo_ThongTin.Controls.Add(this.btn_SuaChiTiet);
            this.gbo_ThongTin.Controls.Add(this.btn_XoaChiTiet);
            this.gbo_ThongTin.Controls.Add(this.btn_ThemChiTiet);
            this.gbo_ThongTin.Controls.Add(this.dgv_DataChiTiet);
            this.gbo_ThongTin.Controls.Add(this.rtf_GhiChu);
            this.gbo_ThongTin.Controls.Add(this.label12);
            this.gbo_ThongTin.Controls.Add(this.label11);
            this.gbo_ThongTin.Controls.Add(this.txt_TongTien);
            this.gbo_ThongTin.Controls.Add(this.cbo_MaSP);
            this.gbo_ThongTin.Controls.Add(this.txt_SLNhap);
            this.gbo_ThongTin.Controls.Add(this.label7);
            this.gbo_ThongTin.Controls.Add(this.label8);
            this.gbo_ThongTin.Controls.Add(this.label9);
            this.gbo_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_ThongTin.Location = new System.Drawing.Point(60, 357);
            this.gbo_ThongTin.Name = "gbo_ThongTin";
            this.gbo_ThongTin.Size = new System.Drawing.Size(872, 353);
            this.gbo_ThongTin.TabIndex = 66;
            this.gbo_ThongTin.TabStop = false;
            this.gbo_ThongTin.Text = "Thông tin chi tiết nhập hàng";
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Location = new System.Drawing.Point(126, 112);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(151, 24);
            this.txt_GiaNhap.TabIndex = 70;
            this.txt_GiaNhap.Leave += new System.EventHandler(this.txt_GiaNhap_Leave);
            // 
            // btn_LamMoiChiTiet
            // 
            this.btn_LamMoiChiTiet.Location = new System.Drawing.Point(723, 103);
            this.btn_LamMoiChiTiet.Name = "btn_LamMoiChiTiet";
            this.btn_LamMoiChiTiet.Size = new System.Drawing.Size(75, 49);
            this.btn_LamMoiChiTiet.TabIndex = 69;
            this.btn_LamMoiChiTiet.Text = "Làm mới";
            this.btn_LamMoiChiTiet.UseVisualStyleBackColor = true;
            this.btn_LamMoiChiTiet.Click += new System.EventHandler(this.btn_LamMoiChiTiet_Click);
            // 
            // btn_SuaChiTiet
            // 
            this.btn_SuaChiTiet.Location = new System.Drawing.Point(614, 103);
            this.btn_SuaChiTiet.Name = "btn_SuaChiTiet";
            this.btn_SuaChiTiet.Size = new System.Drawing.Size(75, 49);
            this.btn_SuaChiTiet.TabIndex = 68;
            this.btn_SuaChiTiet.Text = "Sửa";
            this.btn_SuaChiTiet.UseVisualStyleBackColor = true;
            this.btn_SuaChiTiet.Click += new System.EventHandler(this.btn_SuaChiTiet_Click);
            // 
            // btn_XoaChiTiet
            // 
            this.btn_XoaChiTiet.Location = new System.Drawing.Point(723, 36);
            this.btn_XoaChiTiet.Name = "btn_XoaChiTiet";
            this.btn_XoaChiTiet.Size = new System.Drawing.Size(75, 49);
            this.btn_XoaChiTiet.TabIndex = 67;
            this.btn_XoaChiTiet.Text = "Xoá";
            this.btn_XoaChiTiet.UseVisualStyleBackColor = true;
            this.btn_XoaChiTiet.Click += new System.EventHandler(this.btn_XoaChiTiet_Click);
            // 
            // btn_ThemChiTiet
            // 
            this.btn_ThemChiTiet.Location = new System.Drawing.Point(614, 36);
            this.btn_ThemChiTiet.Name = "btn_ThemChiTiet";
            this.btn_ThemChiTiet.Size = new System.Drawing.Size(75, 49);
            this.btn_ThemChiTiet.TabIndex = 66;
            this.btn_ThemChiTiet.Text = "Thêm";
            this.btn_ThemChiTiet.UseVisualStyleBackColor = true;
            this.btn_ThemChiTiet.Click += new System.EventHandler(this.btn_ThemChiTiet_Click);
            // 
            // dgv_DataChiTiet
            // 
            this.dgv_DataChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DataChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataChiTiet.Location = new System.Drawing.Point(23, 181);
            this.dgv_DataChiTiet.Name = "dgv_DataChiTiet";
            this.dgv_DataChiTiet.Size = new System.Drawing.Size(815, 163);
            this.dgv_DataChiTiet.TabIndex = 65;
            this.dgv_DataChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DataChiTiet_CellClick);
            // 
            // rtf_GhiChu
            // 
            this.rtf_GhiChu.Location = new System.Drawing.Point(423, 75);
            this.rtf_GhiChu.Name = "rtf_GhiChu";
            this.rtf_GhiChu.Size = new System.Drawing.Size(151, 61);
            this.rtf_GhiChu.TabIndex = 64;
            this.rtf_GhiChu.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(317, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 63;
            this.label12.Text = "Ghi chú";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 62;
            this.label11.Text = "Giá nhập";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Location = new System.Drawing.Point(423, 38);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(151, 24);
            this.txt_TongTien.TabIndex = 56;
            // 
            // cbo_MaSP
            // 
            this.cbo_MaSP.FormattingEnabled = true;
            this.cbo_MaSP.Location = new System.Drawing.Point(126, 36);
            this.cbo_MaSP.Name = "cbo_MaSP";
            this.cbo_MaSP.Size = new System.Drawing.Size(151, 26);
            this.cbo_MaSP.TabIndex = 48;
            // 
            // txt_SLNhap
            // 
            this.txt_SLNhap.Location = new System.Drawing.Point(126, 76);
            this.txt_SLNhap.Name = "txt_SLNhap";
            this.txt_SLNhap.Size = new System.Drawing.Size(151, 24);
            this.txt_SLNhap.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "SL nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Tổng tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Mã sản phẩm";
            // 
            // frm_NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1003, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbo_NhapThongTin);
            this.Controls.Add(this.gbo_ThongTin);
            this.Name = "frm_NhapKho";
            this.Text = "frm_NhapKho";
            this.Load += new System.EventHandler(this.frm_NhapKho_Load);
            this.Resize += new System.EventHandler(this.frm_NhapKho_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbo_NhapThongTin.ResumeLayout(false);
            this.gbo_NhapThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.gbo_ThongTin.ResumeLayout(false);
            this.gbo_ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox cbo_MaCH;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_MaNH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbo_NhapThongTin;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.GroupBox gbo_ThongTin;
        private System.Windows.Forms.Button btn_LamMoiChiTiet;
        private System.Windows.Forms.Button btn_SuaChiTiet;
        private System.Windows.Forms.Button btn_XoaChiTiet;
        private System.Windows.Forms.Button btn_ThemChiTiet;
        private System.Windows.Forms.DataGridView dgv_DataChiTiet;
        private System.Windows.Forms.RichTextBox rtf_GhiChu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.ComboBox cbo_MaSP;
        private System.Windows.Forms.TextBox txt_SLNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_NCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.Button btn_InPhieuNhap;
        private System.Windows.Forms.Button btn_HoanTat;
    }
}