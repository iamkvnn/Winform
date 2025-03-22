using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2
{
    public partial class JewelryManagementApp: Form
    {
        private Form activeForm;
        private Button currentButton;
        private jewelryStoreManagementEntities _db;
        public JewelryManagementApp(jewelryStoreManagementEntities db)
        {
            InitializeComponent();
            _db = db;
            btn_Dashboard_Click(btn_Dashboard, new EventArgs());
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
            OpenChildForm(new fDashboard(_db), sender as Button);
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
            OpenChildForm(new fProduct(_db), sender as Button);
        }
    }
}
