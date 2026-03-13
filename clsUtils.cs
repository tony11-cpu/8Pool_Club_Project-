using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPoolClubProject
{
    public sealed class clsUtils
    {
        public sealed class cls8PoolEventArgs : EventArgs
        {
            public string TimeConsumed { get; set; } = "00:00:00";
            public double TotalSeconds { get; set; } = 0;
            public double HoulyRate { get; set; } = 0;
            public double TotalFees { get; set; } = 0;
            
            public cls8PoolEventArgs(string timeConsumed, double totalSeconds, double houlyRate, double totalFees)
            {
                TimeConsumed = timeConsumed;
                TotalSeconds = totalSeconds;
                HoulyRate = houlyRate;
                TotalFees = totalFees;
            }
        }

        static private readonly string _EventViewerSource = "8_Pool_Table";
        static private readonly string _WindoLogName = "Application";
        static public void RaiseLogToEventViewer(string MessageToLog)
        {
            if (!EventLog.SourceExists(_EventViewerSource))
                EventLog.CreateEventSource(_EventViewerSource, _WindoLogName);

            EventLog.WriteEntry(_EventViewerSource, MessageToLog, EventLogEntryType.Information);
        }
    }
}
