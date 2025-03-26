namespace WindowsForms2.FORM
{
    partial class fCategory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelCateBtn = new WindowsForms2.CustomButton();
            this.updateCateBtn = new WindowsForms2.CustomButton();
            this.addCateBtn = new WindowsForms2.CustomButton();
            this.parentCateCbBox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.cateTxtBox = new WindowsForms2.CustomTextBox();
            this.collectionNameTxtBox = new WindowsForms2.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.collectionDesTxtBox = new WindowsForms2.CustomTextBox();
            this.addCollectionBtn = new WindowsForms2.CustomButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.updateCollectionBtn = new WindowsForms2.CustomButton();
            this.cancelCollectionBtn = new WindowsForms2.CustomButton();
            this.customPanel1 = new WindowsForms2.CustomComponent.CustomPanel();
            this.catePanel = new WindowsForms2.CustomComponent.CustomPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.collapseCate = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.catePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collapseCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Danh mục cha";
            // 
            // cancelCateBtn
            // 
            this.cancelCateBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.cancelCateBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.cancelCateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelCateBtn.BorderRadius = 22;
            this.cancelCateBtn.BorderSize = 0;
            this.cancelCateBtn.FlatAppearance.BorderSize = 0;
            this.cancelCateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCateBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCateBtn.ForeColor = System.Drawing.Color.White;
            this.cancelCateBtn.Location = new System.Drawing.Point(423, 671);
            this.cancelCateBtn.Name = "cancelCateBtn";
            this.cancelCateBtn.Size = new System.Drawing.Size(153, 52);
            this.cancelCateBtn.TabIndex = 33;
            this.cancelCateBtn.Text = "Hủy";
            this.cancelCateBtn.TextColor = System.Drawing.Color.White;
            this.cancelCateBtn.UseVisualStyleBackColor = false;
            // 
            // updateCateBtn
            // 
            this.updateCateBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.updateCateBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.updateCateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateCateBtn.BorderRadius = 22;
            this.updateCateBtn.BorderSize = 0;
            this.updateCateBtn.FlatAppearance.BorderSize = 0;
            this.updateCateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCateBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCateBtn.ForeColor = System.Drawing.Color.White;
            this.updateCateBtn.Location = new System.Drawing.Point(236, 671);
            this.updateCateBtn.Name = "updateCateBtn";
            this.updateCateBtn.Size = new System.Drawing.Size(153, 52);
            this.updateCateBtn.TabIndex = 32;
            this.updateCateBtn.Text = "Cập nhật";
            this.updateCateBtn.TextColor = System.Drawing.Color.White;
            this.updateCateBtn.UseVisualStyleBackColor = false;
            // 
            // addCateBtn
            // 
            this.addCateBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.addCateBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.addCateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addCateBtn.BorderRadius = 22;
            this.addCateBtn.BorderSize = 0;
            this.addCateBtn.FlatAppearance.BorderSize = 0;
            this.addCateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCateBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCateBtn.ForeColor = System.Drawing.Color.White;
            this.addCateBtn.Location = new System.Drawing.Point(48, 671);
            this.addCateBtn.Name = "addCateBtn";
            this.addCateBtn.Size = new System.Drawing.Size(153, 52);
            this.addCateBtn.TabIndex = 31;
            this.addCateBtn.Text = "Thêm";
            this.addCateBtn.TextColor = System.Drawing.Color.White;
            this.addCateBtn.UseVisualStyleBackColor = false;
            // 
            // parentCateCbBox
            // 
            this.parentCateCbBox.BackColor = System.Drawing.Color.White;
            this.parentCateCbBox.BorderColor = System.Drawing.Color.LightGray;
            this.parentCateCbBox.BorderSize = 2;
            this.parentCateCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentCateCbBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentCateCbBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parentCateCbBox.IconColor = System.Drawing.Color.DimGray;
            this.parentCateCbBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.parentCateCbBox.ListTextColor = System.Drawing.Color.LightGray;
            this.parentCateCbBox.Location = new System.Drawing.Point(83, 609);
            this.parentCateCbBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.parentCateCbBox.Name = "parentCateCbBox";
            this.parentCateCbBox.Padding = new System.Windows.Forms.Padding(2);
            this.parentCateCbBox.Size = new System.Drawing.Size(462, 36);
            this.parentCateCbBox.TabIndex = 30;
            this.parentCateCbBox.Texts = "";
            // 
            // cateTxtBox
            // 
            this.cateTxtBox.BackColor = System.Drawing.Color.White;
            this.cateTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.cateTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.cateTxtBox.BorderRadius = 15;
            this.cateTxtBox.BorderSize = 2;
            this.cateTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cateTxtBox.Location = new System.Drawing.Point(83, 519);
            this.cateTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.cateTxtBox.Multiline = false;
            this.cateTxtBox.Name = "cateTxtBox";
            this.cateTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cateTxtBox.PasswordChar = false;
            this.cateTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cateTxtBox.PlaceholderText = "Nhập tên danh mục";
            this.cateTxtBox.Size = new System.Drawing.Size(463, 38);
            this.cateTxtBox.TabIndex = 28;
            this.cateTxtBox.Texts = "";
            this.cateTxtBox.UnderlinedStyle = false;
            // 
            // collectionNameTxtBox
            // 
            this.collectionNameTxtBox.BackColor = System.Drawing.Color.White;
            this.collectionNameTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.collectionNameTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.collectionNameTxtBox.BorderRadius = 15;
            this.collectionNameTxtBox.BorderSize = 2;
            this.collectionNameTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionNameTxtBox.Location = new System.Drawing.Point(39, 504);
            this.collectionNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.collectionNameTxtBox.Multiline = false;
            this.collectionNameTxtBox.Name = "collectionNameTxtBox";
            this.collectionNameTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.collectionNameTxtBox.PasswordChar = false;
            this.collectionNameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.collectionNameTxtBox.PlaceholderText = "Nhập tên bộ sưu tập";
            this.collectionNameTxtBox.Size = new System.Drawing.Size(252, 38);
            this.collectionNameTxtBox.TabIndex = 32;
            this.collectionNameTxtBox.Texts = "";
            this.collectionNameTxtBox.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mô tả";
            // 
            // collectionDesTxtBox
            // 
            this.collectionDesTxtBox.BackColor = System.Drawing.Color.White;
            this.collectionDesTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.collectionDesTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.collectionDesTxtBox.BorderRadius = 15;
            this.collectionDesTxtBox.BorderSize = 2;
            this.collectionDesTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionDesTxtBox.Location = new System.Drawing.Point(39, 592);
            this.collectionDesTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.collectionDesTxtBox.Multiline = true;
            this.collectionDesTxtBox.Name = "collectionDesTxtBox";
            this.collectionDesTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.collectionDesTxtBox.PasswordChar = false;
            this.collectionDesTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.collectionDesTxtBox.PlaceholderText = "Nhập mô tả";
            this.collectionDesTxtBox.Size = new System.Drawing.Size(541, 131);
            this.collectionDesTxtBox.TabIndex = 34;
            this.collectionDesTxtBox.Texts = "";
            this.collectionDesTxtBox.UnderlinedStyle = false;
            // 
            // addCollectionBtn
            // 
            this.addCollectionBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.addCollectionBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.addCollectionBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addCollectionBtn.BorderRadius = 17;
            this.addCollectionBtn.BorderSize = 0;
            this.addCollectionBtn.FlatAppearance.BorderSize = 0;
            this.addCollectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCollectionBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCollectionBtn.ForeColor = System.Drawing.Color.White;
            this.addCollectionBtn.Location = new System.Drawing.Point(319, 484);
            this.addCollectionBtn.Name = "addCollectionBtn";
            this.addCollectionBtn.Size = new System.Drawing.Size(122, 45);
            this.addCollectionBtn.TabIndex = 34;
            this.addCollectionBtn.Text = "Thêm";
            this.addCollectionBtn.TextColor = System.Drawing.Color.White;
            this.addCollectionBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(595, 406);
            this.dataGridView2.TabIndex = 1;
            // 
            // updateCollectionBtn
            // 
            this.updateCollectionBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.updateCollectionBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.updateCollectionBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateCollectionBtn.BorderRadius = 17;
            this.updateCollectionBtn.BorderSize = 0;
            this.updateCollectionBtn.FlatAppearance.BorderSize = 0;
            this.updateCollectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCollectionBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCollectionBtn.ForeColor = System.Drawing.Color.White;
            this.updateCollectionBtn.Location = new System.Drawing.Point(468, 481);
            this.updateCollectionBtn.Name = "updateCollectionBtn";
            this.updateCollectionBtn.Size = new System.Drawing.Size(122, 45);
            this.updateCollectionBtn.TabIndex = 35;
            this.updateCollectionBtn.Text = "Cập nhật";
            this.updateCollectionBtn.TextColor = System.Drawing.Color.White;
            this.updateCollectionBtn.UseVisualStyleBackColor = false;
            // 
            // cancelCollectionBtn
            // 
            this.cancelCollectionBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.cancelCollectionBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.cancelCollectionBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelCollectionBtn.BorderRadius = 17;
            this.cancelCollectionBtn.BorderSize = 0;
            this.cancelCollectionBtn.FlatAppearance.BorderSize = 0;
            this.cancelCollectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCollectionBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCollectionBtn.ForeColor = System.Drawing.Color.White;
            this.cancelCollectionBtn.Location = new System.Drawing.Point(391, 535);
            this.cancelCollectionBtn.Name = "cancelCollectionBtn";
            this.cancelCollectionBtn.Size = new System.Drawing.Size(122, 45);
            this.cancelCollectionBtn.TabIndex = 36;
            this.cancelCollectionBtn.Text = "Hủy";
            this.cancelCollectionBtn.TextColor = System.Drawing.Color.White;
            this.cancelCollectionBtn.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 50;
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.Controls.Add(this.label6);
            this.customPanel1.Controls.Add(this.dataGridView2);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.collectionDesTxtBox);
            this.customPanel1.Controls.Add(this.cancelCollectionBtn);
            this.customPanel1.Controls.Add(this.collectionNameTxtBox);
            this.customPanel1.Controls.Add(this.addCollectionBtn);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.updateCollectionBtn);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(647, 12);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(621, 750);
            this.customPanel1.TabIndex = 37;
            // 
            // catePanel
            // 
            this.catePanel.BackColor = System.Drawing.Color.White;
            this.catePanel.BorderRadius = 50;
            this.catePanel.Controls.Add(this.collapseCate);
            this.catePanel.Controls.Add(this.label5);
            this.catePanel.Controls.Add(this.cancelCateBtn);
            this.catePanel.Controls.Add(this.dataGridView1);
            this.catePanel.Controls.Add(this.updateCateBtn);
            this.catePanel.Controls.Add(this.parentCateCbBox);
            this.catePanel.Controls.Add(this.cateTxtBox);
            this.catePanel.Controls.Add(this.label1);
            this.catePanel.Controls.Add(this.addCateBtn);
            this.catePanel.Controls.Add(this.label2);
            this.catePanel.ForeColor = System.Drawing.Color.Black;
            this.catePanel.GradientAngle = 90F;
            this.catePanel.GradientBottomColor = System.Drawing.Color.White;
            this.catePanel.GradientTopColor = System.Drawing.Color.White;
            this.catePanel.Location = new System.Drawing.Point(12, 12);
            this.catePanel.Name = "catePanel";
            this.catePanel.Size = new System.Drawing.Size(629, 750);
            this.catePanel.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 38);
            this.label5.TabIndex = 34;
            this.label5.Text = "Danh mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 38);
            this.label6.TabIndex = 35;
            this.label6.Text = "Bộ sưu tập";
            // 
            // collapseCate
            // 
            this.collapseCate.BackgroundImage = global::WindowsForms2.Properties.Resources.expand_button;
            this.collapseCate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.collapseCate.Location = new System.Drawing.Point(577, 13);
            this.collapseCate.Name = "collapseCate";
            this.collapseCate.Size = new System.Drawing.Size(30, 30);
            this.collapseCate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collapseCate.TabIndex = 35;
            this.collapseCate.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsForms2.Properties.Resources.expand_button;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(578, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // fCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 774);
            this.Controls.Add(this.catePanel);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.catePanel.ResumeLayout(false);
            this.catePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collapseCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomTextBox cateTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomComponent.CustomComboBox parentCateCbBox;
        private CustomButton cancelCateBtn;
        private CustomButton updateCateBtn;
        private CustomButton addCateBtn;
        private CustomTextBox collectionNameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomTextBox collectionDesTxtBox;
        private CustomButton addCollectionBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private CustomButton updateCollectionBtn;
        private CustomButton cancelCollectionBtn;
        private CustomComponent.CustomPanel customPanel1;
        private CustomComponent.CustomPanel catePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox collapseCate;
    }
}