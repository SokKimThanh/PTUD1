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
using GUI.UI.Component;

namespace GUI.UI.Modules
{
    public partial class ucChonPhim : ucBase
    {
        private tbl_DM_Movie_BUS moiveBus = new tbl_DM_Movie_BUS();
        private tbl_DM_AgeRating_BUS ageBus = new tbl_DM_AgeRating_BUS();
        private tbl_DM_MovieSchedule_BUS movieScheBus = new tbl_DM_MovieSchedule_BUS();

        // Component Barmanager menu layout custom
        BarManagerLayoutCustom barManagerLayoutCustom = new BarManagerLayoutCustom();

        // Component layout allow show/hide control menu customize
        LayoutControlCustom layoutControlCustom = new LayoutControlCustom();

        // Component layout view custom for template card
        CardViewLayoutCustom cardViewLayoutCustom = new CardViewLayoutCustom();

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


            barManagerLayoutCustom.BarManagerCustom = barManager1;

            // Tùy chỉnh vô hiệu hóa chuột phải design mode trên menu
            barManagerLayoutCustom.DisableCustomization();

            // Tùy chỉnh vô hiệu hóa kéo thu nhỏ di chuyển menu
            barManagerLayoutCustom.DisableMoving();

            // Tùy chỉnh vô hiệu hóa design mode menu con của layout control 
            layoutControlCustom.DisableLayoutCustomization(layoutForm);
        }
        private void LoadData()
        {
            //btnTiepTuc.Enabled = false;
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
            {
                layoutView1.SelectRow(1);
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

            cardViewLayoutCustom.LayoutView1 = layoutView1;
            cardViewLayoutCustom.GridControl1 = dgvMovies;
            cardViewLayoutCustom.ImageURLFieldName = "MV_POSTERURL";

            cardViewLayoutCustom.SizeDefault = new Size(600, 700);
            cardViewLayoutCustom.SetupLayoutView();

            cardViewLayoutCustom.SizeUpdate = new Size(350, 400);
            cardViewLayoutCustom.SizeFullField = new Size(350, 400);
            cardViewLayoutCustom.AddPhoto();

            // Tìm cột PD_NAME và cấu hình nếu cột tồn tại
            LayoutViewColumn tenSanPham = layoutView1.Columns.ColumnByFieldName("MV_NAME");
            if (tenSanPham != null)
            {
                tenSanPham.Visible = true;
                tenSanPham.Caption = "Tên phim";
            }
            else
            {
                Console.WriteLine("Cột 'MV_NAME' không tồn tại trong LayoutView.");
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
