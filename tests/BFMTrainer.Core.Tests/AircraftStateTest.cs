using BFMTrainer.Core;
namespace BFMTrainer.Core.Tests;

public class AircraftStateTests
{
    [Fact]
    public void AircraftState_Properties_Test()
    {
        // Arrange
        var aircraftState = new AircraftState();

        // Act
        aircraftState.Altitude_m = 3000;
        aircraftState.Airspeed_mps = 130;
        aircraftState.Heading_rad = Math.PI / 2;

        // Assert
        Assert.Equal(3000, aircraftState.Altitude_m);
        Assert.Equal(130, aircraftState.Airspeed_mps);
        Assert.Equal(Math.PI / 2, aircraftState.Heading_rad);
    }
}
