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
    public partial class ucBase : DevExpress.XtraEditors.XtraUserControl
    {
        public string strFunctionCode { get; set; } = "";

        public ucBase()
        {
            this.Load += Load_DataBase;
        }

        protected void Load_DataBase(object sender, EventArgs e)
        {
            try
            {
                //Đặt thuộc tính name cho lblTitle
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void Load_Data()
        {

        }
    }
}
