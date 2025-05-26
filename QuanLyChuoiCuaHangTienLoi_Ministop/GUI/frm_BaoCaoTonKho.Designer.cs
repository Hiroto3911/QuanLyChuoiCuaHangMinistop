namespace GUI
{
    partial class frm_BaoCaoTonKho
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
            this.gbo_NhapThongTin = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_TuChinh = new System.Windows.Forms.RadioButton();
            this.rb_TuDong = new System.Windows.Forms.RadioButton();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.cbo_Thang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_KhuyenMai_HoaDon = new System.Windows.Forms.Label();
            this.cbo_MaCH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbo_ThongTin = new System.Windows.Forms.GroupBox();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gbo_NhapThongTin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbo_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbo_NhapThongTin
            // 
            this.gbo_NhapThongTin.Controls.Add(this.groupBox2);
            this.gbo_NhapThongTin.Controls.Add(this.btn_Xem);
            this.gbo_NhapThongTin.Controls.Add(this.txt_Nam);
            this.gbo_NhapThongTin.Controls.Add(this.cbo_Thang);
            this.gbo_NhapThongTin.Controls.Add(this.label3);
            this.gbo_NhapThongTin.Controls.Add(this.label1);
            this.gbo_NhapThongTin.Controls.Add(this.lbl_KhuyenMai_HoaDon);
            this.gbo_NhapThongTin.Controls.Add(this.cbo_MaCH);
            this.gbo_NhapThongTin.Controls.Add(this.label2);
            this.gbo_NhapThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_NhapThongTin.Location = new System.Drawing.Point(0, 68);
            this.gbo_NhapThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.gbo_NhapThongTin.Name = "gbo_NhapThongTin";
            this.gbo_NhapThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.gbo_NhapThongTin.Size = new System.Drawing.Size(1259, 167);
            this.gbo_NhapThongTin.TabIndex = 69;
            this.gbo_NhapThongTin.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_TuChinh);
            this.groupBox2.Controls.Add(this.rb_TuDong);
            this.groupBox2.Location = new System.Drawing.Point(460, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 132);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều chỉnh thời gian";
            // 
            // rb_TuChinh
            // 
            this.rb_TuChinh.AutoSize = true;
            this.rb_TuChinh.Location = new System.Drawing.Point(20, 28);
            this.rb_TuChinh.Margin = new System.Windows.Forms.Padding(4);
            this.rb_TuChinh.Name = "rb_TuChinh";
            this.rb_TuChinh.Size = new System.Drawing.Size(193, 28);
            this.rb_TuChinh.TabIndex = 73;
            this.rb_TuChinh.TabStop = true;
            this.rb_TuChinh.Text = "Tự chỉnh mốc tgian";
            this.rb_TuChinh.UseVisualStyleBackColor = true;
            this.rb_TuChinh.CheckedChanged += new System.EventHandler(this.rb_TuChinh_CheckedChanged);
            // 
            // rb_TuDong
            // 
            this.rb_TuDong.AutoSize = true;
            this.rb_TuDong.Location = new System.Drawing.Point(20, 80);
            this.rb_TuDong.Margin = new System.Windows.Forms.Padding(4);
            this.rb_TuDong.Name = "rb_TuDong";
            this.rb_TuDong.Size = new System.Drawing.Size(201, 28);
            this.rb_TuDong.TabIndex = 72;
            this.rb_TuDong.TabStop = true;
            this.rb_TuDong.Text = "Lấy thời gian hiện tại";
            this.rb_TuDong.UseVisualStyleBackColor = true;
            this.rb_TuDong.CheckedChanged += new System.EventHandler(this.rb_TuDong_CheckedChanged);
            // 
            // btn_Xem
            // 
            this.btn_Xem.Location = new System.Drawing.Point(771, 28);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(136, 44);
            this.btn_Xem.TabIndex = 74;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(228, 130);
            this.txt_Nam.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(144, 29);
            this.txt_Nam.TabIndex = 71;
            // 
            // cbo_Thang
            // 
            this.cbo_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Thang.Enabled = false;
            this.cbo_Thang.FormattingEnabled = true;
            this.cbo_Thang.Location = new System.Drawing.Point(228, 75);
            this.cbo_Thang.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Thang.Name = "cbo_Thang";
            this.cbo_Thang.Size = new System.Drawing.Size(144, 32);
            this.cbo_Thang.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Tháng";
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
            // cbo_MaCH
            // 
            this.cbo_MaCH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaCH.Enabled = false;
            this.cbo_MaCH.FormattingEnabled = true;
            this.cbo_MaCH.Location = new System.Drawing.Point(228, 25);
            this.cbo_MaCH.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MaCH.Name = "cbo_MaCH";
            this.cbo_MaCH.Size = new System.Drawing.Size(200, 32);
            this.cbo_MaCH.TabIndex = 48;
            this.cbo_MaCH.SelectedValueChanged += new System.EventHandler(this.cbo_MaCH_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Cửa hàng ";
            // 
            // gbo_ThongTin
            // 
            this.gbo_ThongTin.Controls.Add(this.dgv_Data);
            this.gbo_ThongTin.Location = new System.Drawing.Point(0, 242);
            this.gbo_ThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.gbo_ThongTin.Name = "gbo_ThongTin";
            this.gbo_ThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.gbo_ThongTin.Size = new System.Drawing.Size(1259, 497);
            this.gbo_ThongTin.TabIndex = 70;
            this.gbo_ThongTin.TabStop = false;
            this.gbo_ThongTin.Text = "Thông tin tồn kho";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(4, 20);
            this.dgv_Data.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.Size = new System.Drawing.Size(1251, 474);
            this.dgv_Data.TabIndex = 63;
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
            this.panel1.TabIndex = 71;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(467, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(315, 42);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Báo cáo tồn kho ";
            // 
            // frm_BaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1259, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbo_ThongTin);
            this.Controls.Add(this.gbo_NhapThongTin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frm_BaoCaoTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BaoCaoTonKho_Load);
            this.Resize += new System.EventHandler(this.frm_BaoCaoTonKho_Resize);
            this.gbo_NhapThongTin.ResumeLayout(false);
            this.gbo_NhapThongTin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbo_ThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbo_NhapThongTin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_TuChinh;
        private System.Windows.Forms.RadioButton rb_TuDong;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.ComboBox cbo_Thang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_KhuyenMai_HoaDon;
        private System.Windows.Forms.ComboBox cbo_MaCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbo_ThongTin;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
    }
}