using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
        }
        private void LoadData()
        {
            // tai du lieu dgv
            dgvMovies.DataSource = moiveBus.GetAll();
            dgvMovies.RefreshDataSource();

            // Đặt ngày chọn ban đầu
            dtpDate.EditValue = dtpDate.Properties.MinValue;

            // 
            cboMovieSchedule.Properties.DisplayMember = "StartDate";
            cboMovieSchedule.Properties.ValueMember = "AutoID";
            cboMovieSchedule.Properties.Columns.Add(new LookUpColumnInfo("AutoID", "Mã"));
            cboMovieSchedule.Properties.Columns.Add(new LookUpColumnInfo("StartDate", "Suất chiếu", 80,
                DevExpress.Utils.FormatType.DateTime, CConfig.Time_Format_String, true, DevExpress.Utils.HorzAlignment.Default));
            cboMovieSchedule.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            cboMovieSchedule.Properties.DisplayFormat.FormatString = CConfig.Time_Format_String;
        }

        // Phương thức khác
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            // Kiểm tra nếu cột hiện tại là cột chứa đường dẫn hình ảnh
            if (e.Column.FieldName == "MV_POSTERURL")
            {
                // Lấy đường dẫn từ ô hiện tại
                string imagePath = gvMovies.GetRowCellValue(e.RowHandle, e.Column).ToString();


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
                //Lấy form chứa uc này ra
                if (this.Parent is FluentDesignFormContainer v_objContainer)
                {
                    ucChonGhe v_objUC_Chon_Ghe = new ucChonGhe();

                    // Nếu UserControl đã có trong mainContainer thì đưa nó lên trước
                    if (v_objContainer.Controls.Contains(v_objUC_Chon_Ghe) == false)
                    {
                        CCommon.suatChieuDuocChon = (long)cboMovieSchedule.EditValue;

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
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMovies_Click(object sender, EventArgs e)
        {
            int[] dong = gvMovies.GetSelectedRows();
            foreach (int i in dong)
            {
                if (i >= 0)
                {
                    try
                    {
                        string dgv_selected_id = gvMovies.GetRowCellValue(i, "MV_AutoID").ToString().Trim();
                        tbl_DM_Movie_DTO o = moiveBus.Find(long.Parse(dgv_selected_id));
                        tbl_DM_AgeRating_DTO foundAR = ageBus.Find((long)o.MV_AGERATING_AutoID);
                        txtDuration.Text = o.MV_DURATION.ToString().Trim();
                        txtAgeRating.Text = foundAR.AR_NOTE.ToString().Trim();
                        cboMovieSchedule.Properties.DataSource = movieScheBus.GetMovieSchedule_ByMovie(o.MV_AutoID);
                        cboMovieSchedule.ItemIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                }
            }
        }

        private void dtpDate_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvMovies.DataSource = moiveBus.GetMovies_ByScheduleDate((DateTime)dtpDate.EditValue);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dgvMovies_DataSourceChanged(object sender, EventArgs e)
        {
            // Đặt chiều cao dòng phù hợp với kích thước của hình ảnh
            gvMovies.RowHeight = 150;

            var width_img = 100;
            // đặt chiều rộng cột hình ảnh
            gvMovies.Columns["MV_POSTERURL"].Width = width_img;

            // Đặt độ rộng tối thiểu và tối đa cho một cột cụ thể
            gvMovies.Columns["MV_POSTERURL"].MinWidth = width_img;
            gvMovies.Columns["MV_POSTERURL"].MaxWidth = width_img;

            // Vẽ thủ công hình ảnh hiển thị trên lưới 
            gvMovies.CustomDrawCell += gridView1_CustomDrawCell;

            // Đặt tên tiếng Việt cho các cột
            gvMovies.Columns["MV_POSTERURL"].Caption = "Poster";
            gvMovies.Columns["MV_NAME"].Caption = "Tên Phim";
            gvMovies.Columns["MV_PRICE"].Caption = "Giá";
            gvMovies.Columns["MV_DESCRIPTION"].Caption = "Mô tả";
            gvMovies.Columns["MV_DURATION"].Caption = "Thời lượng";
            gvMovies.Columns["MV_AutoID"].Visible = false;
            gvMovies.Columns["MV_AGERATING_AutoID"].Visible = false;
        }
    }
}
