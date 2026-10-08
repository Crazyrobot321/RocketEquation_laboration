using AdventOfCode.Common;

namespace RocketEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(AppContext.BaseDirectory, "input.txt");
            var text = File.ReadAllText(path);
            var fuel = Input.Numbers(text);

            var calc = new FuelCalculator();


            var sum = fuel.Aggregate(0, (acck,x) => acck + calc.CalculateFuel(x));
            var sum2 = 0;
            foreach (var x in fuel)
            {
                sum2 += calc.CalculateFuel(x);
            }
            Console.WriteLine($"{sum}");
            Console.WriteLine($"{sum2}");
        }
    }
}
