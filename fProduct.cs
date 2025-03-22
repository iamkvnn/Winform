using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2
{
    public partial class fProduct: Form
    {
        private jewelryStoreManagementEntities _db;
        public fProduct(jewelryStoreManagementEntities db)
        {
            InitializeComponent();
            _db = db;
            dgvSp.DataSource = _db.products.ToList();
            dgvSp.Columns["id"].Width = 30;
        }
    }
}
