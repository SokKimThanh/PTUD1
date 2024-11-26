using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.UI.Component
{
    public class CardViewLayoutCustom
    {

        public string ImageURLFieldName { get; set; }

        public LayoutView LayoutView1 { get; set; }

        public GridControl GridControl1 { get; set; }

        public void SetupLayoutView()
        {
            // Set the card's minimum size.
            LayoutView1.CardMinSize = new Size(300, 350);
            LayoutView1.OptionsCustomization.AllowFilter = false;
            LayoutView1.OptionsCustomization.ShowGroupView = false;

            // Ngăn không cho phép sửa dữ liệu trực tiếp trên Layoutview
            LayoutView1.OptionsBehavior.Editable = false;

            // Duyệt qua tất cả các cột và ẩn các cột không cần thiết
            foreach (LayoutViewColumn column in LayoutView1.Columns)
            {
                // ẩn tất cả cột không cần thiết
                column.Visible = false;

                // tắt cái tiêu đề của field
                column.LayoutViewField.TextVisible = false;
            }

            LayoutView1.OptionsBehavior.AutoPopulateColumns = false;

            // Create columns.
            LayoutViewColumn colPhoto = LayoutView1.Columns.AddField("PhotoField");

            colPhoto.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            colPhoto.Visible = true;

            // Access corresponding card fields.
            LayoutViewField fieldPhoto = colPhoto.LayoutViewField;

            // Assign editors to card fields.
            RepositoryItemPictureEdit riPictureEdit = new RepositoryItemPictureEdit();
            riPictureEdit.SizeMode = PictureSizeMode.Zoom;
            riPictureEdit.PictureAlignment = ContentAlignment.MiddleCenter;

            GridControl1.RepositoryItems.Add(riPictureEdit);

            colPhoto.ColumnEdit = riPictureEdit;

            // Set the card's minimum size.
            LayoutView1.CardMinSize = new Size(150, 180);

            fieldPhoto.TextVisible = false;
            fieldPhoto.SizeConstraintsType = SizeConstraintsType.Custom;
            fieldPhoto.MaxSize = fieldPhoto.MinSize = new Size(150, 200);


            LayoutView1.CustomUnboundColumnData += LayoutView1_CustomUnboundColumnData;
        }
        /// <summary>
        /// Thêm cột hình ảnh khi hiển thị card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LayoutView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "PhotoField" && e.IsGetData)
            {
                // Lấy đường dẫn từ cột MV_POSTERURL của bản ghi hiện tại
                string imagePath = LayoutView1.GetRowCellValue(e.ListSourceRowIndex, ImageURLFieldName)?.ToString();

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
    }
}
