namespace WindowsForms2.CustomComponent
{
    partial class OrderRow
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
            this.flpOrderRow = new System.Windows.Forms.FlowLayoutPanel();
            this.id = new System.Windows.Forms.Label();
            this.cusId = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.Label();
            this.shipping = new System.Windows.Forms.Label();
            this.flpOrderRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpOrderRow
            // 
            this.flpOrderRow.Controls.Add(this.id);
            this.flpOrderRow.Controls.Add(this.cusId);
            this.flpOrderRow.Controls.Add(this.cusName);
            this.flpOrderRow.Controls.Add(this.totalPrice);
            this.flpOrderRow.Controls.Add(this.status);
            this.flpOrderRow.Controls.Add(this.orderDate);
            this.flpOrderRow.Controls.Add(this.shipping);
            this.flpOrderRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOrderRow.Location = new System.Drawing.Point(0, 0);
            this.flpOrderRow.Margin = new System.Windows.Forms.Padding(0);
            this.flpOrderRow.Name = "flpOrderRow";
            this.flpOrderRow.Size = new System.Drawing.Size(1254, 35);
            this.flpOrderRow.TabIndex = 3;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(10, 0);
            this.id.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(89, 31);
            this.id.TabIndex = 12;
            this.id.Text = "Mã đơn";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusId
            // 
            this.cusId.BackColor = System.Drawing.Color.Transparent;
            this.cusId.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusId.Location = new System.Drawing.Point(109, 0);
            this.cusId.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cusId.Name = "cusId";
            this.cusId.Size = new System.Drawing.Size(83, 31);
            this.cusId.TabIndex = 13;
            this.cusId.Text = "Mã KH";
            this.cusId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusName
            // 
            this.cusName.BackColor = System.Drawing.Color.Transparent;
            this.cusName.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName.Location = new System.Drawing.Point(202, 0);
            this.cusName.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(248, 31);
            this.cusName.TabIndex = 14;
            this.cusName.Text = "Tên khách hàng";
            this.cusName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPrice
            // 
            this.totalPrice.BackColor = System.Drawing.Color.Transparent;
            this.totalPrice.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(460, 0);
            this.totalPrice.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(170, 31);
            this.totalPrice.TabIndex = 16;
            this.totalPrice.Text = "Tổng tiền";
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(640, 0);
            this.status.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(118, 31);
            this.status.TabIndex = 15;
            this.status.Text = "Trạng thái";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderDate
            // 
            this.orderDate.BackColor = System.Drawing.Color.Transparent;
            this.orderDate.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDate.Location = new System.Drawing.Point(768, 0);
            this.orderDate.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(156, 31);
            this.orderDate.TabIndex = 17;
            this.orderDate.Text = "Ngày đặt";
            this.orderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shipping
            // 
            this.shipping.BackColor = System.Drawing.Color.Transparent;
            this.shipping.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipping.Location = new System.Drawing.Point(934, 0);
            this.shipping.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.shipping.Name = "shipping";
            this.shipping.Size = new System.Drawing.Size(155, 31);
            this.shipping.TabIndex = 18;
            this.shipping.Text = "Vận chuyển";
            this.shipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpOrderRow);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "OrderRow";
            this.Size = new System.Drawing.Size(1254, 35);
            this.flpOrderRow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpOrderRow;
        public System.Windows.Forms.Label id;
        public System.Windows.Forms.Label cusId;
        public System.Windows.Forms.Label cusName;
        public System.Windows.Forms.Label totalPrice;
        public System.Windows.Forms.Label status;
        public System.Windows.Forms.Label orderDate;
        public System.Windows.Forms.Label shipping;
    }
}
