﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms2.BLL;

namespace WindowsForms2.FORM
{
    public partial class fVoucher: Form
    {
        private VoucherBLL _voucherBLL;
        public fVoucher()
        {
            _voucherBLL = VoucherBLL.Instance;
            InitializeComponent();
        }
    }
}
