using BUS.Danh_Muc;
using DevExpress.XtraEditors.Controls;
using DTO.tbl_DTO;
using GUI.UI.Component;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucSuatChieu : ucBase
    {
        #region Fields
        private tbl_DM_Movie_BUS movie_bus = new tbl_DM_Movie_BUS();
        private tbl_DM_Theater_BUS theater_bus = new tbl_DM_Theater_BUS();
        private tbl_DM_MovieSchedule_BUS movieSche_bus = new tbl_DM_MovieSchedule_BUS();
        private tbl_DM_Ticket_BUS ticket_bus = new tbl_DM_Ticket_BUS();
        private int cleaningTime = 30;
        private int roundUpMinute = 5;

        // Component grid view layout custom
        GridViewLayoutCustom gridViewLayoutCustom = new GridViewLayoutCustom();

        // Component Barmanager menu layout custom
        BarManagerLayoutCustom barManagerLayoutCustom = new BarManagerLayoutCustom();

        // Component layout allow show/hide control menu customize
        LayoutControlCustom layoutControlCustom = new LayoutControlCustom();
        #endregion

        public ucSuatChieu()
        {
            InitializeComponent();
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 36);
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gvMovieSchedules.OptionsBehavior.Editable = false;

            barManagerLayoutCustom.BarManagerCustom = barManager1;

            // Tùy chỉnh hiển thị find panel trên grid view
            gridViewLayoutCustom.ConfigureFindPanel(gvMovieSchedules);

            // Tùy chỉnh vô hiệu hóa chuột phải design mode trên menu
            barManagerLayoutCustom.DisableCustomization();

            // Tùy chỉnh vô hiệu hóa kéo thu nhỏ di chuyển menu
            barManagerLayoutCustom.DisableMoving();

            // Tùy chỉnh vô hiệu hóa design mode menu con của layout control 
            layoutControlCustom.DisableLayoutCustomization(layoutForm);
        }

        private void IsUsing(bool isUsing)
        {
            btnThem.Enabled = !isUsing;
            btnCapNhat.Enabled = isUsing;
            btnXoa.Enabled = isUsing;
        }
        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();

            // Hiển thị danh sách các lịch chiếu hiện có trong cơ sở dữ liệu
            GetScheduleList(null);

            // Lấy danh sách phim
            cboMovies.Properties.DataSource = null;
            cboMovies.Properties.DataSource = movie_bus.GetAll();
            cboMovies.Properties.DisplayMember = "MV_NAME";
            cboMovies.Properties.ValueMember = "MV_AutoID";
            cboMovies.Properties.Columns.Clear();
            cboMovies.Properties.Columns.Add(new LookUpColumnInfo("MV_NAME", "Tên Phim"));
            cboMovies.Properties.Columns.Add(new LookUpColumnInfo("MV_PRICE", "Giá vé"));
            cboMovies.Properties.Columns.Add(new LookUpColumnInfo("MV_DURATION", "Thời lượng (phút)"));

            // Lấy danh sách phòng chiếu
            cboTheaters.Properties.DataSource = null;
            cboTheaters.Properties.DataSource = theater_bus.GetList();
            cboTheaters.Properties.DisplayMember = "Name";
            cboTheaters.Properties.ValueMember = "AutoID";
            cboTheaters.Properties.Columns.Clear();
            cboTheaters.Properties.Columns.Add(new LookUpColumnInfo("AutoID", "Mã số"));
            cboTheaters.Properties.Columns.Add(new LookUpColumnInfo("Name", "Tên Rạp"));
            cboTheaters.ItemIndex = 0;

            // Làm mới thao tác
            IsUsing(false);
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
                DateTime startDate = (DateTime)dtpStartDate.EditValue;
                DateTime endDate = (DateTime)dtpEndDate.EditValue;

                // Thêm dữ liệu vào danh sách
                movieSche_bus.AddData((long)cboMovies.EditValue, (long)cboTheaters.EditValue, startDate, endDate);

                MessageBox.Show("Thêm lịch chiếu mới thành công", "Thông báo");

                Load_Data();

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (msg.Contains("UNIQUE"))
                {
                    MessageBox.Show("Không thể thực hiện thao tác thêm do trùng lịch", "Lỗi");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
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
                if (re == DialogResult.Yes)
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
                    if (!movieSche_bus.IsBookedSchedule(id))
                    {
                        movieSche_bus.RemoveData(id);
                        MessageBox.Show("Xóa thông tin lịch chiếu thành công", "Thông báo");
                        Load_Data();
                    }
                    else
                    {
                        throw new Exception("Suất phim đã được đặt vé, không thể xóa");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        /// <summary>
        /// Nút cập nhật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn đổi thông tin lịch chiếu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
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
                    List<tbl_DM_Ticket_DTO> foundTickets = ticket_bus.GetList_ByMovieSchedule(id);
                    if (foundTickets.Count > 0)
                    {
                        throw new Exception("Suất chiếu đã có khách đặt vé, không thể thay đổi thông tin !");
                    }
                    DateTime startDate = (DateTime)dtpStartDate.EditValue;
                    DateTime endDate = (DateTime)dtpEndDate.EditValue;

                    movieSche_bus.UpdateData(id, (long)cboMovies.EditValue, (long)cboTheaters.EditValue, startDate, endDate, 0);
                    MessageBox.Show("Thay đổi thông tin lịch chiếu thành công", "Thông báo");
                    Load_Data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
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
                        // Lấy danh sách phim có cùng thời lượng
                        cboMovies.Properties.DataSource = null;
                        cboMovies.Properties.DataSource = movie_bus.GetAll_ByDuration(movie_bus.Find((long)gvMovieSchedules.GetRowCellValue(i, "Movie_AutoID")).MV_DURATION);
                        cboMovies.Properties.DisplayMember = "MV_NAME";
                        cboMovies.Properties.ValueMember = "MV_AutoID";
                        cboMovies.Properties.Columns.Clear();
                        cboMovies.Properties.Columns.Add(new LookUpColumnInfo("MV_NAME", "Tên Phim"));
                        cboMovies.Properties.Columns.Add(new LookUpColumnInfo("MV_PRICE", "Giá vé"));
                        cboMovies.Properties.Columns.Add(new LookUpColumnInfo("MV_DURATION", "Thời lượng (phút)"));



                        cboMovies.EditValue = gvMovieSchedules.GetRowCellValue(i, "Movie_AutoID");
                        cboTheaters.EditValue = gvMovieSchedules.GetRowCellValue(i, "Theater_AutoID");
                        DateTime startDate = (DateTime)gvMovieSchedules.GetRowCellValue(i, "StartDate");
                        DateTime endDate = (DateTime)gvMovieSchedules.GetRowCellValue(i, "EndDate");
                        dtpStartDate.EditValue = startDate;
                        dtpEndDate.EditValue = endDate;
                        IsUsing(true);
                    }
                }
            }
            catch (Exception ex)
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

        /// <summary>
        /// Lấy ngày bắt đầu chiếu
        /// </summary>
        public void GetSetUpDate()
        {
            // Lấy suất chiếu cuối của phòng chiếu đang chọn
            long theaterID = long.Parse(cboTheaters.EditValue.ToString().Trim());
            tbl_DM_MovieSchedule_DTO lastMovieSchedule = movieSche_bus.GetLastMovieSchedule_ByTheater(theaterID);
            tbl_DM_Movie_DTO foundMovie = movie_bus.Find((long)cboMovies.EditValue);

            // Giờ bắt đầu mặc định là ngày mai nếu chưa có suất chiếu nào trong tương lai
            DateTime startTime = RoundUpToNearestHour(DateTime.Now.AddDays(1));

            if (lastMovieSchedule != null && lastMovieSchedule.EndDate > DateTime.Now)
            {
                // Chỉnh lại giờ bắt đầu
                startTime = lastMovieSchedule.EndDate.AddMinutes(cleaningTime);
                if (startTime.Minute % roundUpMinute != 0)
                {
                    startTime = startTime.AddMinutes(roundUpMinute - startTime.Minute % roundUpMinute);
                }
            }
            dtpStartDate.EditValue = startTime;
            dtpEndDate.EditValue = startTime.AddMinutes(foundMovie.MV_DURATION);
        }

        /// <summary>
        /// Lấy danh sách lịch chiếu
        /// </summary>
        /// <param name="theaterID"></param>
        private void GetScheduleList(long? theaterID)
        {
            try
            {
                if (theaterID == null)
                {
                    // Lấy dữ liệu danh sách lịch chiếu
                    dgvMovieSchedules.DataSource = movieSche_bus.GetList(0);
                }
                else
                {
                    List<tbl_DM_MovieSchedule_DTO> source = movieSche_bus.GetMovieSchedule_ByTheater(long.Parse(cboTheaters.EditValue.ToString().Trim()));
                    dgvMovieSchedules.DataSource = source;
                }
                dgvMovieSchedules.Refresh();

                // Đổi tên cột
                gvMovieSchedules.Columns["Movie_Name"].Caption = "Tên Phim";
                gvMovieSchedules.Columns["Theater_Name"].Caption = "Phòng";
                gvMovieSchedules.Columns["StartDate"].Caption = "Giờ bắt đầu";
                gvMovieSchedules.Columns["EndDate"].Caption = "Giờ kết thúc";
                gvMovieSchedules.Columns["AutoID"].Visible = false;
                gvMovieSchedules.Columns["Movie_AutoID"].Visible = false;
                gvMovieSchedules.Columns["Theater_AutoID"].Visible = false;
                gvMovieSchedules.Columns["Deleted"].Visible = false;

                // Đảo vị trí của các cột
                gvMovieSchedules.Columns["Movie_Name"].VisibleIndex = 1;
                gvMovieSchedules.Columns["Theater_Name"].VisibleIndex = 2;
                gvMovieSchedules.Columns["StartDate"].VisibleIndex = 3;
                gvMovieSchedules.Columns["EndDate"].VisibleIndex = 4;

                // Tùy chỉnh kiểu hiển thị của giờ chiếu
                gvMovieSchedules.Columns["StartDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gvMovieSchedules.Columns["StartDate"].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
                gvMovieSchedules.Columns["EndDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gvMovieSchedules.Columns["EndDate"].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        /// <summary>
        /// Thay đổi phòng chiếu phim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboTheaters_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cboMovies.Refresh();
                cboMovies.ItemIndex = 0;
                GetScheduleList((long)cboTheaters.EditValue);
                GetSetUpDate();
                IsUsing(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        /// <summary>
        /// Thay đổi phim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboMovies_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (btnThem.Enabled)
                    GetSetUpDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
