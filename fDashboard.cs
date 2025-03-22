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
    public partial class fDashboard: Form
    {
        private jewelryStoreManagementEntities _db;
        public fDashboard(jewelryStoreManagementEntities db)
        {
            InitializeComponent();
            _db = db;   
        }
    }
}
