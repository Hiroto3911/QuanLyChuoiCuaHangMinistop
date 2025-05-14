namespace GUI
{
    partial class frm_BaoCaoDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart_DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbo_ThongTin = new System.Windows.Forms.GroupBox();
            this.gbo_DieuChinhTGian = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_TuChinh = new System.Windows.Forms.RadioButton();
            this.rb_XemTatCa = new System.Windows.Forms.RadioButton();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.cbo_MaCH = new System.Windows.Forms.ComboBox();
            this.lbl_CuaHang = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).BeginInit();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 52);
            this.panel1.TabIndex = 65;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(270, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(461, 33);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Biểu đồ doanh thu của cửa hàng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.62715F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.37285F));
            this.tableLayoutPanel1.Controls.Add(this.chart_DoanhThu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbo_ThongTin, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 549);
            this.tableLayoutPanel1.TabIndex = 67;
            // 
            // chart_DoanhThu
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_DoanhThu.ChartAreas.Add(chartArea5);
            this.chart_DoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chart_DoanhThu.Legends.Add(legend5);
            this.chart_DoanhThu.Location = new System.Drawing.Point(3, 3);
            this.chart_DoanhThu.Name = "chart_DoanhThu";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            this.chart_DoanhThu.Series.Add(series5);
            this.chart_DoanhThu.Size = new System.Drawing.Size(594, 543);
            this.chart_DoanhThu.TabIndex = 67;
            this.chart_DoanhThu.Text = "Báo cao doanh thu của hàng";
            // 
            // gbo_ThongTin
            // 
            this.gbo_ThongTin.Controls.Add(this.lbl_CuaHang);
            this.gbo_ThongTin.Controls.Add(this.cbo_MaCH);
            this.gbo_ThongTin.Controls.Add(this.gbo_DieuChinhTGian);
            this.gbo_ThongTin.Controls.Add(this.groupBox2);
            this.gbo_ThongTin.Controls.Add(this.btn_Xem);
            this.gbo_ThongTin.Controls.Add(this.dgv_Data);
            this.gbo_ThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbo_ThongTin.Location = new System.Drawing.Point(603, 3);
            this.gbo_ThongTin.Name = "gbo_ThongTin";
            this.gbo_ThongTin.Size = new System.Drawing.Size(338, 543);
            this.gbo_ThongTin.TabIndex = 68;
            this.gbo_ThongTin.TabStop = false;
            // 
            // gbo_DieuChinhTGian
            // 
            this.gbo_DieuChinhTGian.Controls.Add(this.label1);
            this.gbo_DieuChinhTGian.Controls.Add(this.label2);
            this.gbo_DieuChinhTGian.Controls.Add(this.dtp_DenNgay);
            this.gbo_DieuChinhTGian.Controls.Add(this.dtp_TuNgay);
            this.gbo_DieuChinhTGian.Location = new System.Drawing.Point(178, 382);
            this.gbo_DieuChinhTGian.Name = "gbo_DieuChinhTGian";
            this.gbo_DieuChinhTGian.Size = new System.Drawing.Size(154, 107);
            this.gbo_DieuChinhTGian.TabIndex = 77;
            this.gbo_DieuChinhTGian.TabStop = false;
            this.gbo_DieuChinhTGian.Text = "Điều chỉnh thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "Từ";
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.Enabled = false;
            this.dtp_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DenNgay.Location = new System.Drawing.Point(47, 68);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(104, 20);
            this.dtp_DenNgay.TabIndex = 84;
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.Enabled = false;
            this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_TuNgay.Location = new System.Drawing.Point(47, 23);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(104, 20);
            this.dtp_TuNgay.TabIndex = 83;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_TuChinh);
            this.groupBox2.Controls.Add(this.rb_XemTatCa);
            this.groupBox2.Location = new System.Drawing.Point(6, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 107);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chế độ xem";
            // 
            // rb_TuChinh
            // 
            this.rb_TuChinh.AutoSize = true;
            this.rb_TuChinh.Location = new System.Drawing.Point(15, 23);
            this.rb_TuChinh.Name = "rb_TuChinh";
            this.rb_TuChinh.Size = new System.Drawing.Size(116, 17);
            this.rb_TuChinh.TabIndex = 73;
            this.rb_TuChinh.Text = "Tự chỉnh mốc tgian";
            this.rb_TuChinh.UseVisualStyleBackColor = true;
            this.rb_TuChinh.CheckedChanged += new System.EventHandler(this.rb_TuChinh_CheckedChanged);
            // 
            // rb_XemTatCa
            // 
            this.rb_XemTatCa.AutoSize = true;
            this.rb_XemTatCa.Checked = true;
            this.rb_XemTatCa.Location = new System.Drawing.Point(15, 65);
            this.rb_XemTatCa.Name = "rb_XemTatCa";
            this.rb_XemTatCa.Size = new System.Drawing.Size(76, 17);
            this.rb_XemTatCa.TabIndex = 72;
            this.rb_XemTatCa.TabStop = true;
            this.rb_XemTatCa.Text = "Xem tất cả";
            this.rb_XemTatCa.UseVisualStyleBackColor = true;
            this.rb_XemTatCa.CheckedChanged += new System.EventHandler(this.rb_XemTatCa_CheckedChanged);
            // 
            // btn_Xem
            // 
            this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.Location = new System.Drawing.Point(133, 504);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(75, 30);
            this.btn_Xem.TabIndex = 72;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(0, 46);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.Size = new System.Drawing.Size(332, 330);
            this.dgv_Data.TabIndex = 69;
            this.dgv_Data.Click += new System.EventHandler(this.dgv_Data_Click);
            // 
            // cbo_MaCH
            // 
            this.cbo_MaCH.Enabled = false;
            this.cbo_MaCH.FormattingEnabled = true;
            this.cbo_MaCH.Location = new System.Drawing.Point(77, 16);
            this.cbo_MaCH.Name = "cbo_MaCH";
            this.cbo_MaCH.Size = new System.Drawing.Size(181, 21);
            this.cbo_MaCH.TabIndex = 78;
            // 
            // lbl_CuaHang
            // 
            this.lbl_CuaHang.AutoSize = true;
            this.lbl_CuaHang.Location = new System.Drawing.Point(18, 16);
            this.lbl_CuaHang.Name = "lbl_CuaHang";
            this.lbl_CuaHang.Size = new System.Drawing.Size(53, 13);
            this.lbl_CuaHang.TabIndex = 79;
            this.lbl_CuaHang.Text = "Cửa hàng";
            // 
            // frm_BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "frm_BaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BaoCaoDoanhThu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BaoCaoDoanhThu_Load);
            this.Resize += new System.EventHandler(this.frm_BaoCaoDoanhThu_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhThu;
        private System.Windows.Forms.GroupBox gbo_ThongTin;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbo_DieuChinhTGian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_DenNgay;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.RadioButton rb_TuChinh;
        private System.Windows.Forms.RadioButton rb_XemTatCa;
        private System.Windows.Forms.Label lbl_CuaHang;
        private System.Windows.Forms.ComboBox cbo_MaCH;
    }
}