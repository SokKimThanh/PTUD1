using BUS.Sys;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DTO.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucCaiDat : ucBase
    {
        private List<string> m_arrPrinter_Name = new List<string>();
        public ucCaiDat()
        {
            InitializeComponent();

            // Lấy danh sách các máy in cài đặt trên hệ thống

            // Kiểm tra khả dụng của mỗi máy in
            foreach (string v_strPrinter in PrinterSettings.InstalledPrinters)
            {
                PrinterSettings printerSettings = new PrinterSettings();
                printerSettings.PrinterName = v_strPrinter;

                if (printerSettings.IsValid)
                {
                    cboMayIn.Properties.Items.Add(v_strPrinter);
                }
            }
        }

        private void cboNgonNgu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cboMayIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            CCommon.Printer_Name = cboMayIn.SelectedItem.ToString();
        }
    }
}
