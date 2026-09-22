using BFMTrainer.Core;
namespace BFMTrainer.JSBSim;

public class JSBSimFlightDynamicsModel : IFlightDynamicsModel
{
    public AircraftState State { get;}
    public void Step(double deltaTime)
    {
        throw new NotImplementedException();
    }
    public void SetControls(ControlInput controlInput)
    {
        throw new NotImplementedException();
    }
}