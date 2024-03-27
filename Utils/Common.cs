
using System;

namespace BusStopSimulation
{
    public partial class BusStop
    {
        private string FDT(DateTime dt)
        {
            DateTime dt4Print = dt.AddYears(2023);
            return dt4Print.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }

    public class GlobalConfig
    {
        public static int BusIdxStartFrom = 1;
        public static readonly string format = "{0,-22} {1,-27} {2,-10} {3,-10} {4,-10}";

        public static readonly int PlanedArrivalInterval = 10;          // Minutes
        public static readonly int PlanedStopDuration = 1;              // Minutes

        public static readonly int ArriveRandomnessLowerBound = -15;    // Minutes
        public static readonly int ArriveRandomnessUpperBound = 15;     // Minutes

        public static readonly int BerthRandomnessLowerBound = -1;      // Minutes
        public static readonly int BerthRandomnessUpperBound = 10;      // Minutes
    }
}
