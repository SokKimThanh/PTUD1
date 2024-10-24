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
            //ConfigureDataSource();

            // Hiển thị form nhập chuỗi kết nối
            using (var connectionForm = new NhapChuoiKetNoiBaoCao())
            {
                if (connectionForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _connectionString = connectionForm.ConnectionString;
                }
                else
                {
                    // Nếu người dùng không nhập, sử dụng chuỗi kết nối mặc định
                    _connectionString = CConfig.CM_Cinema_DB_ConnectionString;
                }
            }

            // Gọi hàm cấu hình dữ liệu
            ConfigureDataSource();
        }

        private void ConfigureDataSource()
        {
            // Tạo một kết nối đến cơ sở dữ liệu
            SqlDataSource objSqlDataSoucre = new SqlDataSource(CConfig.CM_Cinema_DB_ConnectionString);

            // Tạo một query cho store procedure
            StoredProcQuery objStoreQuery = new StoredProcQuery("SalesQuery", "sp_GetSalesReport");

            // Thêm các tham số vào query (khớp với tham số của stored procedure)
            objStoreQuery.Parameters.Add(new QueryParameter("RP_StartDate", typeof(DateTime), this.Parameters["RP_StartDate"].Value));
            objStoreQuery.Parameters.Add(new QueryParameter("RP_EndDate", typeof(DateTime), this.Parameters["RP_EndDate"].Value));

            // Thêm query vào DataSource
            objSqlDataSoucre.Queries.Add(objStoreQuery);

            // Đặt DataSource cho báo cáo
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
