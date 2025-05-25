namespace GUI
{
    partial class frm_QuanLySanPham
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
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.txt_GiaBanTieuChuan = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbo_ThongTin = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.gbo_NhapThongTin = new System.Windows.Forms.GroupBox();
            this.cbo_DonVi = new System.Windows.Forms.ComboBox();
            this.cbo_LoaiSP = new System.Windows.Forms.ComboBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbo_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.gbo_NhapThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(267, 448);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(100, 60);
            this.btn_LamMoi.TabIndex = 73;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // txt_GiaBanTieuChuan
            // 
            this.txt_GiaBanTieuChuan.Location = new System.Drawing.Point(220, 272);
            this.txt_GiaBanTieuChuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_GiaBanTieuChuan.Name = "txt_GiaBanTieuChuan";
            this.txt_GiaBanTieuChuan.Size = new System.Drawing.Size(255, 29);
            this.txt_GiaBanTieuChuan.TabIndex = 90;
            this.txt_GiaBanTieuChuan.Leave += new System.EventHandler(this.txt_GiaBanTieuChuan_Leave);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(116, 448);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 60);
            this.btn_Sua.TabIndex = 72;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(267, 364);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 60);
            this.btn_Xoa.TabIndex = 71;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(116, 364);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 60);
            this.btn_Them.TabIndex = 70;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "Đơn vị tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 87;
            this.label5.Text = "Giá bán tiêu chuẩn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Tên sản phẩm";
            // 
            // gbo_ThongTin
            // 
            this.gbo_ThongTin.Controls.Add(this.btn_TimKiem);
            this.gbo_ThongTin.Controls.Add(this.dgv_Data);
            this.gbo_ThongTin.Controls.Add(this.txt_TimKiem);
            this.gbo_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_ThongTin.Location = new System.Drawing.Point(572, 126);
            this.gbo_ThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_ThongTin.Name = "gbo_ThongTin";
            this.gbo_ThongTin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_ThongTin.Size = new System.Drawing.Size(671, 582);
            this.gbo_ThongTin.TabIndex = 85;
            this.gbo_ThongTin.TabStop = false;
            this.gbo_ThongTin.Text = "Danh Sách sản phẩm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(199, 535);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(117, 32);
            this.btn_TimKiem.TabIndex = 94;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dgv_Data
            // 
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(20, 28);
            this.dgv_Data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.Size = new System.Drawing.Size(625, 490);
            this.dgv_Data.TabIndex = 65;
            this.dgv_Data.Click += new System.EventHandler(this.dgv_Data_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(323, 535);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(323, 29);
            this.txt_TimKiem.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Mã sản phẩm";
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Enabled = false;
            this.txt_MaSP.Location = new System.Drawing.Point(220, 63);
            this.txt_MaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(255, 29);
            this.txt_MaSP.TabIndex = 81;
            // 
            // gbo_NhapThongTin
            // 
            this.gbo_NhapThongTin.Controls.Add(this.cbo_DonVi);
            this.gbo_NhapThongTin.Controls.Add(this.cbo_LoaiSP);
            this.gbo_NhapThongTin.Controls.Add(this.btn_LamMoi);
            this.gbo_NhapThongTin.Controls.Add(this.txt_GiaBanTieuChuan);
            this.gbo_NhapThongTin.Controls.Add(this.btn_Sua);
            this.gbo_NhapThongTin.Controls.Add(this.btn_Xoa);
            this.gbo_NhapThongTin.Controls.Add(this.btn_Them);
            this.gbo_NhapThongTin.Controls.Add(this.label7);
            this.gbo_NhapThongTin.Controls.Add(this.label5);
            this.gbo_NhapThongTin.Controls.Add(this.label4);
            this.gbo_NhapThongTin.Controls.Add(this.label3);
            this.gbo_NhapThongTin.Controls.Add(this.label2);
            this.gbo_NhapThongTin.Controls.Add(this.txt_TenSP);
            this.gbo_NhapThongTin.Controls.Add(this.txt_MaSP);
            this.gbo_NhapThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_NhapThongTin.Location = new System.Drawing.Point(16, 126);
            this.gbo_NhapThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_NhapThongTin.Name = "gbo_NhapThongTin";
            this.gbo_NhapThongTin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_NhapThongTin.Size = new System.Drawing.Size(523, 582);
            this.gbo_NhapThongTin.TabIndex = 84;
            this.gbo_NhapThongTin.TabStop = false;
            this.gbo_NhapThongTin.Text = "Nhập thông tin ";
            // 
            // cbo_DonVi
            // 
            this.cbo_DonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_DonVi.FormattingEnabled = true;
            this.cbo_DonVi.Location = new System.Drawing.Point(220, 217);
            this.cbo_DonVi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_DonVi.Name = "cbo_DonVi";
            this.cbo_DonVi.Size = new System.Drawing.Size(255, 32);
            this.cbo_DonVi.TabIndex = 92;
            // 
            // cbo_LoaiSP
            // 
            this.cbo_LoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiSP.FormattingEnabled = true;
            this.cbo_LoaiSP.Location = new System.Drawing.Point(220, 162);
            this.cbo_LoaiSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_LoaiSP.Name = "cbo_LoaiSP";
            this.cbo_LoaiSP.Size = new System.Drawing.Size(255, 32);
            this.cbo_LoaiSP.TabIndex = 91;
            this.cbo_LoaiSP.SelectedValueChanged += new System.EventHandler(this.cbo_LoaiSP_SelectedValueChanged);
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(220, 111);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(255, 29);
            this.txt_TenSP.TabIndex = 82;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(437, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(337, 42);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Quản lý sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 64);
            this.panel1.TabIndex = 83;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1259, 740);
            this.Controls.Add(this.gbo_ThongTin);
            this.Controls.Add(this.gbo_NhapThongTin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "frm_QuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QuanLySanPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_QuanLySanPham_Load);
            this.Resize += new System.EventHandler(this.frm_QuanLySanPham_Resize);
            this.gbo_ThongTin.ResumeLayout(false);
            this.gbo_ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.gbo_NhapThongTin.ResumeLayout(false);
            this.gbo_NhapThongTin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.TextBox txt_GiaBanTieuChuan;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbo_ThongTin;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.GroupBox gbo_NhapThongTin;
        private System.Windows.Forms.ComboBox cbo_DonVi;
        private System.Windows.Forms.ComboBox cbo_LoaiSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}