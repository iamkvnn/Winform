﻿using System;
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
