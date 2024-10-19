using BUS;
using BUS.Sys;
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

            // Lấy danh sách các phòng chiếu
            cboTheaters.Properties.DataSource = theater_BUS.GetList();
            cboTheaters.Properties.DisplayMember = "Name";
            cboTheaters.Properties.ValueMember = "AutoID";
            cboTheaters.ItemIndex = 0;
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gridView1.OptionsBehavior.Editable = false;
        }
        protected override void Load_Data()
        {
            //if (strFunctionCode != "")
            //    lblTitle.Text = strFunctionCode.Trim();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rows, cols;
            if(Ultilities.isNumber(txtRows.Text) && Ultilities.isNumber(txtCols.Text))
            {
                rows = int.Parse(txtRows.Text);
                cols = int.Parse(txtCols.Text);
                int couples = Convert.ToInt32(cboCouples.EditValue.ToString());
                int theater_AutoID = 1;
                seat_BUS.AddData(rows, cols, couples, theater_AutoID);
            }
            else
            {
                MessageBox.Show("Nhập số đi bạn !");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCols.Text != "" && txtRows.Text != "")
            {
                cboCouples.Enabled = true;
            }
            else
            {
                cboCouples.Enabled = false;
            }
        }
    }
}
