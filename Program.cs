using BusStopSimulation;

Console.WriteLine("[A bus stop showcase]");

int seed = 0; // Particant can change different seed for testing
var model = new BusStop(seed);
Console.WriteLine("{0,-22} {1,-27} {2,-10} {3,-10} {4,-10}", "Clock Time", "Event", "Arrival#", "Queue Len", "Departure#");
model.Run(TimeSpan.FromHours(24));

Console.WriteLine();
