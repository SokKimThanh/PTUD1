using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI.Component
{
    /// <summary>
    /// Quản lý thuộc tính của barmanager
    /// </summary>
    public class BarManagerLayoutCustom
    {
        public BarManagerLayoutCustom() { }

        public BarManager BarManagerCustom { get; set; }

        /// <summary>
        /// Tùy chỉnh vô hiệu hóa chuột phải design mode trên menu
        /// </summary>
        /// <param name="barManager"></param>
        public void DisableCustomization()
        {
            // Vô hiệu hóa tùy chỉnh trên BarManager
            BarManagerCustom.AllowCustomization = false;
        } 

        /// <summary>
        /// Thanh công cụ chỉ có thể được cố định ở một vị trí cụ thể và không thể kéo
        /// </summary>
        /// <param name="barManager"></param>
        public void DisableMoving()
        {
            foreach (Bar bar in BarManagerCustom.Bars)
            {
                bar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top; // Chỉ cho phép dock ở trên
            }
        } 

    }
}
