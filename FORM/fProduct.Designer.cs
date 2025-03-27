namespace WindowsForms2.FORM
{
    partial class fProduct
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
            this.dgvSp = new System.Windows.Forms.DataGridView();
            this.productInfoPanel = new System.Windows.Forms.Panel();
            this.cancelBtn = new WindowsForms2.CustomButton();
            this.updateProductBtn = new WindowsForms2.CustomButton();
            this.manageSizeBtn = new WindowsForms2.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.statusCbbox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.collectionCbbox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flpAttribute = new System.Windows.Forms.FlowLayoutPanel();
            this.addAttributeBtn = new WindowsForms2.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.materialTxtBox = new WindowsForms2.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productNameTxtBox = new WindowsForms2.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryCbbox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusFilterCbBox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.collectionFilterCbBox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.cateFilterCbBox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.searchTxtBox = new WindowsForms2.CustomTextBox();
            this.addProductBtn = new WindowsForms2.CustomButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSp)).BeginInit();
            this.productInfoPanel.SuspendLayout();
            this.flpAttribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSp
            // 
            this.dgvSp.AllowUserToAddRows = false;
            this.dgvSp.AllowUserToDeleteRows = false;
            this.dgvSp.AllowUserToOrderColumns = true;
            this.dgvSp.AllowUserToResizeColumns = false;
            this.dgvSp.AllowUserToResizeRows = false;
            this.dgvSp.BackgroundColor = System.Drawing.Color.White;
            this.dgvSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSp.Location = new System.Drawing.Point(9, 48);
            this.dgvSp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSp.Name = "dgvSp";
            this.dgvSp.ReadOnly = true;
            this.dgvSp.RowHeadersVisible = false;
            this.dgvSp.RowHeadersWidth = 51;
            this.dgvSp.RowTemplate.Height = 24;
            this.dgvSp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSp.Size = new System.Drawing.Size(942, 353);
            this.dgvSp.TabIndex = 0;
            this.dgvSp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSp_CellClick);
            // 
            // productInfoPanel
            // 
            this.productInfoPanel.Controls.Add(this.cancelBtn);
            this.productInfoPanel.Controls.Add(this.updateProductBtn);
            this.productInfoPanel.Controls.Add(this.manageSizeBtn);
            this.productInfoPanel.Controls.Add(this.label6);
            this.productInfoPanel.Controls.Add(this.statusCbbox);
            this.productInfoPanel.Controls.Add(this.label5);
            this.productInfoPanel.Controls.Add(this.collectionCbbox);
            this.productInfoPanel.Controls.Add(this.label4);
            this.productInfoPanel.Controls.Add(this.flpAttribute);
            this.productInfoPanel.Controls.Add(this.label3);
            this.productInfoPanel.Controls.Add(this.materialTxtBox);
            this.productInfoPanel.Controls.Add(this.label2);
            this.productInfoPanel.Controls.Add(this.productNameTxtBox);
            this.productInfoPanel.Controls.Add(this.label1);
            this.productInfoPanel.Controls.Add(this.categoryCbbox);
            this.productInfoPanel.Location = new System.Drawing.Point(9, 406);
            this.productInfoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.productInfoPanel.Name = "productInfoPanel";
            this.productInfoPanel.Size = new System.Drawing.Size(942, 213);
            this.productInfoPanel.TabIndex = 1;
            this.productInfoPanel.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.cancelBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.cancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelBtn.BorderRadius = 25;
            this.cancelBtn.BorderSize = 0;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(794, 152);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(129, 53);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.TextColor = System.Drawing.Color.White;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.updateProductBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.updateProductBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateProductBtn.BorderRadius = 25;
            this.updateProductBtn.BorderSize = 0;
            this.updateProductBtn.FlatAppearance.BorderSize = 0;
            this.updateProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProductBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductBtn.ForeColor = System.Drawing.Color.White;
            this.updateProductBtn.Location = new System.Drawing.Point(794, 83);
            this.updateProductBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Size = new System.Drawing.Size(129, 53);
            this.updateProductBtn.TabIndex = 17;
            this.updateProductBtn.Text = "Cập nhật";
            this.updateProductBtn.TextColor = System.Drawing.Color.White;
            this.updateProductBtn.UseVisualStyleBackColor = false;
            // 
            // manageSizeBtn
            // 
            this.manageSizeBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.manageSizeBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.manageSizeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.manageSizeBtn.BorderRadius = 25;
            this.manageSizeBtn.BorderSize = 0;
            this.manageSizeBtn.FlatAppearance.BorderSize = 0;
            this.manageSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageSizeBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSizeBtn.ForeColor = System.Drawing.Color.White;
            this.manageSizeBtn.Location = new System.Drawing.Point(794, 14);
            this.manageSizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.manageSizeBtn.Name = "manageSizeBtn";
            this.manageSizeBtn.Size = new System.Drawing.Size(129, 53);
            this.manageSizeBtn.TabIndex = 16;
            this.manageSizeBtn.Text = "Quản lý size";
            this.manageSizeBtn.TextColor = System.Drawing.Color.White;
            this.manageSizeBtn.UseVisualStyleBackColor = false;
            this.manageSizeBtn.Click += new System.EventHandler(this.manageSizeBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Thuộc tính sản phẩm";
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
            this.statusCbbox.Location = new System.Drawing.Point(13, 163);
            this.statusCbbox.Margin = new System.Windows.Forms.Padding(2);
            this.statusCbbox.MinimumSize = new System.Drawing.Size(150, 24);
            this.statusCbbox.Name = "statusCbbox";
            this.statusCbbox.Padding = new System.Windows.Forms.Padding(2);
            this.statusCbbox.Size = new System.Drawing.Size(164, 31);
            this.statusCbbox.TabIndex = 13;
            this.statusCbbox.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Trạng thái";
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
            this.collectionCbbox.Location = new System.Drawing.Point(225, 163);
            this.collectionCbbox.Margin = new System.Windows.Forms.Padding(2);
            this.collectionCbbox.MinimumSize = new System.Drawing.Size(150, 24);
            this.collectionCbbox.Name = "collectionCbbox";
            this.collectionCbbox.Padding = new System.Windows.Forms.Padding(2);
            this.collectionCbbox.Size = new System.Drawing.Size(160, 31);
            this.collectionCbbox.TabIndex = 11;
            this.collectionCbbox.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bộ sưu tập";
            // 
            // flpAttribute
            // 
            this.flpAttribute.AutoScroll = true;
            this.flpAttribute.Controls.Add(this.addAttributeBtn);
            this.flpAttribute.Location = new System.Drawing.Point(413, 28);
            this.flpAttribute.Margin = new System.Windows.Forms.Padding(2);
            this.flpAttribute.Name = "flpAttribute";
            this.flpAttribute.Size = new System.Drawing.Size(362, 182);
            this.flpAttribute.TabIndex = 6;
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
            this.addAttributeBtn.Location = new System.Drawing.Point(8, 2);
            this.addAttributeBtn.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.addAttributeBtn.Name = "addAttributeBtn";
            this.addAttributeBtn.Size = new System.Drawing.Size(95, 29);
            this.addAttributeBtn.TabIndex = 20;
            this.addAttributeBtn.Text = "Thêm";
            this.addAttributeBtn.TextColor = System.Drawing.Color.LightGray;
            this.addAttributeBtn.UseVisualStyleBackColor = false;
            this.addAttributeBtn.Click += new System.EventHandler(this.addAttributeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh mục";
            // 
            // materialTxtBox
            // 
            this.materialTxtBox.BackColor = System.Drawing.Color.White;
            this.materialTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.materialTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.materialTxtBox.BorderRadius = 15;
            this.materialTxtBox.BorderSize = 2;
            this.materialTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTxtBox.Location = new System.Drawing.Point(13, 96);
            this.materialTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.materialTxtBox.Multiline = false;
            this.materialTxtBox.Name = "materialTxtBox";
            this.materialTxtBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.materialTxtBox.PasswordChar = false;
            this.materialTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.materialTxtBox.PlaceholderText = "Nhập chất liệu";
            this.materialTxtBox.Size = new System.Drawing.Size(164, 32);
            this.materialTxtBox.TabIndex = 3;
            this.materialTxtBox.Texts = "";
            this.materialTxtBox.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chất liệu";
            // 
            // productNameTxtBox
            // 
            this.productNameTxtBox.BackColor = System.Drawing.Color.White;
            this.productNameTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.productNameTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.productNameTxtBox.BorderRadius = 15;
            this.productNameTxtBox.BorderSize = 2;
            this.productNameTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTxtBox.Location = new System.Drawing.Point(13, 28);
            this.productNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTxtBox.Multiline = false;
            this.productNameTxtBox.Name = "productNameTxtBox";
            this.productNameTxtBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.productNameTxtBox.PasswordChar = false;
            this.productNameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.productNameTxtBox.PlaceholderText = "Nhập tên sản phẩm";
            this.productNameTxtBox.Size = new System.Drawing.Size(373, 32);
            this.productNameTxtBox.TabIndex = 1;
            this.productNameTxtBox.Texts = "";
            this.productNameTxtBox.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
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
            this.categoryCbbox.Location = new System.Drawing.Point(225, 96);
            this.categoryCbbox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryCbbox.MinimumSize = new System.Drawing.Size(150, 24);
            this.categoryCbbox.Name = "categoryCbbox";
            this.categoryCbbox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryCbbox.Size = new System.Drawing.Size(160, 31);
            this.categoryCbbox.TabIndex = 7;
            this.categoryCbbox.Texts = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsForms2.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(913, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
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
            this.statusFilterCbBox.Location = new System.Drawing.Point(563, 10);
            this.statusFilterCbBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusFilterCbBox.MinimumSize = new System.Drawing.Size(150, 24);
            this.statusFilterCbBox.Name = "statusFilterCbBox";
            this.statusFilterCbBox.Padding = new System.Windows.Forms.Padding(2);
            this.statusFilterCbBox.Size = new System.Drawing.Size(150, 31);
            this.statusFilterCbBox.TabIndex = 22;
            this.statusFilterCbBox.Texts = "Trạng thái";
            // 
            // collectionFilterCbBox
            // 
            this.collectionFilterCbBox.BackColor = System.Drawing.Color.White;
            this.collectionFilterCbBox.BorderColor = System.Drawing.Color.Silver;
            this.collectionFilterCbBox.BorderSize = 2;
            this.collectionFilterCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.collectionFilterCbBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionFilterCbBox.ForeColor = System.Drawing.Color.DarkGray;
            this.collectionFilterCbBox.IconColor = System.Drawing.Color.LightSlateGray;
            this.collectionFilterCbBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.collectionFilterCbBox.ListTextColor = System.Drawing.Color.DimGray;
            this.collectionFilterCbBox.Location = new System.Drawing.Point(395, 10);
            this.collectionFilterCbBox.Margin = new System.Windows.Forms.Padding(2);
            this.collectionFilterCbBox.MinimumSize = new System.Drawing.Size(150, 24);
            this.collectionFilterCbBox.Name = "collectionFilterCbBox";
            this.collectionFilterCbBox.Padding = new System.Windows.Forms.Padding(2);
            this.collectionFilterCbBox.Size = new System.Drawing.Size(150, 31);
            this.collectionFilterCbBox.TabIndex = 21;
            this.collectionFilterCbBox.Texts = "Bộ sưu tập";
            // 
            // cateFilterCbBox
            // 
            this.cateFilterCbBox.BackColor = System.Drawing.Color.White;
            this.cateFilterCbBox.BorderColor = System.Drawing.Color.Silver;
            this.cateFilterCbBox.BorderSize = 2;
            this.cateFilterCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cateFilterCbBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cateFilterCbBox.ForeColor = System.Drawing.Color.DarkGray;
            this.cateFilterCbBox.IconColor = System.Drawing.Color.LightSlateGray;
            this.cateFilterCbBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cateFilterCbBox.ListTextColor = System.Drawing.Color.DimGray;
            this.cateFilterCbBox.Location = new System.Drawing.Point(227, 10);
            this.cateFilterCbBox.Margin = new System.Windows.Forms.Padding(2);
            this.cateFilterCbBox.MinimumSize = new System.Drawing.Size(150, 24);
            this.cateFilterCbBox.Name = "cateFilterCbBox";
            this.cateFilterCbBox.Padding = new System.Windows.Forms.Padding(2);
            this.cateFilterCbBox.Size = new System.Drawing.Size(150, 31);
            this.cateFilterCbBox.TabIndex = 20;
            this.cateFilterCbBox.Texts = "Danh mục";
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BackColor = System.Drawing.Color.White;
            this.searchTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.searchTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.searchTxtBox.BorderRadius = 15;
            this.searchTxtBox.BorderSize = 2;
            this.searchTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(726, 10);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxtBox.Multiline = false;
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Padding = new System.Windows.Forms.Padding(8, 6, 38, 6);
            this.searchTxtBox.PasswordChar = false;
            this.searchTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTxtBox.PlaceholderText = "Tìm kiếm";
            this.searchTxtBox.Size = new System.Drawing.Size(221, 32);
            this.searchTxtBox.TabIndex = 19;
            this.searchTxtBox.Texts = "";
            this.searchTxtBox.UnderlinedStyle = false;
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.addProductBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.addProductBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addProductBtn.BorderRadius = 15;
            this.addProductBtn.BorderSize = 0;
            this.addProductBtn.FlatAppearance.BorderSize = 0;
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtn.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.Color.White;
            this.addProductBtn.Location = new System.Drawing.Point(9, 9);
            this.addProductBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(112, 32);
            this.addProductBtn.TabIndex = 15;
            this.addProductBtn.Text = "Thêm mới";
            this.addProductBtn.TextColor = System.Drawing.Color.White;
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Bộ lọc:";
            // 
            // fProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 629);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusFilterCbBox);
            this.Controls.Add(this.collectionFilterCbBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cateFilterCbBox);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.productInfoPanel);
            this.Controls.Add(this.dgvSp);
            this.Controls.Add(this.addProductBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSp)).EndInit();
            this.productInfoPanel.ResumeLayout(false);
            this.productInfoPanel.PerformLayout();
            this.flpAttribute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSp;
        private System.Windows.Forms.Panel productInfoPanel;
        private CustomTextBox productNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpAttribute;
        private System.Windows.Forms.Label label3;
        private CustomTextBox materialTxtBox;
        private System.Windows.Forms.Label label2;
        private CustomComponent.CustomComboBox categoryCbbox;
        private CustomComponent.CustomComboBox collectionCbbox;
        private System.Windows.Forms.Label label4;
        private CustomComponent.CustomComboBox statusCbbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomButton addAttributeBtn;
        private CustomButton addProductBtn;
        private CustomButton cancelBtn;
        private CustomButton updateProductBtn;
        private CustomButton manageSizeBtn;
        private CustomTextBox searchTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomComponent.CustomComboBox cateFilterCbBox;
        private CustomComponent.CustomComboBox collectionFilterCbBox;
        private CustomComponent.CustomComboBox statusFilterCbBox;
        private System.Windows.Forms.Label label7;
    }
}