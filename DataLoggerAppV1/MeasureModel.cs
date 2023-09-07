using LiveCharts.Geared;
using System;
using System.Collections.Generic;

namespace Winforms.Cartesian.ConstantChanges
{
    public class MeasureModel
    {
        public System.DateTime DateTime { get; set; }
        public double Value { get; set; }
    }
    public class Model
    {
        public List<DateTime> DateTime{ get; set; }
        public GearedValues<double> Value { get; set; }
    }
}
