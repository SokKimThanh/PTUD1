using DevExpress.XtraLayout;
using DevExpress.XtraPrinting.Export;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
