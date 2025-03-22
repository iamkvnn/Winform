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
using WindowsForms2.Exception;

namespace WindowsForms2.FORM
{
    public partial class fProduct: Form
    {
        private ProductDAO productDAO;
        public fProduct(jewelryStoreManagementEntities db)
        {
            InitializeComponent();
            productDAO = new ProductDAO(db);
            dgvSp.DataSource = productDAO.GetProducts();
            dgvSp.Columns["id"].Width = 30;
        }
    }
}
