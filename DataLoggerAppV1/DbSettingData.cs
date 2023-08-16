using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLoggerAppV1
{
    internal class DbSettingData
    {
        public double Offset0 { get; set; }
        public double Offset1 { get; set; }
        public double Offset2 { get; set; }
        public double Offset3 { get; set; }
        public double Offset4 { get; set; }
        public double Offset5 { get; set; }
        public double Offset6 { get; set; }
        public double Offset7 { get; set; }

        public double Slope0 { get; set; }
        public double Slope1 { get; set; }
        public double Slope2 { get; set; }
        public double Slope3 { get; set; }
        public double Slope4 { get; set; }
        public double Slope5 { get; set; }
        public double Slope6 { get; set; }
        public double Slope7 { get; set; }

        public double AlarmLow0 { get; set;}
        public double AlarmLow1 { get; set;}
        public double AlarmLow2 { get; set;}
        public double AlarmLow3 { get; set;}
        public double AlarmLow4 { get; set;}
        public double AlarmLow5 { get; set;}
        public double AlarmLow6 { get; set;}
        public double AlarmLow7 { get; set;}

        public double AlarmHigh0 { get;set;}
        public double AlarmHigh1 { get;set;}
        public double AlarmHigh2 { get;set;}
        public double AlarmHigh3 { get;set;}
        public double AlarmHigh4 { get;set;}
        public double AlarmHigh5 { get;set;}
        public double AlarmHigh6 { get;set;}
        public double AlarmHigh7 { get;set;}

        public double SensorRangeMin0 { get; set; }
        public double SensorRangeMin1 { get; set; }
        public double SensorRangeMin2 { get; set; }
        public double SensorRangeMin3 { get; set; }
        public double SensorRangeMin4 { get; set; }
        public double SensorRangeMin5 { get; set; }
        public double SensorRangeMin6 { get; set; }
        public double SensorRangeMin7 { get; set; }

        public double SensorRangeMax0 { get; set; }
        public double SensorRangeMax1 { get; set; }
        public double SensorRangeMax2 { get; set; }
        public double SensorRangeMax3 { get; set; }
        public double SensorRangeMax4 { get; set; }
        public double SensorRangeMax5 { get; set; }
        public double SensorRangeMax6 { get; set; }
        public double SensorRangeMax7 { get; set; }


        public double MeasureRangeMin0 { get; set; }
        public double MeasureRangeMin1 { get; set; }
        public double MeasureRangeMin2 { get; set; }
        public double MeasureRangeMin3 { get; set; }
        public double MeasureRangeMin4 { get; set; }
        public double MeasureRangeMin5 { get; set; }
        public double MeasureRangeMin6 { get; set; }
        public double MeasureRangeMin7 { get; set; }

        public double MeasureRangeMax0 { get; set; }
        public double MeasureRangeMax1 { get; set; }
        public double MeasureRangeMax2 { get; set; }
        public double MeasureRangeMax3 { get; set; }
        public double MeasureRangeMax4 { get; set; }
        public double MeasureRangeMax5 { get; set; }
        public double MeasureRangeMax6 { get; set; }
        public double MeasureRangeMax7 { get; set; }

        public int AnalysisTime { get; set; }
        public int VentTime { get; set; }
    }
}
