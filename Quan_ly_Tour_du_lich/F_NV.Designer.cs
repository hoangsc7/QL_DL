
namespace Quan_ly_Tour_du_lich
{
    partial class F_NV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NV));
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_nv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_nu = new System.Windows.Forms.RadioButton();
            this.rd_nam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_chucvu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cb_email = new System.Windows.Forms.ComboBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.Ma_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_nv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(378, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(307, 32);
            this.label12.TabIndex = 42;
            this.label12.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(793, 321);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(237, 27);
            this.txt_tim.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_nv);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(53, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1072, 276);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // DGV_nv
            // 
            this.DGV_nv.AllowUserToAddRows = false;
            this.DGV_nv.AllowUserToDeleteRows = false;
            this.DGV_nv.AllowUserToOrderColumns = true;
            this.DGV_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_nv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_NV,
            this.Ten_NV,
            this.NgaySinh,
            this.DiaChi,
            this.Sdt,
            this.CCCD,
            this.ChucVu,
            this.Email,
            this.GioiTinh});
            this.DGV_nv.Location = new System.Drawing.Point(19, 49);
            this.DGV_nv.Name = "DGV_nv";
            this.DGV_nv.ReadOnly = true;
            this.DGV_nv.RowHeadersWidth = 51;
            this.DGV_nv.RowTemplate.Height = 24;
            this.DGV_nv.Size = new System.Drawing.Size(1029, 221);
            this.DGV_nv.TabIndex = 0;
            this.DGV_nv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_nv_CellEnter);
            this.DGV_nv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_nv_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_nu);
            this.groupBox1.Controls.Add(this.rd_nam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_chucvu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_cccd);
            this.groupBox1.Controls.Add(this.date_ngaysinh);
            this.groupBox1.Controls.Add(this.cb_email);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 219);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // rd_nu
            // 
            this.rd_nu.AutoSize = true;
            this.rd_nu.Location = new System.Drawing.Point(273, 158);
            this.rd_nu.Name = "rd_nu";
            this.rd_nu.Size = new System.Drawing.Size(51, 23);
            this.rd_nu.TabIndex = 33;
            this.rd_nu.TabStop = true;
            this.rd_nu.Text = "Nữ";
            this.rd_nu.UseVisualStyleBackColor = true;
            // 
            // rd_nam
            // 
            this.rd_nam.AutoSize = true;
            this.rd_nam.Location = new System.Drawing.Point(147, 158);
            this.rd_nam.Name = "rd_nam";
            this.rd_nam.Size = new System.Drawing.Size(62, 23);
            this.rd_nam.TabIndex = 32;
            this.rd_nam.TabStop = true;
            this.rd_nam.Text = "Nam";
            this.rd_nam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Email:";
            // 
            // cb_chucvu
            // 
            this.cb_chucvu.FormattingEnabled = true;
            this.cb_chucvu.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý"});
            this.cb_chucvu.Location = new System.Drawing.Point(502, 92);
            this.cb_chucvu.Name = "cb_chucvu";
            this.cb_chucvu.Size = new System.Drawing.Size(202, 27);
            this.cb_chucvu.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Chức vụ:";
            // 
            // txt_cccd
            // 
            this.txt_cccd.Location = new System.Drawing.Point(502, 59);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(202, 27);
            this.txt_cccd.TabIndex = 28;
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.CustomFormat = "yyyy/MM/dd";
            this.date_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngaysinh.Location = new System.Drawing.Point(147, 92);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(202, 27);
            this.date_ngaysinh.TabIndex = 25;
            // 
            // cb_email
            // 
            this.cb_email.FormattingEnabled = true;
            this.cb_email.Location = new System.Drawing.Point(502, 125);
            this.cb_email.Name = "cb_email";
            this.cb_email.Size = new System.Drawing.Size(202, 27);
            this.cb_email.TabIndex = 22;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(147, 59);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(202, 27);
            this.txt_tennv.TabIndex = 18;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(147, 125);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(202, 27);
            this.txt_diachi.TabIndex = 17;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(502, 26);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(202, 27);
            this.txt_sdt.TabIndex = 16;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(147, 26);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(202, 27);
            this.txt_manv.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Số CCCD:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // bt_tim
            // 
            this.bt_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Image = ((System.Drawing.Image)(resources.GetObject("bt_tim.Image")));
            this.bt_tim.Location = new System.Drawing.Point(1050, 320);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(75, 28);
            this.bt_tim.TabIndex = 40;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dong.Image = ((System.Drawing.Image)(resources.GetObject("bt_dong.Image")));
            this.bt_dong.Location = new System.Drawing.Point(1036, 229);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(89, 34);
            this.bt_dong.TabIndex = 39;
            this.bt_dong.Text = "Đóng";
            this.bt_dong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.Location = new System.Drawing.Point(1036, 189);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(89, 34);
            this.bt_xoa.TabIndex = 38;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_sua.Image")));
            this.bt_sua.Location = new System.Drawing.Point(1036, 109);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(89, 34);
            this.bt_sua.TabIndex = 37;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.Black;
            this.bt_them.Image = global::Quan_ly_Tour_du_lich.Properties.Resources.add;
            this.bt_them.Location = new System.Drawing.Point(1036, 69);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(89, 34);
            this.bt_them.TabIndex = 36;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Image = ((System.Drawing.Image)(resources.GetObject("bt_reset.Image")));
            this.bt_reset.Location = new System.Drawing.Point(1036, 149);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(89, 34);
            this.bt_reset.TabIndex = 43;
            this.bt_reset.Text = "Reset";
            this.bt_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // Ma_NV
            // 
            this.Ma_NV.DataPropertyName = "Ma_NV";
            this.Ma_NV.HeaderText = "Mã nhân viên";
            this.Ma_NV.MinimumWidth = 6;
            this.Ma_NV.Name = "Ma_NV";
            this.Ma_NV.ReadOnly = true;
            this.Ma_NV.Width = 125;
            // 
            // Ten_NV
            // 
            this.Ten_NV.DataPropertyName = "Ten_NV";
            this.Ten_NV.HeaderText = "Tên nhân viên";
            this.Ten_NV.MinimumWidth = 6;
            this.Ten_NV.Name = "Ten_NV";
            this.Ten_NV.ReadOnly = true;
            this.Ten_NV.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 125;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Phone";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            this.Sdt.Width = 125;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "Số CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            this.CCCD.Width = 125;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            this.ChucVu.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // F_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.bt_dong);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "F_NV";
            this.Text = "F_NV";
            this.Load += new System.EventHandler(this.F_NV_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_nv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_dong;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_nv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.ComboBox cb_email;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_chucvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rd_nu;
        private System.Windows.Forms.RadioButton rd_nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}