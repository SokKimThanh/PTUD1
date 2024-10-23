using BUS.Sys;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;
using DTO.Common;
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
            this.Load += Load_DataBase;
        }

        /// <summary>
        /// Hàm này dùng để gán sự kiện load của uc 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Load_DataBase(object sender, EventArgs e)
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
    }
}
