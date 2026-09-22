namespace BFMTrainer.Core;
public struct ControlInput
{
    public double ThrottleCommand { get; set; }
    public double PitchCommand { get; set; }
    public double RollCommand { get; set; }
    public double YawCommand { get; set; }
}