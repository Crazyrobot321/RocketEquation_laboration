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


            var sum = fuel.Aggregate((acck,x) => acck + calc.CalculateFuel(x));
            //foreach(var x in fuel)
            //{
            //    sum += calc.CalculateFuel(x);
            //}
            Console.WriteLine($"{sum}");
            Console.WriteLine(path);
        }
    }
}
