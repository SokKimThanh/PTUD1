using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucDanhGiaDoTuoi : DevExpress.XtraEditors.XtraUserControl
    {
        public ucDanhGiaDoTuoi()
        {
            InitializeComponent();
            lblTitle.Text = "Quản lý đánh giá độ tuổi".ToUpper();
        }
    }
}
