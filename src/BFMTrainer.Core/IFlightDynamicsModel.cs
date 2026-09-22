namespace BFMTrainer.Core;
public interface IFlightDynamicsModel
{    
    AircraftState State { get; }
    void SetControls (ControlInput controlInput);
    void Step (double deltaTime);
}