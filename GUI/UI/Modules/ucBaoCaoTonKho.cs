using DevExpress.XtraEditors;
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
    public partial class ucBaoCaoTonKho : DevExpress.XtraEditors.XtraUserControl
    {
        public ucBaoCaoTonKho()
        {
            InitializeComponent();
            lblTitle.Text = "Báo cáo Tồn kho".ToUpper();
        }
    }
}
