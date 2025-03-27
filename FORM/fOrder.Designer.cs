namespace WindowsForms2.FORM
{
    partial class fOrder
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flpOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.orderTable = new WindowsForms2.CustomComponent.CustomPanel();
            this.customPanel1 = new WindowsForms2.CustomComponent.CustomPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.endFilter = new WindowsForms2.CustomComponent.CustomDatePicker();
            this.startFilter = new WindowsForms2.CustomComponent.CustomDatePicker();
            this.statusFilterCbBox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.searchTxtBox = new WindowsForms2.CustomTextBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.orderTable.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.LightBlue;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1287, 47);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã KH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên khách hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng tiền";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(725, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng thái";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(927, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày đặt";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1105, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "Hành động";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpOrder
            // 
            this.flpOrder.AutoScroll = true;
            this.flpOrder.BackColor = System.Drawing.Color.White;
            this.flpOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOrder.Location = new System.Drawing.Point(0, 47);
            this.flpOrder.Margin = new System.Windows.Forms.Padding(0);
            this.flpOrder.Name = "flpOrder";
            this.flpOrder.Size = new System.Drawing.Size(1287, 657);
            this.flpOrder.TabIndex = 2;
            // 
            // orderTable
            // 
            this.orderTable.BackColor = System.Drawing.Color.White;
            this.orderTable.BorderRadius = 50;
            this.orderTable.Controls.Add(this.flpOrder);
            this.orderTable.Controls.Add(this.flowLayoutPanel2);
            this.orderTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orderTable.ForeColor = System.Drawing.Color.Black;
            this.orderTable.GradientAngle = 90F;
            this.orderTable.GradientBottomColor = System.Drawing.Color.White;
            this.orderTable.GradientTopColor = System.Drawing.Color.White;
            this.orderTable.Location = new System.Drawing.Point(0, 70);
            this.orderTable.Margin = new System.Windows.Forms.Padding(0);
            this.orderTable.Name = "orderTable";
            this.orderTable.Size = new System.Drawing.Size(1287, 704);
            this.orderTable.TabIndex = 0;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 50;
            this.customPanel1.Controls.Add(this.label9);
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.Controls.Add(this.label11);
            this.customPanel1.Controls.Add(this.label10);
            this.customPanel1.Controls.Add(this.endFilter);
            this.customPanel1.Controls.Add(this.startFilter);
            this.customPanel1.Controls.Add(this.statusFilterCbBox);
            this.customPanel1.Controls.Add(this.searchTxtBox);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1287, 68);
            this.customPanel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Bộ lọc:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsForms2.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1208, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(564, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(311, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Ngày đặt:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // endFilter
            // 
            this.endFilter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.endFilter.BorderSize = 0;
            this.endFilter.Font = new System.Drawing.Font("HarmonyOS Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endFilter.Location = new System.Drawing.Point(593, 12);
            this.endFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endFilter.MinimumSize = new System.Drawing.Size(4, 35);
            this.endFilter.Name = "endFilter";
            this.endFilter.Size = new System.Drawing.Size(143, 35);
            this.endFilter.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.endFilter.TabIndex = 28;
            this.endFilter.TextColor = System.Drawing.Color.White;
            this.endFilter.ValueChanged += new System.EventHandler(this.endFilter_ValueChanged);
            // 
            // startFilter
            // 
            this.startFilter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.startFilter.BorderSize = 0;
            this.startFilter.Font = new System.Drawing.Font("HarmonyOS Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startFilter.Location = new System.Drawing.Point(411, 12);
            this.startFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startFilter.MinimumSize = new System.Drawing.Size(4, 35);
            this.startFilter.Name = "startFilter";
            this.startFilter.Size = new System.Drawing.Size(143, 35);
            this.startFilter.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.startFilter.TabIndex = 27;
            this.startFilter.TextColor = System.Drawing.Color.White;
            this.startFilter.ValueChanged += new System.EventHandler(this.startFilter_ValueChanged);
            // 
            // statusFilterCbBox
            // 
            this.statusFilterCbBox.BackColor = System.Drawing.Color.White;
            this.statusFilterCbBox.BorderColor = System.Drawing.Color.Silver;
            this.statusFilterCbBox.BorderSize = 2;
            this.statusFilterCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusFilterCbBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusFilterCbBox.ForeColor = System.Drawing.Color.DarkGray;
            this.statusFilterCbBox.IconColor = System.Drawing.Color.LightSlateGray;
            this.statusFilterCbBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.statusFilterCbBox.ListTextColor = System.Drawing.Color.DimGray;
            this.statusFilterCbBox.Location = new System.Drawing.Point(89, 15);
            this.statusFilterCbBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusFilterCbBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.statusFilterCbBox.Name = "statusFilterCbBox";
            this.statusFilterCbBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusFilterCbBox.Size = new System.Drawing.Size(200, 43);
            this.statusFilterCbBox.TabIndex = 26;
            this.statusFilterCbBox.Texts = "Trạng thái";
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BackColor = System.Drawing.Color.White;
            this.searchTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.searchTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.searchTxtBox.BorderRadius = 15;
            this.searchTxtBox.BorderSize = 2;
            this.searchTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(1072, 14);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searchTxtBox.Multiline = false;
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Padding = new System.Windows.Forms.Padding(11, 7, 51, 7);
            this.searchTxtBox.PasswordChar = false;
            this.searchTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTxtBox.PlaceholderText = "Nhập mã đơn";
            this.searchTxtBox.Size = new System.Drawing.Size(179, 38);
            this.searchTxtBox.TabIndex = 21;
            this.searchTxtBox.Texts = "";
            this.searchTxtBox.UnderlinedStyle = false;
            // 
            // fOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1287, 774);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.orderTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fOrder";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.orderTable.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flpOrder;
        private CustomComponent.CustomPanel orderTable;
        private CustomComponent.CustomPanel customPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomTextBox searchTxtBox;
        private CustomComponent.CustomComboBox statusFilterCbBox;
        private CustomComponent.CustomDatePicker endFilter;
        private CustomComponent.CustomDatePicker startFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}