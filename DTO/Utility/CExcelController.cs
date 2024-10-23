using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Utility
{
    public class CExcelController
    {
        private ExcelPackage objPakage = null;

        public CExcelController(ExcelPackage objPakage)
        {
            this.objPakage = objPakage;
        }

        public DataTable ListFromCellToColumn(int iSheet, string strCellFrom, string strColEnd)
        {
            DataTable dt = new DataTable();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            ExcelWorksheet v_excelWorksheet = objPakage.Workbook.Worksheets[iSheet];
            int iRowStart = v_excelWorksheet.Cells[strCellFrom].End.Row;
            int iColumnStart = v_excelWorksheet.Cells[strCellFrom].End.Column;
            int iRowEnd = v_excelWorksheet.Dimension.End.Row;
            strColEnd = strColEnd + iRowEnd.ToString();
            int iColumnEnd = v_excelWorksheet.Cells[strColEnd].End.Column;

            //doc tiêu đề làm Col name
            for (int i = iColumnStart; i <= iColumnEnd; i++)
                dt.Columns.Add(i.ToString());

            for (int i = iRowStart; i <= iRowEnd; i++)
            {
                var row = v_excelWorksheet.Cells[i, iColumnStart, i, iColumnEnd];
                DataRow v_Row = dt.NewRow();
                int v_intColumn = 0;
                for (int j = iColumnStart; j <= iColumnEnd; j++)
                {
                    v_Row[v_intColumn] = row[i, j].Value;
                    v_intColumn++;
                }
                dt.Rows.Add(v_Row);
            }

            return dt;
        }

        public DataTable ListFromCellToColumn(string p_strCell_From, string p_strCell_End)
        {
            //3.5 thi STT start sheet = 1,  > 3.5 thi = 0
            return ListFromCellToColumn(1, p_strCell_From, p_strCell_End);
        }
    }
}
