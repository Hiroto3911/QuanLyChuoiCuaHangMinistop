namespace GUI
{
    partial class frm_ChiTietKho
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
            this.txt_MaCTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbo_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.cbo_MaSP = new System.Windows.Forms.ComboBox();
            this.txt_SLTon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.txt_MaCTLSK = new System.Windows.Forms.TextBox();
            this.gbo_ThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.txt_MaThamChieu = new System.Windows.Forms.TextBox();
            this.cbo_LoaiThayDoi = new System.Windows.Forms.ComboBox();
            this.dtp_NgayThayDoi = new System.Windows.Forms.DateTimePicker();
            this.btn_LamMoiChiTiet = new System.Windows.Forms.Button();
            this.dgv_DataChiTiet = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SLThucTe = new System.Windows.Forms.TextBox();
            this.txt_MaChiTietKho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_TenSP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbo_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.gbo_ThongTinChiTiet.SuspendLayout();
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
            this.lbl_Title.Location = new System.Drawing.Point(400, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(173, 33);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Chi tiết kho";
            // 
            // cbo_MaCH
            // 
            this.cbo_MaCH.Enabled = false;
            this.cbo_MaCH.FormattingEnabled = true;
            this.cbo_MaCH.Location = new System.Drawing.Point(126, 34);
            this.cbo_MaCH.Name = "cbo_MaCH";
            this.cbo_MaCH.Size = new System.Drawing.Size(151, 26);
            this.cbo_MaCH.TabIndex = 48;
            // 
            // txt_MaCTK
            // 
            this.txt_MaCTK.Enabled = false;
            this.txt_MaCTK.Location = new System.Drawing.Point(126, 71);
            this.txt_MaCTK.Name = "txt_MaCTK";
            this.txt_MaCTK.Size = new System.Drawing.Size(151, 24);
            this.txt_MaCTK.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Giá bán";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(20, 70);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 16);
            this.label.TabIndex = 51;
            this.label.Text = "Mã chi tiết kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã cửa hàng ";
            // 
            // gbo_ThongTin
            // 
            this.gbo_ThongTin.Controls.Add(this.lbl_TenSP);
            this.gbo_ThongTin.Controls.Add(this.txt_GiaBan);
            this.gbo_ThongTin.Controls.Add(this.cbo_MaSP);
            this.gbo_ThongTin.Controls.Add(this.txt_SLTon);
            this.gbo_ThongTin.Controls.Add(this.label1);
            this.gbo_ThongTin.Controls.Add(this.dgv_Data);
            this.gbo_ThongTin.Controls.Add(this.cbo_MaCH);
            this.gbo_ThongTin.Controls.Add(this.txt_MaCTK);
            this.gbo_ThongTin.Controls.Add(this.label5);
            this.gbo_ThongTin.Controls.Add(this.label);
            this.gbo_ThongTin.Controls.Add(this.label3);
            this.gbo_ThongTin.Controls.Add(this.label2);
            this.gbo_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_ThongTin.Location = new System.Drawing.Point(60, 77);
            this.gbo_ThongTin.Name = "gbo_ThongTin";
            this.gbo_ThongTin.Size = new System.Drawing.Size(872, 274);
            this.gbo_ThongTin.TabIndex = 65;
            this.gbo_ThongTin.TabStop = false;
            this.gbo_ThongTin.Text = "Thông tin chi tiết kho";
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Enabled = false;
            this.txt_GiaBan.Location = new System.Drawing.Point(423, 71);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(151, 24);
            this.txt_GiaBan.TabIndex = 66;
            // 
            // cbo_MaSP
            // 
            this.cbo_MaSP.FormattingEnabled = true;
            this.cbo_MaSP.Location = new System.Drawing.Point(423, 33);
            this.cbo_MaSP.Name = "cbo_MaSP";
            this.cbo_MaSP.Size = new System.Drawing.Size(151, 26);
            this.cbo_MaSP.TabIndex = 65;
            this.cbo_MaSP.SelectedValueChanged += new System.EventHandler(this.cbo_MaSP_SelectedValueChanged);
            // 
            // txt_SLTon
            // 
            this.txt_SLTon.Enabled = false;
            this.txt_SLTon.Location = new System.Drawing.Point(687, 70);
            this.txt_SLTon.Name = "txt_SLTon";
            this.txt_SLTon.Size = new System.Drawing.Size(151, 24);
            this.txt_SLTon.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "SL tồn";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(6, 112);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.Size = new System.Drawing.Size(860, 156);
            this.dgv_Data.TabIndex = 62;
            this.dgv_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Data_CellClick);
            // 
            // txt_MaCTLSK
            // 
            this.txt_MaCTLSK.Enabled = false;
            this.txt_MaCTLSK.Location = new System.Drawing.Point(126, 36);
            this.txt_MaCTLSK.Name = "txt_MaCTLSK";
            this.txt_MaCTLSK.Size = new System.Drawing.Size(151, 24);
            this.txt_MaCTLSK.TabIndex = 58;
            // 
            // gbo_ThongTinChiTiet
            // 
            this.gbo_ThongTinChiTiet.Controls.Add(this.txt_MaThamChieu);
            this.gbo_ThongTinChiTiet.Controls.Add(this.cbo_LoaiThayDoi);
            this.gbo_ThongTinChiTiet.Controls.Add(this.dtp_NgayThayDoi);
            this.gbo_ThongTinChiTiet.Controls.Add(this.btn_LamMoiChiTiet);
            this.gbo_ThongTinChiTiet.Controls.Add(this.txt_MaCTLSK);
            this.gbo_ThongTinChiTiet.Controls.Add(this.dgv_DataChiTiet);
            this.gbo_ThongTinChiTiet.Controls.Add(this.label12);
            this.gbo_ThongTinChiTiet.Controls.Add(this.label11);
            this.gbo_ThongTinChiTiet.Controls.Add(this.txt_SLThucTe);
            this.gbo_ThongTinChiTiet.Controls.Add(this.txt_MaChiTietKho);
            this.gbo_ThongTinChiTiet.Controls.Add(this.label4);
            this.gbo_ThongTinChiTiet.Controls.Add(this.label7);
            this.gbo_ThongTinChiTiet.Controls.Add(this.label8);
            this.gbo_ThongTinChiTiet.Controls.Add(this.label9);
            this.gbo_ThongTinChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_ThongTinChiTiet.Location = new System.Drawing.Point(60, 357);
            this.gbo_ThongTinChiTiet.Name = "gbo_ThongTinChiTiet";
            this.gbo_ThongTinChiTiet.Size = new System.Drawing.Size(872, 353);
            this.gbo_ThongTinChiTiet.TabIndex = 66;
            this.gbo_ThongTinChiTiet.TabStop = false;
            this.gbo_ThongTinChiTiet.Text = "Thông tin chi tiết lịch sử kho";
            // 
            // txt_MaThamChieu
            // 
            this.txt_MaThamChieu.Enabled = false;
            this.txt_MaThamChieu.Location = new System.Drawing.Point(126, 110);
            this.txt_MaThamChieu.Name = "txt_MaThamChieu";
            this.txt_MaThamChieu.Size = new System.Drawing.Size(151, 24);
            this.txt_MaThamChieu.TabIndex = 72;
            // 
            // cbo_LoaiThayDoi
            // 
            this.cbo_LoaiThayDoi.FormattingEnabled = true;
            this.cbo_LoaiThayDoi.Location = new System.Drawing.Point(423, 75);
            this.cbo_LoaiThayDoi.Name = "cbo_LoaiThayDoi";
            this.cbo_LoaiThayDoi.Size = new System.Drawing.Size(151, 26);
            this.cbo_LoaiThayDoi.TabIndex = 71;

            // 
            // dtp_NgayThayDoi
            // 
            this.dtp_NgayThayDoi.Enabled = false;
            this.dtp_NgayThayDoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayThayDoi.Location = new System.Drawing.Point(423, 110);
            this.dtp_NgayThayDoi.Name = "dtp_NgayThayDoi";
            this.dtp_NgayThayDoi.Size = new System.Drawing.Size(151, 24);
            this.dtp_NgayThayDoi.TabIndex = 70;
            // 
            // btn_LamMoiChiTiet
            // 
            this.btn_LamMoiChiTiet.Location = new System.Drawing.Point(687, 52);
            this.btn_LamMoiChiTiet.Name = "btn_LamMoiChiTiet";
            this.btn_LamMoiChiTiet.Size = new System.Drawing.Size(75, 49);
            this.btn_LamMoiChiTiet.TabIndex = 69;
            this.btn_LamMoiChiTiet.Text = "Làm mới";
            this.btn_LamMoiChiTiet.UseVisualStyleBackColor = true;
            this.btn_LamMoiChiTiet.Click += new System.EventHandler(this.btn_LamMoiChiTiet_Click);
            // 
            // dgv_DataChiTiet
            // 
            this.dgv_DataChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DataChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataChiTiet.Location = new System.Drawing.Point(6, 152);
            this.dgv_DataChiTiet.Name = "dgv_DataChiTiet";
            this.dgv_DataChiTiet.RowHeadersWidth = 51;
            this.dgv_DataChiTiet.Size = new System.Drawing.Size(860, 195);
            this.dgv_DataChiTiet.TabIndex = 65;
            this.dgv_DataChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DataChiTiet_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(317, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 63;
            this.label12.Text = "Ngày thay đổi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 62;
            this.label11.Text = "Mã tham chiếu";
            // 
            // txt_SLThucTe
            // 
            this.txt_SLThucTe.Enabled = false;
            this.txt_SLThucTe.Location = new System.Drawing.Point(423, 38);
            this.txt_SLThucTe.Name = "txt_SLThucTe";
            this.txt_SLThucTe.Size = new System.Drawing.Size(151, 24);
            this.txt_SLThucTe.TabIndex = 56;
            // 
            // txt_MaChiTietKho
            // 
            this.txt_MaChiTietKho.Enabled = false;
            this.txt_MaChiTietKho.Location = new System.Drawing.Point(126, 76);
            this.txt_MaChiTietKho.Name = "txt_MaChiTietKho";
            this.txt_MaChiTietKho.Size = new System.Drawing.Size(151, 24);
            this.txt_MaChiTietKho.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Loại thay đổi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Mã chi tiết kho";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "SL Thay đổi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Mã CTLSK";
            // 
            // lbl_TenSP
            // 
            this.lbl_TenSP.AutoSize = true;
            this.lbl_TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSP.Location = new System.Drawing.Point(616, 34);
            this.lbl_TenSP.Name = "lbl_TenSP";
            this.lbl_TenSP.Size = new System.Drawing.Size(93, 16);
            this.lbl_TenSP.TabIndex = 67;
            this.lbl_TenSP.Text = "Tên sản phẩm";
            // 
            // frm_ChiTietKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1003, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbo_ThongTin);
            this.Controls.Add(this.gbo_ThongTinChiTiet);
            this.MinimizeBox = false;
            this.Name = "frm_ChiTietKho";
            this.Text = "frm_ChiTietKho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ChiTietKho_Load);
            this.Resize += new System.EventHandler(this.frm_ChiTietKho_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbo_ThongTin.ResumeLayout(false);
            this.gbo_ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.gbo_ThongTinChiTiet.ResumeLayout(false);
            this.gbo_ThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox cbo_MaCH;
        private System.Windows.Forms.TextBox txt_MaCTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbo_ThongTin;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.TextBox txt_MaCTLSK;
        private System.Windows.Forms.GroupBox gbo_ThongTinChiTiet;
        private System.Windows.Forms.Button btn_LamMoiChiTiet;
        private System.Windows.Forms.DataGridView dgv_DataChiTiet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_SLThucTe;
        private System.Windows.Forms.TextBox txt_MaChiTietKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SLTon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.ComboBox cbo_MaSP;
        private System.Windows.Forms.ComboBox cbo_LoaiThayDoi;
        private System.Windows.Forms.DateTimePicker dtp_NgayThayDoi;
        private System.Windows.Forms.TextBox txt_MaThamChieu;
        private System.Windows.Forms.Label lbl_TenSP;
    }
}