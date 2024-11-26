using BUS.Danh_Muc;
using DTO.Common;
using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Auto_Get_Connection_From_File();

                v_iStep = 2;
                if (CConfig.CM_Cinema_DB_ConnectionString == "")
                    Auto_Connect_DB_By_ManagementObjectSearcher();

                v_iStep = 3;
                if (CConfig.CM_Cinema_DB_ConnectionString == "")
                    Auto_Connect_DB_By_SqlDataSourceEnumerator();

                v_iStep = 4;
                if (CConfig.CM_Cinema_DB_ConnectionString == "")
                    Auto_Connect_DB_Manual();

                v_iStep = 5;
                if (CConfig.CM_Cinema_DB_ConnectionString == "")
                    throw new Exception("Chuỗi kết nối không tồn tại. Đóng chương trình");

                v_iStep = 6;
                CheckDatabaseExists();

                v_iStep = 7;
                Save_Connection();

                v_iStep = 8;
                Task.Run(() => Auto_Delete_Tiket());

                v_iStep = 9;
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
                    if (v_strIntance != "")
                    {
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

                    //Nếu không lấy đc chuỗi kết nối thì lấy từ file app config
                    using (SqlConnection conn = new SqlConnection(CConfig.CM_Cinema_DB_ConnectionString))
                    {
                        conn.Open();

                        conn.Close();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }

        static void CheckDatabaseExists()
        {
            string v_strQuery = "SELECT database_id FROM sys.databases WHERE name = @databaseName";

            using (SqlConnection v_conn = new SqlConnection(CConfig.CM_Cinema_DB_ConnectionString))
            using (SqlCommand v_cmd = new SqlCommand(v_strQuery, v_conn))
            {
                v_cmd.Parameters.AddWithValue("@databaseName", "CM_Cinema_DB");

                try
                {
                    v_conn.Open();
                    object v_objRes = v_cmd.ExecuteScalar();
                    if (v_objRes == null)
                        throw new Exception("Database không tồn tại.");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        static void Config_SqlExpress()
        {
            CConfig.CM_Cinema_DB_ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=CM_Cinema_DB;Integrated Security=True;Encrypt=False";
        }

        static void Auto_Get_Connection_From_File()
        {
            try
            {
                if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder) == false)
                    Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder);

                if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder + "\\ConnectionString\\") == false)
                    Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder + "\\ConnectionString\\");

                string strFileName = "connectionString.txt";
                string strFullFilePath = CConfig.CM_Cinema_FileManagement_Folder + "\\ConnectionString\\" + strFileName;

                //Tạo file nếu file không tồn tại
                if (File.Exists(strFullFilePath) == false)
                {
                    using (FileStream objFile = File.Create(strFullFilePath))
                    {

                    }
                }

                //Đọc thông tin file
                using (Stream objStream = File.Open(strFullFilePath, FileMode.Open))
                {
                    using (StreamReader objSR = new StreamReader(objStream, Encoding.UTF8))
                    {

                        string v_strConnection = objSR.ReadLine();
                        if (string.IsNullOrEmpty(v_strConnection) == false)
                        {
                            v_strConnection = v_strConnection.Trim();

                            //Nếu không lấy đc chuỗi kết nối thì lấy từ file app config
                            using (SqlConnection conn = new SqlConnection(v_strConnection))
                            {
                                conn.Open();
                                conn.Close();

                                CConfig.CM_Cinema_DB_ConnectionString = v_strConnection.Trim();
                            }
                        }
                    }
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        static void Save_Connection()
        {
            try
            {
                if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder) == false)
                    Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder);

                if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder + "\\ConnectionString\\") == false)
                    Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder + "\\ConnectionString\\");

                string strFileName = "connectionString.txt";
                string strFullFilePath = CConfig.CM_Cinema_FileManagement_Folder + "\\ConnectionString\\" + strFileName;

                //Tạo file nếu file không tồn tại
                if (File.Exists(strFullFilePath) == false)
                {
                    using (FileStream objFile = File.Create(strFullFilePath))
                    {

                    }
                }

                //Lưu thông tin chuỗi kết nối
                using (Stream objStream = File.Open(strFullFilePath, FileMode.Open))
                {
                    using (StreamWriter objSR = new StreamWriter(objStream, Encoding.UTF8))
                    {
                        objSR.WriteLine(CConfig.CM_Cinema_DB_ConnectionString);
                    }
                }


            }
            catch (Exception)
            {
                throw;
            }
        }


        private static async Task<int> Auto_Delete_Tiket()
        {
            await Task.Delay(1);
            DateTime v_dtmStart = DateTime.Now;
            try
            {
                tbl_DM_Bill_BUS v_objBill_Bus = new tbl_DM_Bill_BUS();
                tbl_DM_BillDetail_BUS v_objBill_Detail_BUS = new tbl_DM_BillDetail_BUS();
                tbl_DM_Ticket_BUS v_objTiket_BUS = new tbl_DM_Ticket_BUS();
                tbl_DM_Product_BUS v_objProduct_BUS = new tbl_DM_Product_BUS();
                tbl_DM_MovieSchedule_BUS v_objMovieSchedule_Bus = new tbl_DM_MovieSchedule_BUS();
                tbl_DM_Movie_BUS v_objMovie_Bus = new tbl_DM_Movie_BUS();

                foreach (tbl_DM_Bill_DTO v_objData in v_objBill_Bus.List_Data())
                {

                    //Tính tiền cần thanh toán dựa trên ghế và sản phẩm
                    v_objData.Bill_Detail = v_objBill_Detail_BUS.List_Data_By_Bill_ID(v_objData.BL_AutoID);
                    v_objData.Tiket = v_objTiket_BUS.List_Data_By_Bill_ID(v_objData.BL_AutoID);


                    double v_dblTong_Tien_SP = 0;
                    foreach (tbl_DM_BillDetail_DTO v_objBillDetail in v_objData.Bill_Detail)
                    {
                        tbl_DM_Product_DTO v_objSP = v_objProduct_BUS.Find(v_objBillDetail.BD_PRODUCT_AutoID);
                        if (v_objSP != null)
                        {
                            v_dblTong_Tien_SP += v_objSP.PD_PRICE * v_objBillDetail.BD_QUANTITY;
                        }
                    }


                    tbl_DM_Ticket_DTO v_objTiket = v_objData.Tiket.FirstOrDefault(it => it.BillID == v_objData.BL_AutoID);
                    if (v_objTiket != null)
                    {
                        //Lấy suất chiếu
                        double v_dblTong_Tien_Ve = 0;

                        tbl_DM_MovieSchedule_DTO v_objMovieSchedule = v_objMovieSchedule_Bus.GetLastMovieSchedule_ByID(v_objTiket.MovieScheID);
                        if (v_objMovieSchedule_Bus != null)
                        {
                            if ((DateTime.Now - v_objMovieSchedule.EndDate).TotalMilliseconds < 0)
                            {
                                continue;
                            }

                            //Lấy phim
                            tbl_DM_Movie_DTO v_objMovie = v_objMovie_Bus.Find(v_objMovieSchedule.Movie_AutoID);

                            if (v_objMovie != null)
                            {
                                v_dblTong_Tien_Ve = v_objData.Tiket.Count * v_objMovie.MV_PRICE;
                            }
                        }

                        //Tính dựa trên thực tế
                        if (v_dblTong_Tien_Ve + v_dblTong_Tien_SP > v_objData.BL_Total_Price)
                        {
                            //Tiến hành xóa theo hóa đơn
                            v_objBill_Bus.UpdateData(v_objData.BL_AutoID, (int)ETrang_Thai_ID.Huy);
                            v_objBill_Detail_BUS.RemoveData(v_objData.BL_AutoID, CCommon.MaDangNhap, "Auto_Delete");
                            v_objTiket_BUS.RemoveData_By_Bill_ID(v_objData.BL_AutoID, CCommon.MaDangNhap, "Auto_Delete");
                        }
                    }

                }

            }
            catch (Exception)
            {

            }

            return (DateTime.Now - v_dtmStart).Milliseconds;
        }
    }
}