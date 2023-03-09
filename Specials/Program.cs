using System;

namespace Specials
{
    /// <summary>
    /// This program will print the min and max values of the types that
    /// allow this operation
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Print min and max value of a byte
            Console.WriteLine($"Byte Max Value: {byte.MaxValue}");
            Console.WriteLine($"Byte Min Value: {byte.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print min and max value of a sbyte
            Console.WriteLine($"Sbyte Max Value: {sbyte.MaxValue}");
            Console.WriteLine($"Sbyte Min Value: {sbyte.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print min and max value of a short
            Console.WriteLine($"Short Max Value: {short.MaxValue}");
            Console.WriteLine($"Short Min Value: {short.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print min and max value of a ushort
            Console.WriteLine($"Ushort Max Value: {ushort.MaxValue}");
            Console.WriteLine($"Ushort Min Value: {ushort.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print min and max value of a int
            Console.WriteLine($"Int Max Value: {int.MaxValue}");
            Console.WriteLine($"Int Min Value: {int.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print min and max value of a uint
            Console.WriteLine($"Uint Max Value: {uint.MaxValue}");
            Console.WriteLine($"Uint Min Value: {uint.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print min and max value of a long
            Console.WriteLine($"Long Max Value: {long.MaxValue}");
            Console.WriteLine($"Long Min Value: {long.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print min and max value of a ulong
            Console.WriteLine($"Ulong Max Value: {ulong.MaxValue}");
            Console.WriteLine($"Ulong Min Value: {ulong.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print min and max value of a char
            Console.WriteLine($"Char Max Value: {char.MaxValue}");
            Console.WriteLine($"Char Min Value: {char.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print min and max value of a float
            Console.WriteLine($"Float Max Value: {float.MaxValue}");
            Console.WriteLine($"Float Min Value: {float.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print min and max value of a double
            Console.WriteLine($"Double Max Value: {double.MaxValue}");
            Console.WriteLine($"Double Min Value: {double.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print min and max value of a decimal
            Console.WriteLine($"Decimal Max Value: {decimal.MaxValue}");
            Console.WriteLine($"Decimal Min Value: {decimal.MinValue}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            ///Print with a separation line to better distinguish
            /// both parts of the exercise
            Console.WriteLine("-----------------------------------");

            //Empty print to prevent a block of text
            Console.WriteLine();
            
            //Print positive and negative infinity through a double
            Console.WriteLine($"Double Positive Infinity: {double.PositiveInfinity}");
            Console.WriteLine($"Double Negative Infinity: {double.NegativeInfinity}");
            
            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print positive and negative infinity through a float
            Console.WriteLine($"Float Positive Infinity: {float.PositiveInfinity}");
            Console.WriteLine($"Float Negative Infinity: {float.NegativeInfinity}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Print positive and negative infinity through a double
            Console.WriteLine($"Double NaN: {double.NaN}");
            Console.WriteLine($"Float NaN: {float.NaN}");
        }
    }
}
