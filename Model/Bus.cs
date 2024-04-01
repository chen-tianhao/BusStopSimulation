using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusStopSimulation
{
    public class Bus
    {
        int Idx;

        public Bus(int idx)
        {
            Idx = idx;
        }
        public override string ToString()
        {
            return $"Bus[{string.Format("{0:D4}", Idx)}]";
        }
    }
}
