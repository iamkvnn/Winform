namespace WindowsForms2.FORM
{
    partial class JewelryManagementApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.voucherBtn = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.cateBtn = new System.Windows.Forms.Button();
            this.btnSp = new System.Windows.Forms.Button();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblCrrForm = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.pContent = new WindowsForms2.CustomComponent.CustomPanel();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.voucherBtn);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.orderBtn);
            this.panel1.Controls.Add(this.cateBtn);
            this.panel1.Controls.Add(this.btnSp);
            this.panel1.Controls.Add(this.paymentBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 853);
            this.panel1.TabIndex = 0;
            // 
            // voucherBtn
            // 
            this.voucherBtn.BackColor = System.Drawing.Color.Transparent;
            this.voucherBtn.FlatAppearance.BorderSize = 0;
            this.voucherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voucherBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucherBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.voucherBtn.Location = new System.Drawing.Point(1, 473);
            this.voucherBtn.Margin = new System.Windows.Forms.Padding(4);
            this.voucherBtn.Name = "voucherBtn";
            this.voucherBtn.Size = new System.Drawing.Size(251, 38);
            this.voucherBtn.TabIndex = 6;
            this.voucherBtn.TabStop = false;
            this.voucherBtn.Text = "Khuyến mãi";
            this.voucherBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voucherBtn.UseVisualStyleBackColor = false;
            this.voucherBtn.Click += new System.EventHandler(this.voucherBtn_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("HarmonyOS Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_Dashboard.Location = new System.Drawing.Point(1, 198);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(251, 38);
            this.btn_Dashboard.TabIndex = 5;
            this.btn_Dashboard.TabStop = false;
            this.btn_Dashboard.Text = "Thống kê";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.Transparent;
            this.orderBtn.FlatAppearance.BorderSize = 0;
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.orderBtn.Location = new System.Drawing.Point(1, 363);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(251, 38);
            this.orderBtn.TabIndex = 3;
            this.orderBtn.TabStop = false;
            this.orderBtn.Text = "Đơn hàng";
            this.orderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // cateBtn
            // 
            this.cateBtn.BackColor = System.Drawing.Color.Transparent;
            this.cateBtn.FlatAppearance.BorderSize = 0;
            this.cateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cateBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cateBtn.Location = new System.Drawing.Point(1, 308);
            this.cateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cateBtn.Name = "cateBtn";
            this.cateBtn.Size = new System.Drawing.Size(251, 38);
            this.cateBtn.TabIndex = 1;
            this.cateBtn.TabStop = false;
            this.cateBtn.Text = "Danh mục";
            this.cateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cateBtn.UseVisualStyleBackColor = false;
            this.cateBtn.Click += new System.EventHandler(this.cateBtn_Click);
            // 
            // btnSp
            // 
            this.btnSp.BackColor = System.Drawing.Color.Transparent;
            this.btnSp.FlatAppearance.BorderSize = 0;
            this.btnSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSp.Font = new System.Drawing.Font("HarmonyOS Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnSp.Location = new System.Drawing.Point(1, 253);
            this.btnSp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSp.Name = "btnSp";
            this.btnSp.Size = new System.Drawing.Size(251, 38);
            this.btnSp.TabIndex = 0;
            this.btnSp.TabStop = false;
            this.btnSp.Text = "Sản phẩm";
            this.btnSp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSp.UseVisualStyleBackColor = false;
            this.btnSp.Click += new System.EventHandler(this.btnSp_Click);
            // 
            // paymentBtn
            // 
            this.paymentBtn.BackColor = System.Drawing.Color.Transparent;
            this.paymentBtn.FlatAppearance.BorderSize = 0;
            this.paymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.paymentBtn.Location = new System.Drawing.Point(1, 418);
            this.paymentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(251, 38);
            this.paymentBtn.TabIndex = 2;
            this.paymentBtn.TabStop = false;
            this.paymentBtn.Text = "Hóa đơn";
            this.paymentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentBtn.UseVisualStyleBackColor = false;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.lblCrrForm);
            this.panelTitle.Controls.Add(this.btn_quit);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1561, 48);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // lblCrrForm
            // 
            this.lblCrrForm.AutoSize = true;
            this.lblCrrForm.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCrrForm.Location = new System.Drawing.Point(298, 9);
            this.lblCrrForm.Name = "lblCrrForm";
            this.lblCrrForm.Size = new System.Drawing.Size(0, 28);
            this.lblCrrForm.TabIndex = 4;
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.White;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_quit.Location = new System.Drawing.Point(1508, 6);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(47, 36);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.TabStop = false;
            this.btn_quit.Text = "X";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.Color.White;
            this.pContent.BorderRadius = 50;
            this.pContent.ForeColor = System.Drawing.Color.Black;
            this.pContent.GradientAngle = 90F;
            this.pContent.GradientBottomColor = System.Drawing.Color.White;
            this.pContent.GradientTopColor = System.Drawing.Color.Azure;
            this.pContent.Location = new System.Drawing.Point(262, 55);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(1287, 783);
            this.pContent.TabIndex = 3;
            // 
            // JewelryManagementApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 850);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JewelryManagementApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JewelryManagementApp.cs";
            this.Activated += new System.EventHandler(this.JewelryManagementApp_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JewelryManagementApp_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.JewelryManagementApp_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.JewelryManagementApp_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSp;
        private System.Windows.Forms.Button cateBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Button voucherBtn;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label lblCrrForm;
        private CustomComponent.CustomPanel pContent;
    }
}

