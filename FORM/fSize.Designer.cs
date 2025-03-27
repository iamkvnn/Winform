namespace WindowsForms2.FORM
{
    partial class fSize
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
            this.dgvSize = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitBtn = new WindowsForms2.CustomButton();
            this.UpdateSizeBtn = new WindowsForms2.CustomButton();
            this.AddSizeBtn = new WindowsForms2.CustomButton();
            this.discountRateTxtBox = new WindowsForms2.CustomTextBox();
            this.discountPriceTxtBox = new WindowsForms2.CustomTextBox();
            this.priceTxtBox = new WindowsForms2.CustomTextBox();
            this.sizeTxtBox = new WindowsForms2.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSize
            // 
            this.dgvSize.AllowUserToAddRows = false;
            this.dgvSize.AllowUserToDeleteRows = false;
            this.dgvSize.AllowUserToOrderColumns = true;
            this.dgvSize.AllowUserToResizeColumns = false;
            this.dgvSize.AllowUserToResizeRows = false;
            this.dgvSize.BackgroundColor = System.Drawing.Color.White;
            this.dgvSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSize.Location = new System.Drawing.Point(12, 12);
            this.dgvSize.Name = "dgvSize";
            this.dgvSize.ReadOnly = true;
            this.dgvSize.RowHeadersVisible = false;
            this.dgvSize.RowHeadersWidth = 51;
            this.dgvSize.RowTemplate.Height = 24;
            this.dgvSize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSize.Size = new System.Drawing.Size(1176, 397);
            this.dgvSize.TabIndex = 0;
            this.dgvSize.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSize_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giá gốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(913, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tỷ lệ giảm giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(635, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá giảm";
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
            this.exitBtn.Location = new System.Drawing.Point(774, 521);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(172, 48);
            this.exitBtn.TabIndex = 20;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.TextColor = System.Drawing.Color.White;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // UpdateSizeBtn
            // 
            this.UpdateSizeBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.UpdateSizeBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.UpdateSizeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.UpdateSizeBtn.BorderRadius = 18;
            this.UpdateSizeBtn.BorderSize = 0;
            this.UpdateSizeBtn.FlatAppearance.BorderSize = 0;
            this.UpdateSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSizeBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSizeBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateSizeBtn.Location = new System.Drawing.Point(529, 521);
            this.UpdateSizeBtn.Name = "UpdateSizeBtn";
            this.UpdateSizeBtn.Size = new System.Drawing.Size(172, 48);
            this.UpdateSizeBtn.TabIndex = 19;
            this.UpdateSizeBtn.Text = "Cập nhật";
            this.UpdateSizeBtn.TextColor = System.Drawing.Color.White;
            this.UpdateSizeBtn.UseVisualStyleBackColor = false;
            // 
            // AddSizeBtn
            // 
            this.AddSizeBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.AddSizeBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.AddSizeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddSizeBtn.BorderRadius = 18;
            this.AddSizeBtn.BorderSize = 0;
            this.AddSizeBtn.FlatAppearance.BorderSize = 0;
            this.AddSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSizeBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSizeBtn.ForeColor = System.Drawing.Color.White;
            this.AddSizeBtn.Location = new System.Drawing.Point(284, 521);
            this.AddSizeBtn.Name = "AddSizeBtn";
            this.AddSizeBtn.Size = new System.Drawing.Size(172, 48);
            this.AddSizeBtn.TabIndex = 18;
            this.AddSizeBtn.Text = "Thêm";
            this.AddSizeBtn.TextColor = System.Drawing.Color.White;
            this.AddSizeBtn.UseVisualStyleBackColor = false;
            // 
            // discountRateTxtBox
            // 
            this.discountRateTxtBox.BackColor = System.Drawing.Color.White;
            this.discountRateTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.discountRateTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.discountRateTxtBox.BorderRadius = 15;
            this.discountRateTxtBox.BorderSize = 2;
            this.discountRateTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountRateTxtBox.Location = new System.Drawing.Point(917, 451);
            this.discountRateTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountRateTxtBox.Multiline = false;
            this.discountRateTxtBox.Name = "discountRateTxtBox";
            this.discountRateTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.discountRateTxtBox.PasswordChar = false;
            this.discountRateTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.discountRateTxtBox.PlaceholderText = "Nhập tỷ lệ giảm giá";
            this.discountRateTxtBox.Size = new System.Drawing.Size(218, 38);
            this.discountRateTxtBox.TabIndex = 11;
            this.discountRateTxtBox.Texts = "";
            this.discountRateTxtBox.UnderlinedStyle = false;
            this.discountRateTxtBox._TextChanged += new System.EventHandler(this.discountRateTxtBox__TextChanged);
            // 
            // discountPriceTxtBox
            // 
            this.discountPriceTxtBox.BackColor = System.Drawing.Color.White;
            this.discountPriceTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.discountPriceTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.discountPriceTxtBox.BorderRadius = 15;
            this.discountPriceTxtBox.BorderSize = 2;
            this.discountPriceTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountPriceTxtBox.Location = new System.Drawing.Point(639, 451);
            this.discountPriceTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountPriceTxtBox.Multiline = false;
            this.discountPriceTxtBox.Name = "discountPriceTxtBox";
            this.discountPriceTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.discountPriceTxtBox.PasswordChar = false;
            this.discountPriceTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.discountPriceTxtBox.PlaceholderText = "Nhập giá giảm";
            this.discountPriceTxtBox.Size = new System.Drawing.Size(218, 38);
            this.discountPriceTxtBox.TabIndex = 9;
            this.discountPriceTxtBox.Texts = "";
            this.discountPriceTxtBox.UnderlinedStyle = false;
            this.discountPriceTxtBox._TextChanged += new System.EventHandler(this.discountPriceTxtBox__TextChanged);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.BackColor = System.Drawing.Color.White;
            this.priceTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.priceTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.priceTxtBox.BorderRadius = 15;
            this.priceTxtBox.BorderSize = 2;
            this.priceTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxtBox.Location = new System.Drawing.Point(361, 451);
            this.priceTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTxtBox.Multiline = false;
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.priceTxtBox.PasswordChar = false;
            this.priceTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.priceTxtBox.PlaceholderText = "Nhập giá gốc";
            this.priceTxtBox.Size = new System.Drawing.Size(218, 38);
            this.priceTxtBox.TabIndex = 7;
            this.priceTxtBox.Texts = "";
            this.priceTxtBox.UnderlinedStyle = false;
            // 
            // sizeTxtBox
            // 
            this.sizeTxtBox.BackColor = System.Drawing.Color.White;
            this.sizeTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.sizeTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.sizeTxtBox.BorderRadius = 15;
            this.sizeTxtBox.BorderSize = 2;
            this.sizeTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeTxtBox.Location = new System.Drawing.Point(83, 451);
            this.sizeTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.sizeTxtBox.Multiline = false;
            this.sizeTxtBox.Name = "sizeTxtBox";
            this.sizeTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.sizeTxtBox.PasswordChar = false;
            this.sizeTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.sizeTxtBox.PlaceholderText = "Nhập size";
            this.sizeTxtBox.Size = new System.Drawing.Size(218, 38);
            this.sizeTxtBox.TabIndex = 5;
            this.sizeTxtBox.Texts = "";
            this.sizeTxtBox.UnderlinedStyle = false;
            // 
            // fSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 591);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.UpdateSizeBtn);
            this.Controls.Add(this.AddSizeBtn);
            this.Controls.Add(this.discountRateTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discountPriceTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSize";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSize;
        private CustomTextBox sizeTxtBox;
        private System.Windows.Forms.Label label2;
        private CustomTextBox priceTxtBox;
        private System.Windows.Forms.Label label1;
        private CustomTextBox discountRateTxtBox;
        private System.Windows.Forms.Label label3;
        private CustomTextBox discountPriceTxtBox;
        private System.Windows.Forms.Label label4;
        private CustomButton AddSizeBtn;
        private CustomButton UpdateSizeBtn;
        private CustomButton exitBtn;
    }
}