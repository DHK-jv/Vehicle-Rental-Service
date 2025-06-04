
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThueXe.BLL;
using QuanLyThueXe.DTO;

namespace QuanLyThueXe.GUI
{
    public partial class GUI_LoginForm : Form
    {
        public GUI_LoginForm()
        {

            InitializeComponent();
        }

        private void resetTextBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        

        private void GUI_LoginForm_Load(object sender, EventArgs e)
        {
            resetTextBox();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
                
        }

        //private string getContentFileLog(TaiKhoan tk, DateTime dt, string status)
        //{

        //    string content = string.Empty;
        //    content += dt + "  |  ";
        //    if (tk != null)
        //    {
        //        content += tk.getUserName() + "  |  ";
        //        content += tk.getPassword() + "  |  ";
        //    }
        //    else
        //    {
        //        content += "Unknown User" + "  |  ";
        //    }
        //    content += status + "  |  \n";
        //    return content;
        //}

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string status = string.Empty;
            string content = string.Empty;
            BLL_Login busLogin = new BLL_Login();
            DateTime dt = DateTime.Now;
            //CreateFileDoc doc = new CreateFileDoc();
            TaiKhoan tk = busLogin.Login(txtUsername.Text, txtPassword.Text);

            if (tk != null)
            {
                this.Hide();
                MessageBox.Show("Đăng nhập thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GUI_MainForm main = new GUI_MainForm(tk.getPhanQuyen(), busLogin.LayMaNhanVien(tk.getUserName()));
                main.ShowDialog();
                status = "Đăng nhập thành công";
                this.Close();
                //doc.CreateFileWord("Log_Login", getContentFileLog(tk, dt, status));

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu ", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = "Đăng nhập thất bại";
                resetTextBox();
                txtUsername.Focus();
                //doc.CreateFileWord("Log_Login", getContentFileLog(tk, dt, status));
            }
        }

        //. Hàm này nhận phím enter mỗi khi nhấn thì kiểm tra xem textboxUsername có rỗng hay không , nếu có thì focus vào , mỗi lần enter sẽ focus tiếp

        //private void llbFP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    GUI_DatLaiMatKhauForm dlmk = new GUI_DatLaiMatKhauForm();
        //    dlmk.Show();
        //}

        private void GUI_LoginForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        { 
        }

        private void GUI_LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Focus();
                    return;
                }
                btnSignin.PerformClick(); // dùng perform click để mô phỏng hành động click đăng nhập 

            }
        }
    }
}
