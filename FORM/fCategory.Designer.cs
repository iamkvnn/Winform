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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.catePanel = new WindowsForms2.CustomComponent.CustomPanel();
            this.customPanel2 = new WindowsForms2.CustomComponent.CustomPanel();
            this.dgvCate = new System.Windows.Forms.DataGridView();
            this.parentCateCbbox = new WindowsForms2.CustomComponent.CustomComboBox();
            this.collapseCate = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelCateBtn = new WindowsForms2.CustomButton();
            this.updateCateBtn = new WindowsForms2.CustomButton();
            this.cateTxtBox = new WindowsForms2.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCateBtn = new WindowsForms2.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.collectionPanel = new WindowsForms2.CustomComponent.CustomPanel();
            this.customPanel3 = new WindowsForms2.CustomComponent.CustomPanel();
            this.dgvCollection = new System.Windows.Forms.DataGridView();
            this.collection_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collection_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.collectionDesTxtBox = new WindowsForms2.CustomTextBox();
            this.cancelCollectionBtn = new WindowsForms2.CustomButton();
            this.collectionNameTxtBox = new WindowsForms2.CustomTextBox();
            this.addCollectionBtn = new WindowsForms2.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.updateCollectionBtn = new WindowsForms2.CustomButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catePanel.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseCate)).BeginInit();
            this.collectionPanel.SuspendLayout();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // catePanel
            // 
            this.catePanel.BackColor = System.Drawing.Color.White;
            this.catePanel.BorderRadius = 50;
            this.catePanel.Controls.Add(this.customPanel2);
            this.catePanel.Controls.Add(this.parentCateCbbox);
            this.catePanel.Controls.Add(this.collapseCate);
            this.catePanel.Controls.Add(this.label5);
            this.catePanel.Controls.Add(this.cancelCateBtn);
            this.catePanel.Controls.Add(this.updateCateBtn);
            this.catePanel.Controls.Add(this.cateTxtBox);
            this.catePanel.Controls.Add(this.label1);
            this.catePanel.Controls.Add(this.addCateBtn);
            this.catePanel.Controls.Add(this.label2);
            this.catePanel.ForeColor = System.Drawing.Color.Black;
            this.catePanel.GradientAngle = 90F;
            this.catePanel.GradientBottomColor = System.Drawing.Color.White;
            this.catePanel.GradientTopColor = System.Drawing.Color.White;
            this.catePanel.Location = new System.Drawing.Point(9, 10);
            this.catePanel.Margin = new System.Windows.Forms.Padding(2);
            this.catePanel.Name = "catePanel";
            this.catePanel.Size = new System.Drawing.Size(472, 609);
            this.catePanel.TabIndex = 38;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 40;
            this.customPanel2.Controls.Add(this.dgvCate);
            this.customPanel2.Font = new System.Drawing.Font("HarmonyOS Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.Silver;
            this.customPanel2.Location = new System.Drawing.Point(8, 46);
            this.customPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(455, 330);
            this.customPanel2.TabIndex = 37;
            // 
            // dgvCate
            // 
            this.dgvCate.AllowUserToAddRows = false;
            this.dgvCate.AllowUserToDeleteRows = false;
            this.dgvCate.AllowUserToOrderColumns = true;
            this.dgvCate.AllowUserToResizeColumns = false;
            this.dgvCate.AllowUserToResizeRows = false;
            this.dgvCate.BackgroundColor = System.Drawing.Color.White;
            this.dgvCate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCate.ColumnHeadersHeight = 29;
            this.dgvCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.parent_id,
            this.parent_name});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HarmonyOS Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCate.EnableHeadersVisualStyles = false;
            this.dgvCate.GridColor = System.Drawing.Color.LightGray;
            this.dgvCate.Location = new System.Drawing.Point(0, 0);
            this.dgvCate.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCate.MultiSelect = false;
            this.dgvCate.Name = "dgvCate";
            this.dgvCate.ReadOnly = true;
            this.dgvCate.RowHeadersVisible = false;
            this.dgvCate.RowHeadersWidth = 51;
            this.dgvCate.RowTemplate.Height = 25;
            this.dgvCate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCate.Size = new System.Drawing.Size(455, 330);
            this.dgvCate.TabIndex = 0;
            this.dgvCate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCate_CellClick);
            // 
            // parentCateCbbox
            // 
            this.parentCateCbbox.BackColor = System.Drawing.Color.White;
            this.parentCateCbbox.BorderColor = System.Drawing.Color.Silver;
            this.parentCateCbbox.BorderSize = 2;
            this.parentCateCbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentCateCbbox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentCateCbbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parentCateCbbox.IconColor = System.Drawing.Color.LightSlateGray;
            this.parentCateCbbox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.parentCateCbbox.ListTextColor = System.Drawing.Color.DimGray;
            this.parentCateCbbox.Location = new System.Drawing.Point(64, 495);
            this.parentCateCbbox.Margin = new System.Windows.Forms.Padding(2);
            this.parentCateCbbox.MinimumSize = new System.Drawing.Size(150, 24);
            this.parentCateCbbox.Name = "parentCateCbbox";
            this.parentCateCbbox.Padding = new System.Windows.Forms.Padding(2);
            this.parentCateCbbox.Size = new System.Drawing.Size(345, 35);
            this.parentCateCbbox.TabIndex = 36;
            this.parentCateCbbox.Texts = "";
            // 
            // collapseCate
            // 
            this.collapseCate.BackgroundImage = global::WindowsForms2.Properties.Resources.expand_button;
            this.collapseCate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.collapseCate.Location = new System.Drawing.Point(433, 11);
            this.collapseCate.Margin = new System.Windows.Forms.Padding(2);
            this.collapseCate.Name = "collapseCate";
            this.collapseCate.Size = new System.Drawing.Size(22, 24);
            this.collapseCate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collapseCate.TabIndex = 35;
            this.collapseCate.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 30);
            this.label5.TabIndex = 34;
            this.label5.Text = "Danh mục";
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
            this.cancelCateBtn.Location = new System.Drawing.Point(317, 545);
            this.cancelCateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelCateBtn.Name = "cancelCateBtn";
            this.cancelCateBtn.Size = new System.Drawing.Size(115, 42);
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
            this.updateCateBtn.Location = new System.Drawing.Point(177, 545);
            this.updateCateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateCateBtn.Name = "updateCateBtn";
            this.updateCateBtn.Size = new System.Drawing.Size(115, 42);
            this.updateCateBtn.TabIndex = 32;
            this.updateCateBtn.Text = "Cập nhật";
            this.updateCateBtn.TextColor = System.Drawing.Color.White;
            this.updateCateBtn.UseVisualStyleBackColor = false;
            // 
            // cateTxtBox
            // 
            this.cateTxtBox.BackColor = System.Drawing.Color.White;
            this.cateTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.cateTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.cateTxtBox.BorderRadius = 15;
            this.cateTxtBox.BorderSize = 2;
            this.cateTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cateTxtBox.Location = new System.Drawing.Point(62, 422);
            this.cateTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.cateTxtBox.Multiline = false;
            this.cateTxtBox.Name = "cateTxtBox";
            this.cateTxtBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.cateTxtBox.PasswordChar = false;
            this.cateTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cateTxtBox.PlaceholderText = "Nhập tên danh mục";
            this.cateTxtBox.Size = new System.Drawing.Size(347, 32);
            this.cateTxtBox.TabIndex = 28;
            this.cateTxtBox.Texts = "";
            this.cateTxtBox.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 474);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Danh mục cha";
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
            this.addCateBtn.Location = new System.Drawing.Point(36, 545);
            this.addCateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addCateBtn.Name = "addCateBtn";
            this.addCateBtn.Size = new System.Drawing.Size(115, 42);
            this.addCateBtn.TabIndex = 31;
            this.addCateBtn.Text = "Thêm";
            this.addCateBtn.TextColor = System.Drawing.Color.White;
            this.addCateBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên";
            // 
            // collectionPanel
            // 
            this.collectionPanel.BackColor = System.Drawing.Color.White;
            this.collectionPanel.BorderRadius = 50;
            this.collectionPanel.Controls.Add(this.customPanel3);
            this.collectionPanel.Controls.Add(this.pictureBox1);
            this.collectionPanel.Controls.Add(this.label6);
            this.collectionPanel.Controls.Add(this.label3);
            this.collectionPanel.Controls.Add(this.collectionDesTxtBox);
            this.collectionPanel.Controls.Add(this.cancelCollectionBtn);
            this.collectionPanel.Controls.Add(this.collectionNameTxtBox);
            this.collectionPanel.Controls.Add(this.addCollectionBtn);
            this.collectionPanel.Controls.Add(this.label4);
            this.collectionPanel.Controls.Add(this.updateCollectionBtn);
            this.collectionPanel.ForeColor = System.Drawing.Color.Black;
            this.collectionPanel.GradientAngle = 90F;
            this.collectionPanel.GradientBottomColor = System.Drawing.Color.White;
            this.collectionPanel.GradientTopColor = System.Drawing.Color.White;
            this.collectionPanel.Location = new System.Drawing.Point(485, 10);
            this.collectionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.collectionPanel.Name = "collectionPanel";
            this.collectionPanel.Size = new System.Drawing.Size(466, 609);
            this.collectionPanel.TabIndex = 37;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 40;
            this.customPanel3.Controls.Add(this.dgvCollection);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 90F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.Silver;
            this.customPanel3.Location = new System.Drawing.Point(6, 46);
            this.customPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(450, 330);
            this.customPanel3.TabIndex = 38;
            // 
            // dgvCollection
            // 
            this.dgvCollection.AllowUserToAddRows = false;
            this.dgvCollection.AllowUserToDeleteRows = false;
            this.dgvCollection.AllowUserToOrderColumns = true;
            this.dgvCollection.AllowUserToResizeColumns = false;
            this.dgvCollection.AllowUserToResizeRows = false;
            this.dgvCollection.BackgroundColor = System.Drawing.Color.White;
            this.dgvCollection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCollection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCollection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCollection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCollection.ColumnHeadersHeight = 29;
            this.dgvCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCollection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collection_id,
            this.collection_name,
            this.description});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("HarmonyOS Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCollection.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCollection.EnableHeadersVisualStyles = false;
            this.dgvCollection.GridColor = System.Drawing.Color.LightGray;
            this.dgvCollection.Location = new System.Drawing.Point(0, 0);
            this.dgvCollection.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCollection.MultiSelect = false;
            this.dgvCollection.Name = "dgvCollection";
            this.dgvCollection.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("HarmonyOS Sans Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCollection.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCollection.RowHeadersVisible = false;
            this.dgvCollection.RowHeadersWidth = 51;
            this.dgvCollection.RowTemplate.Height = 25;
            this.dgvCollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCollection.Size = new System.Drawing.Size(450, 330);
            this.dgvCollection.TabIndex = 0;
            this.dgvCollection.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCollection_CellClick);
            // 
            // collection_id
            // 
            this.collection_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.collection_id.HeaderText = "ID";
            this.collection_id.MinimumWidth = 6;
            this.collection_id.Name = "collection_id";
            this.collection_id.ReadOnly = true;
            // 
            // collection_name
            // 
            this.collection_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.collection_name.FillWeight = 200F;
            this.collection_name.HeaderText = "Tên Bộ Sưu Tập";
            this.collection_name.MinimumWidth = 6;
            this.collection_name.Name = "collection_name";
            this.collection_name.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.FillWeight = 400F;
            this.description.HeaderText = "Mô Tả";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsForms2.Properties.Resources.expand_button;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(434, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 30);
            this.label6.TabIndex = 35;
            this.label6.Text = "Bộ sưu tập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 388);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên";
            // 
            // collectionDesTxtBox
            // 
            this.collectionDesTxtBox.BackColor = System.Drawing.Color.White;
            this.collectionDesTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.collectionDesTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.collectionDesTxtBox.BorderRadius = 15;
            this.collectionDesTxtBox.BorderSize = 2;
            this.collectionDesTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionDesTxtBox.Location = new System.Drawing.Point(29, 481);
            this.collectionDesTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.collectionDesTxtBox.Multiline = true;
            this.collectionDesTxtBox.Name = "collectionDesTxtBox";
            this.collectionDesTxtBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.collectionDesTxtBox.PasswordChar = false;
            this.collectionDesTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.collectionDesTxtBox.PlaceholderText = "Nhập mô tả";
            this.collectionDesTxtBox.Size = new System.Drawing.Size(406, 106);
            this.collectionDesTxtBox.TabIndex = 34;
            this.collectionDesTxtBox.Texts = "";
            this.collectionDesTxtBox.UnderlinedStyle = false;
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
            this.cancelCollectionBtn.Location = new System.Drawing.Point(293, 435);
            this.cancelCollectionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelCollectionBtn.Name = "cancelCollectionBtn";
            this.cancelCollectionBtn.Size = new System.Drawing.Size(92, 37);
            this.cancelCollectionBtn.TabIndex = 36;
            this.cancelCollectionBtn.Text = "Hủy";
            this.cancelCollectionBtn.TextColor = System.Drawing.Color.White;
            this.cancelCollectionBtn.UseVisualStyleBackColor = false;
            // 
            // collectionNameTxtBox
            // 
            this.collectionNameTxtBox.BackColor = System.Drawing.Color.White;
            this.collectionNameTxtBox.BorderColor = System.Drawing.Color.Silver;
            this.collectionNameTxtBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.collectionNameTxtBox.BorderRadius = 15;
            this.collectionNameTxtBox.BorderSize = 2;
            this.collectionNameTxtBox.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionNameTxtBox.Location = new System.Drawing.Point(29, 410);
            this.collectionNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.collectionNameTxtBox.Multiline = false;
            this.collectionNameTxtBox.Name = "collectionNameTxtBox";
            this.collectionNameTxtBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.collectionNameTxtBox.PasswordChar = false;
            this.collectionNameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.collectionNameTxtBox.PlaceholderText = "Nhập tên bộ sưu tập";
            this.collectionNameTxtBox.Size = new System.Drawing.Size(189, 32);
            this.collectionNameTxtBox.TabIndex = 32;
            this.collectionNameTxtBox.Texts = "";
            this.collectionNameTxtBox.UnderlinedStyle = false;
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
            this.addCollectionBtn.Location = new System.Drawing.Point(239, 393);
            this.addCollectionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addCollectionBtn.Name = "addCollectionBtn";
            this.addCollectionBtn.Size = new System.Drawing.Size(92, 37);
            this.addCollectionBtn.TabIndex = 34;
            this.addCollectionBtn.Text = "Thêm";
            this.addCollectionBtn.TextColor = System.Drawing.Color.White;
            this.addCollectionBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 459);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mô tả";
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
            this.updateCollectionBtn.Location = new System.Drawing.Point(351, 391);
            this.updateCollectionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateCollectionBtn.Name = "updateCollectionBtn";
            this.updateCollectionBtn.Size = new System.Drawing.Size(92, 37);
            this.updateCollectionBtn.TabIndex = 35;
            this.updateCollectionBtn.Text = "Cập nhật";
            this.updateCollectionBtn.TextColor = System.Drawing.Color.White;
            this.updateCollectionBtn.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 200F;
            this.name.HeaderText = "Tên Danh Mục";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // parent_id
            // 
            this.parent_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parent_id.HeaderText = "ID Cha";
            this.parent_id.MinimumWidth = 6;
            this.parent_id.Name = "parent_id";
            this.parent_id.ReadOnly = true;
            // 
            // parent_name
            // 
            this.parent_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parent_name.FillWeight = 210F;
            this.parent_name.HeaderText = "Tên Danh Mục Cha";
            this.parent_name.MinimumWidth = 6;
            this.parent_name.Name = "parent_name";
            this.parent_name.ReadOnly = true;
            // 
            // fCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(960, 629);
            this.Controls.Add(this.catePanel);
            this.Controls.Add(this.collectionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fCategory";
            this.catePanel.ResumeLayout(false);
            this.catePanel.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseCate)).EndInit();
            this.collectionPanel.ResumeLayout(false);
            this.collectionPanel.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCate;
        private CustomTextBox cateTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomButton cancelCateBtn;
        private CustomButton updateCateBtn;
        private CustomButton addCateBtn;
        private CustomTextBox collectionNameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomTextBox collectionDesTxtBox;
        private CustomButton addCollectionBtn;
        private CustomButton updateCollectionBtn;
        private CustomButton cancelCollectionBtn;
        private CustomComponent.CustomPanel collectionPanel;
        private CustomComponent.CustomPanel catePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox collapseCate;
        private CustomComponent.CustomComboBox parentCateCbbox;
        private CustomComponent.CustomPanel customPanel2;
        private CustomComponent.CustomPanel customPanel3;
        private System.Windows.Forms.DataGridView dgvCollection;
        private System.Windows.Forms.DataGridViewTextBoxColumn collection_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn collection_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent_name;
    }
}