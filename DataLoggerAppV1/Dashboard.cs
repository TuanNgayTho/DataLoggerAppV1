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
using MySqlX.XDevAPI.Common;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Office.Interop.Excel;
using Action = System.Action;
using Label = System.Windows.Forms.Label;
using ToolTip = System.Windows.Forms.ToolTip;

namespace DataLoggerAppV1
{
    public partial class Dashboard : Form
    {
        byte progessBarGreen = 1;
        sbyte progessBarRed = 2;
        sbyte progessBarYellow = 3;

        static Plc DashBoardPlc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
        public static Dashboard instance;
        public Label AiDataCh0;
        public Label AiDataCh1;
        public Label AiDataCh2;
        public Label AiDataCh3;
        public Label AiDataCh4;
        public Label AiDataCh5;
        public Label AiDataCh6;
        public Label AiDataCh7;

        public static double DataAi0;
        public static double DataAi1;
        public static double DataAi2;
        public static double DataAi3;
        public static double DataAi4;
        public static double DataAi5;
        public static double DataAi6;
        public static double DataAi7;

        public static bool boolInletStream1;
        public static bool boolInletStream2;
        public static bool boolInletStream3;

        public static bool boolBypassStream1;
        public static bool boolBypassStream2;
        public static bool boolBypassStream3;
        public static bool isConnect;
        public static bool isStay = false;

        bool sttLowAlarm0 = false;
        bool sttLowAlarm1 = false;
        bool sttLowAlarm2 = false;
        bool sttLowAlarm3 = false;
        bool sttLowAlarm4 = false;
        bool sttLowAlarm5 = false;
        bool sttLowAlarm6 = false;
        bool sttLowAlarm7 = false;

        bool sttHighAlarm0 = false;
        bool sttHighAlarm1 = false;
        bool sttHighAlarm2 = false;
        bool sttHighAlarm3 = false;
        bool sttHighAlarm4 = false;
        bool sttHighAlarm5 = false;
        bool sttHighAlarm6 = false;
        bool sttHighAlarm7 = false;
        bool ReadyToCall = false;

        private short AiPercent0;
        private short AiPercent1;
        private short AiPercent2;
        private short AiPercent3;
        private short AiPercent4;
        private short AiPercent5;
        private short AiPercent6;
        private short AiPercent7;

        public Dashboard()
        {
            InitializeComponent();
            AiDataCh0 = lblAiDataCh0;
            AiDataCh1 = lblAiDataCh1;
            AiDataCh2 = lblAiDataCh2;
            AiDataCh3 = lblAiDataCh3;
            AiDataCh4 = lblAiDataCh4;
            AiDataCh5 = lblAiDataCh5;
            AiDataCh6 = lblAiDataCh6;
            AiDataCh7 = lblAiDataCh7;
            instance = this;

            //Creat a new thread and then run method Connect PLC
            Thread t1 = new Thread(() =>
            {
                WriteSampleToDatabase();
            });

            t1.IsBackground = true;


            if (MainForm.running == false)
            {
                ThreadDashBoard();
                t1.Start();
                MainForm.running = true;
            }
            else
            {
                MainForm.runningConnect = false;
            }

        }

        private void ThreadDashBoard()
        {
            Action onCompleted = () =>
            {
                MainForm.runningConnect = true;
                //MessageBox.Show(Convert.ToString(ReadyToCall));
                ThreadDashBoard();
            };

            //Creat a new thread and then run method Connect PLC
            Thread t = new Thread(() =>
            {
                try
                {
                    ConnectToPlc();
                }
                finally
                {
                    onCompleted();
                }
            });
            t.IsBackground = true;
            t.Start();
        }

        //Method Connect PLC and Read Data From PLC
        private void ConnectToPlc()
        {
            var IsRunning = MainForm.runningConnect;
            using (var dashBoardplc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1))
            {
                var i = 0;
                while (IsRunning)
                {
                    while (IsRunning)
                    {

                        dashBoardplc.Close(); dashBoardplc.Close();
                        var result = dashBoardplc.Open();
                        isConnect = dashBoardplc.IsConnected;
                        try
                        {
                            if (dashBoardplc.IsConnected == false)
                            {
                                if (i>5)
                                {
                                    MessageBox.Show("Error: DashBoard " + dashBoardplc.LastErrorCode + "\n" + dashBoardplc.LastErrorString);
                                    i = 0;
                                }
                                dashBoardplc.Close();
                                i += 1;
                                break;
                            }
                            else
                            {
                                i = 0;
                                // Read AI Data From PLC
                                var DbAiData = new DbAiData();
                                dashBoardplc.ReadClass(DbAiData, 4);
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


                                //Ai Data
                                DataAi0 = DbAiData.Ai0;
                                DataAi1 = DbAiData.Ai1;
                                DataAi2 = DbAiData.Ai2;
                                DataAi3 = DbAiData.Ai3;
                                DataAi4 = DbAiData.Ai4;
                                DataAi5 = DbAiData.Ai5;
                                DataAi6 = DbAiData.Ai6;
                                DataAi7 = DbAiData.Ai7;

                                // Read Setting Data From PLC
                                var DbSettingData = new DbSettingData();
                                dashBoardplc.ReadClass(DbSettingData, 1);
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

                                    lblHighAlarm0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh0 * 100) / 100F);
                                    lblHighAlarm1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh1 * 100) / 100F);
                                    lblHighAlarm2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh2 * 100) / 100F);
                                    lblHighAlarm3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh3 * 100) / 100F);
                                    lblHighAlarm4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh4 * 100) / 100F);
                                    lblHighAlarm5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh5 * 100) / 100F);
                                    lblHighAlarm6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh6 * 100) / 100F);
                                    lblHighAlarm7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh7 * 100) / 100F);

                                    lblMeasurementMinRange0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin0 * 100) / 100F);
                                    lblMeasurementMinRange1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin1 * 100) / 100F);
                                    lblMeasurementMinRange2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin2 * 100) / 100F);
                                    lblMeasurementMinRange3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin3 * 100) / 100F);
                                    lblMeasurementMinRange4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin4 * 100) / 100F);
                                    lblMeasurementMinRange5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin5 * 100) / 100F);
                                    lblMeasurementMinRange6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin6 * 100) / 100F);
                                    lblMeasurementMinRange7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin7 * 100) / 100F);

                                    lblMeasurementMaxRange0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax0 * 100) / 100F);
                                    lblMeasurementMaxRange1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax1 * 100) / 100F);
                                    lblMeasurementMaxRange2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax2 * 100) / 100F);
                                    lblMeasurementMaxRange3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax3 * 100) / 100F);
                                    lblMeasurementMaxRange4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax4 * 100) / 100F);
                                    lblMeasurementMaxRange5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax5 * 100) / 100F);
                                    lblMeasurementMaxRange6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax6 * 100) / 100F);
                                    lblMeasurementMaxRange7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax7 * 100) / 100F);
                                }));

                                // Read Bool Status Data From PLC
                                var DbReadBool = new DbReadBool();
                                dashBoardplc.ReadClass(DbReadBool, 13);

                                //Valve status
                                boolInletStream1 = DbReadBool.InletStream1;
                                boolInletStream2 = DbReadBool.InletStream2;
                                boolInletStream3 = DbReadBool.InletStream3;

                                boolBypassStream1 = DbReadBool.BypassStream1;
                                boolBypassStream2 = DbReadBool.BypassStream2;
                                boolBypassStream3 = DbReadBool.BypassStream3;

                                Invoke(new Action(() =>
                                {

                                    //Button Status
                                    btnStream1.BackColor = DbReadBool.MStreamStatus1 ? Color.LightGreen : SystemColors.ControlLight;
                                    btnStream2.BackColor = DbReadBool.MStreamStatus2 ? Color.LightGreen : SystemColors.ControlLight;
                                    btnStream3.BackColor = DbReadBool.MStreamStatus3 ? Color.LightGreen : SystemColors.ControlLight;

                                    if (DbReadBool.ManAuto && btnAutoMode.BackColor != Color.LightGreen)
                                    {
                                        btnAutoMode.BackColor = Color.LightGreen;
                                        btnManMode.BackColor = SystemColors.Control;
                                        btnSart.Enabled = true;
                                        btnStream1.Enabled = false;
                                        btnStream2.Enabled = false;
                                        btnStream3.Enabled = false;
                                    }
                                    else if (DbReadBool.ManAuto == false && btnManMode.BackColor != Color.LightBlue)
                                    {
                                        btnManMode.BackColor = Color.LightBlue;
                                        btnAutoMode.BackColor = SystemColors.Control;
                                        btnStream1.Enabled = true;
                                        btnStream2.Enabled = true;
                                        btnStream3.Enabled = true;
                                        btnSart.Enabled = false;
                                    }

                                    // System Status
                                    if (DbReadBool.SystemStatusAuto && lblAlarmSystem.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmSystem.BackColor = Color.LightGreen;
                                    }
                                    else if (DbReadBool.SystemStatusMan && lblAlarmSystem.BackColor != Color.LightBlue)
                                    {
                                        lblAlarmSystem.BackColor = Color.LightBlue;
                                    }
                                    else if (DbReadBool.SystemStatusLowAlarm && lblAlarmSystem.BackColor != Color.Gold)
                                    {
                                        lblAlarmSystem.BackColor = Color.Gold;
                                    }
                                    else if (DbReadBool.SystemStatusHighAlarm && lblAlarmSystem.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmSystem.BackColor = Color.LightCoral;
                                    }
                                    else if (DbReadBool.SystemStatusAuto == false && DbReadBool.SystemStatusMan == false && DbReadBool.SystemStatusLowAlarm == false && DbReadBool.SystemStatusHighAlarm == false && lblAlarmSystem.BackColor != SystemColors.ControlLight)
                                    {
                                        lblAlarmSystem.BackColor = SystemColors.ControlLight;
                                    }

                                    // System Running Status
                                    if (DbReadBool.SystemRunningAuto)
                                    {
                                        lblAlarmSystem.Text = "SYSTEM RUNNING (AUTO MODE)";
                                    }
                                    else if (DbReadBool.SystemRunningMan)
                                    {
                                        lblAlarmSystem.Text = "SYSTEM RUNNING (MAN MODE)";
                                    }
                                    else
                                    {
                                        lblAlarmSystem.Text = "SYSTEM STOPED";
                                    }
                                }));

                                Invoke(new Action(() =>
                                {
                                    // Ai0 Status
                                    if (DbReadBool.LowAlarm0 && lblAlarmAi0.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi0.BackColor = Color.Gold;
                                        barAi0.ForeColor = Color.Gold;
                                    }
                                    else if (DbReadBool.HighAlarm0 && lblAlarmAi0.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi0.BackColor = Color.LightCoral;
                                        barAi0.ForeColor = Color.LightCoral;
                                    }
                                    else if (DbReadBool.HighAlarm0 == false && DbReadBool.LowAlarm0 == false && lblAlarmAi0.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi0.BackColor = Color.LightGreen;
                                        barAi0.ForeColor = Color.LightGreen;
                                    }

                                    // Ai1 Status
                                    if (DbReadBool.LowAlarm1 && lblAlarmAi1.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi1.BackColor = Color.Gold;
                                        barAi1.ForeColor = Color.Gold;
                                    }
                                    else if (DbReadBool.HighAlarm1 && lblAlarmAi1.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi1.BackColor = Color.LightCoral;
                                        barAi1.ForeColor = Color.LightCoral;
                                    }
                                    else if (DbReadBool.HighAlarm1 == false && DbReadBool.LowAlarm1 == false && lblAlarmAi1.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi1.BackColor = Color.LightGreen;
                                        barAi1.ForeColor = Color.LightGreen;
                                    }

                                    // Ai2 Status
                                    if (DbReadBool.LowAlarm2 && lblAlarmAi2.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi2.BackColor = Color.Gold;
                                        barAi2.ForeColor = Color.Gold;
                                    }
                                    else if (DbReadBool.HighAlarm2 && lblAlarmAi2.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi2.BackColor = Color.LightCoral;
                                        barAi2.ForeColor = Color.LightCoral;
                                    }
                                    else if (DbReadBool.HighAlarm2 == false && DbReadBool.LowAlarm2 == false && lblAlarmAi2.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi2.BackColor = Color.LightGreen;
                                        barAi2.ForeColor = Color.LightGreen;
                                    }

                                    // Ai3 Status
                                    if (DbReadBool.LowAlarm3 && lblAlarmAi3.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi3.BackColor = Color.Gold;
                                        barAi3.ForeColor = Color.Gold;
                                    }
                                    else if (DbReadBool.HighAlarm3 && lblAlarmAi3.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi3.BackColor = Color.LightCoral;
                                        barAi3.ForeColor = Color.LightCoral;
                                    }
                                    else if (DbReadBool.HighAlarm3 == false && DbReadBool.LowAlarm3 == false && lblAlarmAi3.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi3.BackColor = Color.LightGreen;
                                        barAi3.ForeColor = Color.LightGreen;
                                    }

                                    // Ai4 Status
                                    if (DbReadBool.LowAlarm4 && lblAlarmAi4.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi4.BackColor = Color.Gold;
                                        barAi4.ForeColor = Color.Gold;
                                    }
                                    else if (DbReadBool.HighAlarm4 && lblAlarmAi4.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi4.BackColor = Color.LightCoral;
                                        barAi4.ForeColor = Color.LightCoral;
                                    }
                                    else if (DbReadBool.HighAlarm4 == false && DbReadBool.LowAlarm4 == false && lblAlarmAi4.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi4.BackColor = Color.LightGreen;
                                        barAi4.ForeColor = Color.LightGreen;
                                    }

                                    // Ai5 Status
                                    if (DbReadBool.LowAlarm5 && lblAlarmAi5.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi5.BackColor = Color.Gold;
                                        barAi5.ForeColor = Color.Gold;
                                    }
                                    else if (DbReadBool.HighAlarm5 && lblAlarmAi5.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi5.BackColor = Color.LightCoral;
                                        barAi5.ForeColor = Color.LightCoral;
                                    }
                                    else if (DbReadBool.HighAlarm5 == false && DbReadBool.LowAlarm5 == false && lblAlarmAi5.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi5.BackColor = Color.LightGreen;
                                        barAi5.ForeColor = Color.LightGreen;
                                    }

                                    // Ai6 Status
                                    if (DbReadBool.LowAlarm6 && lblAlarmAi6.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi6.BackColor = Color.Gold;
                                        barAi6.ForeColor = Color.Gold;
                                    }
                                    else if (DbReadBool.HighAlarm6 && lblAlarmAi6.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi6.BackColor = Color.LightCoral;
                                        barAi6.ForeColor = Color.LightCoral;
                                    }
                                    else if (DbReadBool.HighAlarm6 == false && DbReadBool.LowAlarm6 == false && lblAlarmAi6.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi6.BackColor = Color.LightGreen;
                                        barAi6.ForeColor = Color.LightGreen;
                                    }

                                    // Ai7 Status
                                    if (DbReadBool.LowAlarm7 && lblAlarmAi7.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi7.BackColor = Color.Gold;
                                        barAi7.ForeColor = Color.Gold;
                                    }
                                    else if (DbReadBool.HighAlarm7 && lblAlarmAi7.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi7.BackColor = Color.LightCoral;
                                        barAi7.ForeColor = Color.LightCoral;
                                    }
                                    else if (DbReadBool.HighAlarm7 == false && DbReadBool.LowAlarm7 == false && lblAlarmAi7.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi7.BackColor = Color.LightGreen;
                                        barAi7.ForeColor = Color.LightGreen;
                                    }

                                    WriteAlarmToDatabase(
                                        DbReadBool.LowAlarm0,
                                        DbReadBool.LowAlarm1,
                                        DbReadBool.LowAlarm2,
                                        DbReadBool.LowAlarm3,
                                        DbReadBool.LowAlarm4,
                                        DbReadBool.LowAlarm5,
                                        DbReadBool.LowAlarm6,
                                        DbReadBool.LowAlarm7,
                                        DbReadBool.HighAlarm0,
                                        DbReadBool.HighAlarm1,
                                        DbReadBool.HighAlarm2,
                                        DbReadBool.HighAlarm3,
                                        DbReadBool.HighAlarm4,
                                        DbReadBool.HighAlarm5,
                                        DbReadBool.HighAlarm6,
                                        DbReadBool.HighAlarm7
                                        );
                                }));
                            }
                        }
                        catch (Exception e)
                        {
                            dashBoardplc.Close();
                            Thread.Sleep(100);
                            //break;
                        }
                        dashBoardplc.Close();
                        if (MainForm.runningConnect == false)
                        {
                            break;
                        }
                        
                        //MessageBox.Show(Convert.ToString(IsRunning));
                    }
                    if (MainForm.runningConnect == false)
                    {
                        break;
                    }
                }
            }
        }


        private void WriteAlarmToDatabase(
            bool LowAlarm0,
            bool LowAlarm1,
            bool LowAlarm2,
            bool LowAlarm3,
            bool LowAlarm4,
            bool LowAlarm5,
            bool LowAlarm6,
            bool LowAlarm7,
            bool HighAlarm0,
            bool HighAlarm1,
            bool HighAlarm2,
            bool HighAlarm3,
            bool HighAlarm4,
            bool HighAlarm5,
            bool HighAlarm6,
            bool HighAlarm7
            )   
        {
            
            // Ai0 write LowAlarm to database
            if (LowAlarm0 == true && sttLowAlarm0 == false)
            {
                try
                {
                    writeAlarm(false, false, Properties.Settings.Default.NameAi0, 0);
                    sttLowAlarm0 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (LowAlarm0 == false && HighAlarm0 == false && sttLowAlarm0 == true)
            {
                try
                {
                    writeAlarm(false, true, Properties.Settings.Default.NameAi0, 0);
                    sttLowAlarm0 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai0 write HighAlarm to database
            if (HighAlarm0 == true && sttHighAlarm0 == false)
            {
                try
                {
                    writeAlarm(true, false, Properties.Settings.Default.NameAi0, 0);
                    sttHighAlarm0 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (HighAlarm0 == false && sttHighAlarm0 == true)
            {
                try
                {
                    writeAlarm(true, true, Properties.Settings.Default.NameAi0, 0);
                    sttHighAlarm0 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai1 write LowAlarm to database
            if (LowAlarm1 == true && sttLowAlarm1 == false)
            {
                try
                {
                    writeAlarm(false, false, Properties.Settings.Default.NameAi1, 1);
                    sttLowAlarm1 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (LowAlarm1 == false && HighAlarm1 == false && sttLowAlarm1 == true)
            {
                try
                {
                    writeAlarm(false, true, Properties.Settings.Default.NameAi1, 1);
                    sttLowAlarm1 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai1 write HighAlarm to database
            if (HighAlarm1 == true && sttHighAlarm1 == false)
            {
                try
                {
                    writeAlarm(true, false, Properties.Settings.Default.NameAi1, 1);
                    sttHighAlarm1 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (HighAlarm1 == false && sttHighAlarm1 == true)
            {
                try
                {
                    writeAlarm(true, true, Properties.Settings.Default.NameAi1, 1);
                    sttHighAlarm1 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai2 write LowAlarm to database
            if (LowAlarm2 == true && sttLowAlarm2 == false)
            {
                try
                {
                    writeAlarm(false, false, Properties.Settings.Default.NameAi2, 2);
                    sttLowAlarm2 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (LowAlarm2 == false && HighAlarm2 == false && sttLowAlarm2 == true)
            {
                try
                {
                    writeAlarm(false, true, Properties.Settings.Default.NameAi2, 2);
                    sttLowAlarm2 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai2 write HighAlarm to database
            if (HighAlarm2 == true && sttHighAlarm2 == false)
            {
                try
                {
                    writeAlarm(true, false, Properties.Settings.Default.NameAi2, 2);
                    sttHighAlarm2 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (HighAlarm2 == false && sttHighAlarm2 == true)
            {
                try
                {
                    writeAlarm(true, true, Properties.Settings.Default.NameAi2, 2);
                    sttHighAlarm2 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai3 write LowAlarm to database
            if (LowAlarm3 == true && sttLowAlarm3 == false)
            {
                try
                {
                    writeAlarm(false, false, Properties.Settings.Default.NameAi3, 3);
                    sttLowAlarm3 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (LowAlarm3 == false && HighAlarm3 == false && sttLowAlarm3 == true)
            {
                try
                {
                    writeAlarm(false, true, Properties.Settings.Default.NameAi3, 3);
                    sttLowAlarm3 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai3 write HighAlarm to database
            if (HighAlarm3 == true && sttHighAlarm3 == false)
            {
                try
                {
                    writeAlarm(true, false, Properties.Settings.Default.NameAi3, 3);
                    sttHighAlarm3 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (HighAlarm3 == false && sttHighAlarm3 == true)
            {
                try
                {
                    writeAlarm(true, true, Properties.Settings.Default.NameAi3, 3);
                    sttHighAlarm3 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai4 write LowAlarm to database
            if (LowAlarm4 == true && sttLowAlarm4 == false)
            {
                try
                {
                    writeAlarm(false, false, Properties.Settings.Default.NameAi4, 4);
                    sttLowAlarm4 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (LowAlarm4 == false && HighAlarm4 == false && sttLowAlarm4 == true)
            {
                try
                {
                    writeAlarm(false, true, Properties.Settings.Default.NameAi4, 4);
                    sttLowAlarm4 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai4 write HighAlarm to database
            if (HighAlarm4 == true && sttHighAlarm4 == false)
            {
                try
                {
                    writeAlarm(true, false, Properties.Settings.Default.NameAi4, 4);
                    sttHighAlarm4 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (HighAlarm4 == false && sttHighAlarm4 == true)
            {
                try
                {
                    writeAlarm(true, true, Properties.Settings.Default.NameAi4, 4);
                    sttHighAlarm4 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai5 write LowAlarm to database
            if (LowAlarm5 == true && sttLowAlarm5 == false)
            {
                try
                {
                    writeAlarm(false, false, Properties.Settings.Default.NameAi5, 5);
                    sttLowAlarm5 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (LowAlarm5 == false && HighAlarm5 == false && sttLowAlarm5 == true)
            {
                try
                {
                    writeAlarm(false, true, Properties.Settings.Default.NameAi5, 5);
                    sttLowAlarm5 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai5 write HighAlarm to database
            if (HighAlarm5 == true && sttHighAlarm5 == false)
            {
                try
                {
                    writeAlarm(true, false, Properties.Settings.Default.NameAi5, 5);
                    sttHighAlarm5 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (HighAlarm5 == false && sttHighAlarm5 == true)
            {
                try
                {
                    writeAlarm(true, true, Properties.Settings.Default.NameAi5, 5);
                    sttHighAlarm5 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai6 write LowAlarm to database
            if (LowAlarm6 == true && sttLowAlarm6 == false)
            {
                try
                {
                    writeAlarm(false, false, Properties.Settings.Default.NameAi6, 6);
                    sttLowAlarm6 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (LowAlarm6 == false && HighAlarm6 == false && sttLowAlarm6 == true)
            {
                try
                {
                    writeAlarm(false, true, Properties.Settings.Default.NameAi6, 6);
                    sttLowAlarm6 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai6 write HighAlarm to database
            if (HighAlarm6 == true && sttHighAlarm6 == false)
            {
                try
                {
                    writeAlarm(true, false, Properties.Settings.Default.NameAi6, 6);
                    sttHighAlarm6 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (HighAlarm6 == false && sttHighAlarm6 == true)
            {
                try
                {
                    writeAlarm(true, true, Properties.Settings.Default.NameAi6, 6);
                    sttHighAlarm6 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai7 write LowAlarm to database
            if (LowAlarm7 == true && sttLowAlarm7 == false)
            {
                try
                {
                    writeAlarm(false, false, Properties.Settings.Default.NameAi7, 7);
                    sttLowAlarm7 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (LowAlarm7 == false && HighAlarm7 == false && sttLowAlarm7 == true)
            {
                try
                {
                    writeAlarm(false, true, Properties.Settings.Default.NameAi7, 7);
                    sttLowAlarm7 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            // Ai7 write HighAlarm to database
            if (HighAlarm7 == true && sttHighAlarm7 == false)
            {
                try
                {
                    writeAlarm(true, false, Properties.Settings.Default.NameAi7, 7);
                    sttHighAlarm7 = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (HighAlarm7 == false && sttHighAlarm7 == true)
            {
                try
                {
                    writeAlarm(true, true, Properties.Settings.Default.NameAi7, 7);
                    sttHighAlarm7 = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            // Function write alarm
            void writeAlarm(bool alarmStatusColor, bool alarmStatus, string aiName, int aiChannel)
            {
                //Connect To Mysql
                string server = "localhost";
                string database = "datalogger";
                string uid = "root";
                string password = "root";
                string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;
                using (MySqlConnection con2 = new MySqlConnection(constring))
                {
                    con2.Open();
                    // write alarm to database
                    var query = "INSERT INTO alarmlist (ainame, aichannel, aivalue0, aivalue1, aivalue2, aivalue3, aivalue4, aivalue5, aivalue6, aivalue7, alarmstatuscolor, alarmstatus)" +
                    " VALUES ('" + aiName + "', " + aiChannel + ", " + DataAi0 + ", " + DataAi1 + ", " + DataAi2 + ", " + DataAi3 +
                    ", " + DataAi4 + ", " + DataAi5 + ", " + DataAi6 + ", " + DataAi7 + ", " + alarmStatusColor + ", " + alarmStatus + ");";

                    // Database write CMD
                    MySqlCommand cmd = new MySqlCommand(query, con2);
                    cmd.ExecuteNonQuery();
                    con2.Close();
                }
            }
        }

        private void WriteSampleToDatabase()
        {
            while (true)
            {
                if (isConnect == true)
                {
                    try
                    {
                        //Connect To Mysql
                        Thread.Sleep(Properties.Settings.Default.CycleTime);
                        string server = "localhost";
                        string database = "datalogger";
                        string uid = "root";
                        string password = "root";
                        string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;
                        using (MySqlConnection con = new MySqlConnection(constring))
                        {
                            con.Open();
                            var query = "INSERT INTO samples (aivalue0, aivalue1, aivalue2, aivalue3, aivalue4, aivalue5, aivalue6, aivalue7) " +
                            "VALUES (" + DataAi0 + ", " + DataAi1 + ", " + DataAi2 + "," + DataAi3 + ", " + DataAi4 + ", " + DataAi5 + ", " + DataAi6 + ", " + DataAi7 + ");";

                            // Database write CMD
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            try
                            {
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                }
                            }
                            catch (Exception e)
                            {
                            }
                            con.Close();
                        }
                    }
                    catch (Exception e)
                    {
                        Thread.Sleep(100);
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
            lblUnitAi0.Text = Properties.Settings.Default.UnitAi0;
            lblUnitAi1.Text = Properties.Settings.Default.UnitAi1;
            lblUnitAi2.Text = Properties.Settings.Default.UnitAi2;
            lblUnitAi3.Text = Properties.Settings.Default.UnitAi3;
            lblUnitAi4.Text = Properties.Settings.Default.UnitAi4;
            lblUnitAi5.Text = Properties.Settings.Default.UnitAi5;
            lblUnitAi6.Text = Properties.Settings.Default.UnitAi6;
            lblUnitAi7.Text = Properties.Settings.Default.UnitAi7;

            lblNameAi0.Text = Properties.Settings.Default.NameAi0;
            lblNameAi1.Text = Properties.Settings.Default.NameAi1;
            lblNameAi2.Text = Properties.Settings.Default.NameAi2;
            lblNameAi3.Text = Properties.Settings.Default.NameAi3;
            lblNameAi4.Text = Properties.Settings.Default.NameAi4;
            lblNameAi5.Text = Properties.Settings.Default.NameAi5;
            lblNameAi6.Text = Properties.Settings.Default.NameAi6;
            lblNameAi7.Text = Properties.Settings.Default.NameAi7;
        }

        // btn Stream 1
        private void button2_Click(object sender, EventArgs e)
        {
            DashBoardPlc.Open();
            DashBoardPlc.Write("DB13.DBX0.0", true);
            //DashBoardPlc.Close();
        }

        // btn Stream 2
        private void button3_Click(object sender, EventArgs e)
        {
            DashBoardPlc.Open();
            DashBoardPlc.Write("DB13.DBX0.1", true);
            //DashBoardPlc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CreaCertificate().ShowDialog();
        }

        private void label48_Click(object sender, EventArgs e)
        {
           
        }

        // btn Man Mode
        private void btnManAuto_Click(object sender, EventArgs e)
        {
            DashBoardPlc.Open();
            DashBoardPlc.Write("DB3.DBX1.0", true);
            //DashBoardPlc.Close();
        }

        // btn Stream 3
        private void btnStream3_Click(object sender, EventArgs e)
        {
            DashBoardPlc.Open();
            DashBoardPlc.Write("DB13.DBX0.2", true);
            //DashBoardPlc.Close();
        }

        // btn Auto Mode
        private void btnAutoMode_Click(object sender, EventArgs e)
        {
            DashBoardPlc.Open();
            DashBoardPlc.Write("DB3.DBX1.1", true);
            //DashBoardPlc.Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DashBoardPlc.Open();
            DashBoardPlc.Write("DB3.DBX0.7", true);
            //DashBoardPlc.Close();
        }

        private void btnSart_Click(object sender, EventArgs e)
        {
            DashBoardPlc.Open();
            DashBoardPlc.Write("DB3.DBX0.6", true);
            //DashBoardPlc.Close();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Dashboard_Leave(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
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
