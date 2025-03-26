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
using WindowsForms2.CustomComponent;

namespace WindowsForms2.FORM
{
    public partial class fOrder: Form
    {
        public fOrder(jewelryStoreManagementEntities db)
        {
            InitializeComponent();
            for(int i = 0; i < 100; i++)
            {
                flpOrder.Controls.Add(new OrderRow());
            }
        }
    }
}
