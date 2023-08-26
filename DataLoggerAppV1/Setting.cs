using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DataLoggerAppV1
{
    public partial class Setting : Form
    {
        public static Setting instance;
        
        public static bool isStay = false;
        public static Plc plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
        public Setting()
        {
            InitializeComponent();
            instance = this;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Setting_Load(object sender, EventArgs e)
        {
            txbUnitAi0.Text = Properties.Settings.Default.UnitAi0;
            txbUnitAi1.Text = Properties.Settings.Default.UnitAi1;
            txbUnitAi2.Text = Properties.Settings.Default.UnitAi2;
            txbUnitAi3.Text = Properties.Settings.Default.UnitAi3;
            txbUnitAi4.Text = Properties.Settings.Default.UnitAi4;
            txbUnitAi5.Text = Properties.Settings.Default.UnitAi5;
            txbUnitAi6.Text = Properties.Settings.Default.UnitAi6;
            txbUnitAi7.Text = Properties.Settings.Default.UnitAi7;

            txbNameAi0.Text = Properties.Settings.Default.NameAi0;
            txbNameAi1.Text = Properties.Settings.Default.NameAi1;
            txbNameAi2.Text = Properties.Settings.Default.NameAi2;
            txbNameAi3.Text = Properties.Settings.Default.NameAi3;
            txbNameAi4.Text = Properties.Settings.Default.NameAi4;
            txbNameAi5.Text = Properties.Settings.Default.NameAi5;
            txbNameAi6.Text = Properties.Settings.Default.NameAi6;
            txbNameAi7.Text = Properties.Settings.Default.NameAi7;

            txbCycleTime.Text = Convert.ToString(Properties.Settings.Default.CycleTime / 1000);

            // Creat a new thread and then run method read from PLC
            Thread t = new Thread(() =>
            {
                ReadFromPlc();
            });
            t.IsBackground = true;
            t.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creat a new thread and then run method read from PLC
            Thread t1 = new Thread(() =>
            {
                WriteToPlc();
            });
            t1.IsBackground = true;
            t1.Start();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        // Read Setting Data
        private void ReadFromPlc()
        {
            using (plc)
            {
                plc.Close();
                Thread.Sleep(100);
                var result = plc.Open();
                Thread.Sleep(100);
                
                try
                {
                    if (result != ErrorCode.NoError)
                    {
                        MessageBox.Show("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
                    }
                    else
                    {
                        var DbSettingData = new DbSettingData();
                        plc.ReadClass(DbSettingData, 1);
                        Invoke(new Action(() =>
                        {
                            //Sensor min range
                            txbSensorMin0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMin0 * 100) / 100F);
                            txbSensorMin1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMin1 * 100) / 100F);
                            txbSensorMin2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMin2 * 100) / 100F);
                            txbSensorMin3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMin3 * 100) / 100F);
                            txbSensorMin4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMin4 * 100) / 100F);
                            txbSensorMin5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMin5 * 100) / 100F);
                            txbSensorMin6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMin6 * 100) / 100F);
                            txbSensorMin7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMin7 * 100) / 100F);

                            //Sensor max range
                            txbSensorMax0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMax0 * 100) / 100F);
                            txbSensorMax1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMax1 * 100) / 100F);
                            txbSensorMax2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMax2 * 100) / 100F);
                            txbSensorMax3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMax3 * 100) / 100F);
                            txbSensorMax4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMax4 * 100) / 100F);
                            txbSensorMax5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMax5 * 100) / 100F);
                            txbSensorMax6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMax6 * 100) / 100F);
                            txbSensorMax7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.SensorRangeMax7 * 100) / 100F);

                            //Measurement min range
                            txbMesurementMin0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin0 * 100) / 100F);
                            txbMesurementMin1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin1 * 100) / 100F);
                            txbMesurementMin2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin2 * 100) / 100F);
                            txbMesurementMin3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin3 * 100) / 100F);
                            txbMesurementMin4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin4 * 100) / 100F);
                            txbMesurementMin5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin5 * 100) / 100F);
                            txbMesurementMin6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin6 * 100) / 100F);
                            txbMesurementMin7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMin7 * 100) / 100F);

                            //Measurement max range
                            txbMesurementMax0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax0 * 100) / 100F);
                            txbMesurementMax1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax1 * 100) / 100F);
                            txbMesurementMax2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax2 * 100) / 100F);
                            txbMesurementMax3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax3 * 100) / 100F);
                            txbMesurementMax4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax4 * 100) / 100F);
                            txbMesurementMax5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax5 * 100) / 100F);
                            txbMesurementMax6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax6 * 100) / 100F);
                            txbMesurementMax7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.MeasureRangeMax7 * 100) / 100F);

                            //Offset
                            txbOffsetAi0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Offset0 * 100) / 100F);
                            txbOffsetAi1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Offset1 * 100) / 100F);
                            txbOffsetAi2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Offset2 * 100) / 100F);
                            txbOffsetAi3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Offset3 * 100) / 100F);
                            txbOffsetAi4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Offset4 * 100) / 100F);
                            txbOffsetAi5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Offset5 * 100) / 100F);
                            txbOffsetAi6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Offset6 * 100) / 100F);
                            txbOffsetAi7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Offset7 * 100) / 100F);

                            //Slope
                            txbSlopeAi0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Slope0 * 100) / 100F);
                            txbSlopeAi1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Slope1 * 100) / 100F);
                            txbSlopeAi2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Slope2 * 100) / 100F);
                            txbSlopeAi3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Slope3 * 100) / 100F);
                            txbSlopeAi4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Slope4 * 100) / 100F);
                            txbSlopeAi5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Slope5 * 100) / 100F);
                            txbSlopeAi6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Slope6 * 100) / 100F);
                            txbSlopeAi7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.Slope7 * 100) / 100F);

                            //Low Alarm
                            txbLowAlarm0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow0 * 100) / 100F);
                            txbLowAlarm1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow1 * 100) / 100F);
                            txbLowAlarm2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow2 * 100) / 100F);
                            txbLowAlarm3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow3 * 100) / 100F);
                            txbLowAlarm4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow4 * 100) / 100F);
                            txbLowAlarm5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow5 * 100) / 100F);
                            txbLowAlarm6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow6 * 100) / 100F);
                            txbLowAlarm7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmLow7 * 100) / 100F);

                            //High Alarm
                            tbxHighAlarm0.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh0 * 100) / 100F);
                            tbxHighAlarm1.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh1 * 100) / 100F);
                            tbxHighAlarm2.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh2 * 100) / 100F);
                            tbxHighAlarm3.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh3 * 100) / 100F);
                            tbxHighAlarm4.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh4 * 100) / 100F);
                            tbxHighAlarm5.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh5 * 100) / 100F);
                            tbxHighAlarm6.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh6 * 100) / 100F);
                            tbxHighAlarm7.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AlarmHigh7 * 100) / 100F);

                            //Vent Time
                            txbVentTime.Text = Convert.ToString(Convert.ToInt32(DbSettingData.VentTime * 100) / 100000F);

                            //Analysis Time
                            txbAnalysisTime.Text = Convert.ToString(Convert.ToInt32(DbSettingData.AnalysisTime * 100) / 100000F);
                        }));

                        // Read Disable Signal From PLC
                        var DbEnableSignal = new DbEnableSignal();
                        plc.ReadClass(DbEnableSignal, 19);
                        Invoke(new Action(() =>
                        {
                            cbxAi0.Checked = DbEnableSignal.DisconnectAi0;
                            cbxAi1.Checked = DbEnableSignal.DisconnectAi1;
                            cbxAi2.Checked = DbEnableSignal.DisconnectAi2;
                            cbxAi3.Checked = DbEnableSignal.DisconnectAi3;
                            cbxAi4.Checked = DbEnableSignal.DisconnectAi4;
                            cbxAi5.Checked = DbEnableSignal.DisconnectAi5;
                            cbxAi6.Checked = DbEnableSignal.DisconnectAi6;
                            cbxAi7.Checked = DbEnableSignal.DisconnectAi7;
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

        // Write Setting Data
        private void WriteToPlc()
        {
            using (var plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1))
            {
                plc.Close();
                Thread.Sleep(100);
                var result = plc.Open();
                Thread.Sleep(100);

                try
                {
                    if (result != ErrorCode.NoError)
                    {
                        MessageBox.Show("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
                    }
                    else
                    {
                        // Write Setting Data To PLC
                        var DbSettingData = new DbSettingData();
                        //Sensor min range
                        DbSettingData.SensorRangeMin0 = Convert.ToDouble(txbSensorMin0.Text);
                        DbSettingData.SensorRangeMin1 = Convert.ToDouble(txbSensorMin1.Text);
                        DbSettingData.SensorRangeMin2 = Convert.ToDouble(txbSensorMin2.Text);
                        DbSettingData.SensorRangeMin3 = Convert.ToDouble(txbSensorMin3.Text);
                        DbSettingData.SensorRangeMin4 = Convert.ToDouble(txbSensorMin4.Text);
                        DbSettingData.SensorRangeMin5 = Convert.ToDouble(txbSensorMin5.Text);
                        DbSettingData.SensorRangeMin6 = Convert.ToDouble(txbSensorMin6.Text);
                        DbSettingData.SensorRangeMin7 = Convert.ToDouble(txbSensorMin7.Text);

                        //Sensor max range
                        DbSettingData.SensorRangeMax0 = Convert.ToDouble(txbSensorMax0.Text);
                        DbSettingData.SensorRangeMax1 = Convert.ToDouble(txbSensorMax1.Text);
                        DbSettingData.SensorRangeMax2 = Convert.ToDouble(txbSensorMax2.Text);
                        DbSettingData.SensorRangeMax3 = Convert.ToDouble(txbSensorMax3.Text);
                        DbSettingData.SensorRangeMax4 = Convert.ToDouble(txbSensorMax4.Text);
                        DbSettingData.SensorRangeMax5 = Convert.ToDouble(txbSensorMax5.Text);
                        DbSettingData.SensorRangeMax6 = Convert.ToDouble(txbSensorMax6.Text);
                        DbSettingData.SensorRangeMax7 = Convert.ToDouble(txbSensorMax7.Text);

                        //Measurement min range
                        DbSettingData.MeasureRangeMin0 = Convert.ToDouble(txbMesurementMin0.Text);
                        DbSettingData.MeasureRangeMin1 = Convert.ToDouble(txbMesurementMin1.Text);
                        DbSettingData.MeasureRangeMin2 = Convert.ToDouble(txbMesurementMin2.Text);
                        DbSettingData.MeasureRangeMin3 = Convert.ToDouble(txbMesurementMin3.Text);
                        DbSettingData.MeasureRangeMin4 = Convert.ToDouble(txbMesurementMin4.Text);
                        DbSettingData.MeasureRangeMin5 = Convert.ToDouble(txbMesurementMin5.Text);
                        DbSettingData.MeasureRangeMin6 = Convert.ToDouble(txbMesurementMin6.Text);
                        DbSettingData.MeasureRangeMin7 = Convert.ToDouble(txbMesurementMin7.Text);

                        //Measurement max range
                        DbSettingData.MeasureRangeMax0 = Convert.ToDouble(txbMesurementMax0.Text);
                        DbSettingData.MeasureRangeMax1 = Convert.ToDouble(txbMesurementMax1.Text);
                        DbSettingData.MeasureRangeMax2 = Convert.ToDouble(txbMesurementMax2.Text);
                        DbSettingData.MeasureRangeMax3 = Convert.ToDouble(txbMesurementMax3.Text);
                        DbSettingData.MeasureRangeMax4 = Convert.ToDouble(txbMesurementMax4.Text);
                        DbSettingData.MeasureRangeMax5 = Convert.ToDouble(txbMesurementMax5.Text);
                        DbSettingData.MeasureRangeMax6 = Convert.ToDouble(txbMesurementMax6.Text);
                        DbSettingData.MeasureRangeMax7 = Convert.ToDouble(txbMesurementMax7.Text);

                        //Offset
                        DbSettingData.Offset0 = Convert.ToDouble(txbOffsetAi0.Text);
                        DbSettingData.Offset1 = Convert.ToDouble(txbOffsetAi1.Text);
                        DbSettingData.Offset2 = Convert.ToDouble(txbOffsetAi2.Text);
                        DbSettingData.Offset3 = Convert.ToDouble(txbOffsetAi3.Text);
                        DbSettingData.Offset4 = Convert.ToDouble(txbOffsetAi4.Text);
                        DbSettingData.Offset5 = Convert.ToDouble(txbOffsetAi5.Text);
                        DbSettingData.Offset6 = Convert.ToDouble(txbOffsetAi6.Text);
                        DbSettingData.Offset7 = Convert.ToDouble(txbOffsetAi7.Text);

                        //Slope
                        DbSettingData.Slope0 = Convert.ToDouble(txbSlopeAi0.Text);
                        DbSettingData.Slope1 = Convert.ToDouble(txbSlopeAi1.Text);
                        DbSettingData.Slope2 = Convert.ToDouble(txbSlopeAi2.Text);
                        DbSettingData.Slope3 = Convert.ToDouble(txbSlopeAi3.Text);
                        DbSettingData.Slope4 = Convert.ToDouble(txbSlopeAi4.Text);
                        DbSettingData.Slope5 = Convert.ToDouble(txbSlopeAi5.Text);
                        DbSettingData.Slope6 = Convert.ToDouble(txbSlopeAi6.Text);
                        DbSettingData.Slope7 = Convert.ToDouble(txbSlopeAi7.Text);

                        //Low Alarm
                        DbSettingData.AlarmLow0 = Convert.ToDouble(txbLowAlarm0.Text);
                        DbSettingData.AlarmLow1 = Convert.ToDouble(txbLowAlarm1.Text);
                        DbSettingData.AlarmLow2 = Convert.ToDouble(txbLowAlarm2.Text);
                        DbSettingData.AlarmLow3 = Convert.ToDouble(txbLowAlarm3.Text);
                        DbSettingData.AlarmLow4 = Convert.ToDouble(txbLowAlarm4.Text);
                        DbSettingData.AlarmLow5 = Convert.ToDouble(txbLowAlarm5.Text);
                        DbSettingData.AlarmLow6 = Convert.ToDouble(txbLowAlarm6.Text);
                        DbSettingData.AlarmLow7 = Convert.ToDouble(txbLowAlarm7.Text);

                        //High Alarm
                        DbSettingData.AlarmHigh0 = Convert.ToDouble(tbxHighAlarm0.Text);
                        DbSettingData.AlarmHigh1 = Convert.ToDouble(tbxHighAlarm1.Text);
                        DbSettingData.AlarmHigh2 = Convert.ToDouble(tbxHighAlarm2.Text);
                        DbSettingData.AlarmHigh3 = Convert.ToDouble(tbxHighAlarm3.Text);
                        DbSettingData.AlarmHigh4 = Convert.ToDouble(tbxHighAlarm4.Text);
                        DbSettingData.AlarmHigh5 = Convert.ToDouble(tbxHighAlarm5.Text);
                        DbSettingData.AlarmHigh6 = Convert.ToDouble(tbxHighAlarm6.Text);
                        DbSettingData.AlarmHigh7 = Convert.ToDouble(tbxHighAlarm7.Text);

                        //Vent Time
                        DbSettingData.VentTime = Convert.ToInt32(txbVentTime.Text) * 1000;

                        //Analysis Time
                        DbSettingData.AnalysisTime = Convert.ToInt32(txbAnalysisTime.Text) * 1000;

                        plc.WriteClass(DbSettingData, 1);


                        // Write Disable Signal To PLC
                        var DbEnableSignal = new DbEnableSignal();
                        DbEnableSignal.DisconnectAi0 = cbxAi0.Checked;
                        DbEnableSignal.DisconnectAi1 = cbxAi1.Checked;
                        DbEnableSignal.DisconnectAi2 = cbxAi2.Checked;
                        DbEnableSignal.DisconnectAi3 = cbxAi3.Checked;
                        DbEnableSignal.DisconnectAi4 = cbxAi4.Checked;
                        DbEnableSignal.DisconnectAi5 = cbxAi5.Checked;
                        DbEnableSignal.DisconnectAi6 = cbxAi6.Checked;
                        DbEnableSignal.DisconnectAi7 = cbxAi7.Checked;

                        plc.WriteClass(DbEnableSignal, 19);

                        Properties.Settings.Default.UnitAi0 = txbUnitAi0.Text;
                        Properties.Settings.Default.UnitAi1 = txbUnitAi1.Text;
                        Properties.Settings.Default.UnitAi2 = txbUnitAi2.Text;
                        Properties.Settings.Default.UnitAi3 = txbUnitAi3.Text;
                        Properties.Settings.Default.UnitAi4 = txbUnitAi4.Text;
                        Properties.Settings.Default.UnitAi5 = txbUnitAi5.Text;
                        Properties.Settings.Default.UnitAi6 = txbUnitAi6.Text;
                        Properties.Settings.Default.UnitAi7 = txbUnitAi7.Text;

                        Properties.Settings.Default.NameAi0 = txbNameAi0.Text;
                        Properties.Settings.Default.NameAi1 = txbNameAi1.Text;
                        Properties.Settings.Default.NameAi2 = txbNameAi2.Text;
                        Properties.Settings.Default.NameAi3 = txbNameAi3.Text;
                        Properties.Settings.Default.NameAi4 = txbNameAi4.Text;
                        Properties.Settings.Default.NameAi5 = txbNameAi5.Text;
                        Properties.Settings.Default.NameAi6 = txbNameAi6.Text;
                        Properties.Settings.Default.NameAi7 = txbNameAi7.Text;

                        Properties.Settings.Default.CycleTime = Convert.ToInt32(txbCycleTime.Text) * 1000;

                        Properties.Settings.Default.Save();
                        MessageBox.Show("Save Successful!");
                    }
                }
                catch (Exception e)
                {
                    plc.Close(); plc.Close();
                    Thread.Sleep(100);
                    result = plc.Open();
                    Thread.Sleep(100);
                    MessageBox.Show("Input Error!");
                }

            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
