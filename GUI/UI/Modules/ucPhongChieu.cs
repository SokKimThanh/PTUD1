using BUS;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DTO;
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
    public partial class ucPhongChieu : ucBase
    {
        private tbl_DM_Theater_BUS theater_bus = new tbl_DM_Theater_BUS();
        public ucPhongChieu()
        {
            InitializeComponent();
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.Trim();
        }

        /// <summary>
        /// Tải dữ liệu lên các thành phần của màn hình
        /// </summary>
        protected override void Load_Data()
        {
            try
            {
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
                tbl_DM_Theater_DTO newItem = new tbl_DM_Theater_DTO(null, txtName.Text, cboStatus.SelectedIndex, 0);
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
                        int deleted = 1;
                        DialogResult re = MessageBox.Show("Bạn có muốn xóa phòng chiếu " + name, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(re == DialogResult.Yes)
                        {
                            tbl_DM_Theater_DTO editTheater = new tbl_DM_Theater_DTO(id, name, status, deleted);
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
                        int deleted = (int)gvTheaters.GetRowCellValue(i, "Deleted");
                        tbl_DM_Theater_DTO editTheater = new tbl_DM_Theater_DTO(id, name, status, deleted);
                        theater_bus.UpdateData(editTheater);
                    }
                }
                Load_Data();
            }catch(Exception ex)
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

        private void gvTheaters_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int[] cacDong = gvTheaters.GetSelectedRows();
            foreach (int i in cacDong)
            {
                if (i >= 0)
                {
                    txtName.Text = gvTheaters.GetRowCellValue(i, "Name").ToString();
                    cboStatus.SelectedIndex = (int)gvTheaters.GetRowCellValue(i, "Status");
                }
            }
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();
        }
    }
}
