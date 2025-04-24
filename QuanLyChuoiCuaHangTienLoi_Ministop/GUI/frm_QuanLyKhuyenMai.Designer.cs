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
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_MaKM = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dtp_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_MaSP = new System.Windows.Forms.ComboBox();
            this.cbo_UuTien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.txt_SLToiThieu = new System.Windows.Forms.TextBox();
            this.btn_LamMoiChiTiet = new System.Windows.Forms.Button();
            this.btn_SuaChiTiet = new System.Windows.Forms.Button();
            this.btn_XoaChiTiet = new System.Windows.Forms.Button();
            this.btn_ThemChiTiet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_DieuKienApDung = new System.Windows.Forms.TextBox();
            this.dgv_DataChiTiet = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_MucGiam = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataChiTiet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(342, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quản lý khuyến mãi";
            // 
            // cbo_MaKM
            // 
            this.cbo_MaKM.Enabled = false;
            this.cbo_MaKM.FormattingEnabled = true;
            this.cbo_MaKM.Location = new System.Drawing.Point(126, 37);
            this.cbo_MaKM.Name = "cbo_MaKM";
            this.cbo_MaKM.Size = new System.Drawing.Size(151, 26);
            this.cbo_MaKM.TabIndex = 48;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(876, 28);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 49);
            this.btn_Them.TabIndex = 42;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // dtp_NgayBatDau
            // 
            this.dtp_NgayBatDau.Enabled = false;
            this.dtp_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayBatDau.Location = new System.Drawing.Point(398, 38);
            this.dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            this.dtp_NgayBatDau.Size = new System.Drawing.Size(151, 24);
            this.dtp_NgayBatDau.TabIndex = 57;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(876, 95);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 48);
            this.btn_Xoa.TabIndex = 43;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(11, 78);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 16);
            this.label.TabIndex = 51;
            this.label.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "SL tối thiểu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã khuyến mãi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_MaSP);
            this.groupBox1.Controls.Add(this.cbo_UuTien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_Data);
            this.groupBox1.Controls.Add(this.txt_SLToiThieu);
            this.groupBox1.Controls.Add(this.cbo_MaKM);
            this.groupBox1.Controls.Add(this.btn_LamMoiChiTiet);
            this.groupBox1.Controls.Add(this.btn_SuaChiTiet);
            this.groupBox1.Controls.Add(this.btn_XoaChiTiet);
            this.groupBox1.Controls.Add(this.btn_ThemChiTiet);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 274);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết khuyến mãi";
            // 
            // cbo_MaSP
            // 
            this.cbo_MaSP.Enabled = false;
            this.cbo_MaSP.FormattingEnabled = true;
            this.cbo_MaSP.Location = new System.Drawing.Point(126, 80);
            this.cbo_MaSP.Name = "cbo_MaSP";
            this.cbo_MaSP.Size = new System.Drawing.Size(151, 26);
            this.cbo_MaSP.TabIndex = 70;
            // 
            // cbo_UuTien
            // 
            this.cbo_UuTien.FormattingEnabled = true;
            this.cbo_UuTien.Location = new System.Drawing.Point(398, 80);
            this.cbo_UuTien.Name = "cbo_UuTien";
            this.cbo_UuTien.Size = new System.Drawing.Size(151, 26);
            this.cbo_UuTien.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Độ ưu tiên";
            // 
            // dgv_Data
            // 
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(14, 123);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.Size = new System.Drawing.Size(937, 145);
            this.dgv_Data.TabIndex = 62;
            // 
            // txt_SLToiThieu
            // 
            this.txt_SLToiThieu.Enabled = false;
            this.txt_SLToiThieu.Location = new System.Drawing.Point(398, 39);
            this.txt_SLToiThieu.Name = "txt_SLToiThieu";
            this.txt_SLToiThieu.Size = new System.Drawing.Size(151, 24);
            this.txt_SLToiThieu.TabIndex = 58;
            // 
            // btn_LamMoiChiTiet
            // 
            this.btn_LamMoiChiTiet.Location = new System.Drawing.Point(876, 39);
            this.btn_LamMoiChiTiet.Name = "btn_LamMoiChiTiet";
            this.btn_LamMoiChiTiet.Size = new System.Drawing.Size(75, 49);
            this.btn_LamMoiChiTiet.TabIndex = 69;
            this.btn_LamMoiChiTiet.Text = "Làm mới";
            this.btn_LamMoiChiTiet.UseVisualStyleBackColor = true;
            // 
            // btn_SuaChiTiet
            // 
            this.btn_SuaChiTiet.Location = new System.Drawing.Point(781, 37);
            this.btn_SuaChiTiet.Name = "btn_SuaChiTiet";
            this.btn_SuaChiTiet.Size = new System.Drawing.Size(75, 49);
            this.btn_SuaChiTiet.TabIndex = 68;
            this.btn_SuaChiTiet.Text = "Sửa";
            this.btn_SuaChiTiet.UseVisualStyleBackColor = true;
            // 
            // btn_XoaChiTiet
            // 
            this.btn_XoaChiTiet.Location = new System.Drawing.Point(692, 37);
            this.btn_XoaChiTiet.Name = "btn_XoaChiTiet";
            this.btn_XoaChiTiet.Size = new System.Drawing.Size(75, 49);
            this.btn_XoaChiTiet.TabIndex = 67;
            this.btn_XoaChiTiet.Text = "Xoá";
            this.btn_XoaChiTiet.UseVisualStyleBackColor = true;
            // 
            // btn_ThemChiTiet
            // 
            this.btn_ThemChiTiet.Location = new System.Drawing.Point(594, 37);
            this.btn_ThemChiTiet.Name = "btn_ThemChiTiet";
            this.btn_ThemChiTiet.Size = new System.Drawing.Size(75, 49);
            this.btn_ThemChiTiet.TabIndex = 66;
            this.btn_ThemChiTiet.Text = "Thêm";
            this.btn_ThemChiTiet.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 52);
            this.panel1.TabIndex = 70;
            // 
            // txt_DieuKienApDung
            // 
            this.txt_DieuKienApDung.Location = new System.Drawing.Point(705, 82);
            this.txt_DieuKienApDung.Name = "txt_DieuKienApDung";
            this.txt_DieuKienApDung.Size = new System.Drawing.Size(151, 24);
            this.txt_DieuKienApDung.TabIndex = 70;
            // 
            // dgv_DataChiTiet
            // 
            this.dgv_DataChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataChiTiet.Location = new System.Drawing.Point(6, 165);
            this.dgv_DataChiTiet.Name = "dgv_DataChiTiet";
            this.dgv_DataChiTiet.Size = new System.Drawing.Size(967, 182);
            this.dgv_DataChiTiet.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(292, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 63;
            this.label12.Text = "Ngày bắt đầu";
            // 
            // txt_MucGiam
            // 
            this.txt_MucGiam.Enabled = false;
            this.txt_MucGiam.Location = new System.Drawing.Point(112, 119);
            this.txt_MucGiam.Name = "txt_MucGiam";
            this.txt_MucGiam.Size = new System.Drawing.Size(151, 24);
            this.txt_MucGiam.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_MaKM);
            this.groupBox2.Controls.Add(this.rb_Tat);
            this.groupBox2.Controls.Add(this.rb_Bat);
            this.groupBox2.Controls.Add(this.cbo_LoaiApDung);
            this.groupBox2.Controls.Add(this.dtp_NgayKetThuc);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_DieuKienApDung);
            this.groupBox2.Controls.Add(this.dgv_DataChiTiet);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtp_NgayBatDau);
            this.groupBox2.Controls.Add(this.txt_MucGiam);
            this.groupBox2.Controls.Add(this.txt_TenKM);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 353);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khuyến mãi";
            // 
            // txt_MaKM
            // 
            this.txt_MaKM.Location = new System.Drawing.Point(112, 38);
            this.txt_MaKM.Name = "txt_MaKM";
            this.txt_MaKM.Size = new System.Drawing.Size(151, 24);
            this.txt_MaKM.TabIndex = 117;
            // 
            // rb_Tat
            // 
            this.rb_Tat.AutoSize = true;
            this.rb_Tat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Tat.Location = new System.Drawing.Point(494, 121);
            this.rb_Tat.Name = "rb_Tat";
            this.rb_Tat.Size = new System.Drawing.Size(45, 20);
            this.rb_Tat.TabIndex = 116;
            this.rb_Tat.TabStop = true;
            this.rb_Tat.Text = "Tắt";
            this.rb_Tat.UseVisualStyleBackColor = true;
            // 
            // rb_Bat
            // 
            this.rb_Bat.AutoSize = true;
            this.rb_Bat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Bat.Location = new System.Drawing.Point(426, 121);
            this.rb_Bat.Name = "rb_Bat";
            this.rb_Bat.Size = new System.Drawing.Size(45, 20);
            this.rb_Bat.TabIndex = 115;
            this.rb_Bat.TabStop = true;
            this.rb_Bat.Text = "Bật";
            this.rb_Bat.UseVisualStyleBackColor = true;
            // 
            // cbo_LoaiApDung
            // 
            this.cbo_LoaiApDung.FormattingEnabled = true;
            this.cbo_LoaiApDung.Location = new System.Drawing.Point(705, 38);
            this.cbo_LoaiApDung.Name = "cbo_LoaiApDung";
            this.cbo_LoaiApDung.Size = new System.Drawing.Size(151, 26);
            this.cbo_LoaiApDung.TabIndex = 77;
            // 
            // dtp_NgayKetThuc
            // 
            this.dtp_NgayKetThuc.Enabled = false;
            this.dtp_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayKetThuc.Location = new System.Drawing.Point(398, 79);
            this.dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            this.dtp_NgayKetThuc.Size = new System.Drawing.Size(151, 24);
            this.dtp_NgayKetThuc.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(293, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 74;
            this.label14.Text = "Trạng thái";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(572, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 73;
            this.label13.Text = "Loại áp dụng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(572, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 72;
            this.label10.Text = "Điều kiện áp dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Ngày kết thúc";
            // 
            // txt_TenKM
            // 
            this.txt_TenKM.Location = new System.Drawing.Point(112, 80);
            this.txt_TenKM.Name = "txt_TenKM";
            this.txt_TenKM.Size = new System.Drawing.Size(151, 24);
            this.txt_TenKM.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Tên khuyến mãi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Mức giảm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Mã Khuyến mãi";
            // 
            // frm_QuanLyKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1003, 713);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_QuanLyKhuyenMai";
            this.Text = "frm_QuanLyKhuyenMai";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataChiTiet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_MaKM;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DateTimePicker dtp_NgayBatDau;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_UuTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.TextBox txt_SLToiThieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_DieuKienApDung;
        private System.Windows.Forms.Button btn_ThemChiTiet;
        private System.Windows.Forms.DataGridView dgv_DataChiTiet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_MucGiam;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}