using O2DESNet.Distributions;
using O2DESNet.Standard;
using System.Reflection;
using System.Reflection.Metadata;

namespace BusStopSimulation
{
    public partial class BusStop
    {
        void Arrive(Bus bus)
        {
            Queue.Add(bus);
            NumberOfBusArrival += 1;
            Console.WriteLine(GlobalConfig.format, FDT(ClockTime), $"{bus} arrives.", NumberOfBusArrival, Queue.Count, NumberOfBusDeparture);
            OnArrive.Invoke();
            if (Queue.Count > NumberOfBusArrival - NumberOfBusDeparture - 1)
            {
                Berth();
            }
        }

        public event Action OnArrive;
    }
}
