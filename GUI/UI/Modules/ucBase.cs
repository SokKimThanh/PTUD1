using BUS.Sys;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;
using DTO.Common;
using DTO.Custom;
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
    public partial class ucBase : DevExpress.XtraEditors.XtraUserControl
    {
        public long iAuto_ID { get; set; } = 0;

        public string strFunctionCode { get; set; } = "";

        public string strActive_User_Name { get; set; } = "";

        protected bool blIs_First_Load = false;

        public ucBase()
        {

        }

        /// <summary>
        /// Hàm này dùng để gán sự kiện load của uc 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Load_DataBase(object sender, EventArgs e)
        {
            try
            {
                strActive_User_Name = CCommon.MaDangNhap;
                if (blIs_First_Load == false)
                {
                    Load_FirstBase();
                    blIs_First_Load = true;
                }

                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Hàm này dùng để gán cho sự kiện nút thêm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Add_DataBase(object sender, EventArgs e)
        {
            try
            {
                Add_Data();
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Hàm này dùng để gán sự kiện cho nút cập nhật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Update_DataBase(object sender, EventArgs e)
        {
            try
            {
                Update_Data();

                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Hàm này dùng để gán sự kiện cho nút xóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Remove_DataBase(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show(LanguageController.GetLanguageDataLabel("Bạn có muốn xóa dòng dữ liệu này?"), LanguageController.GetLanguageDataLabel("Thông báo"), MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    RemoveData(iAuto_ID);
                    Load_Data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Hàm này dùng để load những gì cần load 1 lần
        /// </summary>
        protected virtual void Load_FirstBase()
        {

        }

        /// <summary>
        /// Hàm này dùng để xử lý sự kiện load
        /// </summary>
        protected virtual void Load_Data()
        {

        }

        /// <summary>
        /// Hàm này dùng để xử lý sự kiện update
        /// </summary>
        protected virtual void Update_Data()
        {

        }

        /// <summary>
        /// Hàm này dùng để xử lý sự kiện add
        /// </summary>
        protected virtual void Add_Data()
        {

        }

        /// <summary>
        /// Hàm này dùng để xử lý sự kiện xóa
        /// </summary>
        protected virtual void RemoveData(long iAuto_ID)
        {

        }

        protected void RowClick_Grid(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
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
                        ObjectProcessing(objSelectRow);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        protected virtual void ObjectProcessing(object obj)
        {

        }

        protected void Refresh_Load_DataBase(object sender, EventArgs e)
        {
            try
            {
                strActive_User_Name = CCommon.MaDangNhap;
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void FormatGridView(GridView objGrid)
        {
            List<string> arrDefaultCols = new List<string>()
            {
                "DELETED",
                "CREATED",
                "CREATED_BY",
                "CREATED_BY_FUNCTION",
                "UPDATED",
                "UPDATED_BY",
                "UPDATED_BY_FUNCTION",
            };

            // Danh sách các kiểu dữ liệu số đầy đủ
            List<Type> arrNum = new List<Type>
            {
                typeof(int),        // int (System.Int32)
                typeof(long),       // long (System.Int64)
                typeof(short),      // short (System.Int16)
                typeof(byte),       // byte (System.Byte)
                typeof(sbyte),      // sbyte (System.SByte)
                typeof(ushort),     // ushort (System.UInt16)
                typeof(uint),       // uint (System.UInt32)
                typeof(ulong),      // ulong (System.UInt64)
                typeof(float),      // float (System.Single)
                typeof(double),     // double (System.Double)
                typeof(decimal),    // decimal (System.Decimal)
                typeof(Int16),      // Int16 (System.Int16)
                typeof(Int32),      // Int32 (System.Int32)
                typeof(Int64),      // Int64 (System.Int64)
                typeof(UInt16),     // UInt16 (System.UInt16)
                typeof(UInt32),     // UInt32 (System.UInt32)
                typeof(UInt64)      // UInt64 (System.UInt64)
            };

            //Biến này dùng để tính toán độ rộng cho cột cuối
            int iTotalWidth = 0;

            //Duyệt qua danh sách các cột
            foreach (GridColumn objCol in objGrid.Columns)
            {
                //Kiểm tra xem tên cột có nằm trong danh sách ẩn mặc định k?
                if (arrDefaultCols.Contains(objCol.FieldName.Trim()) == true)
                    objCol.Visible = false; //Ẩn đi

                //Kiểm tra trạng thái ẩn
                if (objCol.Visible == false)
                    continue;

                //Không cần style cột này
                if (objCol.Name == "LastCol")
                    continue;

                //Lấy kiểu dữ liệu cột đó ra
                Type objColType = objCol.ColumnType;

                // Format dữ liệu cột
                if (arrNum.Contains(objColType) == true)
                {
                    // Định dạng số
                    objCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    objCol.DisplayFormat.FormatString = CConfig.Number_Format_String;

                    // Căn phải nội dung
                    objCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;

                    // Màu số (màu đỏ)
                    objCol.AppearanceCell.ForeColor = Color.Red;

                    // Nền màu vàng
                    objCol.AppearanceCell.BackColor = Color.Yellow;

                    //Độ rộng
                    objCol.Width = 80;

                    // Cấu hình tính tổng cho cột
                    objCol.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    objCol.SummaryItem.DisplayFormat = "{0:n3}";  // Định dạng hiển thị tổng (ví dụ: số nguyên)
                }
                else if (objColType == typeof(DateTime) || objColType == typeof(TimeSpan))
                {

                    // Định dạng
                    objCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    objCol.DisplayFormat.FormatString = CConfig.Date_Format_String;

                    // Căn phải nội dung
                    objCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;

                    //Độ rộng
                    objCol.Width = 120;
                }
                else
                {
                    // Định dạng
                    objCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.None;

                    // Căn phải nội dung
                    objCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;

                    //Độ rộng
                    objCol.Width = 200;
                }

                // Đặt font, cỡ chữ
                objCol.AppearanceCell.Font = new Font("Times New Roman", 10);

                //Chỉnh lại theo multilanguage
                objCol.Caption = LanguageController.GetLanguageDataLabel(objCol.Caption);
                iTotalWidth += objCol.Width;
            }

            //Nếu chưa tồn tại thì thêm vào
            if (objGrid.Columns.ColumnByName("LastCol") == null)
            {
                //Thêm cột cuối vào cho đẹp
                GridColumn objLastColumn = new GridColumn
                {
                    Name = "LastCol",
                    FieldName = "",
                    Visible = true
                };

                // Cho phép cột này mở rộng kích thước tự động
                objLastColumn.OptionsColumn.FixedWidth = false;  // Đảm bảo cột có thể thay đổi kích thước
                objLastColumn.MinWidth = 100;                    // Đặt chiều rộng tối thiểu cho cột

                int iWidthCol = objGrid.GridControl.ClientSize.Width - iTotalWidth - 77;

                // Đặt chiều rộng theo GridControl
                if (iWidthCol > 0)
                {
                    objLastColumn.Width = iWidthCol;
                    // Thêm cột vào GridControl

                    objGrid.Columns.Add(objLastColumn);

                }
            }


            // Cài đặt thuộc tính cho toàn bộ footer
            objGrid.Appearance.FooterPanel.BackColor = Color.LightSteelBlue;  // Màu nền của footer
            objGrid.Appearance.FooterPanel.ForeColor = Color.Black;           // Màu chữ của footer
            objGrid.Appearance.FooterPanel.Font = new Font("Times New Roman", 10, FontStyle.Bold);  // Font chữ cho footer
            objGrid.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;  // Căn phải toàn bộ footer

            //Các tùy chỉnh
            objGrid.OptionsView.ShowFooter = true;
            objGrid.OptionsSelection.MultiSelect = true;
            objGrid.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            objGrid.OptionsView.ColumnAutoWidth = false;
            objGrid.OptionsView.RowAutoHeight = true;
            objGrid.OptionsBehavior.AutoExpandAllGroups = true;
            objGrid.ScrollStyle = ScrollStyleFlags.LiveHorzScroll;
            objGrid.OptionsView.ShowIndicator = false;

            objGrid.OptionsBehavior.Editable = false;
        }
    }
}
