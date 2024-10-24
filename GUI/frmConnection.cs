using DevExpress.XtraEditors;
using DTO.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConnection : DevExpress.XtraEditors.XtraForm
    {

        public frmConnection()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(txtConnectionString.Text))
            {
                txtConnectionString.Text = CConfig.CM_Cinema_DB_ConnectionString;
            }
        }

        public string ConnectionString { get; private set; }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy chuỗi kết nối từ TextBox
            ConnectionString = txtConnectionString.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}