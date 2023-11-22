using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Quan_Ly_Tour;
using BLL_Quan_Ly_Tour;
namespace Quan_ly_Tour_du_lich
{
    public partial class F_login : Form
    {
        ACCOUNT taikhoan = new ACCOUNT();
        BLL_QLT tkBLL = new BLL_QLT();
        public bool isThoat = true;

        public F_login()
        {
            InitializeComponent();
        }

        private void phide_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '*')
            {
                peye.BringToFront();
                txt_pass.PasswordChar = '\0';
            }
        }

        private void peye_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '\0')
            {
                phide.BringToFront();
                txt_pass.PasswordChar = '*';
            }
        }

        private void bt_signin_Click(object sender, EventArgs e)
        {
            taikhoan.Email = txt_email.Text;
            taikhoan.Mat_Khau = txt_pass.Text;
            string getlogin = tkBLL.CheckLogin(taikhoan);
            // trả lại kết quả khi nghiệp vụ không đúng
            switch (getlogin)
            {
                case "requeid_email":
                    MessageBox.Show("Email không được để trống!");
                    return;
                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống!");
                    return;
                case "Email mật khẩu không chính xác!":
                    MessageBox.Show("Email mạt khẩu không chính xác!");
                    return;
            }
            MessageBox.Show("Đăng nhập thành công!");
            F_main.quyen = getlogin;
            F_main.email = txt_email.Text;
            F_main fmain = new F_main();
            fmain.Show();
            this.Hide();
            fmain.DangXuat += Fmain_DangXuat;
        }

        private void Fmain_DangXuat(object sender, EventArgs e)
        {
            (sender as F_main).isThoat = false;
            (sender as F_main).Close();
            this.Show();
        }

        private void lk_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_signup fsignup = new F_signup();
            fsignup.Show();
            this.Hide();
        }

        private void F_login_FormClosed(object sender, FormClosedEventArgs e)
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

        private void F_login_Load(object sender, EventArgs e)
        {

        }
    }
}
