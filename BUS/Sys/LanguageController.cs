using DAL;
using DTO.Common;
using DTO.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Sys
{
    public class LanguageController
    {
        public static string GetLanguageDataLabel(string strData)
        {
            tbl_Sys_Language objLanguage = null;

            using (CM_Cinema_DBDataContext objDB = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
            {

                switch (CCommon.LanguageType)
                {
                    case "vi-vn": // Tiếng Việt
                        objLanguage = objDB.tbl_Sys_Languages.FirstOrDefault(it => it.VN_Lang.ToLower() == strData.ToLower());
                        break;
                    case "en-us": // Tiếng Anh
                        objLanguage = objDB.tbl_Sys_Languages.FirstOrDefault(it => it.Eng_Lang.ToLower() == strData.ToLower());
                        break;
                    case "ja-jp": // Tiếng Nhật
                        objLanguage = objDB.tbl_Sys_Languages.FirstOrDefault(it => it.JP_Lang.ToLower() == strData.ToLower());
                        break;
                    case "ko-kr": // Tiếng Hàn
                        objLanguage = objDB.tbl_Sys_Languages.FirstOrDefault(it => it.KR_Lang.ToLower() == strData.ToLower());
                        break;
                    case "zh-cn": // Tiếng Trung (Giản thể)
                        objLanguage = objDB.tbl_Sys_Languages.FirstOrDefault(it => it.CN_Lang.ToLower() == strData.ToLower());
                        break;
                }
                //Nếu obj có khai báo thì check
                if (objLanguage != null)
                {
                    string strRes = "";

                    switch (CCommon.LanguageType)
                    {
                        case "vi-vn": // Tiếng Việt
                            strRes = objLanguage.VN_Lang;
                            break;
                        case "en-us": // Tiếng Anh
                            strRes = objLanguage.Eng_Lang;
                            break;
                        case "ja-jp": // Tiếng Nhật
                            strRes = objLanguage.JP_Lang;
                            break;
                        case "ko-kr": // Tiếng Hàn
                            strRes = objLanguage.KR_Lang;
                            break;
                        case "zh-cn": // Tiếng Trung (Giản thể)
                            strRes = objLanguage.CN_Lang;
                            break;
                    }

                    if (strRes != "")
                        return strRes;
                }

                //Trả về đúng dữ liệu ban đầu nếu không có khai báo
                return strData;
            }
        }

    }
}
