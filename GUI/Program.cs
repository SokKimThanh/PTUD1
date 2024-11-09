using DTO.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Management;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int v_iStep = 0;
            try
            {
                v_iStep = 1;
                Auto_Connect_DB_By_ManagementObjectSearcher();

                v_iStep = 2;
                if (CConfig.CM_Cinema_DB_ConnectionString == "")
                    Auto_Connect_DB_By_SqlDataSourceEnumerator();

                v_iStep = 3;
                if (CConfig.CM_Cinema_DB_ConnectionString == "")
                    Auto_Connect_DB_Manual();

                v_iStep = 4;
                if (CConfig.CM_Cinema_DB_ConnectionString == "")
                    throw new Exception("Chuỗi kết nối không tồn tại. Đóng chương trình");

                v_iStep = 5;
                if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder) == false)
                    Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder);

                v_iStep = 6;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Step[{v_iStep}]: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        static void Auto_Connect_DB_By_ManagementObjectSearcher()
        {

            try
            {
                List<string> v_arrIntance = new List<string>();

                // Tạo một truy vấn WMI để tìm kiếm các dịch vụ SQL Server
                string v_strWin_Quey = "SELECT * FROM Win32_Service WHERE Name LIKE 'MSSQL$%' OR Name = 'MSSQLSERVER'";
                ManagementObjectSearcher v_objSearch = new ManagementObjectSearcher(v_strWin_Quey);

                string v_strServerName = Environment.MachineName;

                foreach (ManagementObject v_objService in v_objSearch.Get())
                {
                    // Lấy tên server và tên instance từ kết quả
                    string v_strService_Name = v_objService["Name"].ToString();

                    // Xác định instance mặc định hoặc instance được đặt tên
                    string v_strIntance = v_strService_Name.Equals("MSSQLSERVER") ? "" : v_strService_Name.Replace("MSSQL$", @"\");

                    // Xây dựng chuỗi kết nối với xác thực Windows (Integrated Security)
                    string v_strConnectionString = $"Server={v_strIntance};Database=CM_Cinema_DB;Integrated Security=True;";

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(v_strConnectionString))
                        {
                            conn.Open();

                            // Lưu chuỗi kết nối khi thành công
                            CConfig.CM_Cinema_DB_ConnectionString = v_strConnectionString;

                            conn.Close();
                            break; // Dừng lại nếu kết nối thành công
                        }
                    }
                    catch (Exception)
                    {
                    }
                }

                v_objSearch.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

        }

        static void Auto_Connect_DB_By_SqlDataSourceEnumerator()
        {
            try
            {
                SqlDataSourceEnumerator objSqlDataSoucre = SqlDataSourceEnumerator.Instance;
                DataTable dt = objSqlDataSoucre.GetDataSources(); //Lấy datasoucre

                foreach (DataRow row in dt.Rows)
                {
                    string strServerName = row["ServerName"].ToString();
                    string strInstanceName = row["InstanceName"].ToString();
                    string strFullServerName = "";
                    if (strInstanceName != null && strInstanceName.Trim() != "")
                        strFullServerName = strServerName.Trim();
                    else
                        strFullServerName = $"{strServerName}\\{strInstanceName}";

                    using (SqlConnection conn = new SqlConnection($"Server={strFullServerName};Database=CM_Cinema_DB;Integrated Security=True;"))
                    {
                        try
                        {
                            conn.Open();
                            conn.Close();
                            CConfig.CM_Cinema_DB_ConnectionString = conn.ConnectionString;
                            break;
                        }
                        catch (SqlException)
                        {

                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        static void Auto_Connect_DB_Manual()
        {
            // Tự động lấy tên máy chủ
            string strServerName = Environment.MachineName;
            if (strServerName == null || strServerName.Trim() == "")
                return;

            string v_strConnectionString = $"Server={strServerName};Database=CM_Cinema_DB;Integrated Security=True;";

            try
            {
                //Nếu không lấy đc chuỗi kết nối thì lấy từ file app config
                using (SqlConnection conn = new SqlConnection(v_strConnectionString))
                {
                    conn.Open();
                    conn.Close();

                    CConfig.CM_Cinema_DB_ConnectionString = v_strConnectionString;
                }
            }
            catch (Exception)
            {
                try
                {
                    // Nếu không kết nối được thì lấy từ app.config
                    CConfig.CM_Cinema_DB_ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CM_Cinema_DB"]?.ConnectionString;

                    if (string.IsNullOrEmpty(CConfig.CM_Cinema_DB_ConnectionString))
                        throw new Exception("Chuỗi kết nối không tồn tại trong app.config.");

                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
    }
}