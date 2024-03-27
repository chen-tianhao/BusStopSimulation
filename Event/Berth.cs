using O2DESNet.Distributions;
using System.Reflection;

namespace BusStopSimulation
{
    public partial class BusStop
    {
        void Berth()
        {
            Bus firstBusInQueue = Queue[0];
            Queue.Remove(firstBusInQueue);
            Console.WriteLine(GlobalConfig.format, FDT(ClockTime), $"{firstBusInQueue.ToString()} berths.", NumberOfBusArrival, Queue.Count, NumberOfBusDeparture);
            TimeSpan BerthingRandomness = TimeSpan.FromMinutes(DefaultRS.Next(GlobalConfig.BerthRandomnessLowerBound, GlobalConfig.BerthRandomnessUpperBound));
            Schedule(() => Depart(firstBusInQueue), TimeSpan.FromMinutes(FixedStopDuration).Add(BerthingRandomness));
        }
    }
}
