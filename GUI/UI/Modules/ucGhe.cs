using BUS;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucGhe : ucBase
    {
        #region Fields
        private tbl_DM_Seat_BUS seat_BUS = new tbl_DM_Seat_BUS();
        private tbl_DM_Theater_BUS theater_BUS = new tbl_DM_Theater_BUS();
        #endregion

        public ucGhe()
        {
            InitializeComponent();
            for(int i = 1; i <= 20; i++)
            {
                cboRows.Items.Add(i.ToString());
                cboCols.Items.Add(i.ToString());
                if(i<=10)
                    cboCouples.Items.Add(i.ToString());
            }
            cboTheater.DataSource = theater_BUS.GetList();
        }
        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.Trim();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rows = cboRows.SelectedIndex;
            int cols = cboCols.SelectedIndex;
            int couples = cboCouples.SelectedIndex;
            int theater_AutoID = 1;
            seat_BUS.AddData(rows,cols,couples,theater_AutoID);
        }
    }
}
