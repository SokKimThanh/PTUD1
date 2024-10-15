using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DTO.Custom;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
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
            // Tự động lấy tên máy chủ
            string strServerName = Environment.MachineName;
            if (strServerName.Trim() == "")
                return;

            CConfig.CM_Cinema_DB_ConnectionString = $"Server={strServerName};Database=CM_Cinema_DB;Integrated Security=True;";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
