// See https://aka.ms/new-console-template for more information
namespace Motorcykel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Motorcycle mc1 = new();
            Motorcycle mc2 = new("Zusuky", true);
            Console.WriteLine(mc1);

            Console.WriteLine();

            Console.WriteLine(mc2);

            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.W:
                        mc2.ShiftGearsUp();
                        break;
                    case ConsoleKey.S:
                        mc2.ShiftGearsDown();
                        break;
                    case ConsoleKey.E:
                        mc2.Rpm += 1000;
                        break;
                    case ConsoleKey.D:
                        mc2.Rpm -= 1000;
                        break;
                        default:
                        break;
                }
            }
        }
    }
}
