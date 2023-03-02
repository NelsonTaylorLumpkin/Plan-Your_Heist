using System;


namespace Heist
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!!!");
            Console.WriteLine("Choose Your Ride-Or-Die!!!");
            string name = Console.ReadLine();
            Console.WriteLine("How good they is?");
            int skill = int.Parse(Console.ReadLine());
            Console.WriteLine("How Not Scared Are They?");
            double courage = double.Parse(Console.ReadLine());
            Console.WriteLine($"{name} {skill} {courage}");

        }
    }
}
