using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI.UI.ReportDesign
{
    public partial class RP_PrintTicket : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_PrintTicket()
        {
            InitializeComponent();
        }
        public void BindParameter(string parameter)
        {
            try
            {
                prmTicketID.Value = parameter;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
