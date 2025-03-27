using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms2.CustomComponent;

namespace WindowsForms2.FORM
{
    public partial class fAddProduct: Form
    {
        public fAddProduct()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            JewelryManagementApp.ActiveForm.Close();
        }

        private void addAttributeBtn_Click(object sender, EventArgs e)
        {
            AttributeShow attributeShow = new AttributeShow();
            CustomButton button = (CustomButton)flpAttribute.Controls.Find("addAttributeBtn", true).First();
            flpAttribute.Controls.Remove(button);
            Button deleteBtn = createAttrDeleteBtn(flpAttribute, attributeShow);
            flpAttribute.Controls.Add(attributeShow);
            flpAttribute.Controls.Add(deleteBtn);
            flpAttribute.Controls.Add(button);
        }

        private Button createAttrDeleteBtn(FlowLayoutPanel flowLayoutPanel, AttributeShow attributeShow)
        {
            Button deleteBtn = new Button();
            deleteBtn.BackgroundImage = Properties.Resources.delete;
            deleteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            deleteBtn.Size = new Size(32, 32);
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.Margin = new Padding(0, 20, 10, 0);
            deleteBtn.Click += (btn, ev) =>
            {
                flowLayoutPanel.Controls.Remove(attributeShow);
                flowLayoutPanel.Controls.Remove(deleteBtn);
            };
            return deleteBtn;
        }

        private void addSizeBtn_Click(object sender, EventArgs e)
        {
            SizeControl sizeControl = new SizeControl();
            CustomButton button = (CustomButton)flpSize.Controls.Find("addSizeBtn", true).First();
            flpSize.Controls.Remove(button);
            Button deleteBtn = createSizeDeleteBtn(flpSize, sizeControl);
            flpSize.Controls.Add(sizeControl);
            flpSize.Controls.Add(deleteBtn);
            flpSize.Controls.Add(button);
        }

        private Button createSizeDeleteBtn(FlowLayoutPanel flp, SizeControl sizeControl)
        {
            Button deleteBtn = new Button();
            deleteBtn.BackgroundImage = Properties.Resources.delete;
            deleteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            deleteBtn.Size = new Size(32, 32);
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.Margin = new Padding(0, 20, 10, 0);
            deleteBtn.Click += (btn, ev) =>
            {
                flp.Controls.Remove(sizeControl);
                flp.Controls.Remove(deleteBtn);
            };
            return deleteBtn;
        }
    }
}
