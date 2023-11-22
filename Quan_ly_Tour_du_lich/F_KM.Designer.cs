
namespace Quan_ly_Tour_du_lich
{
    partial class F_KM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_KM));
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_makm = new System.Windows.Forms.TextBox();
            this.date_ngaykm = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_ngayktkm = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_km = new System.Windows.Forms.DataGridView();
            this.Ma_KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_KTKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.nu_km = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_km)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_km)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(319, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(338, 32);
            this.label12.TabIndex = 42;
            this.label12.Text = "QUẢN LÝ KHUYẾN MÃI";
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(551, 287);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(201, 27);
            this.txt_tim.TabIndex = 41;
            // 
            // bt_tim
            // 
            this.bt_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Image = ((System.Drawing.Image)(resources.GetObject("bt_tim.Image")));
            this.bt_tim.Location = new System.Drawing.Point(762, 287);
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
            this.bt_dong.Location = new System.Drawing.Point(748, 230);
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
            this.bt_xoa.Location = new System.Drawing.Point(748, 190);
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
            this.bt_sua.Location = new System.Drawing.Point(748, 110);
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
            this.bt_them.Location = new System.Drawing.Point(748, 70);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(89, 34);
            this.bt_them.TabIndex = 36;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khuyến mãi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày_KM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Khuyến mãi:";
            // 
            // txt_makm
            // 
            this.txt_makm.Location = new System.Drawing.Point(147, 26);
            this.txt_makm.Name = "txt_makm";
            this.txt_makm.Size = new System.Drawing.Size(207, 27);
            this.txt_makm.TabIndex = 11;
            // 
            // date_ngaykm
            // 
            this.date_ngaykm.CustomFormat = "yyyy/MM/dd";
            this.date_ngaykm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngaykm.Location = new System.Drawing.Point(147, 59);
            this.date_ngaykm.Name = "date_ngaykm";
            this.date_ngaykm.Size = new System.Drawing.Size(207, 27);
            this.date_ngaykm.TabIndex = 25;
            this.date_ngaykm.Value = new System.DateTime(2023, 4, 29, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nu_km);
            this.groupBox1.Controls.Add(this.date_ngayktkm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date_ngaykm);
            this.groupBox1.Controls.Add(this.txt_makm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(113, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 203);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khuyến mãi";
            // 
            // date_ngayktkm
            // 
            this.date_ngayktkm.CustomFormat = "yyyy/MM/dd";
            this.date_ngayktkm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngayktkm.Location = new System.Drawing.Point(147, 93);
            this.date_ngayktkm.Name = "date_ngayktkm";
            this.date_ngayktkm.Size = new System.Drawing.Size(207, 27);
            this.date_ngayktkm.TabIndex = 27;
            this.date_ngayktkm.Value = new System.DateTime(2023, 4, 29, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ngày_KTKM:";
            // 
            // DGV_km
            // 
            this.DGV_km.AllowUserToAddRows = false;
            this.DGV_km.AllowUserToDeleteRows = false;
            this.DGV_km.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_km.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_KM,
            this.Ngay_KM,
            this.Ngay_KTKM,
            this.KM});
            this.DGV_km.Location = new System.Drawing.Point(6, 33);
            this.DGV_km.Name = "DGV_km";
            this.DGV_km.ReadOnly = true;
            this.DGV_km.RowHeadersWidth = 51;
            this.DGV_km.RowTemplate.Height = 24;
            this.DGV_km.Size = new System.Drawing.Size(764, 228);
            this.DGV_km.TabIndex = 43;
            this.DGV_km.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_km_RowEnter);
            // 
            // Ma_KM
            // 
            this.Ma_KM.DataPropertyName = "Ma_KM";
            this.Ma_KM.HeaderText = "Mã khuyến mãi";
            this.Ma_KM.MinimumWidth = 6;
            this.Ma_KM.Name = "Ma_KM";
            this.Ma_KM.ReadOnly = true;
            this.Ma_KM.Width = 150;
            // 
            // Ngay_KM
            // 
            this.Ngay_KM.DataPropertyName = "Ngay_KM";
            this.Ngay_KM.HeaderText = "Ngày khuyến mãi";
            this.Ngay_KM.MinimumWidth = 6;
            this.Ngay_KM.Name = "Ngay_KM";
            this.Ngay_KM.ReadOnly = true;
            this.Ngay_KM.Width = 175;
            // 
            // Ngay_KTKM
            // 
            this.Ngay_KTKM.DataPropertyName = "Ngay_KTKM";
            this.Ngay_KTKM.HeaderText = "Ngày kết thúc khuyến mãi";
            this.Ngay_KTKM.MinimumWidth = 6;
            this.Ngay_KTKM.Name = "Ngay_KTKM";
            this.Ngay_KTKM.ReadOnly = true;
            this.Ngay_KTKM.Width = 225;
            // 
            // KM
            // 
            this.KM.DataPropertyName = "KhuyenMai";
            this.KM.HeaderText = "Khuyến mãi";
            this.KM.MinimumWidth = 6;
            this.KM.Name = "KM";
            this.KM.ReadOnly = true;
            this.KM.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_km);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(47, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 267);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khuyến mãi";
            // 
            // bt_reset
            // 
            this.bt_reset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Image = ((System.Drawing.Image)(resources.GetObject("bt_reset.Image")));
            this.bt_reset.Location = new System.Drawing.Point(748, 150);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(89, 34);
            this.bt_reset.TabIndex = 45;
            this.bt_reset.Text = "Reset";
            this.bt_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // nu_km
            // 
            this.nu_km.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nu_km.Location = new System.Drawing.Point(147, 124);
            this.nu_km.Name = "nu_km";
            this.nu_km.Size = new System.Drawing.Size(86, 27);
            this.nu_km.TabIndex = 28;
            // 
            // F_KM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.bt_dong);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.groupBox1);
            this.Name = "F_KM";
            this.Text = "F_promotion";
            this.Load += new System.EventHandler(this.F_KM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_km)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nu_km)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_makm;
        private System.Windows.Forms.DateTimePicker date_ngaykm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_ngayktkm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_km;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_KM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_KM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_KTKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn KM;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.NumericUpDown nu_km;
    }
}