using DTO.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
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
            List<string> arrServers = new List<string>();

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

            //// Tự động lấy tên máy chủ
            //string strServerName = Environment.MachineName;
            //if (strServerName.Trim() == "")
            //    return;

            //CConfig.CM_Cinema_DB_ConnectionString = $"Server={strServerName};Database=CM_Cinema_DB;Integrated Security=True;";

            //try
            //{
            //    //Nếu không lấy đc chuỗi kết nối thì lấy từ file app config
            //    using (SqlConnection conn = new SqlConnection(CConfig.CM_Cinema_DB_ConnectionString))
            //    {
            //        conn.Open();

            //        conn.Close();
            //    }
            //}
            //catch (Exception)
            //{
            //    CConfig.CM_Cinema_DB_ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CM_Cinema_DB"].ConnectionString;
            //}



            if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder) == false)
                Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}