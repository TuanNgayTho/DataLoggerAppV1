using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using LiveCharts;
using LiveCharts.Events;

using LiveCharts.Wpf;
using LiveCharts.Defaults;
using LiveCharts.Configurations;
using LiveCharts.Helpers;
using MySql.Data.MySqlClient;
using Separator = LiveCharts.Wpf.Separator;
using System.Windows.Data;

using Binding = System.Windows.Data.Binding;
using System.Windows.Media;
using Brushes = System.Windows.Media.Brushes;
using Winforms.Cartesian.ConstantChanges;
using LiveCharts.WinForms;


namespace DataLoggerAppV1
{
    public partial class Trend : Form
    {
        public static Trend instance;
        public static bool isStay = false;

        List<DateTime> times = new List<DateTime>();
        List<float> valueChart = new List<float>();
        List<float> valueChart1 = new List<float>();
        List<float> valueChart2 = new List<float>();
        List<float> valueChart3 = new List<float>();
        List<float> valueChart4 = new List<float>();
        List<float> valueChart5= new List<float>();
        List<float> valueChart6= new List<float>();
        List<float> valueChart7 = new List<float>();
        int count;


        public ChartValues<MeasureModel> ChartValues { get; set; }
        public ChartValues<MeasureModel> ChartValues1 { get; set; }
        public ChartValues<MeasureModel> ChartValues2 { get; set; }
        public ChartValues<MeasureModel> ChartValues3 { get; set; }
        public ChartValues<MeasureModel> ChartValues4 { get; set; }
        public ChartValues<MeasureModel> ChartValues5 { get; set; }
        public ChartValues<MeasureModel> ChartValues6 { get; set; }
        public ChartValues<MeasureModel> ChartValues7 { get; set; }
        public Timer Timer { get; set; }
        public Random R { get; set; }
        public float value { get; set; }
        public float value1 { get; set; }
        public float value2 { get; set; }
        public float value3 { get; set; }
        public float value4 { get; set; }
        public float value5 { get; set; }
        public float value6 { get; set; }
        public float value7 { get; set; }

        public DateTime ts { get; set; }


        public LineSeries MaterialGas1 { get; set; }
        public LineSeries MaterialGas2 { get; set; }
        public LineSeries MaterialGas3 { get; set; }

        public LineSeries MaterialGas4 { get; set; }
        public LineSeries MaterialGas5 { get; set; }
        public LineSeries MaterialGas6 { get; set; }
        public LineSeries MaterialGas7 { get; set; }

        public LineSeries MaterialGas8 { get; set; }

        public Trend()
        {
            InitializeComponent();
            instance =this;
            

            var mapper = Mappers.Xy<MeasureModel>()
               .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
               .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);

            //the ChartValues property will store our values array
            ChartValues = new ChartValues<MeasureModel>();
            ChartValues1 = new ChartValues<MeasureModel>();
            ChartValues2 = new ChartValues<MeasureModel>();
            ChartValues3 = new ChartValues<MeasureModel>();
            ChartValues4 = new ChartValues<MeasureModel>();
            ChartValues5 = new ChartValues<MeasureModel>();
            ChartValues6 = new ChartValues<MeasureModel>();
            ChartValues7 = new ChartValues<MeasureModel>();



            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Time Line",
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("dd-MM-yyyy HH:mm:ss"),
                LabelsRotation = 13,
                Foreground = Brushes.Red,

                Separator = new Separator
                {
                    StrokeThickness = 1,
                    Stroke = Brushes.Black,
                    Step = TimeSpan.FromSeconds(1).Ticks
                }

            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = Name = Properties.Settings.Default.NameAi0,
                LabelFormatter = val => val + " " + Properties.Settings.Default.UnitAi0,

                DisableAnimations = true,
                Foreground = Brushes.Red,
               // MinValue = 0,

                Separator = new Separator
                {

                    // Step=1,
                    Stroke = Brushes.Black,
                    //Stroke = Brushes.Transparent,

                }

            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = Properties.Settings.Default.NameAi1,
                LabelFormatter = val => val + " " + Properties.Settings.Default.UnitAi1,
                DisableAnimations = true,
                Foreground = Brushes.Black,
               // MinValue = 0,
                Separator = new Separator
                {

                    // Step = 1,
                    //Stroke = Brushes.Black,
                    Stroke = Brushes.Transparent,

                }

            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = Properties.Settings.Default.NameAi2,
                LabelFormatter = val => val + " " + Properties.Settings.Default.UnitAi2,
                DisableAnimations = true,
                Foreground = Brushes.Green,
               // MinValue = 0,
                Separator = new Separator
                {

                    //Step = 1,
                    //Stroke = Brushes.Black,
                    Stroke = Brushes.Transparent,

                }

            }); cartesianChart1.AxisY.Add(new Axis
            {
                Title = Properties.Settings.Default.NameAi3,
                LabelFormatter = val => val + " " + Properties.Settings.Default.UnitAi3,
                DisableAnimations = true,
                Foreground = Brushes.Violet,
               // MinValue = 0,
                Separator = new Separator
                {

                    // Step = 1,
                    //Stroke = Brushes.Black,
                    Stroke = Brushes.Transparent,

                }

            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = Properties.Settings.Default.NameAi4,
                LabelFormatter = val => val + " " + Properties.Settings.Default.UnitAi4,
                DisableAnimations = true,
                Position = AxisPosition.RightTop,
                Foreground = Brushes.Gray,
                //MinValue = 0,
                Separator = new Separator
                {

                    // Step = 1,
                   // Stroke = Brushes.Black,
                    Stroke = Brushes.Transparent,

                }

            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = Properties.Settings.Default.NameAi5,
                LabelFormatter = val => val + " " + Properties.Settings.Default.UnitAi5,
                DisableAnimations = true,
                Position = AxisPosition.RightTop,
                //MinValue = 0,
                Foreground = Brushes.Blue,
                Separator = new Separator
                {

                    //Step = 1,
                    //Stroke = Brushes.Black,
                    Stroke = Brushes.Transparent,

                }

            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = Properties.Settings.Default.NameAi6,
                LabelFormatter = val => val + " " + Properties.Settings.Default.UnitAi6,
                DisableAnimations = true,
                Position = AxisPosition.RightTop,
                //MinValue = 0,
                Foreground = Brushes.Orange,
                Separator = new Separator
                {

                    //Step = 1,
                    //Stroke = Brushes.Black,
                    Stroke = Brushes.Transparent,

                }

            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = Properties.Settings.Default.NameAi7,
                LabelFormatter = val => val + " " + Properties.Settings.Default.UnitAi7,

                DisableAnimations = true,
                Position = AxisPosition.RightTop,
                //MinValue = 0,
                Foreground = Brushes.Brown,
                Separator = new Separator
                {

                    //Step = 1,
                   // Stroke = Brushes.Black,
                    Stroke = Brushes.Transparent,

                }

            });
            



            SetAxisLimits(System.DateTime.Now);
            date.Value = DateTime.Now;
            hour2.Value = DateTime.Now;

            //The next code simulates data changes every 500 ms

            Timer = new Timer
            {
                Interval = 1000
            };
            Timer.Tick += TimerOnTick;
            
                Timer.Start();
             
            R = new Random();


            //cartesianChart1.Zoom = ZoomingOptions.X;
            cartesianChart1.DisableAnimations = true;
            cartesianChart1.Hoverable = false;





            ////////////////////////////////////////////



            MaterialGas1 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi0,
                Values = ChartValues,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Red,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 0,
            };
            MaterialGas2 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi1,
                Values = ChartValues1,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Black,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 1


            };
            MaterialGas3 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi2,
                Values = ChartValues2,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Green,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 2
            };
            MaterialGas4 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi3,
                Values = ChartValues3,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Violet,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 3
            };
            MaterialGas5 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi4,
                Values = ChartValues4,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Gray,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 4
            };
            MaterialGas6 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi5,
                Values = ChartValues5,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Blue,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 5
            };
            MaterialGas7 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi6,
                Values = ChartValues6,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Orange,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 6
            };
            MaterialGas8 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi7,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Brown,
                Values = ChartValues7,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 7
            };

            cartesianChart1.Series = new SeriesCollection
          {
              MaterialGas1,
              MaterialGas2,
              MaterialGas3,
              MaterialGas4,
              MaterialGas5,
              MaterialGas6,
              MaterialGas7,
              MaterialGas8,

          };






        }


        private void SetAxisLimits(System.DateTime now)
        {
            cartesianChart1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(20).Ticks; //we only care about the last 8 seconds
        }
        private void SetAxisLimits1(System.DateTime now1, System.DateTime now2, int a)
        {
            cartesianChart1.AxisX[0].MaxValue = now2.Ticks; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue = now2.Ticks - TimeSpan.FromSeconds(a).Ticks; ; //we only care about the last 8 seconds
        }
        private void SetAxisLimits2(System.DateTime now1, System.DateTime now2, int a)
        {
            cartesianChart1.AxisX[0].MaxValue = now1.Ticks + TimeSpan.FromSeconds(a).Ticks;  // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue = now1.Ticks; //we only care about the last 8 seconds
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            if (true)
            {
                var now = System.DateTime.Now;
                var DbSettingData = new DbSettingData();
                //System.Windows.MessageBox.Show("connect");

                cartesianChart1.AxisY[0].MaxValue = Properties.Settings.Default.MaxAi0;
                cartesianChart1.AxisY[0].MinValue = Properties.Settings.Default.MinAi0;
                cartesianChart1.AxisY[1].MaxValue = Properties.Settings.Default.MaxAi1;
                cartesianChart1.AxisY[1].MinValue = Properties.Settings.Default.MinAi1;
                cartesianChart1.AxisY[2].MaxValue = Properties.Settings.Default.MaxAi2;
                cartesianChart1.AxisY[2].MinValue = Properties.Settings.Default.MinAi2;
                cartesianChart1.AxisY[3].MaxValue = Properties.Settings.Default.MaxAi3;
                cartesianChart1.AxisY[3].MinValue = Properties.Settings.Default.MinAi3;
                cartesianChart1.AxisY[4].MaxValue = Properties.Settings.Default.MaxAi4;
                cartesianChart1.AxisY[4].MinValue = Properties.Settings.Default.MinAi4;
                cartesianChart1.AxisY[5].MaxValue = Properties.Settings.Default.MaxAi5;
                cartesianChart1.AxisY[5].MinValue = Properties.Settings.Default.MinAi5;
                cartesianChart1.AxisY[6].MaxValue = Properties.Settings.Default.MaxAi6;
                cartesianChart1.AxisY[6].MinValue = Properties.Settings.Default.MinAi6;
                cartesianChart1.AxisY[7].MaxValue = Properties.Settings.Default.MaxAi7;
                cartesianChart1.AxisY[7].MinValue = Properties.Settings.Default.MinAi7;


                //cartesianChart1.AxisY[0].Separator.Step = Math.Round((cartesianChart1.AxisY[0].MaxValue - cartesianChart1.AxisY[0].MinValue));
                //cartesianChart1.AxisY[1].Separator.Step = Math.Round((cartesianChart1.AxisY[1].MaxValue - cartesianChart1.AxisY[1].MinValue));
                //cartesianChart1.AxisY[2].Separator.Step = Math.Round((cartesianChart1.AxisY[2].MaxValue - cartesianChart1.AxisY[2].MinValue));
                //cartesianChart1.AxisY[3].Separator.Step = Math.Round((cartesianChart1.AxisY[3].MaxValue - cartesianChart1.AxisY[3].MinValue));
                //cartesianChart1.AxisY[4].Separator.Step = Math.Round((cartesianChart1.AxisY[4].MaxValue - cartesianChart1.AxisY[4].MinValue));
                //cartesianChart1.AxisY[5].Separator.Step = Math.Round((cartesianChart1.AxisY[5].MaxValue - cartesianChart1.AxisY[5].MinValue));
                //cartesianChart1.AxisY[6].Separator.Step = Math.Round((cartesianChart1.AxisY[6].MaxValue - cartesianChart1.AxisY[6].MinValue));
                //cartesianChart1.AxisY[7].Separator.Step = Math.Round((cartesianChart1.AxisY[7].MaxValue - cartesianChart1.AxisY[7].MinValue));

                //lets only use the last 30 values
                if (ChartValues.Count > 20) ChartValues.RemoveAt(0);
                if (ChartValues1.Count > 20) ChartValues1.RemoveAt(0);
                if (ChartValues2.Count > 20) ChartValues2.RemoveAt(0);
                if (ChartValues3.Count > 20) ChartValues3.RemoveAt(0);
                if (ChartValues4.Count > 20) ChartValues4.RemoveAt(0);
                if (ChartValues5.Count > 20) ChartValues5.RemoveAt(0);
                if (ChartValues6.Count > 20) ChartValues6.RemoveAt(0);
                if (ChartValues7.Count > 20) ChartValues7.RemoveAt(0);
                ////
                ///
                try
                {
                    DateTime enteredDate;
                    string server = "localhost";
                    string database = "datalogger";
                    string uid = "root";
                    string password = "root";
                    string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;
                    MySqlConnection con = new MySqlConnection(constring);
                    con.Open();


                    var query = "Select aivalue0,aivalue1,aivalue2,aivalue3,aivalue4,aivalue5,aivalue6,aivalue7,ts from samples ORDER BY id DESC LIMIT 1";




                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //System.Windows.MessageBox.Show("ok");
                    while (reader.Read())
                    {
                        /*

                        value = float.Parse(String.Format("{0:0.##}", reader["aivalue0"]));   
                        value1 = float.Parse(String.Format("{0:0.00}", reader["aivalue1"]));
                        value2 = float.Parse(String.Format("{0:0.00}", reader["aivalue2"]));
                        value3 = float.Parse(String.Format("{0:0.00}", reader["aivalue3"]));
                        value4 = float.Parse(String.Format("{0:0.00}", reader["aivalue4"]));
                        value5 = float.Parse(String.Format("{0:0.00}", reader["aivalue5"]));
                        value6 = float.Parse(String.Format("{0:0.00}", reader["aivalue6"]));
                        value7 = float.Parse(String.Format("{0:0.00}", reader["aivalue7"]));*/

                        value = Convert.ToInt32(float.Parse(reader["aivalue0"].ToString()) * 100) / 100F;
                        //textBox1.Text = value.ToString();
                        value1 = Convert.ToInt32(float.Parse(reader["aivalue1"].ToString()) * 100) / 100F;
                        value2 = Convert.ToInt32(float.Parse(reader["aivalue2"].ToString()) * 100) / 100F;
                        value3 = Convert.ToInt32(float.Parse(reader["aivalue3"].ToString()) * 100) / 100F;
                        value4 = Convert.ToInt32(float.Parse(reader["aivalue4"].ToString()) * 100) / 100F;
                        value5 = Convert.ToInt32(float.Parse(reader["aivalue5"].ToString()) * 100) / 100F;
                        value6 = Convert.ToInt32(float.Parse(reader["aivalue6"].ToString()) * 100) / 100F;
                        value7 = Convert.ToInt32(float.Parse(reader["aivalue7"].ToString()) * 100) / 100F;


                        ts = DateTime.Parse(reader["ts"].ToString());

                        //System.Windows.MessageBox.Show(reader["ts"].ToString());

                    }

                    con.Close();
                    ChartValues.Add(new MeasureModel
                    {
                        DateTime = ts,
                        Value = double.Parse(value.ToString())
                    });

                    ChartValues1.Add(new MeasureModel
                    {
                        DateTime = ts,
                        Value = double.Parse(value1.ToString())
                    });
                    ChartValues2.Add(new MeasureModel
                    {
                        DateTime = ts,
                        Value = double.Parse(value2.ToString())
                    });
                    ChartValues3.Add(new MeasureModel
                    {
                        DateTime = ts,
                        Value = double.Parse(value3.ToString())
                    });
                    ChartValues4.Add(new MeasureModel
                    {
                        DateTime = ts,
                        Value = double.Parse(value4.ToString())
                    });
                    ChartValues5.Add(new MeasureModel
                    {
                        DateTime = ts,
                        Value = double.Parse(value5.ToString())
                    });
                    ChartValues6.Add(new MeasureModel
                    {
                        DateTime = ts,
                        Value = double.Parse(value6.ToString())
                    });
                    ChartValues7.Add(new MeasureModel
                    {
                        DateTime = ts,
                        Value = double.Parse(value7.ToString())
                    });


                    SetAxisLimits(now);
                }


                catch
                {


                }
            }




        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            MaterialGas1.Visibility = MaterialGas1.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[0].ShowLabels = cartesianChart1.AxisY[0].ShowLabels == false ? cartesianChart1.AxisY[0].ShowLabels = true : cartesianChart1.AxisY[0].ShowLabels = false;
           // cartesianChart1.AxisY[0].Separator.Step = Math.Round((cartesianChart1.AxisY[0].MaxValue - cartesianChart1.AxisY[0].MinValue),2);
            //cartesianChart1.AxisY[0].Title = cartesianChart1.AxisY[0].Title == Properties.Settings.Default.NameAi0 ? cartesianChart1.AxisY[0].Title = "" : cartesianChart1.AxisY[0].Title = Properties.Settings.Default.NameAi0;
            //cartesianChart1.AxisY[0].Separator.Stroke = cartesianChart1.AxisY[0].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[0].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[0].Separator.Stroke = Brushes.Black;




        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas2.Visibility = MaterialGas2.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[1].ShowLabels = cartesianChart1.AxisY[1].ShowLabels == false ? cartesianChart1.AxisY[1].ShowLabels = true : cartesianChart1.AxisY[1].ShowLabels = false;
            cartesianChart1.AxisY[1].Title = cartesianChart1.AxisY[1].Title == Properties.Settings.Default.NameAi1 ? cartesianChart1.AxisY[1].Title = "" : cartesianChart1.AxisY[1].Title = Properties.Settings.Default.NameAi1;
            //cartesianChart1.AxisY[1].Separator.Stroke = cartesianChart1.AxisY[1].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[1].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[1].Separator.Stroke = Brushes.Black;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas3.Visibility = MaterialGas3.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[2].ShowLabels = cartesianChart1.AxisY[2].ShowLabels == false ? cartesianChart1.AxisY[2].ShowLabels = true : cartesianChart1.AxisY[2].ShowLabels = false;
            cartesianChart1.AxisY[2].Title = cartesianChart1.AxisY[2].Title == Properties.Settings.Default.NameAi2 ? cartesianChart1.AxisY[2].Title = "" : cartesianChart1.AxisY[2].Title = Properties.Settings.Default.NameAi2;
           // cartesianChart1.AxisY[2].Separator.Stroke = cartesianChart1.AxisY[2].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[2].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[2].Separator.Stroke = Brushes.Black;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas4.Visibility = MaterialGas4.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[3].ShowLabels = cartesianChart1.AxisY[3].ShowLabels == false ? cartesianChart1.AxisY[3].ShowLabels = true : cartesianChart1.AxisY[3].ShowLabels = false;
            cartesianChart1.AxisY[3].Title = cartesianChart1.AxisY[3].Title == Properties.Settings.Default.NameAi3 ? cartesianChart1.AxisY[3].Title = "" : cartesianChart1.AxisY[3].Title = Properties.Settings.Default.NameAi3;
           // cartesianChart1.AxisY[3].Separator.Stroke = cartesianChart1.AxisY[3].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[3].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[3].Separator.Stroke = Brushes.Black;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas5.Visibility = MaterialGas5.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[4].ShowLabels = cartesianChart1.AxisY[4].ShowLabels == false ? cartesianChart1.AxisY[4].ShowLabels = true : cartesianChart1.AxisY[4].ShowLabels = false;
            cartesianChart1.AxisY[4].Title = cartesianChart1.AxisY[4].Title == Properties.Settings.Default.NameAi4 ? cartesianChart1.AxisY[4].Title = "" : cartesianChart1.AxisY[4].Title = Properties.Settings.Default.NameAi4;
           // cartesianChart1.AxisY[4].Separator.Stroke = cartesianChart1.AxisY[4].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[4].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[4].Separator.Stroke = Brushes.Black;
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas6.Visibility = MaterialGas6.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[5].ShowLabels = cartesianChart1.AxisY[5].ShowLabels == false ? cartesianChart1.AxisY[5].ShowLabels = true : cartesianChart1.AxisY[5].ShowLabels = false;
            cartesianChart1.AxisY[5].Title = cartesianChart1.AxisY[5].Title == Properties.Settings.Default.NameAi5 ? cartesianChart1.AxisY[5].Title = "" : cartesianChart1.AxisY[5].Title = Properties.Settings.Default.NameAi5;
           // cartesianChart1.AxisY[5].Separator.Stroke = cartesianChart1.AxisY[5].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[5].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[5].Separator.Stroke = Brushes.Black;
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas7.Visibility = MaterialGas7.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[6].ShowLabels = cartesianChart1.AxisY[6].ShowLabels == false ? cartesianChart1.AxisY[6].ShowLabels = true : cartesianChart1.AxisY[6].ShowLabels = false;
            cartesianChart1.AxisY[6].Title = cartesianChart1.AxisY[6].Title == Properties.Settings.Default.NameAi6 ? cartesianChart1.AxisY[6].Title = "" : cartesianChart1.AxisY[6].Title = Properties.Settings.Default.NameAi6;
           // cartesianChart1.AxisY[6].Separator.Stroke = cartesianChart1.AxisY[6].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[6].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[6].Separator.Stroke = Brushes.Black;
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas8.Visibility = MaterialGas8.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[7].ShowLabels = cartesianChart1.AxisY[7].ShowLabels == false ? cartesianChart1.AxisY[7].ShowLabels = true : cartesianChart1.AxisY[7].ShowLabels = false;
            cartesianChart1.AxisY[7].Title = cartesianChart1.AxisY[7].Title == Properties.Settings.Default.NameAi7 ? cartesianChart1.AxisY[7].Title = "" : cartesianChart1.AxisY[7].Title = Properties.Settings.Default.NameAi7;
           // cartesianChart1.AxisY[7].Separator.Stroke = cartesianChart1.AxisY[7].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[7].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[7].Separator.Stroke = Brushes.Black;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChartValues.Clear();
            ChartValues1.Clear();
            ChartValues2.Clear();
            ChartValues3.Clear();
            ChartValues4.Clear();
            ChartValues5.Clear();
            ChartValues6.Clear();
            ChartValues7.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String iDay, iMonth, iYear, iHour, iMininute, iSeconds;
            String iDay2, iMonth2, iYear2, iHour2, iMininute2, iSeconds2;
            String Day1, Day2;
            //var now = System.DateTime.Now;
            count = 0;
            iDay = date.Value.Day.ToString();
            iMonth = date.Value.Month.ToString();
            iYear = date.Value.Year.ToString();

            iHour = hour1.Value.Hour.ToString();
            iMininute = hour1.Value.Minute.ToString();
            iSeconds = hour1.Value.Second.ToString();
            Day1 = iYear + "-" + iMonth + "-" + iDay + " " + iHour + ":" + iMininute + ":" + iSeconds;

            iDay2 = date.Value.Day.ToString();
            iMonth2 = date.Value.Month.ToString();
            iYear2 = date.Value.Year.ToString();
            iHour2 = hour2.Value.Hour.ToString();
            iMininute2 = hour2.Value.Minute.ToString();
            iSeconds2 = hour2.Value.Second.ToString();
            Day2 = iYear2 + "-" + iMonth2 + "-" + iDay2 + " " + iHour2 + ":" + iMininute2 + ":" + iSeconds2;

            //System.Windows.MessageBox.Show("" + Day1 + Day2);

            string server = "localhost";
            string database = "datalogger";
            string uid = "root";
            string password = "root";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            var query = "select * from samples WHERE ts >='" + Day1 + "' AND ts <='" + Day2 + "'";

            


            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            valueChart.Clear();
            valueChart1.Clear();
            valueChart2.Clear();
            valueChart3.Clear();
            valueChart4.Clear();
            valueChart5.Clear();
            valueChart6.Clear();
            valueChart7.Clear();
            times.Clear();
            while (reader.Read())
            {
                
                /*
                value = int.Parse(reader["aivalue0"].ToString());
                value1 = int.Parse(reader["aivalue1"].ToString());
                value2 = int.Parse(reader["aivalue2"].ToString());
                value3 = int.Parse(reader["aivalue3"].ToString());
                value4 = int.Parse(reader["aivalue4"].ToString());
                value5 = int.Parse(reader["aivalue5"].ToString());
                value6 = int.Parse(reader["aivalue6"].ToString());
                value7 = int.Parse(reader["aivalue7"].ToString());
                */
                value = Convert.ToInt32(float.Parse(reader["aivalue0"].ToString()) * 100) / 100F;
                value1 = Convert.ToInt32(float.Parse(reader["aivalue1"].ToString()) * 100) / 100F;
                value2 = Convert.ToInt32(float.Parse(reader["aivalue2"].ToString()) * 100) / 100F;
                value3 = Convert.ToInt32(float.Parse(reader["aivalue3"].ToString()) * 100) / 100F;
                value4 = Convert.ToInt32(float.Parse(reader["aivalue4"].ToString()) * 100) / 100F;
                value5 = Convert.ToInt32(float.Parse(reader["aivalue5"].ToString()) * 100) / 100F;
                value6 = Convert.ToInt32(float.Parse(reader["aivalue6"].ToString()) * 100) / 100F;
                value7 = Convert.ToInt32(float.Parse(reader["aivalue7"].ToString()) * 100) / 100F;
                ts = DateTime.Parse(reader["ts"].ToString());
                
                times.Add(ts);
                
                valueChart.Add(value);
                valueChart1.Add(value1);
                valueChart2.Add(value2);
                valueChart3.Add(value3);
                valueChart4.Add(value4);
                valueChart5.Add(value5);
                valueChart6.Add(value6);
                valueChart7.Add(value7);

                //System.Windows.MessageBox.Show(valueChart[count].ToString());
                count++;



                //System.Windows.MessageBox.Show(reader["ts"].ToString());

            }
            int flg = 0;
            if (count < 20) flg = count-1;
            else flg = 20;
            for (int i = 0; i <= flg; i++) {

                if (count < 20)
                {
               // System.Windows.MessageBox.Show(valueChart[i].ToString());
                   ChartValues.Add(new MeasureModel
                    {
                        DateTime = times[i],
                        Value = double.Parse(valueChart[i].ToString())
                    });
                    ChartValues1.Add(new MeasureModel
                    {
                        DateTime = times[i],
                        Value = double.Parse(valueChart1[i].ToString())
                    });
                    ChartValues2.Add(new MeasureModel
                    {
                        DateTime = times[i],
                        Value = double.Parse(valueChart2[i].ToString())
                    });
                    ChartValues3.Add(new MeasureModel
                    {
                        DateTime = times[i],
                        Value = double.Parse(valueChart3[i].ToString())
                    });
                    ChartValues4.Add(new MeasureModel
                    {
                        DateTime = times[i],
                        Value = double.Parse(valueChart4[i].ToString())
                    });
                    ChartValues5.Add(new MeasureModel
                    {
                        DateTime = times[i],
                        Value = double.Parse(valueChart5[i].ToString())
                    });
                    ChartValues6.Add(new MeasureModel
                    {
                        DateTime = times[i],
                        Value = double.Parse(valueChart6[i].ToString())
                    });
                    ChartValues7.Add(new MeasureModel
                    {
                        DateTime = times[i],
                        Value = double.Parse(valueChart7[i].ToString())
                    });



                }
                else
                {

                    ChartValues.Add(new MeasureModel
                    {
                        DateTime = times[count - 21 + i],
                        Value = double.Parse(valueChart[count - 21 + i].ToString())
                    });
                    ChartValues1.Add(new MeasureModel
                    {
                        DateTime = times[count - 21 + i],
                        Value = double.Parse(valueChart1[count - 21 + i].ToString())
                    });
                    ChartValues2.Add(new MeasureModel
                    {
                        DateTime = times[count - 21 + i],
                        Value = double.Parse(valueChart2[count - 21 + i].ToString())
                    });
                    ChartValues3.Add(new MeasureModel
                    {
                        DateTime = times[count - 21 + i],
                        Value = double.Parse(valueChart3[count - 21 + i].ToString())
                    });
                    ChartValues4.Add(new MeasureModel
                    {
                        DateTime = times[count - 21 + i],
                        Value = double.Parse(valueChart4[count - 21 + i].ToString())
                    });
                    ChartValues5.Add(new MeasureModel
                    {
                        DateTime = times[count - 21 + i],
                        Value = double.Parse(valueChart5[count - 21 + i].ToString())
                    });
                    ChartValues6.Add(new MeasureModel
                    {
                        DateTime = times[count - 21 + i],
                        Value = double.Parse(valueChart6[count - 21 + i].ToString())
                    });
                    ChartValues7.Add(new MeasureModel
                    {
                        DateTime = times[count - 21 + i],
                        Value = double.Parse(valueChart7[count - 21 + i].ToString())
                    });
                }


            }


            //ChartValues1.Add(new MeasureModel
            //{
            //    DateTime = ts,
            //    Value = double.Parse(value1.ToString())
            //});
            //ChartValues2.Add(new MeasureModel
            //{
            //    DateTime = ts,
            //    Value = double.Parse(value2.ToString())
            //});
            //ChartValues3.Add(new MeasureModel
            //{
            //    DateTime = ts,
            //    Value = double.Parse(value3.ToString())
            //});
            //ChartValues4.Add(new MeasureModel
            //{
            //    DateTime = ts,
            //    Value = double.Parse(value4.ToString())
            //});
            //ChartValues5.Add(new MeasureModel
            //{
            //    DateTime = ts,
            //    Value = double.Parse(value5.ToString())
            //});
            //ChartValues6.Add(new MeasureModel
            //{
            //    DateTime = ts,
            //    Value = double.Parse(value6.ToString())
            //});
            //ChartValues7.Add(new MeasureModel
            //{
            //    DateTime = ts,
            //    Value = double.Parse(value7.ToString())
            //});

            con.Close();
            SetAxisLimits1(date.Value, hour2.Value, 20);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //SetAxisLimits1(dateTimePicker1.Value, dateTimePicker2.Value, count);

            cartesianChart1.AxisX[0].MaxValue += TimeSpan.FromSeconds(20).Ticks; ; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue += TimeSpan.FromSeconds(20).Ticks; ; //we only care about the last 8 seconds
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // SetAxisLimits2(dateTimePicker1.Value, dateTimePicker2.Value, count);
            cartesianChart1.AxisX[0].MaxValue -= TimeSpan.FromSeconds(20).Ticks; ; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue -= TimeSpan.FromSeconds(20).Ticks; ; //we only care about the last 8 seconds
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetAxisLimits1(date.Value, hour2.Value, 20);
        }

        private void Trend_Load(object sender, EventArgs e)
        {
            checkBox1.Text = Properties.Settings.Default.NameAi0;
            checkBox2.Text = Properties.Settings.Default.NameAi1;
            checkBox3.Text = Properties.Settings.Default.NameAi2;
            checkBox4.Text = Properties.Settings.Default.NameAi3;
            checkBox5.Text = Properties.Settings.Default.NameAi4;
            checkBox6.Text = Properties.Settings.Default.NameAi5;
            checkBox7.Text = Properties.Settings.Default.NameAi6;
            checkBox8.Text = Properties.Settings.Default.NameAi7;
            checkBox1.ForeColor = Properties.Settings.Default.ColorAi0;
            checkBox2.ForeColor = Properties.Settings.Default.ColorAi1;
            checkBox3.ForeColor = Properties.Settings.Default.ColorAi2;
            checkBox4.ForeColor = Properties.Settings.Default.ColorAi3;
            checkBox5.ForeColor = Properties.Settings.Default.ColorAi4;
            checkBox6.ForeColor = Properties.Settings.Default.ColorAi5;
            checkBox7.ForeColor = Properties.Settings.Default.ColorAi6;
            checkBox8.ForeColor = Properties.Settings.Default.ColorAi7;

        }
    }
}
