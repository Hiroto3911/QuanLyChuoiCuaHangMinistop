namespace GUI
{
	partial class frm_ThayDoiChuoiSQLServer
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_ServerName = new System.Windows.Forms.TextBox();
			this.cbo_DataBaseName = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbo_Authentication = new System.Windows.Forms.ComboBox();
			this.txt_UserName = new System.Windows.Forms.TextBox();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_TestConnection = new System.Windows.Forms.Button();
			this.btn_Ok = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Authentication :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 324);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Database name";
			// 
			// txt_ServerName
			// 
			this.txt_ServerName.Location = new System.Drawing.Point(128, 84);
			this.txt_ServerName.Name = "txt_ServerName";
			this.txt_ServerName.Size = new System.Drawing.Size(196, 20);
			this.txt_ServerName.TabIndex = 5;
			// 
			// cbo_DataBaseName
			// 
			this.cbo_DataBaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_DataBaseName.FormattingEnabled = true;
			this.cbo_DataBaseName.Location = new System.Drawing.Point(128, 324);
			this.cbo_DataBaseName.Name = "cbo_DataBaseName";
			this.cbo_DataBaseName.Size = new System.Drawing.Size(196, 21);
			this.cbo_DataBaseName.TabIndex = 8;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cbo_Authentication);
			this.groupBox1.Controls.Add(this.txt_UserName);
			this.groupBox1.Controls.Add(this.txt_Password);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 138);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(332, 157);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Log on to the server";
			// 
			// cbo_Authentication
			// 
			this.cbo_Authentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_Authentication.FormattingEnabled = true;
			this.cbo_Authentication.Location = new System.Drawing.Point(116, 32);
			this.cbo_Authentication.Name = "cbo_Authentication";
			this.cbo_Authentication.Size = new System.Drawing.Size(196, 24);
			this.cbo_Authentication.TabIndex = 66;
			this.cbo_Authentication.SelectedValueChanged += new System.EventHandler(this.cbo_Authentication_SelectedValueChanged);
			// 
			// txt_UserName
			// 
			this.txt_UserName.Location = new System.Drawing.Point(116, 72);
			this.txt_UserName.Name = "txt_UserName";
			this.txt_UserName.Size = new System.Drawing.Size(196, 22);
			this.txt_UserName.TabIndex = 13;
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(116, 112);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Size = new System.Drawing.Size(196, 22);
			this.txt_Password.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "User name";
			// 
			// btn_TestConnection
			// 
			this.btn_TestConnection.Location = new System.Drawing.Point(12, 394);
			this.btn_TestConnection.Name = "btn_TestConnection";
			this.btn_TestConnection.Size = new System.Drawing.Size(101, 23);
			this.btn_TestConnection.TabIndex = 11;
			this.btn_TestConnection.Text = "Test Connection";
			this.btn_TestConnection.UseVisualStyleBackColor = true;
			this.btn_TestConnection.Click += new System.EventHandler(this.btn_TestConnection_Click);
			// 
			// btn_Ok
			// 
			this.btn_Ok.Location = new System.Drawing.Point(178, 394);
			this.btn_Ok.Name = "btn_Ok";
			this.btn_Ok.Size = new System.Drawing.Size(75, 23);
			this.btn_Ok.TabIndex = 12;
			this.btn_Ok.Text = "OK";
			this.btn_Ok.UseVisualStyleBackColor = true;
			this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(269, 394);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 13;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// lbl_Title
			// 
			this.lbl_Title.AutoSize = true;
			this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.Color.White;
			this.lbl_Title.Location = new System.Drawing.Point(25, 9);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(299, 31);
			this.lbl_Title.TabIndex = 19;
			this.lbl_Title.Text = "Thay đổi chuỗi kết nối";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.lbl_Title);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(356, 52);
			this.panel1.TabIndex = 65;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(433, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(146, 33);
			this.label6.TabIndex = 18;
			this.label6.Text = "Bán hàng";
			// 
			// frm_ThayDoiChuoiSQLServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(144)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(356, 438);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Ok);
			this.Controls.Add(this.btn_TestConnection);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbo_DataBaseName);
			this.Controls.Add(this.txt_ServerName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.Name = "frm_ThayDoiChuoiSQLServer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SQL Server";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ThayDoiChuoiSQLServer_FormClosing);
			this.Load += new System.EventHandler(this.frm_ThayDoiChuoiSQLServer_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_ServerName;
		private System.Windows.Forms.ComboBox cbo_DataBaseName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_UserName;
		private System.Windows.Forms.TextBox txt_Password;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_TestConnection;
		private System.Windows.Forms.Button btn_Ok;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbo_Authentication;
	}
}