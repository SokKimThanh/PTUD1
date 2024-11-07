using BUS.Danh_Muc;
using DevExpress.XtraEditors.Controls;
using DTO.tbl_DTO;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.UI.Modules
{
    public partial class ucSuatChieu : ucBase
    {
        #region Fields
        private tbl_DM_Movie_BUS movie_bus = new tbl_DM_Movie_BUS();
        private tbl_DM_Theater_BUS theater_bus = new tbl_DM_Theater_BUS();
        private tbl_DM_MovieSchedule_BUS movieSche_bus = new tbl_DM_MovieSchedule_BUS();
        #endregion

        public ucSuatChieu()
        {
            InitializeComponent();
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 36);
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gvMovieSchedules.OptionsBehavior.Editable = false;
        }

        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();

            // Lấy danh sách phim
            cboMovies.Properties.DataSource = movie_bus.GetAll();
            cboMovies.Properties.DisplayMember = "MV_NAME";
            cboMovies.Properties.ValueMember = "MV_AutoID";
            cboMovies.Properties.Columns.Add(new LookUpColumnInfo("MV_NAME", "Tên Phim"));
            cboMovies.Properties.Columns.Add(new LookUpColumnInfo("MV_PRICE", "Giá vé"));
            cboMovies.SelectionStart = 0;

            // Lấy danh sách phòng chiếu
            cboTheaters.Properties.DataSource = theater_bus.GetList();
            cboTheaters.Properties.DisplayMember = "Name";
            cboTheaters.Properties.ValueMember = "AutoID";
            cboTheaters.Properties.Columns.Add(new LookUpColumnInfo("AutoID", "Mã số"));
            cboTheaters.Properties.Columns.Add(new LookUpColumnInfo("Name", "Tên Rạp"));
            cboTheaters.SelectionStart = 0;

            // Lấy dữ liệu danh sách lịch chiếu
            dgvMovieSchedules.DataSource = movieSche_bus.GetList();
            dgvMovieSchedules.Refresh();

            // Lấy suất chiếu cuối của phòng chiếu đang chọn
            tbl_DM_MovieSchedule_DTO lastMovieSchedule = movieSche_bus.GetLastMovieSchedule_ByTheater((long)cboTheaters.EditValue);
            if (lastMovieSchedule != null)
            {
                // Gắn giờ bắt đầu và giờ kết thúc
                dtpStartDate.EditValue = lastMovieSchedule.StartDate;
                dtpEndDate.EditValue = lastMovieSchedule.EndDate;
            }
            else
            {
                // Gắn giờ gần nhất hiện tại
                dtpStartDate.EditValue = RoundUpToNearestHour(DateTime.Now);

                // Gắn giờ kết thúc theo thời gian chiếu của phim
                tbl_DM_Movie_DTO foundMovie = movie_bus.Find((long)cboMovies.EditValue);
                dtpEndDate.EditValue = RoundUpToNearestHour(DateTime.Now).AddMinutes(foundMovie.MV_DURATION);
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
                // Lấy ngày và giờ đã chọn
                DateTime startDate = (DateTime)dtpEndDate.EditValue;
                DateTime endDate = (DateTime)dtpEndDate.EditValue;

                // Thêm dữ liệu vào danh sách
                movieSche_bus.AddData((long)cboMovies.EditValue, (long)cboTheaters.EditValue, startDate, endDate);

                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Nút xóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult re = MessageBox.Show("Bạn muốn xóa lịch chiếu này chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(re == DialogResult.Yes)
                {
                    long id = -1;
                    int[] cacDong = gvMovieSchedules.GetSelectedRows();
                    foreach (int i in cacDong)
                    {
                        if (i >= 0)
                        {
                            id = (long)gvMovieSchedules.GetRowCellValue(i, "AutoID");
                        }
                    }
                    movieSche_bus.RemoveData(id);
                }
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Nút cập nhật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                long id = -1;
                int[] cacDong = gvMovieSchedules.GetSelectedRows();
                foreach (int i in cacDong)
                {
                    if (i >= 0)
                    {
                        id = (long)gvMovieSchedules.GetRowCellValue(i, "AutoID");
                    }
                }
                DateTime startDate = (DateTime)dtpStartDate.EditValue;
                DateTime endDate = (DateTime)dtpEndDate.EditValue;

                movieSche_bus.UpdateData(id, (long)cboMovies.EditValue, (long)cboTheaters.EditValue, startDate, endDate, 0);
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Nút làm mới dữ liệu
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
        /// Thao tác chọn 1 phần tử trên danh sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvMovieSchedules_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                int[] cacDong = gvMovieSchedules.GetSelectedRows();
                foreach (int i in cacDong)
                {
                    if (i >= 0)
                    {
                        cboMovies.EditValue = gvMovieSchedules.GetRowCellValue(i, "Movie_AutoID");
                        cboTheaters.EditValue = gvMovieSchedules.GetRowCellValue(i, "Theater_AutoID");
                        DateTime startDate = (DateTime)gvMovieSchedules.GetRowCellValue(i, "StartDate");
                        dtpStartDate.EditValue = startDate;
                        dtpEndDate.EditValue = startDate;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Hàm làm tròn lên giờ
        /// </summary>
        /// <param name="dateTime">Giờ hiện tại</param>
        /// <returns></returns>
        public static DateTime RoundUpToNearestHour(DateTime dateTime)
        {
            if (dateTime.Minute == 0 && dateTime.Second == 0 && dateTime.Millisecond == 0)
            {
                return dateTime; // Already on the hour
            }

            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours(1);
        }

    }
}
