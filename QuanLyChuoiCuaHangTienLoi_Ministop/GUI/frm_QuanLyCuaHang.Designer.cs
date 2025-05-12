namespace GUI
{
    partial class frm_QuanLyCuaHang
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
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.gbo_NhapThongTin = new System.Windows.Forms.GroupBox();
            this.rtf_DiaChi = new System.Windows.Forms.RichTextBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.txt_MaNguoiQL = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_DTH = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenCH = new System.Windows.Forms.TextBox();
            this.txt_MaCH = new System.Windows.Forms.TextBox();
            this.gbo_Data = new System.Windows.Forms.GroupBox();
            this.pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.gbo_NhapThongTin.SuspendLayout();
            this.gbo_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.pnl_Title.Controls.Add(this.lbl_Title);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(1259, 64);
            this.pnl_Title.TabIndex = 78;
            this.pnl_Title.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Title_Paint);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(437, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(328, 42);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Quản lý cửa hàng";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(24, 63);
            this.dgv_Data.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.Size = new System.Drawing.Size(620, 490);
            this.dgv_Data.TabIndex = 65;
            this.dgv_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Data_CellContentClick);
            this.dgv_Data.Click += new System.EventHandler(this.dgv_Data_Click);
            // 
            // gbo_NhapThongTin
            // 
            this.gbo_NhapThongTin.Controls.Add(this.rtf_DiaChi);
            this.gbo_NhapThongTin.Controls.Add(this.btn_LamMoi);
            this.gbo_NhapThongTin.Controls.Add(this.txt_MaNguoiQL);
            this.gbo_NhapThongTin.Controls.Add(this.btn_Sua);
            this.gbo_NhapThongTin.Controls.Add(this.txt_DTH);
            this.gbo_NhapThongTin.Controls.Add(this.btn_Xoa);
            this.gbo_NhapThongTin.Controls.Add(this.btn_Them);
            this.gbo_NhapThongTin.Controls.Add(this.label7);
            this.gbo_NhapThongTin.Controls.Add(this.label5);
            this.gbo_NhapThongTin.Controls.Add(this.label4);
            this.gbo_NhapThongTin.Controls.Add(this.label3);
            this.gbo_NhapThongTin.Controls.Add(this.label2);
            this.gbo_NhapThongTin.Controls.Add(this.txt_TenCH);
            this.gbo_NhapThongTin.Controls.Add(this.txt_MaCH);
            this.gbo_NhapThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_NhapThongTin.Location = new System.Drawing.Point(16, 94);
            this.gbo_NhapThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.gbo_NhapThongTin.Name = "gbo_NhapThongTin";
            this.gbo_NhapThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.gbo_NhapThongTin.Size = new System.Drawing.Size(523, 582);
            this.gbo_NhapThongTin.TabIndex = 81;
            this.gbo_NhapThongTin.TabStop = false;
            this.gbo_NhapThongTin.Text = "Nhập thông tin cửa hàng";
            // 
            // rtf_DiaChi
            // 
            this.rtf_DiaChi.Location = new System.Drawing.Point(220, 217);
            this.rtf_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.rtf_DiaChi.Name = "rtf_DiaChi";
            this.rtf_DiaChi.Size = new System.Drawing.Size(255, 102);
            this.rtf_DiaChi.TabIndex = 91;
            this.rtf_DiaChi.Text = "";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(269, 492);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(100, 60);
            this.btn_LamMoi.TabIndex = 73;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // txt_MaNguoiQL
            // 
            this.txt_MaNguoiQL.Enabled = false;
            this.txt_MaNguoiQL.Location = new System.Drawing.Point(220, 343);
            this.txt_MaNguoiQL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNguoiQL.Name = "txt_MaNguoiQL";
            this.txt_MaNguoiQL.Size = new System.Drawing.Size(255, 29);
            this.txt_MaNguoiQL.TabIndex = 90;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(119, 492);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 60);
            this.btn_Sua.TabIndex = 72;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_DTH
            // 
            this.txt_DTH.Location = new System.Drawing.Point(220, 162);
            this.txt_DTH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DTH.Name = "txt_DTH";
            this.txt_DTH.Size = new System.Drawing.Size(255, 29);
            this.txt_DTH.TabIndex = 89;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(269, 409);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 60);
            this.btn_Xoa.TabIndex = 71;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(119, 409);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
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
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 87;
            this.label5.Text = "Quản lý cửa hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Tên cửa hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Số điện thoại";
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
            this.label2.Text = "Mã cửa hàng ";
            // 
            // txt_TenCH
            // 
            this.txt_TenCH.Location = new System.Drawing.Point(220, 111);
            this.txt_TenCH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenCH.Name = "txt_TenCH";
            this.txt_TenCH.Size = new System.Drawing.Size(255, 29);
            this.txt_TenCH.TabIndex = 82;
            // 
            // txt_MaCH
            // 
            this.txt_MaCH.Enabled = false;
            this.txt_MaCH.Location = new System.Drawing.Point(220, 63);
            this.txt_MaCH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaCH.Name = "txt_MaCH";
            this.txt_MaCH.Size = new System.Drawing.Size(255, 29);
            this.txt_MaCH.TabIndex = 81;
            // 
            // gbo_Data
            // 
            this.gbo_Data.Controls.Add(this.dgv_Data);
            this.gbo_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Data.Location = new System.Drawing.Point(572, 94);
            this.gbo_Data.Margin = new System.Windows.Forms.Padding(4);
            this.gbo_Data.Name = "gbo_Data";
            this.gbo_Data.Padding = new System.Windows.Forms.Padding(4);
            this.gbo_Data.Size = new System.Drawing.Size(671, 582);
            this.gbo_Data.TabIndex = 82;
            this.gbo_Data.TabStop = false;
            this.gbo_Data.Text = "Thông tin cửa hàng";
            // 
            // frm_QuanLyCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1259, 740);
            this.Controls.Add(this.gbo_Data);
            this.Controls.Add(this.gbo_NhapThongTin);
            this.Controls.Add(this.pnl_Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frm_QuanLyCuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QuanLyCuaHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_QuanLyCuaHang_Load);
            this.Resize += new System.EventHandler(this.frm_QuanLyCuaHang_Resize);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.gbo_NhapThongTin.ResumeLayout(false);
            this.gbo_NhapThongTin.PerformLayout();
            this.gbo_Data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.GroupBox gbo_NhapThongTin;
        private System.Windows.Forms.TextBox txt_MaNguoiQL;
        private System.Windows.Forms.TextBox txt_DTH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenCH;
        private System.Windows.Forms.TextBox txt_MaCH;
        private System.Windows.Forms.GroupBox gbo_Data;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.RichTextBox rtf_DiaChi;
    }
}