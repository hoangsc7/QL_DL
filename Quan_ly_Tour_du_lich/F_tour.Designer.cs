
namespace Quan_ly_Tour_du_lich
{
    partial class F_tour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_tour));
            this.txt_img = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_tour = new System.Windows.Forms.DataGridView();
            this.Ma_Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiemKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_matour = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_ddkhoihanh = new System.Windows.Forms.TextBox();
            this.txt_thoigian = new System.Windows.Forms.TextBox();
            this.txt_diadiem = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.cb_makm = new System.Windows.Forms.ComboBox();
            this.cb_loaihinh = new System.Windows.Forms.ComboBox();
            this.date_khoihanh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pt_img = new System.Windows.Forms.PictureBox();
            this.bt_mo = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_tour)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_img)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_img
            // 
            this.txt_img.Location = new System.Drawing.Point(457, 23);
            this.txt_img.Multiline = true;
            this.txt_img.Name = "txt_img";
            this.txt_img.Size = new System.Drawing.Size(192, 55);
            this.txt_img.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Img:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_tour);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1167, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Tour";
            // 
            // DGV_tour
            // 
            this.DGV_tour.AllowUserToAddRows = false;
            this.DGV_tour.AllowUserToDeleteRows = false;
            this.DGV_tour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_tour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Tour,
            this.Img,
            this.Mota,
            this.DiaDiem,
            this.ThoiGian,
            this.NgayKhoiHanh,
            this.GiaKM,
            this.Gia,
            this.DiaDiemKH,
            this.LoaiHinh,
            this.Ma_KM});
            this.DGV_tour.Location = new System.Drawing.Point(60, 37);
            this.DGV_tour.Name = "DGV_tour";
            this.DGV_tour.ReadOnly = true;
            this.DGV_tour.RowHeadersWidth = 51;
            this.DGV_tour.RowTemplate.Height = 24;
            this.DGV_tour.Size = new System.Drawing.Size(1044, 222);
            this.DGV_tour.TabIndex = 0;
            this.DGV_tour.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_tour_RowEnter);
            // 
            // Ma_Tour
            // 
            this.Ma_Tour.DataPropertyName = "Ma_Tour";
            this.Ma_Tour.HeaderText = "Mã Tour";
            this.Ma_Tour.MinimumWidth = 6;
            this.Ma_Tour.Name = "Ma_Tour";
            this.Ma_Tour.ReadOnly = true;
            this.Ma_Tour.Width = 125;
            // 
            // Img
            // 
            this.Img.DataPropertyName = "Img";
            this.Img.HeaderText = "Img";
            this.Img.MinimumWidth = 6;
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            this.Img.Width = 125;
            // 
            // Mota
            // 
            this.Mota.DataPropertyName = "Mota";
            this.Mota.HeaderText = "Mô tả";
            this.Mota.MinimumWidth = 6;
            this.Mota.Name = "Mota";
            this.Mota.ReadOnly = true;
            this.Mota.Width = 125;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa điểm";
            this.DiaDiem.MinimumWidth = 6;
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.ReadOnly = true;
            this.DiaDiem.Width = 125;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            this.ThoiGian.Width = 125;
            // 
            // NgayKhoiHanh
            // 
            this.NgayKhoiHanh.DataPropertyName = "NgayKhoiHanh";
            this.NgayKhoiHanh.HeaderText = "Ngày khởi hành";
            this.NgayKhoiHanh.MinimumWidth = 6;
            this.NgayKhoiHanh.Name = "NgayKhoiHanh";
            this.NgayKhoiHanh.ReadOnly = true;
            this.NgayKhoiHanh.Width = 125;
            // 
            // GiaKM
            // 
            this.GiaKM.DataPropertyName = "GiaKM";
            this.GiaKM.HeaderText = "Giá khuyến mãi";
            this.GiaKM.MinimumWidth = 6;
            this.GiaKM.Name = "GiaKM";
            this.GiaKM.ReadOnly = true;
            this.GiaKM.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 125;
            // 
            // DiaDiemKH
            // 
            this.DiaDiemKH.DataPropertyName = "DiaDiemKH";
            this.DiaDiemKH.HeaderText = "Địa điểm khởi hành";
            this.DiaDiemKH.MinimumWidth = 6;
            this.DiaDiemKH.Name = "DiaDiemKH";
            this.DiaDiemKH.ReadOnly = true;
            this.DiaDiemKH.Width = 125;
            // 
            // LoaiHinh
            // 
            this.LoaiHinh.DataPropertyName = "LoaiHinh";
            this.LoaiHinh.HeaderText = "Loại hình";
            this.LoaiHinh.MinimumWidth = 6;
            this.LoaiHinh.Name = "LoaiHinh";
            this.LoaiHinh.ReadOnly = true;
            this.LoaiHinh.Width = 125;
            // 
            // Ma_KM
            // 
            this.Ma_KM.DataPropertyName = "Ma_KM";
            this.Ma_KM.HeaderText = "Mã khuyến mãi";
            this.Ma_KM.MinimumWidth = 6;
            this.Ma_KM.Name = "Ma_KM";
            this.Ma_KM.ReadOnly = true;
            this.Ma_KM.Width = 125;
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(927, 309);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(176, 27);
            this.txt_tim.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(517, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 32);
            this.label12.TabIndex = 24;
            this.label12.Text = "QUẢN LÝ TOUR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa điểm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thời gian:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày khởi hành:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giá:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Địa điểm khởi hành:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Loại hình:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mã khuyến mãi:";
            // 
            // txt_matour
            // 
            this.txt_matour.Location = new System.Drawing.Point(147, 26);
            this.txt_matour.Name = "txt_matour";
            this.txt_matour.Size = new System.Drawing.Size(202, 27);
            this.txt_matour.TabIndex = 11;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(457, 175);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(192, 27);
            this.txt_gia.TabIndex = 15;
            // 
            // txt_ddkhoihanh
            // 
            this.txt_ddkhoihanh.Location = new System.Drawing.Point(175, 158);
            this.txt_ddkhoihanh.Name = "txt_ddkhoihanh";
            this.txt_ddkhoihanh.Size = new System.Drawing.Size(174, 27);
            this.txt_ddkhoihanh.TabIndex = 16;
            // 
            // txt_thoigian
            // 
            this.txt_thoigian.Location = new System.Drawing.Point(145, 92);
            this.txt_thoigian.Name = "txt_thoigian";
            this.txt_thoigian.Size = new System.Drawing.Size(204, 27);
            this.txt_thoigian.TabIndex = 17;
            // 
            // txt_diadiem
            // 
            this.txt_diadiem.Location = new System.Drawing.Point(147, 59);
            this.txt_diadiem.Name = "txt_diadiem";
            this.txt_diadiem.Size = new System.Drawing.Size(204, 27);
            this.txt_diadiem.TabIndex = 18;
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(457, 84);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(192, 85);
            this.txt_mota.TabIndex = 19;
            // 
            // cb_makm
            // 
            this.cb_makm.FormattingEnabled = true;
            this.cb_makm.Location = new System.Drawing.Point(175, 224);
            this.cb_makm.Name = "cb_makm";
            this.cb_makm.Size = new System.Drawing.Size(174, 27);
            this.cb_makm.TabIndex = 22;
            // 
            // cb_loaihinh
            // 
            this.cb_loaihinh.FormattingEnabled = true;
            this.cb_loaihinh.Items.AddRange(new object[] {
            "Tour nội địa",
            "Tour nước ngoài"});
            this.cb_loaihinh.Location = new System.Drawing.Point(175, 191);
            this.cb_loaihinh.Name = "cb_loaihinh";
            this.cb_loaihinh.Size = new System.Drawing.Size(174, 27);
            this.cb_loaihinh.TabIndex = 23;
            // 
            // date_khoihanh
            // 
            this.date_khoihanh.CustomFormat = "yyyy/MM/dd";
            this.date_khoihanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_khoihanh.Location = new System.Drawing.Point(145, 125);
            this.date_khoihanh.Name = "date_khoihanh";
            this.date_khoihanh.Size = new System.Drawing.Size(204, 27);
            this.date_khoihanh.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pt_img);
            this.groupBox1.Controls.Add(this.bt_mo);
            this.groupBox1.Controls.Add(this.date_khoihanh);
            this.groupBox1.Controls.Add(this.cb_loaihinh);
            this.groupBox1.Controls.Add(this.cb_makm);
            this.groupBox1.Controls.Add(this.txt_img);
            this.groupBox1.Controls.Add(this.txt_mota);
            this.groupBox1.Controls.Add(this.txt_diadiem);
            this.groupBox1.Controls.Add(this.txt_thoigian);
            this.groupBox1.Controls.Add(this.txt_ddkhoihanh);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.txt_matour);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Tour";
            // 
            // pt_img
            // 
            this.pt_img.InitialImage = null;
            this.pt_img.Location = new System.Drawing.Point(750, 22);
            this.pt_img.Name = "pt_img";
            this.pt_img.Size = new System.Drawing.Size(136, 130);
            this.pt_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_img.TabIndex = 27;
            this.pt_img.TabStop = false;
            // 
            // bt_mo
            // 
            this.bt_mo.Image = ((System.Drawing.Image)(resources.GetObject("bt_mo.Image")));
            this.bt_mo.Location = new System.Drawing.Point(655, 22);
            this.bt_mo.Name = "bt_mo";
            this.bt_mo.Size = new System.Drawing.Size(89, 47);
            this.bt_mo.TabIndex = 26;
            this.bt_mo.Text = "Mở";
            this.bt_mo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_mo.UseVisualStyleBackColor = true;
            this.bt_mo.Click += new System.EventHandler(this.bt_mo_Click);
            // 
            // bt_tim
            // 
            this.bt_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Image = ((System.Drawing.Image)(resources.GetObject("bt_tim.Image")));
            this.bt_tim.Location = new System.Drawing.Point(1109, 307);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(87, 29);
            this.bt_tim.TabIndex = 6;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dong.Image = ((System.Drawing.Image)(resources.GetObject("bt_dong.Image")));
            this.bt_dong.Location = new System.Drawing.Point(1109, 220);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(89, 34);
            this.bt_dong.TabIndex = 5;
            this.bt_dong.Text = "Đóng";
            this.bt_dong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.Location = new System.Drawing.Point(1109, 180);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(89, 34);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_sua.Image")));
            this.bt_sua.Location = new System.Drawing.Point(1107, 100);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(89, 34);
            this.bt_sua.TabIndex = 3;
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
            this.bt_them.Location = new System.Drawing.Point(1107, 60);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(89, 34);
            this.bt_them.TabIndex = 2;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Image = ((System.Drawing.Image)(resources.GetObject("bt_reset.Image")));
            this.bt_reset.Location = new System.Drawing.Point(1109, 140);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(89, 34);
            this.bt_reset.TabIndex = 38;
            this.bt_reset.Text = "Reset";
            this.bt_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // F_tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 653);
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
            this.Name = "F_tour";
            this.Text = "F_tour";
            this.Load += new System.EventHandler(this.F_tour_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_tour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_img;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_tour;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_dong;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_mo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_matour;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_ddkhoihanh;
        private System.Windows.Forms.TextBox txt_thoigian;
        private System.Windows.Forms.TextBox txt_diadiem;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.ComboBox cb_makm;
        private System.Windows.Forms.ComboBox cb_loaihinh;
        private System.Windows.Forms.DateTimePicker date_khoihanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pt_img;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiemKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_KM;
        private System.Windows.Forms.Button bt_reset;
    }
}