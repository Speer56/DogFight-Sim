using BFMTrainer.Core;


AircraftState aircraftState = new AircraftState
{
    Altitude_m = 3000,
    Airspeed_mps = 130,
    Heading_rad = Math.PI / 2,
};

ControlInput controlInput = new ControlInput
{
    ThrottleCommand = 0.8,
    PitchCommand = 0.1,
    RollCommand = -0.05,
    YawCommand = 0.02,
};

Console.WriteLine($"Aircraft State:");
Console.WriteLine($"Altitude: {aircraftState.Altitude_m} meters");
Console.WriteLine($"Airspeed: {aircraftState.Airspeed_mps} m/s");
Console.WriteLine($"Heading: {aircraftState.Heading_rad * 180.0 / Math.PI} degrees");
Console.WriteLine("\n");
Console.WriteLine($"Control Input:");
Console.WriteLine($"Throttle: {controlInput.ThrottleCommand}");
Console.WriteLine($"Pitch: {controlInput.PitchCommand}");
Console.WriteLine($"Roll: {controlInput.RollCommand}");
Console.WriteLine($"Yaw: {controlInput.YawCommand}");
