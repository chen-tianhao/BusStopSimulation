using System.Reflection;

namespace BusStopSimulation
{
    public partial class BusStop
    {
        void Depart(Bus bus)
        {
            NumberOfBusDeparture += 1;
            Console.WriteLine(GlobalConfig.format, FDT(ClockTime), $"{bus} departs.", NumberOfBusArrival, Queue.Count, NumberOfBusDeparture);
            if (Queue.Count > 0 ) 
            {
                Berth();
            }
        }
    }
}
