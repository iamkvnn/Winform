namespace WindowsForms2
{
    partial class fLogin
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
            this.password = new WindowsForms2.CustomTextBox();
            this.username = new WindowsForms2.CustomTextBox();
            this.btnLogin = new WindowsForms2.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(435, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 562);
            this.panel1.TabIndex = 1;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderColor = System.Drawing.Color.White;
            this.password.BorderFocusColor = System.Drawing.Color.White;
            this.password.BorderRadius = 15;
            this.password.BorderSize = 3;
            this.password.Font = new System.Drawing.Font("HarmonyOS Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(82, 328);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.password.PasswordChar = true;
            this.password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.password.PlaceholderText = "Mật khẩu";
            this.password.Size = new System.Drawing.Size(338, 41);
            this.password.TabIndex = 2;
            this.password.Texts = "";
            this.password.UnderlinedStyle = false;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.BorderColor = System.Drawing.Color.White;
            this.username.BorderFocusColor = System.Drawing.Color.White;
            this.username.BorderRadius = 15;
            this.username.BorderSize = 3;
            this.username.Font = new System.Drawing.Font("HarmonyOS Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(82, 243);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.username.PasswordChar = false;
            this.username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.username.PlaceholderText = "Tài khoản";
            this.username.Size = new System.Drawing.Size(338, 41);
            this.username.TabIndex = 1;
            this.username.Texts = "";
            this.username.UnderlinedStyle = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.BorderRadius = 21;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("HarmonyOS Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(159, 393);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(168, 49);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Be Vietnam Pro Black", 28.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 72);
            this.label4.TabIndex = 4;
            this.label4.Text = "Welcome Back!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập: ";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("DFVN Elyaris", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(5, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 133);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jewelry Store Management";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.White;
            this.btn_quit.BackgroundImage = global::WindowsForms2.Properties.Resources.close_button;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_quit.Location = new System.Drawing.Point(897, 8);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(24, 24);
            this.btn_quit.TabIndex = 2;
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForms2.Properties.Resources.fLoginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomButton btnLogin;
        private CustomTextBox username;
        private CustomTextBox password;
    }
}