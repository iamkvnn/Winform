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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSp
            // 
            this.dgvSp.AllowUserToAddRows = false;
            this.dgvSp.AllowUserToDeleteRows = false;
            this.dgvSp.AllowUserToOrderColumns = true;
            this.dgvSp.AllowUserToResizeRows = false;
            this.dgvSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSp.Location = new System.Drawing.Point(12, 12);
            this.dgvSp.Name = "dgvSp";
            this.dgvSp.ReadOnly = true;
            this.dgvSp.RowHeadersWidth = 51;
            this.dgvSp.RowTemplate.Height = 24;
            this.dgvSp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSp.Size = new System.Drawing.Size(1256, 510);
            this.dgvSp.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 234);
            this.panel1.TabIndex = 1;
            // 
            // fProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSp;
        private System.Windows.Forms.Panel panel1;
    }
}