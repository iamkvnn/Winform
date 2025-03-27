namespace WindowsForms2.CustomComponent
{
    partial class AttributeShow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAttribute = new System.Windows.Forms.Panel();
            this.attributeValueTxtBox = new WindowsForms2.CustomTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.attributeNameTxtBox = new WindowsForms2.CustomTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelAttribute.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAttribute
            // 
            this.panelAttribute.Controls.Add(this.attributeValueTxtBox);
            this.panelAttribute.Controls.Add(this.label11);
            this.panelAttribute.Controls.Add(this.attributeNameTxtBox);
            this.panelAttribute.Controls.Add(this.label12);
            this.panelAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAttribute.Location = new System.Drawing.Point(0, 0);
            this.panelAttribute.Margin = new System.Windows.Forms.Padding(12, 0, 12, 6);
            this.panelAttribute.Name = "panelAttribute";
            this.panelAttribute.Size = new System.Drawing.Size(377, 76);
            this.panelAttribute.TabIndex = 21;
            // 
            // attributeValueTxtBox
            // 
            this.attributeValueTxtBox.BackColor = System.Drawing.Color.White;
            this.attributeValueTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.attributeValueTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.attributeValueTxtBox.BorderRadius = 13;
            this.attributeValueTxtBox.BorderSize = 2;
            this.attributeValueTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributeValueTxtBox.Location = new System.Drawing.Point(197, 30);
            this.attributeValueTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.attributeValueTxtBox.Multiline = false;
            this.attributeValueTxtBox.Name = "attributeValueTxtBox";
            this.attributeValueTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.attributeValueTxtBox.PasswordChar = false;
            this.attributeValueTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.attributeValueTxtBox.PlaceholderText = "Nhập";
            this.attributeValueTxtBox.Size = new System.Drawing.Size(175, 38);
            this.attributeValueTxtBox.TabIndex = 18;
            this.attributeValueTxtBox.Texts = "";
            this.attributeValueTxtBox.UnderlinedStyle = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(193, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "Giá trị";
            // 
            // attributeNameTxtBox
            // 
            this.attributeNameTxtBox.BackColor = System.Drawing.Color.White;
            this.attributeNameTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.attributeNameTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.attributeNameTxtBox.BorderRadius = 13;
            this.attributeNameTxtBox.BorderSize = 2;
            this.attributeNameTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributeNameTxtBox.Location = new System.Drawing.Point(4, 30);
            this.attributeNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.attributeNameTxtBox.Multiline = false;
            this.attributeNameTxtBox.Name = "attributeNameTxtBox";
            this.attributeNameTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.attributeNameTxtBox.PasswordChar = false;
            this.attributeNameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.attributeNameTxtBox.PlaceholderText = "Nhập";
            this.attributeNameTxtBox.Size = new System.Drawing.Size(185, 38);
            this.attributeNameTxtBox.TabIndex = 16;
            this.attributeNameTxtBox.Texts = "";
            this.attributeNameTxtBox.UnderlinedStyle = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tên thuộc tính";
            // 
            // AttributeShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAttribute);
            this.Margin = new System.Windows.Forms.Padding(10, 0, 10, 6);
            this.Name = "AttributeShow";
            this.Size = new System.Drawing.Size(377, 76);
            this.panelAttribute.ResumeLayout(false);
            this.panelAttribute.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAttribute;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public CustomTextBox attributeValueTxtBox;
        public CustomTextBox attributeNameTxtBox;
    }
}
