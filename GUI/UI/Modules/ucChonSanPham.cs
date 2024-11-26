using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using DTO.tbl_DTO;
using DTO.Utility;
using GUI.UI.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucChonSanPham : ucBase
    {
        private List<tbl_DM_Product_DTO> m_arrSP_Chon = new List<tbl_DM_Product_DTO>();
        public string[] Danh_Sach_Ten_Ghe { get; set; }
        public double Tong_Tien_Ghe { get; set; }

        // Component grid view layout custom
        GridViewLayoutCustom gridViewLayoutCustom = new GridViewLayoutCustom();

        // Component Barmanager menu layout custom
        BarManagerLayoutCustom barManagerLayoutCustom = new BarManagerLayoutCustom();

        // Component layout allow show/hide control menu customize
        LayoutControlCustom layoutControlCustom = new LayoutControlCustom();
        public ucChonSanPham()
        {
            InitializeComponent();
            lblTitle.Text = "Thêm sản phẩm".ToUpper();
        }

        protected override void Load_Data()
        {
            //Load danh sách sản phẩm
            tbl_DM_Product_BUS v_objProductBus = new tbl_DM_Product_BUS();
            gridControl1.DataSource = v_objProductBus.GetAll();

            //Lưới chọn sản phẩm
            grdChon_San_Pham.Columns["PD_AutoID"].Visible = false;
            grdChon_San_Pham.Columns["PD_NAME"].Caption = LanguageController.GetLanguageDataLabel("Tên");
            grdChon_San_Pham.Columns["PD_IMAGEURL"].Caption = LanguageController.GetLanguageDataLabel("Hình ảnh");
            grdChon_San_Pham.Columns["PD_QUANTITY"].Caption = LanguageController.GetLanguageDataLabel("Số lượng");
            grdChon_San_Pham.Columns["PD_PRICE"].Caption = LanguageController.GetLanguageDataLabel("Giá");

            grdChon_San_Pham.RowClick += RowClick_Grid;

            FormatGridView(grdChon_San_Pham);

            //Lưới hiển thị sản phẩm chọn
            gridControl2.DataSource = m_arrSP_Chon;
            grdHien_Thi_San_Pham.RowClick += RowClick_GridHTSP;
            grdHien_Thi_San_Pham.Columns["PD_AutoID"].Visible = false;
            grdHien_Thi_San_Pham.Columns["PD_NAME"].Caption = LanguageController.GetLanguageDataLabel("Tên");
            grdHien_Thi_San_Pham.Columns["PD_IMAGEURL"].Caption = LanguageController.GetLanguageDataLabel("Hình ảnh");
            grdHien_Thi_San_Pham.Columns["PD_QUANTITY"].Caption = LanguageController.GetLanguageDataLabel("Số lượng");
            grdHien_Thi_San_Pham.Columns["PD_PRICE"].Caption = LanguageController.GetLanguageDataLabel("Giá");
            FormatGridView(grdHien_Thi_San_Pham);

            // Ngăn không cho phép chỉnh sửa trực tiếp trên GridView
            grdChon_San_Pham.OptionsBehavior.Editable = false;

            // Ngăn không cho phép chỉnh sửa trực tiếp trên GridView
            grdHien_Thi_San_Pham.OptionsBehavior.Editable = false;

            barManagerLayoutCustom.BarManagerCustom = barManager1;

            // Tùy chỉnh hiển thị find panel trên grid view
            gridViewLayoutCustom.ConfigureFindPanel(grdChon_San_Pham);

            // Tùy chỉnh hiển thị find panel trên grid view
            gridViewLayoutCustom.ConfigureFindPanel(grdHien_Thi_San_Pham);

            // Tùy chỉnh vô hiệu hóa chuột phải design mode trên menu
            barManagerLayoutCustom.DisableCustomization();

            // Tùy chỉnh vô hiệu hóa kéo thu nhỏ di chuyển menu
            barManagerLayoutCustom.DisableMoving();

            // Tùy chỉnh vô hiệu hóa design mode menu con của layout control 
            layoutControlCustom.DisableLayoutCustomization(layoutForm);
        }


        /// <summary>
        /// Xử lý khi chọn sản phẩm
        /// </summary>
        /// <param name="obj"></param>
        protected override void ObjectProcessing(object obj)
        {
            tbl_DM_Product_DTO v_objEdit = obj as tbl_DM_Product_DTO;
            if (v_objEdit != null)
            {
                tbl_DM_Product_DTO v_objRes = new tbl_DM_Product_DTO();
                CUtility.Clone_Entity(v_objEdit, v_objRes);

                v_objRes.PD_QUANTITY = 0;

                m_arrSP_Chon.Add(v_objRes);

                gridControl2.DataSource = m_arrSP_Chon;
                grdHien_Thi_San_Pham.Columns["PD_AutoID"].Visible = false;
                grdHien_Thi_San_Pham.Columns["PD_NAME"].Caption = LanguageController.GetLanguageDataLabel("Tên");
                grdHien_Thi_San_Pham.Columns["PD_IMAGEURL"].Caption = LanguageController.GetLanguageDataLabel("Hình ảnh");
                grdHien_Thi_San_Pham.Columns["PD_QUANTITY"].Caption = LanguageController.GetLanguageDataLabel("Số lượng");
                grdHien_Thi_San_Pham.Columns["PD_PRICE"].Caption = LanguageController.GetLanguageDataLabel("Giá");
                FormatGridView(grdHien_Thi_San_Pham);
            }

        }

        private int v_iRow_Select = -1;

        private void RowClick_GridHTSP(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                // Cast sender về GridView
                GridView objGridView = sender as DevExpress.XtraGrid.Views.Grid.GridView;

                if (objGridView != null)
                {
                    // Lấy dữ liệu của hàng hiện tại (hàng được chọn)
                    object objSelectRow = objGridView.GetRow(objGridView.FocusedRowHandle);

                    if (objSelectRow != null)
                    {
                        v_iRow_Select = objGridView.FocusedRowHandle;
                        txtSo_Luong.Text = (objSelectRow as tbl_DM_Product_DTO).PD_QUANTITY.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Hủy thì trả về màn hình trước đó
            try
            {
                //Lấy form chứa uc này ra
                if (this.Parent is FluentDesignFormContainer v_objContainer)
                {
                    ucChonThanhToan v_objLoad = new ucChonThanhToan();

                    if (v_objContainer.Controls.Contains(v_objLoad) == false)
                    {
                        // Clear toàn bộ những gì trên container
                        v_objContainer.Controls.Clear();

                        // Dock control vào container để nó chiếm toàn bộ diện tích
                        v_objLoad.Dock = DockStyle.Fill;

                        // Thêm UserControl vào main container
                        v_objContainer.Controls.Add(v_objLoad);

                        v_objLoad.Load_DataBase(sender, e);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXac_Nhan_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy form chứa uc này ra
                if (this.Parent is FluentDesignFormContainer v_objContainer)
                {
                    ucChonThanhToan v_objLoad = new ucChonThanhToan();

                    if (v_objContainer.Controls.Contains(v_objLoad) == false)
                    {
                        // Clear toàn bộ những gì trên container
                        v_objContainer.Controls.Clear();

                        // Dock control vào container để nó chiếm toàn bộ diện tích
                        v_objLoad.Dock = DockStyle.Fill;

                        // Thêm UserControl vào main container
                        v_objContainer.Controls.Add(v_objLoad);

                        v_objLoad.Load_DataBase(sender, e);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<tbl_DM_Product_DTO> m_arrSP_Da_Chon = new List<tbl_DM_Product_DTO>();

        private void txtSo_Luong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị mới từ SpinEdit
                decimal newValue = ((DevExpress.XtraEditors.SpinEdit)sender).Value;

                if ((double)newValue < 0)
                {
                    ((DevExpress.XtraEditors.SpinEdit)sender).Value = 0;
                    return;
                }

                // Kiểm tra chỉ số hàng có hợp lệ trong DataGridView
                if (v_iRow_Select >= 0 && grdChon_San_Pham.IsValidRowHandle(v_iRow_Select))
                {
                    try
                    {
                        // Cập nhật giá trị cho cột mong muốn trong hàng đã chọn
                        grdHien_Thi_San_Pham.SetRowCellValue(v_iRow_Select, "PD_QUANTITY", newValue);

                        //Lấy hết dữ liệu trong data griview
                        m_arrSP_Da_Chon = gridControl2.DataSource as List<tbl_DM_Product_DTO>;

                        //Tiến hành sum lại
                        txtTong_Tien_San_Pham.Text = m_arrSP_Da_Chon.Sum(it => it.PD_PRICE * it.PD_QUANTITY).ToString();

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
