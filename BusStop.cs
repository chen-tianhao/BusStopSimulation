using O2DESNet;

namespace BusStopSimulation
{
    public partial class BusStop : Sandbox
    {
        #region static
        public int FixedArrivalInterval { get; set; }
        public int FixedStopDuration { get; set; }
        #endregion

        #region dynamic
        public List<Bus> Queue { get; private set; }
        public double NumberOfBusArrival {  get; private set; }
        public double NumberOfBusDeparture { get; private set; }
        #endregion

        public BusStop(int seed = 0) : base(seed)
        {
            Init();
        }

        private void Init()
        {
            FixedArrivalInterval = GlobalConfig.PlanedArrivalInterval;
            FixedStopDuration = GlobalConfig.PlanedStopDuration;
            Queue = new List<Bus>();
            NumberOfBusArrival = 0;
            NumberOfBusDeparture = 0;
            Schedule(() => Arrive(new Bus()));
        }
    }
}
