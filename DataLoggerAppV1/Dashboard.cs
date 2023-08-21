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

        public static Dashboard instance;
        public Label AiDataCh0;
        public Label AiDataCh1;
        public Label AiDataCh2;
        public Label AiDataCh3;
        public Label AiDataCh4;
        public Label AiDataCh5;
        public Label AiDataCh6;
        public Label AiDataCh7;

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

            // Creat a new thread and then run method Connect PLC
            Thread t = new Thread(() =>
            {
                ConnectToPlc();
            });
            t.IsBackground = true;
            t.Start();
            
        }

        // Method Connect PLC and Read Data From PLC
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
                                plc.ReadClass(DbReadBool, 13);
                                Invoke(new Action(() =>
                                {
                                    //Button Status
                                    btnStream1.BackColor = DbReadBool.MStreamStatus1 ? Color.LightGreen : SystemColors.ControlLight;
                                    btnStream2.BackColor = DbReadBool.MStreamStatus2 ? Color.LightGreen : SystemColors.ControlLight;
                                    btnStream3.BackColor = DbReadBool.MStreamStatus3 ? Color.LightGreen : SystemColors.ControlLight;

                                    if (DbReadBool.ManAuto)
                                    {
                                        btnSart.Enabled = true;
                                        btnStream1.Enabled = false;
                                        btnStream2.Enabled = false;
                                        btnStream3.Enabled = false;
                                        btnManMode.BackColor = SystemColors.Control;
                                        btnAutoMode.BackColor = Color.LightGreen;
                                    }
                                    else
                                    {
                                        btnStream1.Enabled = true;
                                        btnStream2.Enabled = true;
                                        btnStream3.Enabled = true;
                                        btnSart.Enabled = false;
                                        btnAutoMode.BackColor = SystemColors.Control;
                                        btnManMode.BackColor = Color.LightBlue;
                                    }
                                    
                                    // System Status
                                    if (DbReadBool.SystemStatusAuto)
                                    {
                                        lblAlarmSystem.BackColor = Color.LightGreen;
                                    }
                                    else if (DbReadBool.SystemStatusMan)
                                    {
                                        lblAlarmSystem.BackColor = Color.LightBlue;
                                    }
                                    else if (DbReadBool.SystemStatusLowAlarm)
                                    {
                                        lblAlarmSystem.BackColor = Color.Gold;
                                    }
                                    else if (DbReadBool.SystemStatusHighAlarm)
                                    {
                                        lblAlarmSystem.BackColor = Color.LightCoral;
                                    }
                                    else
                                    {
                                        lblAlarmSystem.BackColor = SystemColors.ControlLight;
                                    }

                                    // System Running Status
                                    if (DbReadBool.SystemRunningAuto)
                                    {
                                        lblAlarmSystem.Text = "SYSTEM RUNNING (AUTO MODE)";
                                    }
                                    else if(DbReadBool.SystemRunningMan)
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
                                        //ModifyProgressBarColor.SetState(barAi0, progessBarYellow);
                                    }
                                    else if (DbReadBool.HighAlarm0 && lblAlarmAi0.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi0.BackColor = Color.LightCoral;
                                        barAi0.ForeColor = Color.LightCoral;
                                        //ModifyProgressBarColor.SetState(barAi0, progessBarRed);
                                    }
                                    else if (DbReadBool.HighAlarm0 == false && DbReadBool.LowAlarm0 ==false && lblAlarmAi0.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi0.BackColor = Color.LightGreen;
                                        barAi0.ForeColor = Color.LightGreen;
                                        //ModifyProgressBarColor.SetState(barAi0, progessBarGreen);
                                    }

                                    // Ai1 Status
                                    if (DbReadBool.LowAlarm1 && lblAlarmAi1.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi1.BackColor = Color.Gold;
                                        barAi1.ForeColor = Color.Gold;
                                        //ModifyProgressBarColor.SetState(barAi1, progessBarYellow);
                                    }
                                    else if (DbReadBool.HighAlarm1 && lblAlarmAi1.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi1.BackColor = Color.LightCoral;
                                        barAi1.ForeColor = Color.LightCoral;
                                        //ModifyProgressBarColor.SetState(barAi1, progessBarRed);
                                    }
                                    else if (DbReadBool.HighAlarm1 == false && DbReadBool.LowAlarm1 == false && lblAlarmAi1.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi1.BackColor = Color.LightGreen;
                                        barAi1.ForeColor = Color.LightGreen;
                                        //ModifyProgressBarColor.SetState(barAi1, progessBarGreen);
                                    }

                                    // Ai2 Status
                                    if (DbReadBool.LowAlarm2 && lblAlarmAi2.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi2.BackColor = Color.Gold;
                                        barAi2.ForeColor = Color.Gold;
                                        //ModifyProgressBarColor.SetState(barAi2, progessBarYellow);
                                    }
                                    else if (DbReadBool.HighAlarm2 && lblAlarmAi2.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi2.BackColor = Color.LightCoral;
                                        barAi2.ForeColor = Color.LightCoral;
                                        //ModifyProgressBarColor.SetState(barAi2, progessBarRed);
                                    }
                                    else if (DbReadBool.HighAlarm2 == false && DbReadBool.LowAlarm2 == false && lblAlarmAi2.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi2.BackColor = Color.LightGreen;
                                        barAi2.ForeColor = Color.LightGreen;
                                        //ModifyProgressBarColor.SetState(barAi2, progessBarGreen);
                                    }

                                    // Ai3 Status
                                    if (DbReadBool.LowAlarm3 && lblAlarmAi3.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi3.BackColor = Color.Gold;
                                        barAi3.ForeColor = Color.Gold;
                                        //ModifyProgressBarColor.SetState(barAi3, progessBarYellow);
                                    }
                                    else if (DbReadBool.HighAlarm3 && lblAlarmAi3.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi3.BackColor = Color.LightCoral;
                                        barAi3.ForeColor = Color.LightCoral;
                                        //ModifyProgressBarColor.SetState(barAi3, progessBarRed);
                                    }
                                    else if (DbReadBool.HighAlarm3 == false && DbReadBool.LowAlarm3 == false && lblAlarmAi3.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi3.BackColor = Color.LightGreen;
                                        barAi3.ForeColor = Color.LightGreen;
                                        //ModifyProgressBarColor.SetState(barAi3, progessBarGreen);
                                    }

                                    // Ai4 Status
                                    if (DbReadBool.LowAlarm4 && lblAlarmAi4.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi4.BackColor = Color.Gold;
                                        barAi4.ForeColor = Color.Gold;
                                        //ModifyProgressBarColor.SetState(barAi4, progessBarYellow);
                                    }
                                    else if (DbReadBool.HighAlarm4 && lblAlarmAi4.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi4.BackColor = Color.LightCoral;
                                        barAi4.ForeColor = Color.LightCoral;
                                        //ModifyProgressBarColor.SetState(barAi4, progessBarRed);
                                    }
                                    else if (DbReadBool.HighAlarm4 == false && DbReadBool.LowAlarm4 == false && lblAlarmAi4.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi4.BackColor = Color.LightGreen;
                                        barAi4.ForeColor = Color.LightGreen;
                                        //ModifyProgressBarColor.SetState(barAi4, progessBarGreen);
                                    }

                                    // Ai5 Status
                                    if (DbReadBool.LowAlarm5 && lblAlarmAi5.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi5.BackColor = Color.Gold;
                                        barAi5.ForeColor = Color.Gold;
                                        //ModifyProgressBarColor.SetState(barAi5, progessBarYellow);
                                    }
                                    else if (DbReadBool.HighAlarm5 && lblAlarmAi5.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi5.BackColor = Color.LightCoral;
                                        barAi5.ForeColor = Color.LightCoral;
                                        //ModifyProgressBarColor.SetState(barAi5, progessBarRed);
                                    }
                                    else if (DbReadBool.HighAlarm5 == false && DbReadBool.LowAlarm5 == false && lblAlarmAi5.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi5.BackColor = Color.LightGreen;
                                        barAi5.ForeColor = Color.LightGreen;
                                        //ModifyProgressBarColor.SetState(barAi5, progessBarGreen);
                                    }

                                    // Ai6 Status
                                    if (DbReadBool.LowAlarm6 && lblAlarmAi6.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi6.BackColor = Color.Gold;
                                        barAi6.ForeColor = Color.Gold;
                                        //ModifyProgressBarColor.SetState(barAi6, progessBarYellow);
                                    }
                                    else if (DbReadBool.HighAlarm6 && lblAlarmAi6.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi6.BackColor = Color.LightCoral;
                                        barAi6.ForeColor = Color.LightCoral;
                                        //ModifyProgressBarColor.SetState(barAi6, progessBarRed);
                                    }
                                    else if (DbReadBool.HighAlarm6 == false && DbReadBool.LowAlarm6 == false && lblAlarmAi6.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi6.BackColor = Color.LightGreen;
                                        barAi6.ForeColor = Color.LightGreen;
                                        //ModifyProgressBarColor.SetState(barAi6, progessBarGreen);
                                    }

                                    // Ai7 Status
                                    if (DbReadBool.LowAlarm7 && lblAlarmAi7.BackColor != Color.Gold)
                                    {
                                        lblAlarmAi7.BackColor = Color.Gold;
                                        barAi7.ForeColor = Color.Gold;
                                        //ModifyProgressBarColor.SetState(barAi7, progessBarYellow);
                                    }
                                    else if (DbReadBool.HighAlarm7 && lblAlarmAi7.BackColor != Color.LightCoral)
                                    {
                                        lblAlarmAi7.BackColor = Color.LightCoral;
                                        barAi7.ForeColor = Color.LightCoral;
                                        //ModifyProgressBarColor.SetState(barAi7, progessBarRed);
                                    }
                                    else if (DbReadBool.HighAlarm7 == false && DbReadBool.LowAlarm7 == false && lblAlarmAi7.BackColor != Color.LightGreen)
                                    {
                                        lblAlarmAi7.BackColor = Color.LightGreen;
                                        barAi7.ForeColor = Color.LightGreen;
                                        //ModifyProgressBarColor.SetState(barAi7, progessBarGreen);
                                    }
                                }));
                            }
                        }
                        catch (Exception e)
                        {
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
            var plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
            var result = plc.Open();
            try
            {
                if (result != ErrorCode.NoError)
                {
                    MessageBox.Show("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
                }
                else
                {
                    plc.Write("DB13.DBX0.0", true);
                }
            }
            catch (Exception exception)
            {
            }
            plc.Open();

        }

        // btn Stream 2
        private void button3_Click(object sender, EventArgs e)
        {
            var plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
            var result = plc.Open();
            try
            {
                if (result != ErrorCode.NoError)
                {
                    MessageBox.Show("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
                }
                else
                {
                    plc.Write("DB13.DBX0.1", true);
                }
            }
            catch (Exception exception)
            {
            }
            plc.Open();
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
            var plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
            var result = plc.Open();
            try
            {
                if (result != ErrorCode.NoError)
                {
                    MessageBox.Show("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
                }
                else
                {
                    plc.Write("DB3.DBX1.0", true);
                }
            }
            catch (Exception exception)
            {
            }
            plc.Open();
        }

        // btn Stream 3
        private void btnStream3_Click(object sender, EventArgs e)
        {
            var plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
            var result = plc.Open();
            try
            {
                if (result != ErrorCode.NoError)
                {
                    MessageBox.Show("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
                }
                else
                {
                    plc.Write("DB13.DBX0.2", true);
                }
            }
            catch (Exception exception)
            {
            }
            plc.Open();
        }

        // btn Auto Mode
        private void btnAutoMode_Click(object sender, EventArgs e)
        {
            var plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
            var result = plc.Open();
            try
            {
                if (result != ErrorCode.NoError)
                {
                    MessageBox.Show("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
                }
                else
                {
                    plc.Write("DB3.DBX1.1", true);
                }
            }
            catch (Exception exception)
            {
            }
            plc.Open();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            var plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
            var result = plc.Open();
            try
            {
                if (result != ErrorCode.NoError)
                {
                    MessageBox.Show("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
                }
                else
                {
                    plc.Write("DB3.DBX0.7", true);
                }
            }
            catch (Exception exception)
            {
            }
            plc.Open();
        }

        private void btnSart_Click(object sender, EventArgs e)
        {
            var plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
            var result = plc.Open();
            try
            {
                if (result != ErrorCode.NoError)
                {
                    MessageBox.Show("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
                }
                else
                {
                    plc.Write("DB3.DBX0.6", true);
                }
            }
            catch (Exception exception)
            {
            }
            plc.Open();
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
