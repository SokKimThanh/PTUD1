using DevExpress.XtraLayout;

namespace GUI.UI.Component
{
    /// <summary>
    /// Quản lý thuộc tính của layout control và các component kế thừa thuộc tính bên trong nó
    /// </summary>
    public class LayoutControlCustom
    {
        /// <summary>
        /// Tùy chỉnh vô hiệu hóa design mode menu con của layout control 
        /// </summary>
        /// <param name="container"></param>
        public void DisableLayoutCustomization(LayoutControl layoutControl)
        {
            layoutControl.AllowCustomization = false;
        }
    }
}
