using RocketEquation;

namespace Rocketequation.Tests
{
    public class EquationTest
    {
        //Fuel required to launch a given module is based on its mass.
        //Specifically, to find the fuel required for a module, take its mass,
        //divide by three, round down, and subtract 2.

        //Del 1
        [Theory]
        [InlineData(12,2)]
        [InlineData(14,2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void CanCalculateFuelForOneModule(int mass, int expected)
        {

            // Arrange
            var sut = new FuelCalculator();

            // Act
            var actual = sut.CalculateFuel(mass);

            // Assert
            Assert.Equal(expected, actual);
        }

        ////Del 2
        //[Fact]
        //public void CanCalculate_FuelMass_UntilZeroOrNegative
    }
}
