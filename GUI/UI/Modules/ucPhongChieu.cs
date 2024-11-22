﻿using BUS.Danh_Muc;
using DevExpress.Charts.Native;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucPhongChieu : ucBase
    {
        private tbl_DM_Theater_BUS theater_bus = new tbl_DM_Theater_BUS();
        public ucPhongChieu()
        {
            InitializeComponent();
            gvTheaters.OptionsView.ShowGroupPanel = false;
            gvTheaters.OptionsFind.AlwaysVisible = true;
            ActionBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
        }

        /// <summary>
        /// Tải dữ liệu lên các thành phần của màn hình
        /// </summary>
        protected override void Load_Data()
        {
            try
            {
                if (strFunctionCode != "")
                    lblTitle.Text = strFunctionCode.ToUpper().Trim();

                // Combo box trạng thái phòng chiếu
                cboStatus.Properties.Items.Clear();
                cboStatus.Properties.Items.Add("Bảo trì");
                cboStatus.Properties.Items.Add("Đang hoạt động");
                cboStatus.SelectedIndex = 0;

                // Danh sách phòng chiếu
                dgvView.DataSource = theater_bus.GetList();
                dgvView.Refresh();

                // Xóa dữ liệu trên ô Tên phòng chiếu
                txtName.EditValue = "";

                // Reset dữ liệu cho các combobox ghế
                cboRows.SelectedIndex = 0;
                cboColumns.SelectedIndex = 0;
                cboCouples.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Nút thêm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbl_DM_Theater_DTO newItem = new tbl_DM_Theater_DTO(null, txtName.Text, cboStatus.SelectedIndex, cboRows.SelectedIndex + 1, cboColumns.SelectedIndex + 1, cboCouples.SelectedIndex + 1, 0);
                theater_bus.AddData(newItem);
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Xóa thông tin phòng chiếu khỏi view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int[] cacDong = gvTheaters.GetSelectedRows();
                foreach (int i in cacDong)
                {
                    if (i >= 0)
                    {
                        long id = (long)gvTheaters.GetRowCellValue(i, "AutoID");
                        string name = txtName.Text.Trim();
                        int status = cboStatus.SelectedIndex;
                        int rows = cboRows.SelectedIndex + 1;
                        int cols = cboColumns.SelectedIndex + 1;
                        int couples = cboCouples.SelectedIndex + 1;
                        int deleted = 1;
                        DialogResult re = MessageBox.Show("Bạn có muốn xóa phòng chiếu " + name, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (re == DialogResult.Yes)
                        {
                            tbl_DM_Theater_DTO editTheater = new tbl_DM_Theater_DTO(id, name, status, rows, cols, couples, deleted);
                            theater_bus.UpdateData(editTheater);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Cập nhật thông tin phòng chiếu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int[] cacDong = gvTheaters.GetSelectedRows();
                foreach (int i in cacDong)
                {
                    if (i >= 0)
                    {
                        long id = (long)gvTheaters.GetRowCellValue(i, "AutoID");
                        string name = txtName.Text.Trim();
                        int status = cboStatus.SelectedIndex;
                        int rows = cboRows.SelectedIndex + 1;
                        int cols = cboColumns.SelectedIndex + 1;
                        int couples = cboCouples.SelectedIndex + 1;
                        int deleted = (int)gvTheaters.GetRowCellValue(i, "Deleted");
                        tbl_DM_Theater_DTO editTheater = new tbl_DM_Theater_DTO(id, name, status, rows, cols, couples, deleted);
                        theater_bus.UpdateData(editTheater);
                    }
                }
                Load_Data();
                MessageBox.Show("Cập nhật thông tin thành công !", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Tải lại dữ liệu lên màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Chọn 1 thành phần trên danh sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvTheaters_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int[] cacDong = gvTheaters.GetSelectedRows();
            foreach (int i in cacDong)
            {
                if (i >= 0)
                {
                    txtName.Text = gvTheaters.GetRowCellValue(i, "Name").ToString();
                    cboStatus.SelectedIndex = (int)gvTheaters.GetRowCellValue(i, "Status");
                    cboRows.SelectedIndex = (int)gvTheaters.GetRowCellValue(i, "Rows") - 1;
                    cboColumns.SelectedIndex = (int)gvTheaters.GetRowCellValue(i, "Columns") - 1;
                    cboCouples.SelectedIndex = (int)gvTheaters.GetRowCellValue(i, "Couples") - 1;
                }
            }
        }

        private void ucPhongChieu_Load(object sender, EventArgs e)
        {
            cboRows.Properties.Items.Clear();
            cboColumns.Properties.Items.Clear();
            cboCouples.Properties.Items.Clear();
            for (int i = 1; i <= 20; i++)
            {
                int couple = i / 2;
                if (i % 2 == 0)
                {
                    cboCouples.Properties.Items.Add(couple);
                }
                cboRows.Properties.Items.Add(i);
                cboColumns.Properties.Items.Add(i);
            }
        }
    }
}
