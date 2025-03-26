namespace WindowsForms2.FORM
{
    partial class fAddProduct
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flpAttribute = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpSize = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.addSizeBtn = new WindowsForms2.CustomButton();
            this.statusCbbox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.collectionCbbox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.categoryCbbox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.addAttributeBtn = new WindowsForms2.CustomButton();
            this.materialTxtBox = new WindowsForms2.CustomTextBox();
            this.productNameTxtBox = new WindowsForms2.CustomTextBox();
            this.exitBtn = new WindowsForms2.CustomButton();
            this.addProductBtn = new WindowsForms2.CustomButton();
            this.flpAttribute.SuspendLayout();
            this.flpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(644, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Thuộc tính sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Bộ sưu tập";
            // 
            // flpAttribute
            // 
            this.flpAttribute.AutoScroll = true;
            this.flpAttribute.Controls.Add(this.addAttributeBtn);
            this.flpAttribute.Location = new System.Drawing.Point(648, 79);
            this.flpAttribute.Name = "flpAttribute";
            this.flpAttribute.Size = new System.Drawing.Size(482, 245);
            this.flpAttribute.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Chất liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên sản phẩm";
            // 
            // flpSize
            // 
            this.flpSize.AutoScroll = true;
            this.flpSize.Controls.Add(this.addSizeBtn);
            this.flpSize.Location = new System.Drawing.Point(26, 365);
            this.flpSize.Name = "flpSize";
            this.flpSize.Size = new System.Drawing.Size(1117, 330);
            this.flpSize.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Size";
            // 
            // addSizeBtn
            // 
            this.addSizeBtn.BackColor = System.Drawing.Color.Silver;
            this.addSizeBtn.BackgroundColor = System.Drawing.Color.Silver;
            this.addSizeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.addSizeBtn.BorderRadius = 15;
            this.addSizeBtn.BorderSize = 0;
            this.addSizeBtn.FlatAppearance.BorderSize = 0;
            this.addSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSizeBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSizeBtn.ForeColor = System.Drawing.Color.LightGray;
            this.addSizeBtn.Location = new System.Drawing.Point(10, 3);
            this.addSizeBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.addSizeBtn.Name = "addSizeBtn";
            this.addSizeBtn.Size = new System.Drawing.Size(127, 36);
            this.addSizeBtn.TabIndex = 21;
            this.addSizeBtn.Text = "Thêm";
            this.addSizeBtn.TextColor = System.Drawing.Color.LightGray;
            this.addSizeBtn.UseVisualStyleBackColor = false;
            this.addSizeBtn.Click += new System.EventHandler(this.addSizeBtn_Click);
            // 
            // statusCbbox
            // 
            this.statusCbbox.BackColor = System.Drawing.Color.White;
            this.statusCbbox.BorderColor = System.Drawing.Color.Silver;
            this.statusCbbox.BorderSize = 2;
            this.statusCbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCbbox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCbbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusCbbox.IconColor = System.Drawing.Color.LightSlateGray;
            this.statusCbbox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.statusCbbox.ListTextColor = System.Drawing.Color.DimGray;
            this.statusCbbox.Location = new System.Drawing.Point(50, 260);
            this.statusCbbox.MinimumSize = new System.Drawing.Size(200, 30);
            this.statusCbbox.Name = "statusCbbox";
            this.statusCbbox.Padding = new System.Windows.Forms.Padding(2);
            this.statusCbbox.Size = new System.Drawing.Size(252, 38);
            this.statusCbbox.TabIndex = 33;
            this.statusCbbox.Texts = "";
            // 
            // collectionCbbox
            // 
            this.collectionCbbox.BackColor = System.Drawing.Color.White;
            this.collectionCbbox.BorderColor = System.Drawing.Color.Silver;
            this.collectionCbbox.BorderSize = 2;
            this.collectionCbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.collectionCbbox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionCbbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.collectionCbbox.IconColor = System.Drawing.Color.LightSlateGray;
            this.collectionCbbox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.collectionCbbox.ListTextColor = System.Drawing.Color.DimGray;
            this.collectionCbbox.Location = new System.Drawing.Point(366, 260);
            this.collectionCbbox.MinimumSize = new System.Drawing.Size(200, 30);
            this.collectionCbbox.Name = "collectionCbbox";
            this.collectionCbbox.Padding = new System.Windows.Forms.Padding(2);
            this.collectionCbbox.Size = new System.Drawing.Size(240, 38);
            this.collectionCbbox.TabIndex = 31;
            this.collectionCbbox.Texts = "";
            // 
            // categoryCbbox
            // 
            this.categoryCbbox.BackColor = System.Drawing.Color.White;
            this.categoryCbbox.BorderColor = System.Drawing.Color.Silver;
            this.categoryCbbox.BorderSize = 2;
            this.categoryCbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCbbox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCbbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryCbbox.IconColor = System.Drawing.Color.LightSlateGray;
            this.categoryCbbox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.categoryCbbox.ListTextColor = System.Drawing.Color.DimGray;
            this.categoryCbbox.Location = new System.Drawing.Point(366, 169);
            this.categoryCbbox.MinimumSize = new System.Drawing.Size(200, 30);
            this.categoryCbbox.Name = "categoryCbbox";
            this.categoryCbbox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryCbbox.Size = new System.Drawing.Size(240, 38);
            this.categoryCbbox.TabIndex = 29;
            this.categoryCbbox.Texts = "";
            // 
            // addAttributeBtn
            // 
            this.addAttributeBtn.BackColor = System.Drawing.Color.Silver;
            this.addAttributeBtn.BackgroundColor = System.Drawing.Color.Silver;
            this.addAttributeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.addAttributeBtn.BorderRadius = 15;
            this.addAttributeBtn.BorderSize = 0;
            this.addAttributeBtn.FlatAppearance.BorderSize = 0;
            this.addAttributeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAttributeBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAttributeBtn.ForeColor = System.Drawing.Color.LightGray;
            this.addAttributeBtn.Location = new System.Drawing.Point(10, 3);
            this.addAttributeBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.addAttributeBtn.Name = "addAttributeBtn";
            this.addAttributeBtn.Size = new System.Drawing.Size(127, 36);
            this.addAttributeBtn.TabIndex = 20;
            this.addAttributeBtn.Text = "Thêm";
            this.addAttributeBtn.TextColor = System.Drawing.Color.LightGray;
            this.addAttributeBtn.UseVisualStyleBackColor = false;
            this.addAttributeBtn.Click += new System.EventHandler(this.addAttributeBtn_Click);
            // 
            // materialTxtBox
            // 
            this.materialTxtBox.BackColor = System.Drawing.Color.White;
            this.materialTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.materialTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.materialTxtBox.BorderRadius = 15;
            this.materialTxtBox.BorderSize = 2;
            this.materialTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTxtBox.Location = new System.Drawing.Point(50, 169);
            this.materialTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.materialTxtBox.Multiline = false;
            this.materialTxtBox.Name = "materialTxtBox";
            this.materialTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.materialTxtBox.PasswordChar = false;
            this.materialTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.materialTxtBox.PlaceholderText = "Nhập chất liệu";
            this.materialTxtBox.Size = new System.Drawing.Size(252, 38);
            this.materialTxtBox.TabIndex = 26;
            this.materialTxtBox.Texts = "";
            this.materialTxtBox.UnderlinedStyle = false;
            // 
            // productNameTxtBox
            // 
            this.productNameTxtBox.BackColor = System.Drawing.Color.White;
            this.productNameTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.productNameTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.productNameTxtBox.BorderRadius = 15;
            this.productNameTxtBox.BorderSize = 2;
            this.productNameTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTxtBox.Location = new System.Drawing.Point(50, 79);
            this.productNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTxtBox.Multiline = false;
            this.productNameTxtBox.Name = "productNameTxtBox";
            this.productNameTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.productNameTxtBox.PasswordChar = false;
            this.productNameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.productNameTxtBox.PlaceholderText = "Nhập tên sản phẩm";
            this.productNameTxtBox.Size = new System.Drawing.Size(556, 38);
            this.productNameTxtBox.TabIndex = 24;
            this.productNameTxtBox.Texts = "";
            this.productNameTxtBox.UnderlinedStyle = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.exitBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.exitBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.exitBtn.BorderRadius = 18;
            this.exitBtn.BorderSize = 0;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(757, 715);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(172, 48);
            this.exitBtn.TabIndex = 22;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.TextColor = System.Drawing.Color.White;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.addProductBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.addProductBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addProductBtn.BorderRadius = 18;
            this.addProductBtn.BorderSize = 0;
            this.addProductBtn.FlatAppearance.BorderSize = 0;
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.Color.White;
            this.addProductBtn.Location = new System.Drawing.Point(267, 715);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(172, 48);
            this.addProductBtn.TabIndex = 21;
            this.addProductBtn.Text = "Thêm";
            this.addProductBtn.TextColor = System.Drawing.Color.White;
            this.addProductBtn.UseVisualStyleBackColor = false;
            // 
            // fAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 779);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flpSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusCbbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.collectionCbbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryCbbox);
            this.Controls.Add(this.flpAttribute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.materialTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productNameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addProductBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddProduct";
            this.flpAttribute.ResumeLayout(false);
            this.flpSize.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton exitBtn;
        private CustomButton addProductBtn;
        private System.Windows.Forms.Label label6;
        private CustomComponent.CustomComboBox statusCbbox;
        private System.Windows.Forms.Label label5;
        private CustomComponent.CustomComboBox collectionCbbox;
        private System.Windows.Forms.Label label4;
        private CustomComponent.CustomComboBox categoryCbbox;
        private System.Windows.Forms.FlowLayoutPanel flpAttribute;
        private CustomButton addAttributeBtn;
        private System.Windows.Forms.Label label3;
        private CustomTextBox materialTxtBox;
        private System.Windows.Forms.Label label2;
        private CustomTextBox productNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpSize;
        private System.Windows.Forms.Label label7;
        private CustomButton addSizeBtn;
    }
}