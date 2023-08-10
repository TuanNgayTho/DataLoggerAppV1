using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProgressBar = System.Windows.Forms.ProgressBar;
using S7.Net;
using S7.Net.Types;

namespace DataLoggerAppV1
{
    public partial class Dashboard : Form
    {
        byte progessBarGreen = 1;
        sbyte progessBarRed = 2;
        sbyte progessBarYellow = 3;

        public Dashboard()
        {
            InitializeComponent();

            // Creat a new thread and then run method Connect PLC
            Thread t = new Thread(() =>
            {
                ConnectToPlc();
            });
            t.IsBackground = true;
            t.Start();
            
        }

        // Method Connect PLC
        private void ConnectToPlc()
        {
            using (var plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1))
            {
                while (true)
                {
                    plc.Close(); plc.Close(); plc.Close();
                    Thread.Sleep(200);
                    var result = plc.Open();
                    Thread.Sleep(800);

                    while (true)
                    {
                        try
                        {
                            if (result != ErrorCode.NoError)
                            {
                                MessageBox.Show("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
                                break;
                            }
                            else
                            {
                                //    Invoke(new Action(() =>
                                //    {
                                //        lblAiDataCh0.Text = Convert.ToString(Convert.ToInt32(((uint)plc.Read("DB4.DBD0.0")).ConvertToDouble() * 100) / 100F);
                                //        lblAiDataCh1.Text = Convert.ToString(Convert.ToInt32(((uint)plc.Read("DB4.DBD4.0")).ConvertToDouble() * 100) / 100F);
                                //        lblAiDataCh2.Text = Convert.ToString(Convert.ToInt32(((uint)plc.Read("DB4.DBD8.0")).ConvertToDouble() * 100) / 100F);
                                //        lblAiDataCh3.Text = Convert.ToString(Convert.ToInt32(((uint)plc.Read("DB4.DBD12.0")).ConvertToDouble() * 100) / 100F);
                                //        lblAiDataCh4.Text = Convert.ToString(Convert.ToInt32(((uint)plc.Read("DB4.DBD16.0")).ConvertToDouble() * 100) / 100F);
                                //        lblAiDataCh5.Text = Convert.ToString(Convert.ToInt32(((uint)plc.Read("DB4.DBD20.0")).ConvertToDouble() * 100) / 100F);
                                //        lblAiDataCh6.Text = Convert.ToString(Convert.ToInt32(((uint)plc.Read("DB4.DBD24.0")).ConvertToDouble() * 100) / 100F);
                                //        lblAiDataCh7.Text = Convert.ToString(Convert.ToInt32(((uint)plc.Read("DB4.DBD28.0")).ConvertToDouble() * 100) / 100F);

                                //        barStream1.Value = (ushort)plc.Read("DB4.DBW32.0");
                                //        barStream2.Value = (ushort)plc.Read("DB4.DBW34.0");
                                //        barStream3.Value = (ushort)plc.Read("DB4.DBW36.0");
                                //        barStream4.Value = (ushort)plc.Read("DB4.DBW38.0");
                                //        barStream5.Value = (ushort)plc.Read("DB4.DBW40.0");
                                //        barStream6.Value = (ushort)plc.Read("DB4.DBW42.0");
                                //        barStream7.Value = (ushort)plc.Read("DB4.DBW44.0");
                                //        barStream8.Value = (ushort)plc.Read("DB4.DBW46.0");

                                //    }));

                                // Read AI Data From PLC
                                var DbAiData = new DbAiData();
                                plc.ReadClass(DbAiData, 4);
                                Invoke(new Action(() =>
                                {
                                    lblAiDataCh0.Text = Convert.ToString(Convert.ToInt32(DbAiData.Ai0 * 100) / 100F);
                                    lblAiDataCh1.Text = Convert.ToString(Convert.ToInt32(DbAiData.Ai1 * 100) / 100F);
                                    lblAiDataCh2.Text = Convert.ToString(Convert.ToInt32(DbAiData.Ai2 * 100) / 100F);
                                    lblAiDataCh3.Text = Convert.ToString(Convert.ToInt32(DbAiData.Ai3 * 100) / 100F);
                                    lblAiDataCh4.Text = Convert.ToString(Convert.ToInt32(DbAiData.Ai4 * 100) / 100F);
                                    lblAiDataCh5.Text = Convert.ToString(Convert.ToInt32(DbAiData.Ai5 * 100) / 100F);
                                    lblAiDataCh6.Text = Convert.ToString(Convert.ToInt32(DbAiData.Ai6 * 100) / 100F);
                                    lblAiDataCh7.Text = Convert.ToString(Convert.ToInt32(DbAiData.Ai7 * 100) / 100F);

                                    barAi0.Value = DbAiData.AiPercent0;
                                    barAi1.Value = DbAiData.AiPercent1;
                                    barAi2.Value = DbAiData.AiPercent2;
                                    barAi3.Value = DbAiData.AiPercent3;
                                    barAi4.Value = DbAiData.AiPercent4;
                                    barAi5.Value = DbAiData.AiPercent5;
                                    barAi6.Value = DbAiData.AiPercent6;
                                    barAi7.Value = DbAiData.AiPercent7;
                                }));


                                // Read Setting Data From PLC
                                var DbSettingData = new DbSettingData();
                                plc.ReadClass(DbSettingData, 1);
                                Invoke(new Action(() =>
                                {
                                    lblLowAlarm0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow0 * 100) / 100F);
                                    lblLowAlarm1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow1 * 100) / 100F);
                                    lblLowAlarm2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow2 * 100) / 100F);
                                    lblLowAlarm3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow3 * 100) / 100F);
                                    lblLowAlarm4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow4 * 100) / 100F);
                                    lblLowAlarm5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow5 * 100) / 100F);
                                    lblLowAlarm6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow6 * 100) / 100F);
                                    lblLowAlarm7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow7 * 100) / 100F);

                                    lblHighAlarm0.Text =
                                        Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh0 * 100) / 100F);
                                    lblHighAlarm1.Text =
                                        Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh1 * 100) / 100F);
                                    lblHighAlarm2.Text =
                                        Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh2 * 100) / 100F);
                                    lblHighAlarm3.Text =
                                        Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh3 * 100) / 100F);
                                    lblHighAlarm4.Text =
                                        Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh4 * 100) / 100F);
                                    lblHighAlarm5.Text =
                                        Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh5 * 100) / 100F);
                                    lblHighAlarm6.Text =
                                        Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh6 * 100) / 100F);
                                    lblHighAlarm7.Text =
                                        Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh7 * 100) / 100F);
                                }));

                                Invoke(new Action(() =>
                                {
                                }));
                            }
                        }
                        catch (Exception e)
                        {
                            //MessageBox.Show("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
                            plc.Close(); plc.Close();
                            Thread.Sleep(100);
                            result = plc.Open();
                            Thread.Sleep(100);
                        }
                    }
                }
            }
        }

        


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label48_Click(object sender, EventArgs e)
        {

        }
    }
    //Function Color Progress Bar
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }


}
