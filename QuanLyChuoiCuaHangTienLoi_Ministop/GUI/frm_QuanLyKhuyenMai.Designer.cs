namespace GUI
{
    partial class frm_QuanLyKhuyenMai
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
            this.components = new System.ComponentModel.Container();
            this.llbl_title = new System.Windows.Forms.Label();
            this.cbo_MaKM = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dtp_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbo_ChiTietKhuyenMai = new System.Windows.Forms.GroupBox();
            this.cbo_MaSP = new System.Windows.Forms.ComboBox();
            this.cbo_UuTien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SLToiThieu = new System.Windows.Forms.TextBox();
            this.btn_LamMoiChiTiet = new System.Windows.Forms.Button();
            this.btn_SuaChiTiet = new System.Windows.Forms.Button();
            this.btn_XoaChiTiet = new System.Windows.Forms.Button();
            this.btn_ThemChiTiet = new System.Windows.Forms.Button();
            this.dgv_DataChiTiet = new System.Windows.Forms.DataGridView();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.txt_DieuKienApDung = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_MucGiam = new System.Windows.Forms.TextBox();
            this.gbo_KhuyenMai = new System.Windows.Forms.GroupBox();
            this.cbo_LocDuLieu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_MaKM = new System.Windows.Forms.TextBox();
            this.rb_Tat = new System.Windows.Forms.RadioButton();
            this.rb_Bat = new System.Windows.Forms.RadioButton();
            this.cbo_LoaiApDung = new System.Windows.Forms.ComboBox();
            this.dtp_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenKM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbo_ChiTietKhuyenMai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.pnl_Title.SuspendLayout();
            this.gbo_KhuyenMai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // llbl_title
            // 
            this.llbl_title.AutoSize = true;
            this.llbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_title.ForeColor = System.Drawing.Color.White;
            this.llbl_title.Location = new System.Drawing.Point(456, 11);
            this.llbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_title.Name = "llbl_title";
            this.llbl_title.Size = new System.Drawing.Size(366, 42);
            this.llbl_title.TabIndex = 18;
            this.llbl_title.Text = "Quản lý khuyến mãi";
            // 
            // cbo_MaKM
            // 
            this.cbo_MaKM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_MaKM.DropDownWidth = 200;
            this.cbo_MaKM.FormattingEnabled = true;
            this.cbo_MaKM.Location = new System.Drawing.Point(168, 46);
            this.cbo_MaKM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_MaKM.Name = "cbo_MaKM";
            this.cbo_MaKM.Size = new System.Drawing.Size(200, 32);
            this.cbo_MaKM.TabIndex = 48;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(1168, 48);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 32);
            this.btn_Them.TabIndex = 42;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dtp_NgayBatDau
            // 
            this.dtp_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayBatDau.Location = new System.Drawing.Point(531, 47);
            this.dtp_NgayBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            this.dtp_NgayBatDau.Size = new System.Drawing.Size(200, 29);
            this.dtp_NgayBatDau.TabIndex = 57;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(1168, 98);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 32);
            this.btn_Xoa.TabIndex = 43;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(15, 96);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(110, 20);
            this.label.TabIndex = 51;
            this.label.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "SL tối thiểu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã khuyến mãi";
            // 
            // gbo_ChiTietKhuyenMai
            // 
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.cbo_MaSP);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.cbo_UuTien);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.label1);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.txt_SLToiThieu);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.cbo_MaKM);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.btn_LamMoiChiTiet);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.btn_SuaChiTiet);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.btn_XoaChiTiet);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.btn_ThemChiTiet);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.label);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.label3);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.label2);
            this.gbo_ChiTietKhuyenMai.Controls.Add(this.dgv_DataChiTiet);
            this.gbo_ChiTietKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_ChiTietKhuyenMai.Location = new System.Drawing.Point(16, 530);
            this.gbo_ChiTietKhuyenMai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_ChiTietKhuyenMai.Name = "gbo_ChiTietKhuyenMai";
            this.gbo_ChiTietKhuyenMai.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_ChiTietKhuyenMai.Size = new System.Drawing.Size(1305, 337);
            this.gbo_ChiTietKhuyenMai.TabIndex = 71;
            this.gbo_ChiTietKhuyenMai.TabStop = false;
            this.gbo_ChiTietKhuyenMai.Text = "Chi tiết khuyến mãi";
            // 
            // cbo_MaSP
            // 
            this.cbo_MaSP.DropDownWidth = 200;
            this.cbo_MaSP.FormattingEnabled = true;
            this.cbo_MaSP.Location = new System.Drawing.Point(168, 98);
            this.cbo_MaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_MaSP.Name = "cbo_MaSP";
            this.cbo_MaSP.Size = new System.Drawing.Size(200, 32);
            this.cbo_MaSP.TabIndex = 70;
            // 
            // cbo_UuTien
            // 
            this.cbo_UuTien.FormattingEnabled = true;
            this.cbo_UuTien.Location = new System.Drawing.Point(531, 98);
            this.cbo_UuTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_UuTien.Name = "cbo_UuTien";
            this.cbo_UuTien.Size = new System.Drawing.Size(200, 32);
            this.cbo_UuTien.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Độ ưu tiên";
            // 
            // txt_SLToiThieu
            // 
            this.txt_SLToiThieu.Location = new System.Drawing.Point(531, 48);
            this.txt_SLToiThieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SLToiThieu.Name = "txt_SLToiThieu";
            this.txt_SLToiThieu.Size = new System.Drawing.Size(200, 29);
            this.txt_SLToiThieu.TabIndex = 58;
            // 
            // btn_LamMoiChiTiet
            // 
            this.btn_LamMoiChiTiet.Location = new System.Drawing.Point(1168, 48);
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
            this.btn_SuaChiTiet.Location = new System.Drawing.Point(1041, 46);
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
            this.btn_XoaChiTiet.Location = new System.Drawing.Point(923, 46);
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
            this.btn_ThemChiTiet.Location = new System.Drawing.Point(792, 46);
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
            this.dgv_DataChiTiet.Location = new System.Drawing.Point(8, 138);
            this.dgv_DataChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_DataChiTiet.Name = "dgv_DataChiTiet";
            this.dgv_DataChiTiet.RowHeadersWidth = 51;
            this.dgv_DataChiTiet.Size = new System.Drawing.Size(1289, 187);
            this.dgv_DataChiTiet.TabIndex = 65;
            this.dgv_DataChiTiet.Click += new System.EventHandler(this.dgv_DataChiTiet_Click);
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(8, 193);
            this.dgv_Data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.Size = new System.Drawing.Size(1289, 234);
            this.dgv_Data.TabIndex = 62;
        
            this.dgv_Data.Click += new System.EventHandler(this.dgv_Data_Click);
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.pnl_Title.Controls.Add(this.llbl_title);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(1337, 64);
            this.pnl_Title.TabIndex = 70;
            // 
            // txt_DieuKienApDung
            // 
            this.txt_DieuKienApDung.Location = new System.Drawing.Point(940, 101);
            this.txt_DieuKienApDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DieuKienApDung.Name = "txt_DieuKienApDung";
            this.txt_DieuKienApDung.Size = new System.Drawing.Size(200, 29);
            this.txt_DieuKienApDung.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(389, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "Ngày bắt đầu";
            // 
            // txt_MucGiam
            // 
            this.txt_MucGiam.Location = new System.Drawing.Point(149, 146);
            this.txt_MucGiam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MucGiam.Name = "txt_MucGiam";
            this.txt_MucGiam.Size = new System.Drawing.Size(200, 29);
            this.txt_MucGiam.TabIndex = 56;
            this.txt_MucGiam.Leave += new System.EventHandler(this.txt_MucGiam_Leave);
            // 
            // gbo_KhuyenMai
            // 
            this.gbo_KhuyenMai.Controls.Add(this.cbo_LocDuLieu);
            this.gbo_KhuyenMai.Controls.Add(this.label5);
            this.gbo_KhuyenMai.Controls.Add(this.btn_Sua);
            this.gbo_KhuyenMai.Controls.Add(this.txt_MaKM);
            this.gbo_KhuyenMai.Controls.Add(this.rb_Tat);
            this.gbo_KhuyenMai.Controls.Add(this.dgv_Data);
            this.gbo_KhuyenMai.Controls.Add(this.rb_Bat);
            this.gbo_KhuyenMai.Controls.Add(this.cbo_LoaiApDung);
            this.gbo_KhuyenMai.Controls.Add(this.dtp_NgayKetThuc);
            this.gbo_KhuyenMai.Controls.Add(this.label14);
            this.gbo_KhuyenMai.Controls.Add(this.btn_Them);
            this.gbo_KhuyenMai.Controls.Add(this.label13);
            this.gbo_KhuyenMai.Controls.Add(this.btn_Xoa);
            this.gbo_KhuyenMai.Controls.Add(this.label10);
            this.gbo_KhuyenMai.Controls.Add(this.label4);
            this.gbo_KhuyenMai.Controls.Add(this.txt_DieuKienApDung);
            this.gbo_KhuyenMai.Controls.Add(this.label12);
            this.gbo_KhuyenMai.Controls.Add(this.dtp_NgayBatDau);
            this.gbo_KhuyenMai.Controls.Add(this.txt_MucGiam);
            this.gbo_KhuyenMai.Controls.Add(this.txt_TenKM);
            this.gbo_KhuyenMai.Controls.Add(this.label7);
            this.gbo_KhuyenMai.Controls.Add(this.label8);
            this.gbo_KhuyenMai.Controls.Add(this.label9);
            this.gbo_KhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_KhuyenMai.Location = new System.Drawing.Point(16, 89);
            this.gbo_KhuyenMai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_KhuyenMai.Name = "gbo_KhuyenMai";
            this.gbo_KhuyenMai.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_KhuyenMai.Size = new System.Drawing.Size(1305, 434);
            this.gbo_KhuyenMai.TabIndex = 72;
            this.gbo_KhuyenMai.TabStop = false;
            this.gbo_KhuyenMai.Text = "Thông tin khuyến mãi";
            this.gbo_KhuyenMai.Enter += new System.EventHandler(this.gbo_KhuyenMai_Enter);
            // 
            // cbo_LocDuLieu
            // 
            this.cbo_LocDuLieu.FormattingEnabled = true;
            this.cbo_LocDuLieu.Location = new System.Drawing.Point(940, 144);
            this.cbo_LocDuLieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_LocDuLieu.Name = "cbo_LocDuLieu";
            this.cbo_LocDuLieu.Size = new System.Drawing.Size(200, 32);
            this.cbo_LocDuLieu.TabIndex = 120;
            this.cbo_LocDuLieu.SelectedValueChanged += new System.EventHandler(this.cbo_LocDuLieu_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(763, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 119;
            this.label5.Text = "Lọc theo";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(1168, 145);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 31);
            this.btn_Sua.TabIndex = 118;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_MaKM
            // 
            this.txt_MaKM.Enabled = false;
            this.txt_MaKM.Location = new System.Drawing.Point(149, 47);
            this.txt_MaKM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaKM.Name = "txt_MaKM";
            this.txt_MaKM.Size = new System.Drawing.Size(200, 29);
            this.txt_MaKM.TabIndex = 117;
            // 
            // rb_Tat
            // 
            this.rb_Tat.AutoSize = true;
            this.rb_Tat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Tat.Location = new System.Drawing.Point(659, 149);
            this.rb_Tat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_Tat.Name = "rb_Tat";
            this.rb_Tat.Size = new System.Drawing.Size(54, 24);
            this.rb_Tat.TabIndex = 116;
            this.rb_Tat.TabStop = true;
            this.rb_Tat.Text = "Tắt";
            this.rb_Tat.UseVisualStyleBackColor = true;
            // 
            // rb_Bat
            // 
            this.rb_Bat.AutoSize = true;
            this.rb_Bat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Bat.Location = new System.Drawing.Point(568, 149);
            this.rb_Bat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_Bat.Name = "rb_Bat";
            this.rb_Bat.Size = new System.Drawing.Size(56, 24);
            this.rb_Bat.TabIndex = 115;
            this.rb_Bat.TabStop = true;
            this.rb_Bat.Text = "Bật";
            this.rb_Bat.UseVisualStyleBackColor = true;
            // 
            // cbo_LoaiApDung
            // 
            this.cbo_LoaiApDung.FormattingEnabled = true;
            this.cbo_LoaiApDung.Location = new System.Drawing.Point(940, 47);
            this.cbo_LoaiApDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_LoaiApDung.Name = "cbo_LoaiApDung";
            this.cbo_LoaiApDung.Size = new System.Drawing.Size(200, 32);
            this.cbo_LoaiApDung.TabIndex = 77;
            this.cbo_LoaiApDung.SelectedValueChanged += new System.EventHandler(this.cbo_LoaiApDung_SelectedValueChanged);
            // 
            // dtp_NgayKetThuc
            // 
            this.dtp_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayKetThuc.Location = new System.Drawing.Point(531, 97);
            this.dtp_NgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            this.dtp_NgayKetThuc.Size = new System.Drawing.Size(200, 29);
            this.dtp_NgayKetThuc.TabIndex = 75;
            this.dtp_NgayKetThuc.Leave += new System.EventHandler(this.dtp_NgayKetThuc_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(391, 146);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 74;
            this.label14.Text = "Trạng thái";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(763, 47);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 73;
            this.label13.Text = "Loại áp dụng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(763, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 72;
            this.label10.Text = "Điều kiện áp dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Ngày kết thúc";
            // 
            // txt_TenKM
            // 
            this.txt_TenKM.Location = new System.Drawing.Point(149, 98);
            this.txt_TenKM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenKM.Name = "txt_TenKM";
            this.txt_TenKM.Size = new System.Drawing.Size(200, 29);
            this.txt_TenKM.TabIndex = 50;
            this.txt_TenKM.Leave += new System.EventHandler(this.txt_TenKM_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Tên khuyến mãi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Mức giảm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Mã Khuyến mãi";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_QuanLyKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1337, 878);
            this.Controls.Add(this.gbo_ChiTietKhuyenMai);
            this.Controls.Add(this.pnl_Title);
            this.Controls.Add(this.gbo_KhuyenMai);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_QuanLyKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QuanLyKhuyenMai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_QuanLyKhuyenMai_Load);
            this.Resize += new System.EventHandler(this.frm_QuanLyKhuyenMai_Resize);
            this.gbo_ChiTietKhuyenMai.ResumeLayout(false);
            this.gbo_ChiTietKhuyenMai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.gbo_KhuyenMai.ResumeLayout(false);
            this.gbo_KhuyenMai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label llbl_title;
        private System.Windows.Forms.ComboBox cbo_MaKM;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DateTimePicker dtp_NgayBatDau;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbo_ChiTietKhuyenMai;
        private System.Windows.Forms.ComboBox cbo_UuTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.TextBox txt_SLToiThieu;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.TextBox txt_DieuKienApDung;
        private System.Windows.Forms.Button btn_ThemChiTiet;
        private System.Windows.Forms.DataGridView dgv_DataChiTiet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_MucGiam;
        private System.Windows.Forms.GroupBox gbo_KhuyenMai;
        private System.Windows.Forms.Button btn_LamMoiChiTiet;
        private System.Windows.Forms.Button btn_SuaChiTiet;
        private System.Windows.Forms.Button btn_XoaChiTiet;
        private System.Windows.Forms.TextBox txt_TenKM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_LoaiApDung;
        private System.Windows.Forms.DateTimePicker dtp_NgayKetThuc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaKM;
        private System.Windows.Forms.RadioButton rb_Tat;
        private System.Windows.Forms.RadioButton rb_Bat;
        private System.Windows.Forms.ComboBox cbo_MaSP;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbo_LocDuLieu;
        private System.Windows.Forms.Label label5;
    }
}