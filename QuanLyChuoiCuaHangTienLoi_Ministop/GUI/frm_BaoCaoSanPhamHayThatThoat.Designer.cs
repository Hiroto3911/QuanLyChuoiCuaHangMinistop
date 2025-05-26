namespace GUI
{
    partial class frm_BaoCaoSanPhamHayThatThoat
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
            this.gbo_ThongTin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_SoLanThatThoat = new System.Windows.Forms.ComboBox();
            this.gbo_DieuChinhTGian = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_TuChinh = new System.Windows.Forms.RadioButton();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.lbl_CuaHang = new System.Windows.Forms.Label();
            this.cbo_MaCH = new System.Windows.Forms.ComboBox();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbo_ThongTin.SuspendLayout();
            this.gbo_DieuChinhTGian.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1259, 64);
            this.panel1.TabIndex = 66;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(312, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(639, 42);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Báo cáo sản phẩm hay bị thất thoát";
            // 
            // gbo_ThongTin
            // 
            this.gbo_ThongTin.Controls.Add(this.label3);
            this.gbo_ThongTin.Controls.Add(this.cbo_SoLanThatThoat);
            this.gbo_ThongTin.Controls.Add(this.gbo_DieuChinhTGian);
            this.gbo_ThongTin.Controls.Add(this.groupBox2);
            this.gbo_ThongTin.Controls.Add(this.btn_Xem);
            this.gbo_ThongTin.Controls.Add(this.lbl_CuaHang);
            this.gbo_ThongTin.Controls.Add(this.cbo_MaCH);
            this.gbo_ThongTin.Controls.Add(this.dgv_Data);
            this.gbo_ThongTin.Location = new System.Drawing.Point(16, 71);
            this.gbo_ThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.gbo_ThongTin.Name = "gbo_ThongTin";
            this.gbo_ThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.gbo_ThongTin.Size = new System.Drawing.Size(1227, 666);
            this.gbo_ThongTin.TabIndex = 69;
            this.gbo_ThongTin.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Số lần thất thoát";
            // 
            // cbo_SoLanThatThoat
            // 
            this.cbo_SoLanThatThoat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SoLanThatThoat.FormattingEnabled = true;
            this.cbo_SoLanThatThoat.Location = new System.Drawing.Point(171, 78);
            this.cbo_SoLanThatThoat.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_SoLanThatThoat.Name = "cbo_SoLanThatThoat";
            this.cbo_SoLanThatThoat.Size = new System.Drawing.Size(195, 24);
            this.cbo_SoLanThatThoat.TabIndex = 83;
            // 
            // gbo_DieuChinhTGian
            // 
            this.gbo_DieuChinhTGian.Controls.Add(this.label1);
            this.gbo_DieuChinhTGian.Controls.Add(this.label2);
            this.gbo_DieuChinhTGian.Controls.Add(this.dtp_DenNgay);
            this.gbo_DieuChinhTGian.Controls.Add(this.dtp_TuNgay);
            this.gbo_DieuChinhTGian.Location = new System.Drawing.Point(51, 292);
            this.gbo_DieuChinhTGian.Margin = new System.Windows.Forms.Padding(4);
            this.gbo_DieuChinhTGian.Name = "gbo_DieuChinhTGian";
            this.gbo_DieuChinhTGian.Padding = new System.Windows.Forms.Padding(4);
            this.gbo_DieuChinhTGian.Size = new System.Drawing.Size(316, 132);
            this.gbo_DieuChinhTGian.TabIndex = 82;
            this.gbo_DieuChinhTGian.TabStop = false;
            this.gbo_DieuChinhTGian.Text = "Điều chỉnh thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Từ";
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DenNgay.Location = new System.Drawing.Point(75, 84);
            this.dtp_DenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(153, 22);
            this.dtp_DenNgay.TabIndex = 84;
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_TuNgay.Location = new System.Drawing.Point(75, 28);
            this.dtp_TuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(153, 22);
            this.dtp_TuNgay.TabIndex = 83;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_TuChinh);
            this.groupBox2.Location = new System.Drawing.Point(51, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(316, 132);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chế độ xem";
            // 
            // rb_TuChinh
            // 
            this.rb_TuChinh.AutoSize = true;
            this.rb_TuChinh.Checked = true;
            this.rb_TuChinh.Location = new System.Drawing.Point(75, 44);
            this.rb_TuChinh.Margin = new System.Windows.Forms.Padding(4);
            this.rb_TuChinh.Name = "rb_TuChinh";
            this.rb_TuChinh.Size = new System.Drawing.Size(139, 20);
            this.rb_TuChinh.TabIndex = 73;
            this.rb_TuChinh.TabStop = true;
            this.rb_TuChinh.Text = "Tự chỉnh mốc tgian";
            this.rb_TuChinh.UseVisualStyleBackColor = true;
            this.rb_TuChinh.CheckedChanged += new System.EventHandler(this.rb_TuChinh_CheckedChanged);
            // 
            // btn_Xem
            // 
            this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.Location = new System.Drawing.Point(149, 460);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(100, 44);
            this.btn_Xem.TabIndex = 80;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // lbl_CuaHang
            // 
            this.lbl_CuaHang.AutoSize = true;
            this.lbl_CuaHang.Location = new System.Drawing.Point(47, 23);
            this.lbl_CuaHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CuaHang.Name = "lbl_CuaHang";
            this.lbl_CuaHang.Size = new System.Drawing.Size(64, 16);
            this.lbl_CuaHang.TabIndex = 79;
            this.lbl_CuaHang.Text = "Cửa hàng";
            // 
            // cbo_MaCH
            // 
            this.cbo_MaCH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaCH.Enabled = false;
            this.cbo_MaCH.FormattingEnabled = true;
            this.cbo_MaCH.Location = new System.Drawing.Point(171, 23);
            this.cbo_MaCH.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MaCH.Name = "cbo_MaCH";
            this.cbo_MaCH.Size = new System.Drawing.Size(195, 24);
            this.cbo_MaCH.TabIndex = 78;
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(448, 20);
            this.dgv_Data.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.Size = new System.Drawing.Size(752, 612);
            this.dgv_Data.TabIndex = 69;
            // 
            // frm_BaoCaoSanPhamHayThatThoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1259, 740);
            this.Controls.Add(this.gbo_ThongTin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frm_BaoCaoSanPhamHayThatThoat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BaoCaoSanPhamHayThatThoat_Load);
            this.Resize += new System.EventHandler(this.frm_BaoCaoSanPhamHayThatThoat_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbo_ThongTin.ResumeLayout(false);
            this.gbo_ThongTin.PerformLayout();
            this.gbo_DieuChinhTGian.ResumeLayout(false);
            this.gbo_DieuChinhTGian.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox gbo_ThongTin;
        private System.Windows.Forms.Label lbl_CuaHang;
        private System.Windows.Forms.ComboBox cbo_MaCH;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.GroupBox gbo_DieuChinhTGian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_DenNgay;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_TuChinh;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_SoLanThatThoat;
    }
}