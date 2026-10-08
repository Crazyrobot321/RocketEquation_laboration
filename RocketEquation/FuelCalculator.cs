using System;
using System.Collections.Generic;
using System.Text;

namespace RocketEquation
{
    public class FuelCalculator
    {
        //take its mass,
        //divide by three,
        //round down, and subtract 2.
        public int CalculateFuel(int mass)
        {
            return mass / 3 - 2;
        }
    }
}
