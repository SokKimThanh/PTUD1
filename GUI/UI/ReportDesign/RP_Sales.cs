using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
using DTO.Custom;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI.UI.ReportDesign
{
    public partial class RP_Sales : DevExpress.XtraReports.UI.XtraReport
    {
        private readonly string _connectionString;

        public RP_Sales()
        {
            InitializeComponent();

            // Mở form nhập kết nối
            //using (var connectionForm = new frmConnection())
            //{
            //    if (connectionForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        _connectionString = connectionForm.ConnectionString;
            //    }
            //    else
            //    {
            //        // Chuỗi kết nối mặc định
            //        _connectionString = CConfig.CM_Cinema_DB_ConnectionString;
            //    }
            //}

            // Kết nối với report
            //ConfigureDataSource();
        }

        private void ConfigureDataSource()
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new ArgumentException("Chuỗi kết nối không được rỗng.");
            }

            // Tạo một kết nối đến cơ sở dữ liệu
            SqlDataSource objSqlDataSoucre = new SqlDataSource(_connectionString);
            this.DataSource = objSqlDataSoucre;
        }

        public void Add(DateTime _startDate, DateTime _endDate)
        {
            // Truyền tham số vào báo cáo
            this.Parameters["RP_StartDate"].Value = _startDate;
            this.Parameters["RP_EndDate"].Value = _endDate;

            // Tắt field nhập parameter khi preview
            this.Parameters["RP_StartDate"].Visible = false;
            this.Parameters["RP_EndDate"].Visible = false;
        }
    }
}
