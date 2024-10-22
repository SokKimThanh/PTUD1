using BUS;
using BUS.Sys;
using System;
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

        }
        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();

            // Lấy danh sách các phòng chiếu
            cboTheaters.Properties.DataSource = theater_BUS.GetList();
            cboTheaters.Properties.DisplayMember = "Name";
            cboTheaters.Properties.ValueMember = "AutoID";
            cboTheaters.ItemIndex = 0;

            // Lấy danh sách ghế trong các phòng chiếu
            dgv.DataSource = seat_BUS.GetList();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int rows, cols;
                if (Ultilities.isNumber(txtRows.Text) && Ultilities.isNumber(txtCols.Text))
                {
                    rows = int.Parse(txtRows.Text);
                    cols = int.Parse(txtCols.Text);
                    int couples = Convert.ToInt32(cboCouples.EditValue.ToString());
                    long theater_AutoID = (long)cboTheaters.EditValue;
                    seat_BUS.AddData(rows, cols, couples, theater_AutoID);
                }
                else
                {
                    MessageBox.Show("Nhập số đi bạn !");
                }
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                cboCouples.Properties.Items.Clear();
                for (int couple = 1; couple < Convert.ToInt32(txtCols.Text.Trim()) / 2; couple++)
                {
                    cboCouples.Properties.Items.Add(couple.ToString());
                }
                cboCouples.SelectedIndex = 0;
            }
            else
            {
                cboCouples.Enabled = false;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
