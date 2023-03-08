using System;

namespace PerguntaValores
{
    /// <summary>
    /// Ask the player for a height and a radius of a cylinder. Uses these
    /// values to calculate and display the volume and surface area of the
    /// cylinder
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the player for the cylinder's height
            Console.WriteLine("Please provide the cylinder's height:");
            //Receive the value, convert it to float and store it
            float a = Convert.ToSingle(Console.ReadLine());
            //Ask the player for the cylinder's radius
            Console.WriteLine("Please provide the cylinder's radius:");
            //Receive the value, convert it to float and store it
            float r = Convert.ToSingle(Console.ReadLine());

            //Print blank line so the results don't appear all together
            Console.WriteLine();
            //Calculate and print the cylinder's volume
            Console.WriteLine($"Volume: {Math.PI * Math.Pow(r,2) * a}");
            //Calculate and print and cylinder's surface area
            Console.WriteLine($"Surfaces Area: {2 * Math.PI * r * (r + a)}");
        }
    }
}