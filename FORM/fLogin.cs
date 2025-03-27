using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms2.DAL;

namespace WindowsForms2.FORM
{
    public partial class fLogin: Form
    {
        public fLogin()
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(170, 255, 255, 255);
            this.btn_quit.BackColor = Color.FromArgb(170, 255, 255, 255);
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            ModelDAO.Instance.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (this.username.Texts == "" || this.password.Texts == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            //    return;
            //}
            //var user = db.users.Where(u => u.username == this.username.Texts && u.password == this.password.Texts).FirstOrDefault();
            //if (user == null)
            //{
            //    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            //    return;
            //}
            JewelryManagementApp f = new JewelryManagementApp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
