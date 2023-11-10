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
using System.Threading;
using LiveCharts.Geared;
using Geared.Winforms.SpeedTest;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Utilities.Collections;
using System.Runtime.InteropServices;

namespace DataLoggerAppV1
{
    public partial class Trend : Form
    {
        public static Trend instance;
        public static bool isStay = false;
        public GearedValues<double> Values1 { get; set; }

        List<DateTime> times = new List<DateTime>();
        List<String> times1= new List<String>();
        List<float> valueChart = new List<float>();
        List<float> valueChart1 = new List<float>();
        List<float> valueChart2 = new List<float>();
        List<float> valueChart3 = new List<float>();
        List<float> valueChart4 = new List<float>();
        List<float> valueChart5= new List<float>();
        List<float> valueChart6= new List<float>();
        List<float> valueChart7 = new List<float>();
        bool busy1, busy2, busy3;
        int count,count_tong,sott, count_inc,temp,temp1;
        const double con = 0.0;

        String iDay, iMonth, iYear, iHour, iMininute, iSeconds;
        String iDay2, iMonth2, iYear2, iHour2, iMininute2, iSeconds2;
        String Day1, Day2;

        public ChartValues<MeasureModel> ChartValues { get; set; }
        public ChartValues<MeasureModel> ChartValues1 { get; set; }
        public ChartValues<MeasureModel> ChartValues2 { get; set; }
        public ChartValues<MeasureModel> ChartValues3 { get; set; }
        public ChartValues<MeasureModel> ChartValues4 { get; set; }
        public ChartValues<MeasureModel> ChartValues5 { get; set; }
        public ChartValues<MeasureModel> ChartValues6 { get; set; }
        public ChartValues<MeasureModel> ChartValues7 { get; set; }

        // public Timer Timer { get; set; }
        


        public Thread ti;
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
        public LineSeries MaterialGas9 { get; set; }

        private double _trend;

       

        public bool IsReading { get; set; }
        
        public double Count { get; set; }
        public double CurrentLecture { get; set; }
        public bool IsHot { get; set; }
        private SpeedTestVm _viewModel = new SpeedTestVm();
        private TruyXuat TruyXuat1 = new TruyXuat();
        public Trend()
        {
            InitializeComponent();
            instance =this;
            button3.Enabled = false;
            //button4.Enabled = false;
            button5.Enabled = false;
            //button6.Enabled = false;
            _viewModel.Read(times1);

            var mapper = Mappers.Xy<MeasureModel>()
               .X(model => model.DateTime.Ticks)  //use DateTime.Ticks as X
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
                Labels = times1,
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("dd-MM-yyyy" +" HH:mm:ss"),
                LabelsRotation = -18,
                Foreground = Brushes.Red,
                
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    Stroke = Brushes.Black,
                    // Step = TimeSpan.FromSeconds(1).Ticks
                }

            }) ;
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = Properties.Settings.Default.NameAi0,
               // Unit =100,
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

            }) ;
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
                Foreground = Brushes.Lime,
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
            



          //  SetAxisLimits(System.DateTime.Now);
            date.Value = DateTime.Now;
            hour1.Value = DateTime.Parse("00:00:00");

           
        
       


            cartesianChart1.Zoom = ZoomingOptions.X;
            cartesianChart1.DisableAnimations = true;
            cartesianChart1.Hoverable = false;
            //cartesianChart1.AnimationsSpeed = TimeSpan.FromMilliseconds(1000);
            //cartesianChart1.DataTooltip = null;

           

            ////////////////////////////////////////////



            MaterialGas1 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi0,
                Values = _viewModel.Values,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Red,
                //PointGeometry = null,
                PointGeometrySize = 1,
                StrokeThickness = 1,
                ScalesYAt = 0,
            };
            MaterialGas2 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi1,
                Values = _viewModel.Values1,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Black,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 1


            };
            MaterialGas3 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi2,
                Values = _viewModel.Values2,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Green,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 2
            };
            MaterialGas4 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi3,
                Values = _viewModel.Values3,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Violet,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 3
            };
            MaterialGas5 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi4,
                Values = _viewModel.Values4,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Lime,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 4
            };
            MaterialGas6 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi5,
                Values = _viewModel.Values5,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Blue,
                PointGeometrySize = 1,
                StrokeThickness = 2,
                ScalesYAt = 5
            };
            MaterialGas7 = new LineSeries
            {
                Title = Properties.Settings.Default.NameAi6,
                Values = _viewModel.Values6,
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
                Values = _viewModel.Values7,
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



            // System.Windows.Controls.Panel.SetZIndex(MaterialGas9, 1);
             if (Properties.Settings.Default.MinAi0 != Properties.Settings.Default.MaxAi0) { 
            cartesianChart1.AxisY[0].MaxValue = Properties.Settings.Default.MaxAi0;
            cartesianChart1.AxisY[0].MinValue = Properties.Settings.Default.MinAi0;

              }
             else
              {
                  cartesianChart1.AxisY[0].MaxValue = double.NaN;
                cartesianChart1.AxisY[0].MinValue = con;
              }
            if (Properties.Settings.Default.MinAi1 != Properties.Settings.Default.MaxAi1)
            {
                cartesianChart1.AxisY[1].MaxValue = Properties.Settings.Default.MaxAi1;
                cartesianChart1.AxisY[1].MinValue = Properties.Settings.Default.MinAi1;
            }
            else
            {
                cartesianChart1.AxisY[1].MaxValue = double.NaN;
                cartesianChart1.AxisY[1].MinValue = con;
            }
            if (Properties.Settings.Default.MinAi2 != Properties.Settings.Default.MaxAi2)
            {
                cartesianChart1.AxisY[2].MaxValue = Properties.Settings.Default.MaxAi2;
                cartesianChart1.AxisY[2].MinValue = Properties.Settings.Default.MinAi2;
            }
            else {
                cartesianChart1.AxisY[2].MaxValue = double.NaN;
                cartesianChart1.AxisY[2].MinValue = con;
            }
            if (Properties.Settings.Default.MinAi3 != Properties.Settings.Default.MaxAi3)
            {
                cartesianChart1.AxisY[3].MaxValue = Properties.Settings.Default.MaxAi3;
                cartesianChart1.AxisY[3].MinValue = Properties.Settings.Default.MinAi3;
            }
            else
            {
                cartesianChart1.AxisY[3].MaxValue = double.NaN;
                cartesianChart1.AxisY[3].MinValue = con;
            }
            if (Properties.Settings.Default.MinAi4 != Properties.Settings.Default.MaxAi4)
            {
                cartesianChart1.AxisY[4].MaxValue = Properties.Settings.Default.MaxAi4;
                cartesianChart1.AxisY[4].MinValue = Properties.Settings.Default.MinAi4;
            }
            else
            {
                cartesianChart1.AxisY[4].MaxValue = double.NaN;
                cartesianChart1.AxisY[4].MinValue = con;
            }
            if (Properties.Settings.Default.MinAi5 != Properties.Settings.Default.MaxAi5)
            {
                cartesianChart1.AxisY[5].MaxValue = Properties.Settings.Default.MaxAi5;
                cartesianChart1.AxisY[5].MinValue = Properties.Settings.Default.MinAi5;
            }
            else
            {
                cartesianChart1.AxisY[5].MaxValue = double.NaN;
                cartesianChart1.AxisY[5].MinValue = con;
            }
            if (Properties.Settings.Default.MinAi6 != Properties.Settings.Default.MaxAi6)
            {
                cartesianChart1.AxisY[6].MaxValue = Properties.Settings.Default.MaxAi6;
                cartesianChart1.AxisY[6].MinValue = Properties.Settings.Default.MinAi6;
            }
            else {
                cartesianChart1.AxisY[6].MaxValue = double.NaN;
                cartesianChart1.AxisY[6].MinValue = con;
            }
            if (Properties.Settings.Default.MinAi7 != Properties.Settings.Default.MaxAi7)
            {
                cartesianChart1.AxisY[7].MaxValue = Properties.Settings.Default.MaxAi7;
                cartesianChart1.AxisY[7].MinValue = Properties.Settings.Default.MinAi7;
            }
            else
            {
                cartesianChart1.AxisY[7].MaxValue = double.NaN;
                cartesianChart1.AxisY[7].MinValue = con;
            }



        }



        private void SetAxisLimits()
        {
            cartesianChart1.AxisX[0].MaxValue = DateTime.Parse(times1[times1.Count-1]).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue = DateTime.Parse(times1[0]).Ticks; //we only care about the last 8 seconds
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

       

       
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            MaterialGas1.Visibility = MaterialGas1.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[0].ShowLabels = cartesianChart1.AxisY[0].ShowLabels == false ? cartesianChart1.AxisY[0].ShowLabels = true : cartesianChart1.AxisY[0].ShowLabels = false;
           // cartesianChart1.AxisY[0].Separator.Step = Math.Round((cartesianChart1.AxisY[0].MaxValue - cartesianChart1.AxisY[0].MinValue),2);
            cartesianChart1.AxisY[0].Title = cartesianChart1.AxisY[0].Title == Properties.Settings.Default.NameAi0 ? cartesianChart1.AxisY[0].Title = "" : cartesianChart1.AxisY[0].Title = Properties.Settings.Default.NameAi0;
            //cartesianChart1.AxisY[0].Separator.Stroke = cartesianChart1.AxisY[0].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[0].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[0].Separator.Stroke = Brushes.Black;
            checkBox1.BackColor = checkBox1.BackColor == System.Drawing.Color.Gainsboro? checkBox1.BackColor= System.Drawing.Color.Gray : checkBox1.BackColor = System.Drawing.Color.Gainsboro;



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas2.Visibility = MaterialGas2.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[1].ShowLabels = cartesianChart1.AxisY[1].ShowLabels == false ? cartesianChart1.AxisY[1].ShowLabels = true : cartesianChart1.AxisY[1].ShowLabels = false;
            cartesianChart1.AxisY[1].Title = cartesianChart1.AxisY[1].Title == Properties.Settings.Default.NameAi1 ? cartesianChart1.AxisY[1].Title = "" : cartesianChart1.AxisY[1].Title = Properties.Settings.Default.NameAi1;
            //cartesianChart1.AxisY[1].Separator.Stroke = cartesianChart1.AxisY[1].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[1].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[1].Separator.Stroke = Brushes.Black;
            checkBox2.BackColor = checkBox2.BackColor == System.Drawing.Color.Gainsboro ? checkBox2.BackColor = System.Drawing.Color.Gray : checkBox2.BackColor = System.Drawing.Color.Gainsboro;

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            hour1.Value= date.Value;
            hour2.Value= date.Value;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas3.Visibility = MaterialGas3.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[2].ShowLabels = cartesianChart1.AxisY[2].ShowLabels == false ? cartesianChart1.AxisY[2].ShowLabels = true : cartesianChart1.AxisY[2].ShowLabels = false;
            cartesianChart1.AxisY[2].Title = cartesianChart1.AxisY[2].Title == Properties.Settings.Default.NameAi2 ? cartesianChart1.AxisY[2].Title = "" : cartesianChart1.AxisY[2].Title = Properties.Settings.Default.NameAi2;
            checkBox3.BackColor = checkBox3.BackColor == System.Drawing.Color.Gainsboro ? checkBox3.BackColor = System.Drawing.Color.Gray : checkBox3.BackColor = System.Drawing.Color.Gainsboro;

            // cartesianChart1.AxisY[2].Separator.Stroke = cartesianChart1.AxisY[2].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[2].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[2].Separator.Stroke = Brushes.Black;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas4.Visibility = MaterialGas4.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[3].ShowLabels = cartesianChart1.AxisY[3].ShowLabels == false ? cartesianChart1.AxisY[3].ShowLabels = true : cartesianChart1.AxisY[3].ShowLabels = false;
            cartesianChart1.AxisY[3].Title = cartesianChart1.AxisY[3].Title == Properties.Settings.Default.NameAi3 ? cartesianChart1.AxisY[3].Title = "" : cartesianChart1.AxisY[3].Title = Properties.Settings.Default.NameAi3;
            checkBox4.BackColor = checkBox4.BackColor == System.Drawing.Color.Gainsboro ? checkBox4.BackColor = System.Drawing.Color.Gray : checkBox4.BackColor = System.Drawing.Color.Gainsboro;

            // cartesianChart1.AxisY[3].Separator.Stroke = cartesianChart1.AxisY[3].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[3].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[3].Separator.Stroke = Brushes.Black;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas5.Visibility = MaterialGas5.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[4].ShowLabels = cartesianChart1.AxisY[4].ShowLabels == false ? cartesianChart1.AxisY[4].ShowLabels = true : cartesianChart1.AxisY[4].ShowLabels = false;
            cartesianChart1.AxisY[4].Title = cartesianChart1.AxisY[4].Title == Properties.Settings.Default.NameAi4 ? cartesianChart1.AxisY[4].Title = "" : cartesianChart1.AxisY[4].Title = Properties.Settings.Default.NameAi4;
            checkBox5.BackColor = checkBox5.BackColor == System.Drawing.Color.Gainsboro ? checkBox5.BackColor = System.Drawing.Color.Gray : checkBox5.BackColor = System.Drawing.Color.Gainsboro;

            // cartesianChart1.AxisY[4].Separator.Stroke = cartesianChart1.AxisY[4].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[4].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[4].Separator.Stroke = Brushes.Black;
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas6.Visibility = MaterialGas6.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[5].ShowLabels = cartesianChart1.AxisY[5].ShowLabels == false ? cartesianChart1.AxisY[5].ShowLabels = true : cartesianChart1.AxisY[5].ShowLabels = false;
            cartesianChart1.AxisY[5].Title = cartesianChart1.AxisY[5].Title == Properties.Settings.Default.NameAi5 ? cartesianChart1.AxisY[5].Title = "" : cartesianChart1.AxisY[5].Title = Properties.Settings.Default.NameAi5;
            checkBox6.BackColor = checkBox6.BackColor == System.Drawing.Color.Gainsboro ? checkBox6.BackColor = System.Drawing.Color.Gray : checkBox6.BackColor = System.Drawing.Color.Gainsboro;

            // cartesianChart1.AxisY[5].Separator.Stroke = cartesianChart1.AxisY[5].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[5].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[5].Separator.Stroke = Brushes.Black;
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas7.Visibility = MaterialGas7.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[6].ShowLabels = cartesianChart1.AxisY[6].ShowLabels == false ? cartesianChart1.AxisY[6].ShowLabels = true : cartesianChart1.AxisY[6].ShowLabels = false;
            cartesianChart1.AxisY[6].Title = cartesianChart1.AxisY[6].Title == Properties.Settings.Default.NameAi6 ? cartesianChart1.AxisY[6].Title = "" : cartesianChart1.AxisY[6].Title = Properties.Settings.Default.NameAi6;
            checkBox7.BackColor = checkBox7.BackColor == System.Drawing.Color.Gainsboro ? checkBox7.BackColor = System.Drawing.Color.Gray : checkBox7.BackColor = System.Drawing.Color.Gainsboro;

            // cartesianChart1.AxisY[6].Separator.Stroke = cartesianChart1.AxisY[6].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[6].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[6].Separator.Stroke = Brushes.Black;
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            MaterialGas8.Visibility = MaterialGas8.Visibility == Visibility.Visible
                 ? Visibility.Hidden
                 : Visibility.Visible;
            cartesianChart1.AxisY[7].ShowLabels = cartesianChart1.AxisY[7].ShowLabels == false ? cartesianChart1.AxisY[7].ShowLabels = true : cartesianChart1.AxisY[7].ShowLabels = false;
            cartesianChart1.AxisY[7].Title = cartesianChart1.AxisY[7].Title == Properties.Settings.Default.NameAi7 ? cartesianChart1.AxisY[7].Title = "" : cartesianChart1.AxisY[7].Title = Properties.Settings.Default.NameAi7;
            checkBox8.BackColor = checkBox8.BackColor == System.Drawing.Color.Gainsboro ? checkBox8.BackColor = System.Drawing.Color.Gray : checkBox8.BackColor = System.Drawing.Color.Gainsboro;

            // cartesianChart1.AxisY[7].Separator.Stroke = cartesianChart1.AxisY[7].Separator.Stroke == Brushes.Black ? cartesianChart1.AxisY[7].Separator.Stroke = Brushes.Transparent : cartesianChart1.AxisY[7].Separator.Stroke = Brushes.Black;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Timer.Start();
            _viewModel.Read(times1);
            button3.Enabled = false;
            //button4.Enabled = false;
            button5.Enabled = false;
           // button6.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
           // Timer.Stop();
           _viewModel.Stop();
            button3.Enabled = true;
            //button4.Enabled = true;
            button5.Enabled = true;
           // button6.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.save_para == true)
            {
                if (Properties.Settings.Default.MinAi0 != Properties.Settings.Default.MaxAi0)
                {
                    cartesianChart1.AxisY[0].MaxValue = Properties.Settings.Default.MaxAi0;
                    cartesianChart1.AxisY[0].MinValue = Properties.Settings.Default.MinAi0;
                }
                else
                {
                    cartesianChart1.AxisY[0].MaxValue = double.NaN;
                    cartesianChart1.AxisY[0].MinValue = 0;
                }
                if (Properties.Settings.Default.MinAi1 != Properties.Settings.Default.MaxAi1)
                {
                    cartesianChart1.AxisY[1].MaxValue = Properties.Settings.Default.MaxAi1;
                    cartesianChart1.AxisY[1].MinValue = Properties.Settings.Default.MinAi1;
                }
                else
                {
                    cartesianChart1.AxisY[1].MaxValue = double.NaN;
                    cartesianChart1.AxisY[1].MinValue = 0;
                }
                if (Properties.Settings.Default.MinAi2 != Properties.Settings.Default.MaxAi2)
                {
                    cartesianChart1.AxisY[2].MaxValue = Properties.Settings.Default.MaxAi2;
                    cartesianChart1.AxisY[2].MinValue = Properties.Settings.Default.MinAi2;
                }
                else
                {
                    cartesianChart1.AxisY[2].MaxValue = double.NaN;
                    cartesianChart1.AxisY[2].MinValue = 0;
                }
                if (Properties.Settings.Default.MinAi3 != Properties.Settings.Default.MaxAi3)
                {
                    cartesianChart1.AxisY[3].MaxValue = Properties.Settings.Default.MaxAi3;
                    cartesianChart1.AxisY[3].MinValue = Properties.Settings.Default.MinAi3;
                }
                else
                {
                    cartesianChart1.AxisY[3].MaxValue = double.NaN;
                    cartesianChart1.AxisY[3].MinValue = 0;
                }
                if (Properties.Settings.Default.MinAi4 != Properties.Settings.Default.MaxAi4)
                {
                    cartesianChart1.AxisY[4].MaxValue = Properties.Settings.Default.MaxAi4;
                    cartesianChart1.AxisY[4].MinValue = Properties.Settings.Default.MinAi4;
                }
                else
                {
                    cartesianChart1.AxisY[4].MaxValue = double.NaN;
                    cartesianChart1.AxisY[4].MinValue = 0;
                }
                if (Properties.Settings.Default.MinAi5 != Properties.Settings.Default.MaxAi5)
                {
                    cartesianChart1.AxisY[5].MaxValue = Properties.Settings.Default.MaxAi5;
                    cartesianChart1.AxisY[5].MinValue = Properties.Settings.Default.MinAi5;
                }
                else
                {
                    cartesianChart1.AxisY[5].MaxValue = double.NaN;
                    cartesianChart1.AxisY[5].MinValue = 0;
                }
                if (Properties.Settings.Default.MinAi6 != Properties.Settings.Default.MaxAi6)
                {
                    cartesianChart1.AxisY[6].MaxValue = Properties.Settings.Default.MaxAi6;
                    cartesianChart1.AxisY[6].MinValue = Properties.Settings.Default.MinAi6;
                }
                else
                {
                    cartesianChart1.AxisY[6].MaxValue = double.NaN;
                    cartesianChart1.AxisY[6].MinValue = 0;
                }
                if (Properties.Settings.Default.MinAi7 != Properties.Settings.Default.MaxAi7)
                {
                    cartesianChart1.AxisY[7].MaxValue = Properties.Settings.Default.MaxAi7;
                    cartesianChart1.AxisY[7].MinValue = Properties.Settings.Default.MinAi7;
                }
                else
                {
                    cartesianChart1.AxisY[7].MaxValue = double.NaN;
                    cartesianChart1.AxisY[7].MinValue = 0;
                }
               
                cartesianChart1.AxisY[0].Title = Properties.Settings.Default.NameAi0;
                cartesianChart1.AxisY[1].Title = Properties.Settings.Default.NameAi1;
                cartesianChart1.AxisY[2].Title = Properties.Settings.Default.NameAi2;
                cartesianChart1.AxisY[3].Title = Properties.Settings.Default.NameAi3;
                cartesianChart1.AxisY[4].Title = Properties.Settings.Default.NameAi4;
                cartesianChart1.AxisY[5].Title = Properties.Settings.Default.NameAi5;
                cartesianChart1.AxisY[6].Title = Properties.Settings.Default.NameAi6;
                cartesianChart1.AxisY[7].Title = Properties.Settings.Default.NameAi7;
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
                Properties.Settings.Default.save_para = false;
                Properties.Settings.Default.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            _viewModel.Values.Clear();
            _viewModel.Values1.Clear();
            _viewModel.Values2.Clear();
            _viewModel.Values3.Clear();
            _viewModel.Values4.Clear();
            _viewModel.Values5.Clear();
            _viewModel.Values6.Clear();
            _viewModel.Values7.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            List<float> value = new List<float>();
            List<float> value1 = new List<float>();
            List<float> value2 = new List<float>();
            List<float> value3 = new List<float>();
            List<float> value4 = new List<float>();
            List<float> value5 = new List<float>();
            List<float> value6 = new List<float>();
            List<float> value7 = new List<float>();
           
            busy1 = false;
            count_tong = 0;
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
            _viewModel.Search(times1, Day1, Day2);

           

        }

        private void button4_Click(object sender, EventArgs e)
        {
             


        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            busy1 = false;
            count_tong = 0;
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
            WriteExcel.WriteReport_pdf(Day1, Day2);
             //WriteExcel.WriteReport(Day1, Day2);
        }



        private void button6_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = double.NaN;
            cartesianChart1.AxisX[0].MaxValue = double.NaN;
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
        private void AxOnRangeChanged(RangeChangedEventArgs eventArgs)
        {
            
        }
    }
}
