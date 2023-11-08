using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLoggerAppV1
{
    internal class DbReadBool
    {
        public bool MStream1 { get; set; }
        public bool MStream2 { get; set; }
        public bool MStream3 { get; set; }
        public bool ManAuto { get; set; }
        public bool SystemStatusAuto { get; set; }
        public bool SystemStatusMan { get; set; }
        public bool SystemStatusLowAlarm { get; set; }
        public bool SystemStatusHighAlarm { get; set; }

        public bool SystemRunningAuto { get; set; }
        public bool SystemRunningMan { get; set; }
        public bool MStreamStatus1 { get; set; }
        public bool MStreamStatus2 { get; set; }
        public bool MStreamStatus3 { get; set; }
        public bool AStream1 { get; set; }
        public bool AStream2 { get; set; }
        public bool AStream3 { get; set; }

        public bool LowAlarm0 { get; set; }
        public bool LowAlarm1 { get; set; }
        public bool LowAlarm2 { get; set; }
        public bool LowAlarm3 { get; set; }
        public bool LowAlarm4 { get; set; }
        public bool LowAlarm5 { get; set; }
        public bool LowAlarm6 { get; set; }
        public bool LowAlarm7 { get; set; }

        public bool InletStream1 { get; set; }
        public bool InletStream2 { get; set; }
        public bool InletStream3 { get; set; }
        public bool BypassStream1 { get; set; }
        public bool BypassStream2 { get; set; }
        public bool BypassStream3 { get; set; }
        public bool LevelSwitch { get; set; }
        public bool Free26 { get; set; }

        public bool HighAlarm0 { get; set; }
        public bool HighAlarm1 { get; set;}
        public bool HighAlarm2 { get; set;}
        public bool HighAlarm3 { get; set;}
        public bool HighAlarm4 { get; set;}
        public bool HighAlarm5 { get; set;}
        public bool HighAlarm6 { get; set;}
        public bool HighAlarm7 { get; set;}
    }
}
