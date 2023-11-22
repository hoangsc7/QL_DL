
namespace Quan_ly_Tour_du_lich
{
    partial class F_KH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_KH));
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_kh = new System.Windows.Forms.DataGridView();
            this.Ma_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_nu = new System.Windows.Forms.RadioButton();
            this.rd_nam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cb_email = new System.Windows.Forms.ComboBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_kh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(356, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(348, 32);
            this.label12.TabIndex = 33;
            this.label12.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(798, 324);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(176, 27);
            this.txt_tim.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_kh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1024, 277);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // DGV_kh
            // 
            this.DGV_kh.AllowUserToAddRows = false;
            this.DGV_kh.AllowUserToDeleteRows = false;
            this.DGV_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_kh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_KH,
            this.Ten_KH,
            this.NgaySinh,
            this.DiaChi,
            this.Sdt,
            this.CCCD,
            this.Email,
            this.GioiTinh});
            this.DGV_kh.Location = new System.Drawing.Point(42, 26);
            this.DGV_kh.Name = "DGV_kh";
            this.DGV_kh.ReadOnly = true;
            this.DGV_kh.RowHeadersWidth = 51;
            this.DGV_kh.RowTemplate.Height = 24;
            this.DGV_kh.Size = new System.Drawing.Size(952, 232);
            this.DGV_kh.TabIndex = 1;
            this.DGV_kh.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_kh_CellEnter);
            this.DGV_kh.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_nv_RowEnter);
            // 
            // Ma_KH
            // 
            this.Ma_KH.DataPropertyName = "Ma_KH";
            this.Ma_KH.HeaderText = "Mã khách hàng";
            this.Ma_KH.MinimumWidth = 6;
            this.Ma_KH.Name = "Ma_KH";
            this.Ma_KH.ReadOnly = true;
            this.Ma_KH.Width = 125;
            // 
            // Ten_KH
            // 
            this.Ten_KH.DataPropertyName = "Ten_KH";
            this.Ten_KH.HeaderText = "Tên khách hàng";
            this.Ten_KH.MinimumWidth = 6;
            this.Ten_KH.Name = "Ten_KH";
            this.Ten_KH.ReadOnly = true;
            this.Ten_KH.Width = 125;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_nu);
            this.groupBox1.Controls.Add(this.rd_nam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_cccd);
            this.groupBox1.Controls.Add(this.date_ngaysinh);
            this.groupBox1.Controls.Add(this.cb_email);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 276);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // rd_nu
            // 
            this.rd_nu.AutoSize = true;
            this.rd_nu.Location = new System.Drawing.Point(539, 27);
            this.rd_nu.Name = "rd_nu";
            this.rd_nu.Size = new System.Drawing.Size(51, 23);
            this.rd_nu.TabIndex = 31;
            this.rd_nu.TabStop = true;
            this.rd_nu.Text = "Nữ";
            this.rd_nu.UseVisualStyleBackColor = true;
            // 
            // rd_nam
            // 
            this.rd_nam.AutoSize = true;
            this.rd_nam.Location = new System.Drawing.Point(471, 27);
            this.rd_nam.Name = "rd_nam";
            this.rd_nam.Size = new System.Drawing.Size(62, 23);
            this.rd_nam.TabIndex = 30;
            this.rd_nam.TabStop = true;
            this.rd_nam.Text = "Nam";
            this.rd_nam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Giới tính:";
            // 
            // txt_cccd
            // 
            this.txt_cccd.Location = new System.Drawing.Point(471, 89);
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
            this.cb_email.Location = new System.Drawing.Point(471, 122);
            this.cb_email.Name = "cb_email";
            this.cb_email.Size = new System.Drawing.Size(202, 27);
            this.cb_email.TabIndex = 22;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(147, 59);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(202, 27);
            this.txt_tenkh.TabIndex = 18;
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
            this.txt_sdt.Location = new System.Drawing.Point(471, 56);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(202, 27);
            this.txt_sdt.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(373, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Số CCCD:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 59);
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
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khách hàng:";
            // 
            // bt_tim
            // 
            this.bt_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Image = ((System.Drawing.Image)(resources.GetObject("bt_tim.Image")));
            this.bt_tim.Location = new System.Drawing.Point(980, 324);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(75, 28);
            this.bt_tim.TabIndex = 31;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dong.Image = ((System.Drawing.Image)(resources.GetObject("bt_dong.Image")));
            this.bt_dong.Location = new System.Drawing.Point(966, 235);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(89, 34);
            this.bt_dong.TabIndex = 30;
            this.bt_dong.Text = "Đóng";
            this.bt_dong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.Location = new System.Drawing.Point(966, 195);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(89, 34);
            this.bt_xoa.TabIndex = 29;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_sua.Image")));
            this.bt_sua.Location = new System.Drawing.Point(966, 115);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(89, 34);
            this.bt_sua.TabIndex = 28;
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
            this.bt_them.Location = new System.Drawing.Point(966, 75);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(89, 34);
            this.bt_them.TabIndex = 27;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Image = ((System.Drawing.Image)(resources.GetObject("bt_reset.Image")));
            this.bt_reset.Location = new System.Drawing.Point(966, 155);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(89, 34);
            this.bt_reset.TabIndex = 38;
            this.bt_reset.Text = "Reset";
            this.bt_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(147, 26);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(202, 27);
            this.txt_makh.TabIndex = 11;
            // 
            // F_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 653);
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
            this.Name = "F_KH";
            this.Text = "F_KH";
            this.Load += new System.EventHandler(this.F_KH_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_kh)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.ComboBox cb_email;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_kh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rd_nu;
        private System.Windows.Forms.RadioButton rd_nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label1;
    }
}