using System;

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
                prmTicketID.Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
