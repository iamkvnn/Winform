namespace WindowsForms2.CustomComponent
{
    partial class SizeControl
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
            this.discountRateTxtBox = new WindowsForms2.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.discountPriceTxtBox = new WindowsForms2.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTxtBox = new WindowsForms2.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeTxtBox = new WindowsForms2.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // discountRateTxtBox
            // 
            this.discountRateTxtBox.BackColor = System.Drawing.Color.White;
            this.discountRateTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.discountRateTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.discountRateTxtBox.BorderRadius = 15;
            this.discountRateTxtBox.BorderSize = 2;
            this.discountRateTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountRateTxtBox.Location = new System.Drawing.Point(785, 35);
            this.discountRateTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountRateTxtBox.Multiline = false;
            this.discountRateTxtBox.Name = "discountRateTxtBox";
            this.discountRateTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.discountRateTxtBox.PasswordChar = false;
            this.discountRateTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.discountRateTxtBox.PlaceholderText = "Nhập tỷ lệ giảm giá";
            this.discountRateTxtBox.Size = new System.Drawing.Size(218, 38);
            this.discountRateTxtBox.TabIndex = 19;
            this.discountRateTxtBox.Texts = "";
            this.discountRateTxtBox.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(781, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tỷ lệ giảm giá";
            // 
            // discountPriceTxtBox
            // 
            this.discountPriceTxtBox.BackColor = System.Drawing.Color.White;
            this.discountPriceTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.discountPriceTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.discountPriceTxtBox.BorderRadius = 15;
            this.discountPriceTxtBox.BorderSize = 2;
            this.discountPriceTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountPriceTxtBox.Location = new System.Drawing.Point(517, 35);
            this.discountPriceTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountPriceTxtBox.Multiline = false;
            this.discountPriceTxtBox.Name = "discountPriceTxtBox";
            this.discountPriceTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.discountPriceTxtBox.PasswordChar = false;
            this.discountPriceTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.discountPriceTxtBox.PlaceholderText = "Nhập giá giảm";
            this.discountPriceTxtBox.Size = new System.Drawing.Size(218, 38);
            this.discountPriceTxtBox.TabIndex = 17;
            this.discountPriceTxtBox.Texts = "";
            this.discountPriceTxtBox.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Giá giảm";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.BackColor = System.Drawing.Color.White;
            this.priceTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.priceTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.priceTxtBox.BorderRadius = 15;
            this.priceTxtBox.BorderSize = 2;
            this.priceTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxtBox.Location = new System.Drawing.Point(251, 35);
            this.priceTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTxtBox.Multiline = false;
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.priceTxtBox.PasswordChar = false;
            this.priceTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.priceTxtBox.PlaceholderText = "Nhập giá gốc";
            this.priceTxtBox.Size = new System.Drawing.Size(218, 38);
            this.priceTxtBox.TabIndex = 15;
            this.priceTxtBox.Texts = "";
            this.priceTxtBox.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giá gốc";
            // 
            // sizeTxtBox
            // 
            this.sizeTxtBox.BackColor = System.Drawing.Color.White;
            this.sizeTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.sizeTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.sizeTxtBox.BorderRadius = 15;
            this.sizeTxtBox.BorderSize = 2;
            this.sizeTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeTxtBox.Location = new System.Drawing.Point(12, 35);
            this.sizeTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.sizeTxtBox.Multiline = false;
            this.sizeTxtBox.Name = "sizeTxtBox";
            this.sizeTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.sizeTxtBox.PasswordChar = false;
            this.sizeTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.sizeTxtBox.PlaceholderText = "Nhập size";
            this.sizeTxtBox.Size = new System.Drawing.Size(194, 38);
            this.sizeTxtBox.TabIndex = 13;
            this.sizeTxtBox.Texts = "";
            this.sizeTxtBox.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Size";
            // 
            // SizeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.discountRateTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discountPriceTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeTxtBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "SizeControl";
            this.Size = new System.Drawing.Size(1008, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public CustomTextBox discountRateTxtBox;
        public CustomTextBox discountPriceTxtBox;
        public CustomTextBox priceTxtBox;
        public CustomTextBox sizeTxtBox;
    }
}
