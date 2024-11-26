using DevExpress.XtraGrid.Views.Grid;

namespace GUI.UI.Component
{
    /// <summary>
    /// Quản lý thuộc tính của grid view 
    /// </summary>
    public class GridViewLayoutCustom
    {
        /// <summary>
        /// Tùy chỉnh hiển thị find panel trên grid view
        /// </summary>
        /// <param name="gridView"></param>
        public void ConfigureFindPanel(GridView gridView)
        {
            if (gridView == null) return;

            // Kích hoạt Find Panel
            gridView.OptionsFind.AlwaysVisible = true;

            // Hiển thị nút "Find"
            gridView.OptionsFind.ShowFindButton = true;

            // Hiển thị nút "Clear"
            gridView.OptionsFind.ShowClearButton = true;

            // Hiển thị nút "Close"
            gridView.OptionsFind.ShowCloseButton = true;

            // Hiển thị nút "Previous" và "Next"
            gridView.OptionsFind.ShowSearchNavButtons = true;

            // Đặt vị trí Find Panel (mặc định là cạnh trên của GridView)
            gridView.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;

            // Thiết lập văn bản mặc định trong ô tìm kiếm
            gridView.OptionsFind.FindNullPrompt = "Nhập nội dung để tìm kiếm...";
        }
    }
}
