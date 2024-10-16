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
    public partial class ucBaoCaoThuChi : ucBase
    {
        public ucBaoCaoThuChi()
        {
            InitializeComponent();
            lblTitle.Text = "Báo cáo thu chi".ToUpper();
        }

        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.Trim();
        }
    }
}
