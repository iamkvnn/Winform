using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms2.DAL;

namespace WindowsForms2.FORM
{
    public partial class fSize: Form
    {
        public fSize(jewelryStoreManagementEntities db, long pid)
        {
            InitializeComponent();
            dgvSize.DataSource = db.product_size.Where(s => s.product_id == pid).Select(s => new
            {
                s.id,
                s.size,
                s.price,
                s.discount_price,
                s.discount_rate,
                s.stock,
                s.sold
            }).ToList();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            JewelryManagementApp.ActiveForm.Close();
        }

        private void dgvSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSize.Rows[e.RowIndex];
                int sizeId = Convert.ToInt32(row.Cells["id"].Value);
                sizeTxtBox.Texts = row.Cells["size"].Value.ToString();
                priceTxtBox.Texts = row.Cells["price"].Value.ToString();
                discountPriceTxtBox.Texts = row.Cells["discount_price"].Value.ToString();
                discountRateTxtBox.Texts = row.Cells["discount_rate"].Value.ToString();
            } 
        }

        private void discountPriceTxtBox__TextChanged(object sender, EventArgs e)
        {
            double discountPrice, price;
            if (double.TryParse(discountPriceTxtBox.Texts, out discountPrice) && double.TryParse(priceTxtBox.Texts, out price) && price != 0)
            {
                discountRateTxtBox.Texts = (discountPrice * 100 / price).ToString();
            }
            else
            {
                discountRateTxtBox.Texts = "Invalid input";
            }
        }

        private void discountRateTxtBox__TextChanged(object sender, EventArgs e)
        {
            double discountPrice, price;
            if (double.TryParse(discountRateTxtBox.Texts, out discountPrice) && double.TryParse(priceTxtBox.Texts, out price) && price != 0)
            {
                discountPriceTxtBox.Texts = (price * discountPrice / 100).ToString();
            }
            else
            {
                discountPriceTxtBox.Texts = "Invalid input";
            }
        }
    }
}
