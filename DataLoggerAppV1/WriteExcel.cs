using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.CSharp;

namespace DataLoggerAppV1
{
    internal class WriteExcel
    {
        public static void writeExcel(string url, string[] Infor,
            string[] DataAi0,
            string[] DataAi1,
            string[] DataAi2,
            string[] DataAi3,
            string[] DataAi4,
            string[] DataAi5,
            string[] DataAi6,
            string[] DataAi7,
            bool SelectAi0,
            bool SelectAi1,
            bool SelectAi2,
            bool SelectAi3,
            bool SelectAi4,
            bool SelectAi5,
            bool SelectAi6,
            bool SelectAi7
            )

        {
            const string MyFileName = "ExcelTemplate.xlsx";
            string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var filePath = Path.Combine(execPath, MyFileName);
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets[3];

            // Write Customer information Value to Excel
            Range celRange = ws.Range["D2:G2"];
            string[] CustomerInfor = Infor;
            celRange.set_Value(XlRangeValueDataType.xlRangeValueDefault, CustomerInfor);

            // Write Ai Value to Excel
            int stt = 2;
            string range = "A" + stt + ":" + "C" + stt;
            Range WriteAiValue = ws.Range[range];

            if (SelectAi0)
            {
                WriteAiValue.set_Value(XlRangeValueDataType.xlRangeValueDefault, DataAi0);
                stt++;
                range = "A" + stt + ":" + "C" + stt;
                WriteAiValue = ws.Range[range];
            }
            if (SelectAi1)
            {
                WriteAiValue.set_Value(XlRangeValueDataType.xlRangeValueDefault, DataAi1);
                stt++;
                range = "A" + stt + ":" + "C" + stt;
                WriteAiValue = ws.Range[range];
            }
            if (SelectAi2)
            {
                WriteAiValue.set_Value(XlRangeValueDataType.xlRangeValueDefault, DataAi2);
                stt++;
                range = "A" + stt + ":" + "C" + stt;
                WriteAiValue = ws.Range[range];
            }
            if (SelectAi3)
            {
                WriteAiValue.set_Value(XlRangeValueDataType.xlRangeValueDefault, DataAi3);
                stt++;
                range = "A" + stt + ":" + "C" + stt;
                WriteAiValue = ws.Range[range];
            }
            if (SelectAi4)
            {
                WriteAiValue.set_Value(XlRangeValueDataType.xlRangeValueDefault, DataAi4);
                stt++;
                range = "A" + stt + ":" + "C" + stt;
                WriteAiValue = ws.Range[range];
            }
            if (SelectAi5)
            {
                WriteAiValue.set_Value(XlRangeValueDataType.xlRangeValueDefault, DataAi5);
                stt++;
                range = "A" + stt + ":" + "C" + stt;
                WriteAiValue = ws.Range[range];
            }
            if (SelectAi6)
            {
                WriteAiValue.set_Value(XlRangeValueDataType.xlRangeValueDefault, DataAi6);
                stt++;
                range = "A" + stt + ":" + "C" + stt;
                WriteAiValue = ws.Range[range];
            }
            if (SelectAi7)
            {
                WriteAiValue.set_Value(XlRangeValueDataType.xlRangeValueDefault, DataAi7);
                stt++;
                range = "A" + stt + ":" + "C" + stt;
                WriteAiValue = ws.Range[range];
            }

            // SaveAs Excel file
            try
            {
                wb.SaveAs(url);
                wb.Close();

                Process.Start(url);
                excel.Quit();
                MessageBox.Show("Export successful!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Some excel files is opened, please close excel files and try again!\nOr file path wrong!");
            }

        }
    }
}
