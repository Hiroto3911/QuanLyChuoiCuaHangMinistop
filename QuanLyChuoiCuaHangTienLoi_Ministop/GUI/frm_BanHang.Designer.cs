namespace GUI
{
    partial class frm_BanHang
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
            this.dtp_NgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbo_HoaDon = new System.Windows.Forms.GroupBox();
            this.lbl_KhuyenMai_HoaDon = new System.Windows.Forms.Label();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.gbo_ChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.lbl_KhuyenMai_SanPham = new System.Windows.Forms.Label();
            this.lbl_TenSP = new System.Windows.Forms.Label();
            this.txt_SanPham = new System.Windows.Forms.TextBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.btn_LamMoiChiTiet = new System.Windows.Forms.Button();
            this.btn_SuaChiTiet = new System.Windows.Forms.Button();
            this.btn_XoaChiTiet = new System.Windows.Forms.Button();
            this.btn_ThemChiTiet = new System.Windows.Forms.Button();
            this.dgv_DataChiTiet = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.txt_MaCTHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbo_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.gbo_ChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 64);
            this.panel1.TabIndex = 64;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(577, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(187, 42);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Bán hàng";
            // 
            // cbo_MaCH
            // 
            this.cbo_MaCH.Enabled = false;
            this.cbo_MaCH.FormattingEnabled = true;
            this.cbo_MaCH.Location = new System.Drawing.Point(168, 39);
            this.cbo_MaCH.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MaCH.Name = "cbo_MaCH";
            this.cbo_MaCH.Size = new System.Drawing.Size(200, 32);
            this.cbo_MaCH.TabIndex = 48;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(964, 39);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 60);
            this.btn_Them.TabIndex = 42;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dtp_NgayLapHD
            // 
            this.dtp_NgayLapHD.Enabled = false;
            this.dtp_NgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLapHD.Location = new System.Drawing.Point(564, 81);
            this.dtp_NgayLapHD.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayLapHD.Name = "dtp_NgayLapHD";
            this.dtp_NgayLapHD.Size = new System.Drawing.Size(200, 29);
            this.dtp_NgayLapHD.TabIndex = 57;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(819, 39);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 59);
            this.btn_Xoa.TabIndex = 43;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Enabled = false;
            this.txt_MaHD.Location = new System.Drawing.Point(168, 81);
            this.txt_MaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(200, 29);
            this.txt_MaHD.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ngày lập";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(27, 80);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(96, 20);
            this.label.TabIndex = 51;
            this.label.Text = "Mã hoá đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 38);
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
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã cửa hàng ";
            // 
            // gbo_HoaDon
            // 
            this.gbo_HoaDon.Controls.Add(this.lbl_KhuyenMai_HoaDon);
            this.gbo_HoaDon.Controls.Add(this.btn_HoanTat);
            this.gbo_HoaDon.Controls.Add(this.btn_InHoaDon);
            this.gbo_HoaDon.Controls.Add(this.txt_TongTien);
            this.gbo_HoaDon.Controls.Add(this.label1);
            this.gbo_HoaDon.Controls.Add(this.dgv_Data);
            this.gbo_HoaDon.Controls.Add(this.txt_MaNV);
            this.gbo_HoaDon.Controls.Add(this.cbo_MaCH);
            this.gbo_HoaDon.Controls.Add(this.btn_Them);
            this.gbo_HoaDon.Controls.Add(this.dtp_NgayLapHD);
            this.gbo_HoaDon.Controls.Add(this.btn_Xoa);
            this.gbo_HoaDon.Controls.Add(this.txt_MaHD);
            this.gbo_HoaDon.Controls.Add(this.label5);
            this.gbo_HoaDon.Controls.Add(this.label);
            this.gbo_HoaDon.Controls.Add(this.label3);
            this.gbo_HoaDon.Controls.Add(this.label2);
            this.gbo_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_HoaDon.Location = new System.Drawing.Point(80, 71);
            this.gbo_HoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.gbo_HoaDon.Name = "gbo_HoaDon";
            this.gbo_HoaDon.Padding = new System.Windows.Forms.Padding(4);
            this.gbo_HoaDon.Size = new System.Drawing.Size(1163, 353);
            this.gbo_HoaDon.TabIndex = 65;
            this.gbo_HoaDon.TabStop = false;
            this.gbo_HoaDon.Text = "Thông tin Hoá đơn";
            // 
            // lbl_KhuyenMai_HoaDon
            // 
            this.lbl_KhuyenMai_HoaDon.AutoSize = true;
            this.lbl_KhuyenMai_HoaDon.Location = new System.Drawing.Point(28, 164);
            this.lbl_KhuyenMai_HoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KhuyenMai_HoaDon.Name = "lbl_KhuyenMai_HoaDon";
            this.lbl_KhuyenMai_HoaDon.Size = new System.Drawing.Size(0, 24);
            this.lbl_KhuyenMai_HoaDon.TabIndex = 67;
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.Enabled = false;
            this.btn_HoanTat.Location = new System.Drawing.Point(964, 111);
            this.btn_HoanTat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(100, 60);
            this.btn_HoanTat.TabIndex = 66;
            this.btn_HoanTat.Text = "Hoàn tất";
            this.btn_HoanTat.UseVisualStyleBackColor = true;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.Enabled = false;
            this.btn_InHoaDon.Location = new System.Drawing.Point(819, 112);
            this.btn_InHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(100, 59);
            this.btn_InHoaDon.TabIndex = 65;
            this.btn_InHoaDon.Text = "In hoá đơn";
            this.btn_InHoaDon.UseVisualStyleBackColor = true;
            this.btn_InHoaDon.Click += new System.EventHandler(this.btn_InHoaDon_Click);
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Location = new System.Drawing.Point(564, 126);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(200, 29);
            this.txt_TongTien.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tổng tiền";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(31, 190);
            this.dgv_Data.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.Size = new System.Drawing.Size(1087, 156);
            this.dgv_Data.TabIndex = 62;
            this.dgv_Data.Click += new System.EventHandler(this.dgv_Data_Click);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(564, 38);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(200, 29);
            this.txt_MaNV.TabIndex = 58;
            // 
            // gbo_ChiTietHoaDon
            // 
            this.gbo_ChiTietHoaDon.Controls.Add(this.lbl_KhuyenMai_SanPham);
            this.gbo_ChiTietHoaDon.Controls.Add(this.lbl_TenSP);
            this.gbo_ChiTietHoaDon.Controls.Add(this.txt_SanPham);
            this.gbo_ChiTietHoaDon.Controls.Add(this.txt_ThanhTien);
            this.gbo_ChiTietHoaDon.Controls.Add(this.btn_LamMoiChiTiet);
            this.gbo_ChiTietHoaDon.Controls.Add(this.btn_SuaChiTiet);
            this.gbo_ChiTietHoaDon.Controls.Add(this.btn_XoaChiTiet);
            this.gbo_ChiTietHoaDon.Controls.Add(this.btn_ThemChiTiet);
            this.gbo_ChiTietHoaDon.Controls.Add(this.dgv_DataChiTiet);
            this.gbo_ChiTietHoaDon.Controls.Add(this.label11);
            this.gbo_ChiTietHoaDon.Controls.Add(this.txt_DonGia);
            this.gbo_ChiTietHoaDon.Controls.Add(this.txt_SL);
            this.gbo_ChiTietHoaDon.Controls.Add(this.txt_MaCTHD);
            this.gbo_ChiTietHoaDon.Controls.Add(this.label4);
            this.gbo_ChiTietHoaDon.Controls.Add(this.label7);
            this.gbo_ChiTietHoaDon.Controls.Add(this.label8);
            this.gbo_ChiTietHoaDon.Controls.Add(this.label9);
            this.gbo_ChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_ChiTietHoaDon.Location = new System.Drawing.Point(80, 444);
            this.gbo_ChiTietHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.gbo_ChiTietHoaDon.Name = "gbo_ChiTietHoaDon";
            this.gbo_ChiTietHoaDon.Padding = new System.Windows.Forms.Padding(4);
            this.gbo_ChiTietHoaDon.Size = new System.Drawing.Size(1163, 418);
            this.gbo_ChiTietHoaDon.TabIndex = 66;
            this.gbo_ChiTietHoaDon.TabStop = false;
            this.gbo_ChiTietHoaDon.Text = "Thông tin chi tiết Hoá đơn";
            // 
            // lbl_KhuyenMai_SanPham
            // 
            this.lbl_KhuyenMai_SanPham.AutoSize = true;
            this.lbl_KhuyenMai_SanPham.Location = new System.Drawing.Point(28, 172);
            this.lbl_KhuyenMai_SanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KhuyenMai_SanPham.Name = "lbl_KhuyenMai_SanPham";
            this.lbl_KhuyenMai_SanPham.Size = new System.Drawing.Size(0, 24);
            this.lbl_KhuyenMai_SanPham.TabIndex = 73;
            // 
            // lbl_TenSP
            // 
            this.lbl_TenSP.AutoSize = true;
            this.lbl_TenSP.Location = new System.Drawing.Point(164, 126);
            this.lbl_TenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenSP.Name = "lbl_TenSP";
            this.lbl_TenSP.Size = new System.Drawing.Size(132, 24);
            this.lbl_TenSP.TabIndex = 72;
            this.lbl_TenSP.Text = "Tên sản phẩm";
            // 
            // txt_SanPham
            // 
            this.txt_SanPham.Location = new System.Drawing.Point(168, 92);
            this.txt_SanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SanPham.Name = "txt_SanPham";
            this.txt_SanPham.Size = new System.Drawing.Size(200, 29);
            this.txt_SanPham.TabIndex = 71;
            this.txt_SanPham.Text = "SP00";
            this.txt_SanPham.Leave += new System.EventHandler(this.txt_SanPham_Leave);
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Location = new System.Drawing.Point(564, 142);
            this.txt_ThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(200, 29);
            this.txt_ThanhTien.TabIndex = 70;
            this.txt_ThanhTien.Text = "0";
            // 
            // btn_LamMoiChiTiet
            // 
            this.btn_LamMoiChiTiet.Location = new System.Drawing.Point(964, 127);
            this.btn_LamMoiChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LamMoiChiTiet.Name = "btn_LamMoiChiTiet";
            this.btn_LamMoiChiTiet.Size = new System.Drawing.Size(100, 60);
            this.btn_LamMoiChiTiet.TabIndex = 69;
            this.btn_LamMoiChiTiet.Text = "Làm mới";
            this.btn_LamMoiChiTiet.UseVisualStyleBackColor = true;
            this.btn_LamMoiChiTiet.Click += new System.EventHandler(this.btn_LamMoiChiTiet_Click);
            // 
            // btn_SuaChiTiet
            // 
            this.btn_SuaChiTiet.Enabled = false;
            this.btn_SuaChiTiet.Location = new System.Drawing.Point(819, 127);
            this.btn_SuaChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaChiTiet.Name = "btn_SuaChiTiet";
            this.btn_SuaChiTiet.Size = new System.Drawing.Size(100, 60);
            this.btn_SuaChiTiet.TabIndex = 68;
            this.btn_SuaChiTiet.Text = "Sửa";
            this.btn_SuaChiTiet.UseVisualStyleBackColor = true;
            this.btn_SuaChiTiet.Click += new System.EventHandler(this.btn_SuaChiTiet_Click);
            // 
            // btn_XoaChiTiet
            // 
            this.btn_XoaChiTiet.Enabled = false;
            this.btn_XoaChiTiet.Location = new System.Drawing.Point(964, 44);
            this.btn_XoaChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaChiTiet.Name = "btn_XoaChiTiet";
            this.btn_XoaChiTiet.Size = new System.Drawing.Size(100, 60);
            this.btn_XoaChiTiet.TabIndex = 67;
            this.btn_XoaChiTiet.Text = "Xoá";
            this.btn_XoaChiTiet.UseVisualStyleBackColor = true;
            this.btn_XoaChiTiet.Click += new System.EventHandler(this.btn_XoaChiTiet_Click);
            // 
            // btn_ThemChiTiet
            // 
            this.btn_ThemChiTiet.Enabled = false;
            this.btn_ThemChiTiet.Location = new System.Drawing.Point(819, 44);
            this.btn_ThemChiTiet.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgv_DataChiTiet.Location = new System.Drawing.Point(31, 198);
            this.dgv_DataChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DataChiTiet.Name = "dgv_DataChiTiet";
            this.dgv_DataChiTiet.RowHeadersWidth = 51;
            this.dgv_DataChiTiet.Size = new System.Drawing.Size(1087, 213);
            this.dgv_DataChiTiet.TabIndex = 65;
            this.dgv_DataChiTiet.Click += new System.EventHandler(this.dgv_DataChiTiet_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(421, 142);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 62;
            this.label11.Text = "Thành tiền";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Enabled = false;
            this.txt_DonGia.Location = new System.Drawing.Point(564, 92);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(200, 29);
            this.txt_DonGia.TabIndex = 57;
            // 
            // txt_SL
            // 
            this.txt_SL.Location = new System.Drawing.Point(564, 47);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(200, 29);
            this.txt_SL.TabIndex = 56;
            // 
            // txt_MaCTHD
            // 
            this.txt_MaCTHD.Enabled = false;
            this.txt_MaCTHD.Location = new System.Drawing.Point(168, 44);
            this.txt_MaCTHD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaCTHD.Name = "txt_MaCTHD";
            this.txt_MaCTHD.Size = new System.Drawing.Size(200, 29);
            this.txt_MaCTHD.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Mã chi tiết HD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "SL Mua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Mã sản phẩm";
            // 
            // frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1337, 878);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbo_HoaDon);
            this.Controls.Add(this.gbo_ChiTietHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BanHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BanHang_Load);
            this.Resize += new System.EventHandler(this.frm_BanHang_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbo_HoaDon.ResumeLayout(false);
            this.gbo_HoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.gbo_ChiTietHoaDon.ResumeLayout(false);
            this.gbo_ChiTietHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox cbo_MaCH;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapHD;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbo_HoaDon;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.GroupBox gbo_ChiTietHoaDon;
        private System.Windows.Forms.Button btn_LamMoiChiTiet;
        private System.Windows.Forms.Button btn_SuaChiTiet;
        private System.Windows.Forms.Button btn_XoaChiTiet;
        private System.Windows.Forms.Button btn_ThemChiTiet;
        private System.Windows.Forms.DataGridView dgv_DataChiTiet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.TextBox txt_MaCTHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.Button btn_HoanTat;
        private System.Windows.Forms.TextBox txt_SanPham;
        private System.Windows.Forms.Label lbl_TenSP;
        private System.Windows.Forms.Label lbl_KhuyenMai_HoaDon;
        private System.Windows.Forms.Label lbl_KhuyenMai_SanPham;
    }
}