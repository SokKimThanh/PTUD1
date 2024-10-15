﻿using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucBaoCaoDoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        public ucBaoCaoDoanhThu()
        {
            InitializeComponent();
            lblTitle.Text = "Báo cáo doanh thu".ToUpper();
        }
    }
}