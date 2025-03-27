using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms2.BLL;
using WindowsForms2.DAL;
using WindowsForms2.CustomComponent;

namespace WindowsForms2.FORM
{
    public partial class fOrder: Form
    {
        private OrderBLL _orderBLL;
        public fOrder()
        {
            _orderBLL = OrderBLL.Instance;
            InitializeComponent();
            LoadOrder();
        }

        private void LoadOrder()
        {
            var orders = _orderBLL.GetOrders().Select(o => new
            {
                o.id,
                o.customer_id,
                o.customer.full_name,
                o.total_price,
                o.status,
                o.order_date,
                o.shipping_method
            }).ToList();
            foreach (var order in orders)
            {
                OrderRow orderRow = new OrderRow();
                orderRow.id.Text = order.id.ToString();
                orderRow.cusId.Text = order.customer_id.ToString();
                orderRow.cusName.Text = order.full_name;
                orderRow.totalPrice.Text = formatPrice(order.total_price);
                orderRow.status.Text = order.status;
                orderRow.orderDate.Text = order.order_date.ToString();
                //if (order.status == "PENDING")
                flpOrder.Controls.Add(orderRow);
            }
        }

        private string formatPrice(long price)
        {
            return price.ToString("N0") + " VNĐ";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void startFilter_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endFilter_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
