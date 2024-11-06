using BUS.Sys;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
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
    public partial class ucChonPhim : ucBase
    {
        public ucChonPhim()
        {
            InitializeComponent();
        }

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
    }
}
