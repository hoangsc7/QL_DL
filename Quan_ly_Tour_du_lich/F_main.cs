using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Quan_Ly_Tour;
using DTO_Quan_Ly_Tour;

namespace Quan_ly_Tour_du_lich
{
    public partial class F_main : Form
    {
        public static string quyen;
        public static string email;
        public bool isThoat = true;

        public F_main()
        {
            InitializeComponent();
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NV fnv = new F_NV();
            fnv.Show();
            fnv.MdiParent = this;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_KH fkh = new F_KH();
            fkh.Show();
            fkh.MdiParent = this;
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_booking.email = email;
            F_booking.quyen = quyen;
            F_booking fbooking = new F_booking();
            fbooking.Show();
            fbooking.MdiParent = this;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void F_main_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            if (quyen == "003")
            {
                tsmi_Quanly.Visible = false;
                tsmi_quanlytaikhoan.Text = email;
            }
            else if (quyen == "002")
            {
                tsmi_nhanvien.Visible = false;
                tsmi_dattour.Visible = false;
                tsmi_quanlytaikhoan.Text = email;
            }
            else
            {
                tsmi_dattour.Visible = false;
                tsmi_quanlytaikhoan.Text = email;
            }
        }


        public event EventHandler DangXuat;

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void tsmi_tour_Click(object sender, EventArgs e)
        {
            F_tour ftour = new F_tour();
            ftour.Show();
            ftour.MdiParent = this;
        }

        private void tsmi_dattour_Click(object sender, EventArgs e)
        {
            F_booking.email = email;
            F_booking.quyen = quyen;
            F_booking fbooking = new F_booking();
            fbooking.Show();
            fbooking.MdiParent = this;
        }

        private void F_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                DialogResult msg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void tsmi_khuyenmai_Click(object sender, EventArgs e)
        {
            F_KM fkm = new F_KM();
            fkm.Show();
            fkm.MdiParent = this;
        }

        private void tsmi_quanlytaikhoan_Click(object sender, EventArgs e)
        {
            F_Infor.email = email;
            F_Infor.quyen = quyen;
            F_Infor finfor = new F_Infor();
            finfor.Show();
            finfor.MdiParent = this;
        }

        private void tsmi_Quanly_Click(object sender, EventArgs e)
        {

        }
    }
}
