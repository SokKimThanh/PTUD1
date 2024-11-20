using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using DTO.Common;
using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraLayout;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraExport.Helpers;

namespace GUI.UI.Modules
{
    public partial class ucChonPhim : ucBase
    {
        private tbl_DM_Movie_BUS moiveBus = new tbl_DM_Movie_BUS();
        private tbl_DM_AgeRating_BUS ageBus = new tbl_DM_AgeRating_BUS();
        private tbl_DM_MovieSchedule_BUS movieScheBus = new tbl_DM_MovieSchedule_BUS();

        //Khởi tạo giao diện
        public ucChonPhim()
        {
            InitializeComponent();
            lblTitle.Text = "Chọn Phim".ToUpper();
        }

        //Tải dữ liệu
        private void ucChonPhim_Load(object sender, EventArgs e)
        {
            LoadData();
            SetupLayoutView();
        }
        private void LoadData()
        {
            // tai du lieu dgv
            dgvMovies.DataSource = moiveBus.GetAll();
            dgvMovies.RefreshDataSource();

            // Đặt ngày chọn ban đầu
            dtpDate.Properties.MinValue = DateTime.Now;
            dtpDate.EditValue = dtpDate.Properties.MinValue;

            // Hiển thị danh sách suất chiếu của phim được chọn
            cboMovieSchedule.Properties.DisplayMember = "StartDate";
            cboMovieSchedule.Properties.ValueMember = "AutoID";
            cboMovieSchedule.Properties.Columns.Add(new LookUpColumnInfo("AutoID", "Mã"));
            cboMovieSchedule.Properties.Columns.Add(new LookUpColumnInfo("StartDate", "Suất chiếu", 80,
              DevExpress.Utils.FormatType.DateTime, CConfig.Time_Format_String, true, DevExpress.Utils.HorzAlignment.Default));
            cboMovieSchedule.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            cboMovieSchedule.Properties.DisplayFormat.FormatString = CConfig.Time_Format_String;
        }
        private void ClearData()
        {
            txtAgeRating.Text = string.Empty;
            txtThoiLuong.Text = string.Empty;
            cboMovieSchedule.Clear();
        }

        // Phương thức khác
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            // Kiểm tra nếu cột hiện tại là cột chứa đường dẫn hình ảnh
            if (e.Column.FieldName == "MV_POSTERURL")
            {
                // Lấy đường dẫn từ ô hiện tại
                string imagePath = layoutView1.GetRowCellValue(e.RowHandle, e.Column).ToString();


                // Kiểm tra nếu file tồn tại
                if (File.Exists(imagePath))
                {
                    // Chuyển đường dẫn thành hình ảnh
                    Image img = Image.FromFile(imagePath);
                    // Vẽ hình ảnh vào ô
                    e.Graphics.DrawImage(img, e.Bounds);
                    e.Handled = true; // Ngăn không vẽ dữ liệu mặc định lên ô
                }
                else
                {
                    // Chuyển đường dẫn thành hình ảnh
                    Image img = Properties.Resources.gridview_no_image;
                    // Vẽ hình ảnh vào ô
                    e.Graphics.DrawImage(img, e.Bounds);
                    e.Handled = true; // Ngăn không vẽ dữ liệu mặc định lên ô
                }
            }
        }

        // Các sự kiện
        private void btnTiep_Tuc_Click(object sender, EventArgs e)
        {
            try
            {
                if (CCommon.suatChieuDuocChon != -1)
                {
                    //Lấy form chứa uc này ra
                    if (this.Parent is FluentDesignFormContainer v_objContainer)
                    {
                        ucChonGhe v_objUC_Chon_Ghe = new ucChonGhe();

                        // Nếu UserControl đã có trong mainContainer thì đưa nó lên trước
                        if (v_objContainer.Controls.Contains(v_objUC_Chon_Ghe) == false)
                        {

                            // Clear toàn bộ những gì trên container
                            v_objContainer.Controls.Clear();

                            // Dock control vào container để nó chiếm toàn bộ diện tích
                            v_objUC_Chon_Ghe.Dock = DockStyle.Fill;

                            // Thêm UserControl vào main container
                            v_objContainer.Controls.Add(v_objUC_Chon_Ghe);
                            v_objUC_Chon_Ghe.Load_DataBase(sender, e);
                        }
                    }
                }
                else
                {
                    throw new Exception("Vui lòng chọn phim và 1 suất chiếu hiện có trong danh sách để tiếp tục");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpDate_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Cập nhật lại danh sách các phim được chiếu trong ngày
                dgvMovies.Refresh();
                dgvMovies.DataSource = moiveBus.GetMovies_ByScheduleDate((DateTime)dtpDate.EditValue);

                // Hủy chọn suất chiếu trước đó do đổi ngày 
                CCommon.suatChieuDuocChon = -1;

                // Xóa thông tin suất chiếu trước đó do đổi ngày
                cboMovieSchedule.Properties.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dgvMovies_DataSourceChanged(object sender, EventArgs e)
        {
            // Đặt chiều cao dòng phù hợp với kích thước của hình ảnh
            //layoutView1.RowHeight = 150;

            var width_img = 100;
            // đặt chiều rộng cột hình ảnh
            layoutView1.Columns["MV_POSTERURL"].Width = width_img;

            // Đặt độ rộng tối thiểu và tối đa cho một cột cụ thể
            layoutView1.Columns["MV_POSTERURL"].MinWidth = width_img;
            layoutView1.Columns["MV_POSTERURL"].MaxWidth = width_img;

            // Vẽ thủ công hình ảnh hiển thị trên lưới 
            //layoutView1.CustomDrawCell += gridView1_CustomDrawCell;

            // Đặt tên tiếng Việt cho các cột
            layoutView1.Columns["MV_POSTERURL"].Caption = "Poster";
            layoutView1.Columns["MV_NAME"].Caption = "Tên Phim";
            layoutView1.Columns["MV_PRICE"].Caption = "Giá";
            layoutView1.Columns["MV_DESCRIPTION"].Caption = "Mô tả";
            layoutView1.Columns["MV_DURATION"].Caption = "Thời lượng";
            layoutView1.Columns["MV_AutoID"].Visible = false;
            layoutView1.Columns["MV_AGERATING_AutoID"].Visible = false;

            // Đặt VisibleIndex của cột MV_POSTERURL về 0 để chuyển nó lên vị trí đầu tiên
            layoutView1.Columns["MV_POSTERURL"].VisibleIndex = 0;

            // Chọn phim đầu tiên xuất hiện
            if (layoutView1.Columns.Count > 0)
                layoutView1.SelectRow(1);
        }

        private void gridControl1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int[] dong = layoutView1.GetSelectedRows();
            foreach (int i in dong)
            {
                if (i >= 0)
                {
                    try
                    {
                        string dgv_selected_id = layoutView1.GetRowCellValue(i, "MV_AutoID").ToString().Trim();
                        tbl_DM_Movie_DTO o = moiveBus.Find(long.Parse(dgv_selected_id));
                        tbl_DM_AgeRating_DTO foundAR = ageBus.Find((long)o.MV_AGERATING_AutoID);
                        txtThoiLuong.Text = o.MV_DURATION.ToString().Trim();
                        txtAgeRating.Text = foundAR.AR_NOTE.ToString().Trim();
                        cboMovieSchedule.Properties.DataSource = movieScheBus.GetMovieSchedule_ByMovieDate(o.MV_AutoID, (DateTime)dtpDate.EditValue);
                        cboMovieSchedule.ItemIndex = 0;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                }
            }
        }

        private void cboMovieSchedule_EditValueChanged(object sender, EventArgs e)
        {
            if (cboMovieSchedule.Properties.DataSource != null)
            {
                // Cập nhật suất chiếu đang được chọn lên nhánh chính
                CCommon.suatChieuDuocChon = (long)cboMovieSchedule.EditValue;
            }
            else
            {
                CCommon.suatChieuDuocChon = -1;
            }
        }
        public void SetupLayoutView()
        {
            // Set the card's minimum size.
            layoutView1.CardMinSize = new Size(300, 350);

            // Ngăn không cho phép sửa dữ liệu trực tiếp trên Layoutview
            layoutView1.OptionsBehavior.Editable = false;

            // Duyệt qua tất cả các cột và ẩn các cột không cần thiết
            foreach (LayoutViewColumn column in layoutView1.Columns)
            {
                // ẩn tất cả cột không cần thiết
                column.Visible = false;

                // tắt cái tiêu đề của field
                column.LayoutViewField.TextVisible = false;
            }

            // Tạo cột hình ảnh không có sẵn trong dữ liệu (Unbound)
            LayoutViewColumn hinhAnhColumn = layoutView1.Columns.AddField("PosterImage");
            // tắt cái tiêu đề của field
            hinhAnhColumn.LayoutViewField.TextVisible = false;
            hinhAnhColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            hinhAnhColumn.Visible = true;
            hinhAnhColumn.Caption = "Hình ảnh";

            // Thiết lập LayoutViewField cho cột hình ảnh
            LayoutViewField hinhAnhField = hinhAnhColumn.LayoutViewField;
            hinhAnhField.TextVisible = false;
            hinhAnhField.SizeConstraintsType = SizeConstraintsType.Default;

            // Thiết lập RepositoryItemPictureEdit để hiển thị hình ảnh
            RepositoryItemPictureEdit pictureEdit = new RepositoryItemPictureEdit();
            pictureEdit.SizeMode = PictureSizeMode.Zoom; // Thử chế độ Zoom thay vì Squeeze
            pictureEdit.PictureAlignment = ContentAlignment.MiddleCenter; // Căn giữa hình ảnh
            dgvMovies.RepositoryItems.Add(pictureEdit);
            hinhAnhColumn.ColumnEdit = pictureEdit;

            // Tìm cột MV_NAME và cấu hình nếu cột tồn tại
            LayoutViewColumn tenPhim = layoutView1.Columns.ColumnByFieldName("MV_NAME");
            if (tenPhim != null)
            {
                tenPhim.Visible = true;
                tenPhim.Caption = "Tên phim";
            }
            else
            {
                Console.WriteLine("Cột 'MV_NAME' không tồn tại trong LayoutView.");
            }
        }


        /// <summary>
        /// Thêm cột hình ảnh khi hiển thị card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void layoutView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "PosterImage" && e.IsGetData)
            {
                // Lấy đường dẫn từ cột MV_POSTERURL của bản ghi hiện tại
                string imagePath = layoutView1.GetRowCellValue(e.ListSourceRowIndex, "MV_POSTERURL")?.ToString();

                // Kiểm tra nếu file tồn tại
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    // Đọc hình ảnh từ đường dẫn
                    e.Value = Image.FromFile(imagePath);
                }
                else
                {
                    // Nếu không có hình ảnh, sử dụng hình ảnh mặc định
                    e.Value = Properties.Resources.picture_card_no_image;
                }
            }
        }

        private void dgvMovies_Click(object sender, EventArgs e)
        {
            int[] dong = layoutView1.GetSelectedRows();
            foreach (int i in dong)
            {
                if (i >= 0)
                {
                    try
                    {
                        string dgv_selected_id = layoutView1.GetRowCellValue(i, "MV_AutoID").ToString().Trim();
                        tbl_DM_Movie_DTO o = moiveBus.Find(long.Parse(dgv_selected_id));
                        tbl_DM_AgeRating_DTO foundAR = ageBus.Find((long)o.MV_AGERATING_AutoID);
                        txtTenPhim.Text = o.MV_NAME.ToString().Trim();
                        txtThoiLuong.Text = o.MV_DURATION.ToString().Trim();
                        txtAgeRating.Text = foundAR.AR_NOTE.ToString().Trim();
                        cboMovieSchedule.Properties.DataSource = movieScheBus.GetMovieSchedule_ByMovieDate(o.MV_AutoID, (DateTime)dtpDate.EditValue);
                        cboMovieSchedule.ItemIndex = 0;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                }
            }
        }
    }
}
