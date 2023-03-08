using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the cylinder's height:");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please provide the cylinder's radius:");
            float r = Convert.ToSingle(Console.ReadLine());

            float pi = 3.1415926f;

            Console.WriteLine();
            Console.WriteLine($"Volume: {pi * (r*r) * a}");
            Console.WriteLine($"Surface's Area: {2* pi * r * (r + a)}");
        }
    }
}
