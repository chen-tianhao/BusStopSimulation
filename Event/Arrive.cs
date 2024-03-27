using O2DESNet.Distributions;
using System.Reflection;

namespace BusStopSimulation
{
    public partial class BusStop
    {
        void Arrive(Bus bus)
        {
            Queue.Add(bus);
            NumberOfBusArrival += 1;
            Console.WriteLine(GlobalConfig.format, FDT(ClockTime), $"{bus} arrives.", NumberOfBusArrival, Queue.Count, NumberOfBusDeparture);
            TimeSpan ArrivalRandomness = TimeSpan.FromMinutes(DefaultRS.Next(GlobalConfig.ArriveRandomnessLowerBound, GlobalConfig.ArriveRandomnessUpperBound));
            Schedule(() => Arrive(new Bus()), TimeSpan.FromMinutes(FixedArrivalInterval).Add(ArrivalRandomness));

            if (Queue.Count > NumberOfBusArrival - NumberOfBusDeparture - 1)
            {
                Berth();
            }
        }
    }
}
