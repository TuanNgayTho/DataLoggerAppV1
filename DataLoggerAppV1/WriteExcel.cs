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
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using NetToolKit;
using System.Drawing.Printing;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Threading;

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
                //excel.Quit();
                MessageBox.Show("Export successful!");
            }
            catch (Exception e)
            {
                //MessageBox.Show("Some excel files is opened, please close excel files and try again!\nOr file path wrong!");
                MessageBox.Show(e.Message);
            }

        }
        public static void WriteReport(String Day1 ,String Day2) {

            float[] value_0 = new float[86400] ;
            float[] value_1 = new float[86400] ;
            float[] value_2 = new float[86400] ;
            float[] value_3 = new float[86400];
            float[] value_4 = new float[86400];
            float[] value_5 = new float[86400];
            float[] value_6 = new float[86400];
            float[] value_7 = new float[86400];
            string[][] array = new string[86400][];
            
            
            
            int[] chart = { 1,3,2,4};
           
            int temp;
            DateTime[] ts1 = new DateTime[86400];
            string url = "C:\\Users\\PC\\Downloads\\Certificate.xlsx";
            
            try
            {

                
                temp = 0;
                DateTime enteredDate;
                string server = "localhost";
                string database = "datalogger";
                string uid = "root";
                string password = "root";
                string constring = "server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

                MySqlConnection con = new MySqlConnection(constring);
                con.Open();


                var query = "select * from samples WHERE ts >='" + Day1 + "' AND ts <='" + Day2 + "'";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ts1[temp] = DateTime.Parse(reader["ts"].ToString());

                    value_0[temp] = Convert.ToInt32(float.Parse(reader["aivalue0"].ToString()) * 100) / 100F;
                    value_1[temp] = Convert.ToInt32(float.Parse(reader["aivalue1"].ToString()) * 100) / 100F;
                    value_2[temp] = Convert.ToInt32(float.Parse(reader["aivalue2"].ToString()) * 100) / 100F;
                    value_3[temp] = Convert.ToInt32(float.Parse(reader["aivalue3"].ToString()) * 100) / 100F;
                    value_4[temp] = Convert.ToInt32(float.Parse(reader["aivalue4"].ToString()) * 100) / 100F;
                    value_5[temp] = Convert.ToInt32(float.Parse(reader["aivalue5"].ToString()) * 100) / 100F;
                    value_6[temp] = Convert.ToInt32(float.Parse(reader["aivalue6"].ToString()) * 100) / 100F;
                    value_7[temp] = Convert.ToInt32(float.Parse(reader["aivalue7"].ToString()) * 100) / 100F;
                    //System.Windows.MessageBox.Show("ok");
                    

                    temp++;
                }
                con.Close();

                Array.Clear(array, 0, temp);
                const string MyFileName = "report.xlsx";
                string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                var filePath = Path.Combine(execPath, MyFileName);
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb;
                Worksheet ws;

                wb = excel.Workbooks.Open(filePath);
                ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets[3];

                // Write Customer information Value to Excel
               

                // Write Ai Value to Excel
                int stt = 1;
                //for (int i = 0; i < 86400; i++)
                //{
                    

                //}

                if (temp != 0)
                {
                    string range;
                    Range WriteAiValue;
                     //array = new float[temp - 1][];

                    for (int i = 0; i < temp-1; i++)
                    {
                        array[i] = new string[9];
                        array[i][0] = value_0[i].ToString();
                        array[i][1] = value_1[i].ToString();
                        array[i][2] = value_2[i].ToString();
                        array[i][3] = value_3[i].ToString();
                        array[i][4] = value_4[i].ToString();
                        array[i][5] = value_5[i].ToString();
                        array[i][6] = value_6[i].ToString();
                        array[i][7] = value_7[i].ToString();
                        array[i][8] = ts1[i].ToString();
                        range = "A" + stt + ":" + "I" + stt;
                        WriteAiValue = ws.Range[range];

                        WriteAiValue.set_Value(XlRangeValueDataType.xlRangeValueDefault, array[i]);
                        stt++;
                    }

                    
                }
                //range = "B" + 2 + ":" + "B" + temp;
                //WriteAiValue = ws.Range[range];
                //WriteAiValue.set_Value(XlRangeValueDataType.xlRangeValueDefault, value_1);
                //range = "C" + 2 + ":" + "C" + temp;
                //WriteAiValue = ws.Range[range];
                //WriteAiValue.set_Value(XlRangeValueDataType.xlRangeValueDefault, value_2);


                wb.SaveAs(url);
                wb.Close();

                Process.Start(url);
                excel.Quit();
                MessageBox.Show("Export successful!");
            }

            
            catch (Exception e)
            {
                //MessageBox.Show("Some excel files is opened, please close excel files and try again!\nOr file path wrong!");
                MessageBox.Show(e.Message);
            }


        }
        public static void WriteReport_pdf(String Day1, String Day2)
        {

            float[] value_0 = new float[86400];
            float[] value_1 = new float[86400];
            float[] value_2 = new float[86400];
            float[] value_3 = new float[86400];
            float[] value_4 = new float[86400];
            float[] value_5 = new float[86400];
            float[] value_6 = new float[86400];
            float[] value_7 = new float[86400];
            string[][] array = new string[86400][];



            int[] chart = { 1, 3, 2, 4 };

            int temp;
            DateTime[] ts1 = new DateTime[86400];
            string url = "C:\\Users\\PC\\Downloads\\Certificate.xlsx";

            try
            {


                temp = 0;
                DateTime enteredDate;
                string server = "localhost";
                string database = "datalogger";
                string uid = "root";
                string password = "root";
                string constring = "server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

                MySqlConnection con = new MySqlConnection(constring);
                con.Open();


                var query = "select * from samples WHERE ts >='" + Day1 + "' AND ts <='" + Day2 + "'";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ts1[temp] = DateTime.Parse(reader["ts"].ToString());

                    value_0[temp] = Convert.ToInt32(float.Parse(reader["aivalue0"].ToString()) * 100) / 100F;
                    value_1[temp] = Convert.ToInt32(float.Parse(reader["aivalue1"].ToString()) * 100) / 100F;
                    value_2[temp] = Convert.ToInt32(float.Parse(reader["aivalue2"].ToString()) * 100) / 100F;
                    value_3[temp] = Convert.ToInt32(float.Parse(reader["aivalue3"].ToString()) * 100) / 100F;
                    value_4[temp] = Convert.ToInt32(float.Parse(reader["aivalue4"].ToString()) * 100) / 100F;
                    value_5[temp] = Convert.ToInt32(float.Parse(reader["aivalue5"].ToString()) * 100) / 100F;
                    value_6[temp] = Convert.ToInt32(float.Parse(reader["aivalue6"].ToString()) * 100) / 100F;
                    value_7[temp] = Convert.ToInt32(float.Parse(reader["aivalue7"].ToString()) * 100) / 100F;
                    //System.Windows.MessageBox.Show("ok");


                    temp++;
                }
                con.Close();


                Array.Clear(array, 0, temp);
                int stt = 1;


   

          

           
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show(ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(10);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            
                            pdfTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                            
                            pdfTable.AddCell("STT");
                            pdfTable.AddCell("Ai0");
                            pdfTable.AddCell("Ai1");
                            pdfTable.AddCell("Ai2");
                            pdfTable.AddCell("Ai3");
                            pdfTable.AddCell("Ai4");
                            pdfTable.AddCell("Ai5");
                            pdfTable.AddCell("Ai6");
                            pdfTable.AddCell("Ai7");
                            pdfTable.AddCell("Time");


                            for (int i = 0; i < temp - 1; i++)
                        {
                            array[i] = new string[9];
                            array[i][0] = value_0[i].ToString();
                            array[i][1] = value_1[i].ToString();
                            array[i][2] = value_2[i].ToString();
                            array[i][3] = value_3[i].ToString();
                            array[i][4] = value_4[i].ToString();
                            array[i][5] = value_5[i].ToString();
                            array[i][6] = value_6[i].ToString();
                            array[i][7] = value_7[i].ToString();
                            array[i][8] = ts1[i].ToString();
                                pdfTable.AddCell(i.ToString());
                                pdfTable.AddCell(array[i][0].ToString());
                                pdfTable.AddCell(array[i][1].ToString());
                                pdfTable.AddCell(array[i][2].ToString());
                                pdfTable.AddCell(array[i][3].ToString());
                                pdfTable.AddCell(array[i][4].ToString());
                                pdfTable.AddCell(array[i][5].ToString());
                                pdfTable.AddCell(array[i][6].ToString());
                                pdfTable.AddCell(array[i][7].ToString());
                                pdfTable.AddCell(array[i][8].ToString());


                            }

                        

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                         
                                pdfDoc.Open();
                                pdfDoc.Add(new Paragraph("EXPORT DATALOGGING"+"   "+DateTime.Now.ToString()));
                                pdfDoc.Add(new Paragraph("   "));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Export successful!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

            catch (Exception e)
            {
                //MessageBox.Show("Some excel files is opened, please close excel files and try again!\nOr file path wrong!");
                MessageBox.Show(e.Message);
            }
        }
    }
}
