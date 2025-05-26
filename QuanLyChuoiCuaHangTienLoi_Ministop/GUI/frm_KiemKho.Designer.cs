namespace GUI
{
    partial class frm_KiemKho
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
            this.btn_LamMoiChiTiet = new System.Windows.Forms.Button();
            this.btn_SuaChiTiet = new System.Windows.Forms.Button();
            this.btn_XoaChiTiet = new System.Windows.Forms.Button();
            this.btn_ThemChiTiet = new System.Windows.Forms.Button();
            this.dgv_DataChiTiet = new System.Windows.Forms.DataGridView();
            this.rtf_GhiChu = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.txt_ChenhLech = new System.Windows.Forms.TextBox();
            this.txt_SLThucTe = new System.Windows.Forms.TextBox();
            this.cbo_MaSP = new System.Windows.Forms.ComboBox();
            this.txt_SLHeThong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.gbo_NhapThongTin = new System.Windows.Forms.GroupBox();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.cbo_MaCH = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dtp_NgayKiem = new System.Windows.Forms.DateTimePicker();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_MaKK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gbo_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.lbl_TenSP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.gbo_NhapThongTin.SuspendLayout();
            this.gbo_ThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LamMoiChiTiet
            // 
            this.btn_LamMoiChiTiet.Location = new System.Drawing.Point(989, 129);
            this.btn_LamMoiChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LamMoiChiTiet.Name = "btn_LamMoiChiTiet";
            this.btn_LamMoiChiTiet.Size = new System.Drawing.Size(100, 60);
            this.btn_LamMoiChiTiet.TabIndex = 69;
            this.btn_LamMoiChiTiet.Text = "Làm mới";
            this.btn_LamMoiChiTiet.UseVisualStyleBackColor = true;
            this.btn_LamMoiChiTiet.Click += new System.EventHandler(this.btn_LamMoiChiTiet_Click);
            // 
            // btn_SuaChiTiet
            // 
            this.btn_SuaChiTiet.Location = new System.Drawing.Point(844, 129);
            this.btn_SuaChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SuaChiTiet.Name = "btn_SuaChiTiet";
            this.btn_SuaChiTiet.Size = new System.Drawing.Size(100, 60);
            this.btn_SuaChiTiet.TabIndex = 68;
            this.btn_SuaChiTiet.Text = "Sửa";
            this.btn_SuaChiTiet.UseVisualStyleBackColor = true;
            this.btn_SuaChiTiet.Click += new System.EventHandler(this.btn_SuaChiTiet_Click);
            // 
            // btn_XoaChiTiet
            // 
            this.btn_XoaChiTiet.Location = new System.Drawing.Point(989, 47);
            this.btn_XoaChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_XoaChiTiet.Name = "btn_XoaChiTiet";
            this.btn_XoaChiTiet.Size = new System.Drawing.Size(100, 60);
            this.btn_XoaChiTiet.TabIndex = 67;
            this.btn_XoaChiTiet.Text = "Xoá";
            this.btn_XoaChiTiet.UseVisualStyleBackColor = true;
            this.btn_XoaChiTiet.Click += new System.EventHandler(this.btn_XoaChiTiet_Click);
            // 
            // btn_ThemChiTiet
            // 
            this.btn_ThemChiTiet.Location = new System.Drawing.Point(844, 47);
            this.btn_ThemChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ThemChiTiet.Name = "btn_ThemChiTiet";
            this.btn_ThemChiTiet.Size = new System.Drawing.Size(100, 60);
            this.btn_ThemChiTiet.TabIndex = 66;
            this.btn_ThemChiTiet.Text = "Thêm";
            this.btn_ThemChiTiet.UseVisualStyleBackColor = true;
            this.btn_ThemChiTiet.Click += new System.EventHandler(this.btn_ThemChiTiet_Click);
            // 
            // dgv_DataChiTiet
            // 
            this.dgv_DataChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DataChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataChiTiet.Location = new System.Drawing.Point(8, 215);
            this.dgv_DataChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_DataChiTiet.Name = "dgv_DataChiTiet";
            this.dgv_DataChiTiet.RowHeadersWidth = 51;
            this.dgv_DataChiTiet.Size = new System.Drawing.Size(1147, 201);
            this.dgv_DataChiTiet.TabIndex = 65;
            this.dgv_DataChiTiet.Click += new System.EventHandler(this.dgv_DataChiTiet_Click);
            // 
            // rtf_GhiChu
            // 
            this.rtf_GhiChu.Location = new System.Drawing.Point(589, 144);
            this.rtf_GhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtf_GhiChu.Name = "rtf_GhiChu";
            this.rtf_GhiChu.Size = new System.Drawing.Size(200, 66);
            this.rtf_GhiChu.TabIndex = 64;
            this.rtf_GhiChu.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(448, 138);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "Ghi chú";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(448, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 62;
            this.label11.Text = "Trang thái ";
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TrangThai.Enabled = false;
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Location = new System.Drawing.Point(589, 96);
            this.cbo_TrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(200, 32);
            this.cbo_TrangThai.TabIndex = 60;
            // 
            // txt_ChenhLech
            // 
            this.txt_ChenhLech.Enabled = false;
            this.txt_ChenhLech.Location = new System.Drawing.Point(589, 49);
            this.txt_ChenhLech.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ChenhLech.Name = "txt_ChenhLech";
            this.txt_ChenhLech.Size = new System.Drawing.Size(200, 29);
            this.txt_ChenhLech.TabIndex = 57;
            // 
            // txt_SLThucTe
            // 
            this.txt_SLThucTe.Location = new System.Drawing.Point(193, 178);
            this.txt_SLThucTe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SLThucTe.Name = "txt_SLThucTe";
            this.txt_SLThucTe.Size = new System.Drawing.Size(200, 29);
            this.txt_SLThucTe.TabIndex = 56;
            this.txt_SLThucTe.Leave += new System.EventHandler(this.txt_SLThucTe_Leave);
            // 
            // cbo_MaSP
            // 
            this.cbo_MaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaSP.FormattingEnabled = true;
            this.cbo_MaSP.Location = new System.Drawing.Point(193, 47);
            this.cbo_MaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_MaSP.Name = "cbo_MaSP";
            this.cbo_MaSP.Size = new System.Drawing.Size(200, 32);
            this.cbo_MaSP.TabIndex = 48;
            this.cbo_MaSP.SelectedValueChanged += new System.EventHandler(this.cbo_MaSP_SelectedValueChanged);
            // 
            // txt_SLHeThong
            // 
            this.txt_SLHeThong.Enabled = false;
            this.txt_SLHeThong.Location = new System.Drawing.Point(193, 139);
            this.txt_SLHeThong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SLHeThong.Name = "txt_SLHeThong";
            this.txt_SLHeThong.Size = new System.Drawing.Size(200, 29);
            this.txt_SLHeThong.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Chênh lệch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "SL hệ thống";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "SL thực tế";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Mã sản phẩm";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(31, 146);
            this.dgv_Data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.Size = new System.Drawing.Size(1087, 183);
            this.dgv_Data.TabIndex = 62;
            this.dgv_Data.Click += new System.EventHandler(this.dgv_Data_Click);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(589, 37);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(200, 29);
            this.txt_MaNV.TabIndex = 58;
            // 
            // gbo_NhapThongTin
            // 
            this.gbo_NhapThongTin.Controls.Add(this.btn_HoanTat);
            this.gbo_NhapThongTin.Controls.Add(this.dgv_Data);
            this.gbo_NhapThongTin.Controls.Add(this.txt_MaNV);
            this.gbo_NhapThongTin.Controls.Add(this.cbo_MaCH);
            this.gbo_NhapThongTin.Controls.Add(this.btn_Them);
            this.gbo_NhapThongTin.Controls.Add(this.dtp_NgayKiem);
            this.gbo_NhapThongTin.Controls.Add(this.btn_Xoa);
            this.gbo_NhapThongTin.Controls.Add(this.txt_MaKK);
            this.gbo_NhapThongTin.Controls.Add(this.label5);
            this.gbo_NhapThongTin.Controls.Add(this.label);
            this.gbo_NhapThongTin.Controls.Add(this.label3);
            this.gbo_NhapThongTin.Controls.Add(this.label2);
            this.gbo_NhapThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_NhapThongTin.Location = new System.Drawing.Point(80, 91);
            this.gbo_NhapThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_NhapThongTin.Name = "gbo_NhapThongTin";
            this.gbo_NhapThongTin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_NhapThongTin.Size = new System.Drawing.Size(1163, 337);
            this.gbo_NhapThongTin.TabIndex = 62;
            this.gbo_NhapThongTin.TabStop = false;
            this.gbo_NhapThongTin.Text = "Thông tin kiểm kê ";
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.Enabled = false;
            this.btn_HoanTat.Location = new System.Drawing.Point(919, 92);
            this.btn_HoanTat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(100, 47);
            this.btn_HoanTat.TabIndex = 69;
            this.btn_HoanTat.Text = "Hoàn tất";
            this.btn_HoanTat.UseVisualStyleBackColor = true;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // cbo_MaCH
            // 
            this.cbo_MaCH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaCH.Enabled = false;
            this.cbo_MaCH.FormattingEnabled = true;
            this.cbo_MaCH.Location = new System.Drawing.Point(193, 38);
            this.cbo_MaCH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_MaCH.Name = "cbo_MaCH";
            this.cbo_MaCH.Size = new System.Drawing.Size(200, 32);
            this.cbo_MaCH.TabIndex = 48;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(989, 37);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 47);
            this.btn_Them.TabIndex = 42;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dtp_NgayKiem
            // 
            this.dtp_NgayKiem.Enabled = false;
            this.dtp_NgayKiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayKiem.Location = new System.Drawing.Point(589, 80);
            this.dtp_NgayKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_NgayKiem.Name = "dtp_NgayKiem";
            this.dtp_NgayKiem.Size = new System.Drawing.Size(200, 29);
            this.dtp_NgayKiem.TabIndex = 57;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(844, 38);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 47);
            this.btn_Xoa.TabIndex = 43;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_MaKK
            // 
            this.txt_MaKK.Enabled = false;
            this.txt_MaKK.Location = new System.Drawing.Point(193, 80);
            this.txt_MaKK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaKK.Name = "txt_MaKK";
            this.txt_MaKK.Size = new System.Drawing.Size(200, 29);
            this.txt_MaKK.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ngày kiểm";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(52, 79);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 20);
            this.label.TabIndex = 51;
            this.label.Text = "Mã kiểm kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã cửa hàng ";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(577, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(181, 42);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Kiểm kho";
            // 
            // gbo_ThongTin
            // 
            this.gbo_ThongTin.Controls.Add(this.txt_TenSP);
            this.gbo_ThongTin.Controls.Add(this.lbl_TenSP);
            this.gbo_ThongTin.Controls.Add(this.btn_LamMoiChiTiet);
            this.gbo_ThongTin.Controls.Add(this.btn_SuaChiTiet);
            this.gbo_ThongTin.Controls.Add(this.btn_XoaChiTiet);
            this.gbo_ThongTin.Controls.Add(this.btn_ThemChiTiet);
            this.gbo_ThongTin.Controls.Add(this.dgv_DataChiTiet);
            this.gbo_ThongTin.Controls.Add(this.rtf_GhiChu);
            this.gbo_ThongTin.Controls.Add(this.label12);
            this.gbo_ThongTin.Controls.Add(this.label11);
            this.gbo_ThongTin.Controls.Add(this.cbo_TrangThai);
            this.gbo_ThongTin.Controls.Add(this.txt_ChenhLech);
            this.gbo_ThongTin.Controls.Add(this.txt_SLThucTe);
            this.gbo_ThongTin.Controls.Add(this.cbo_MaSP);
            this.gbo_ThongTin.Controls.Add(this.txt_SLHeThong);
            this.gbo_ThongTin.Controls.Add(this.label4);
            this.gbo_ThongTin.Controls.Add(this.label7);
            this.gbo_ThongTin.Controls.Add(this.label8);
            this.gbo_ThongTin.Controls.Add(this.label9);
            this.gbo_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_ThongTin.Location = new System.Drawing.Point(80, 436);
            this.gbo_ThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_ThongTin.Name = "gbo_ThongTin";
            this.gbo_ThongTin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_ThongTin.Size = new System.Drawing.Size(1163, 434);
            this.gbo_ThongTin.TabIndex = 63;
            this.gbo_ThongTin.TabStop = false;
            this.gbo_ThongTin.Text = "Thông tin chi tiết kiểm kê";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Enabled = false;
            this.txt_TenSP.Location = new System.Drawing.Point(193, 90);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(200, 29);
            this.txt_TenSP.TabIndex = 78;
            // 
            // lbl_TenSP
            // 
            this.lbl_TenSP.AutoSize = true;
            this.lbl_TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSP.Location = new System.Drawing.Point(52, 90);
            this.lbl_TenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenSP.Name = "lbl_TenSP";
            this.lbl_TenSP.Size = new System.Drawing.Size(115, 20);
            this.lbl_TenSP.TabIndex = 77;
            this.lbl_TenSP.Text = "Tên sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 64);
            this.panel1.TabIndex = 61;
            // 
            // frm_KiemKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1337, 878);
            this.Controls.Add(this.gbo_NhapThongTin);
            this.Controls.Add(this.gbo_ThongTin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "frm_KiemKho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_KiemKho_Load);
            this.Resize += new System.EventHandler(this.frm_KiemKho_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.gbo_NhapThongTin.ResumeLayout(false);
            this.gbo_NhapThongTin.PerformLayout();
            this.gbo_ThongTin.ResumeLayout(false);
            this.gbo_ThongTin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LamMoiChiTiet;
        private System.Windows.Forms.Button btn_SuaChiTiet;
        private System.Windows.Forms.Button btn_XoaChiTiet;
        private System.Windows.Forms.Button btn_ThemChiTiet;
        private System.Windows.Forms.DataGridView dgv_DataChiTiet;
        private System.Windows.Forms.RichTextBox rtf_GhiChu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.TextBox txt_ChenhLech;
        private System.Windows.Forms.TextBox txt_SLThucTe;
        private System.Windows.Forms.ComboBox cbo_MaSP;
        private System.Windows.Forms.TextBox txt_SLHeThong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.GroupBox gbo_NhapThongTin;
        private System.Windows.Forms.ComboBox cbo_MaCH;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DateTimePicker dtp_NgayKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_MaKK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox gbo_ThongTin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_HoanTat;
		private System.Windows.Forms.TextBox txt_TenSP;
		private System.Windows.Forms.Label lbl_TenSP;
	}
}