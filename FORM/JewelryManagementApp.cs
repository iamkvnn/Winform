using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms2.DAL;
using WindowsForms2.BLL;

namespace WindowsForms2.FORM
{
    public partial class JewelryManagementApp: Form
    {
        private int borderSize = 0;
        private Form activeForm;
        private Button currentButton;
        public JewelryManagementApp()
        {
            this.Padding = new Padding(borderSize);
            InitializeComponent();
            btn_Dashboard_Click(btn_Dashboard, new EventArgs());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        private void JewelryManagementApp_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void JewelryManagementApp_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void JewelryManagementApp_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void JewelryManagementApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            JewelryManagementApp.ActiveForm.Close();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDashboard(), sender as Button);
        }

        private void ActivateButton(Button btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != btnSender)
                {
                    DeactivateCrrButton();
                    currentButton = btnSender;
                    currentButton.BackColor = Color.FromArgb(229, 219, 255);
                    lblCrrForm.Text = currentButton.Text.ToLower()=="thống kê" ? "Thống kê" : "Quản lý " + currentButton.Text.ToLower();
                }
            }
        }

        private void DeactivateCrrButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Transparent;
            }
        }

        private void OpenChildForm(Form childForm, Button sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(sender);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pContent.Controls.Add(childForm);
            pContent.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fProduct(), sender as Button);
        }

        private void cateBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCategory(), sender as Button);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fOrder(), sender as Button);
        }

        private void voucherBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fVoucher(), sender as Button);
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCustomer(), sender as Button);
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fStaff(), sender as Button);
        }
    }
}
