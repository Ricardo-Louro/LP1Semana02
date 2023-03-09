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
            //Define min and max value of a byte
            byte byte_min = byte.MinValue;
            byte byte_max = byte.MaxValue;

            //Print min, max and overflow value of a byte
            Console.WriteLine($"Byte Max Value: {byte_max}");
            Console.WriteLine($"Byte Overflow: {(byte)(byte_max + (byte) 1)}");
            Console.WriteLine($"Byte Min Value: {byte_min}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Define min and max value of an sbyte
            sbyte sbyte_min = sbyte.MinValue;
            sbyte sbyte_max = sbyte.MaxValue;

            //Print min, max and overflow value of an sbyte
            Console.WriteLine($"Sbyte Max Value: {sbyte_max}");
            Console.WriteLine($"Sbyte Overflow: {(sbyte)(sbyte_max + (sbyte) 1)}");
            Console.WriteLine($"Sbyte Min Value: {sbyte_min}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Define min and max value of a short
            short short_min = short.MinValue;
            short short_max = short.MaxValue;

            //Print min, max and overflow value of a short
            Console.WriteLine($"Short Max Value: {short_max}");
            Console.WriteLine($"Short Overflow: {(short)(short_max + (short) 1)}");
            Console.WriteLine($"Short Min Value: {short_min}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Define min and max value of a ushort
            ushort ushort_min = ushort.MinValue;
            ushort ushort_max = ushort.MaxValue;

            //Print min, max and overflow value of a ushort
            Console.WriteLine($"Ushort Max Value: {ushort_max}");
            Console.WriteLine($"Ushort Overflow: {(ushort)(ushort_max + (ushort) 1)}");
            Console.WriteLine($"Ushort Min Value: {ushort_min}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Define min and max value of an int
            int int_min = int.MinValue;
            int int_max = int.MaxValue;

            //Print min, max and overflow value of an int
            Console.WriteLine($"Int Max Value: {int_max}");
            Console.WriteLine($"Int Overflow: {(int)(int_max + (int) 1)}");
            Console.WriteLine($"Int Min Value: {int_min}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Define min and max value of a uint
            uint uint_min = uint.MinValue;
            uint uint_max = uint.MaxValue;
            
            //Print min, max and overflow value of a uint
            Console.WriteLine($"Uint Max Value: {uint_max}");
            Console.WriteLine($"Uint Overflow: {(uint)(uint_max + (uint) 1)}");
            Console.WriteLine($"Uint Min Value: {uint_min}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Define min and max value of a long
            long long_min = long.MinValue;
            long long_max = long.MaxValue;
            
            //Print min, max and overflow value of a long
            Console.WriteLine($"Long Max Value: {long_max}");
            Console.WriteLine($"Long Overflow: {(long)(long_max + (long) 1)}");
            Console.WriteLine($"Long Min Value: {long_min}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Define min and max value of a ulong
            ulong ulong_min = ulong.MinValue;
            ulong ulong_max = ulong.MaxValue;

            //Print min, max and overflow value of a ulong
            Console.WriteLine($"Ulong Max Value: {ulong_max}");
            Console.WriteLine($"Ulong Overflow: {(ulong)(ulong_max + (ulong) 1)}");
            Console.WriteLine($"Ulong Min Value: {ulong_min}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Define min and max value of a char
            char char_min = char.MinValue;
            char char_max = char.MaxValue;

            //Print min, max and overflow value of a char
            Console.WriteLine($"Char Max Value: {char_max}");
            Console.WriteLine($"Char Overflow: {(char)(char_max + (char) 1)}");
            Console.WriteLine($"Char Min Value: {char_min}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Define min and max value of a float
            float float_min = float.MinValue;
            float float_max = float.MaxValue;

            //Print min, max, overflow and underflow value of a float
            Console.WriteLine($"Float Max Value: {float_max}");
            Console.WriteLine($"Float Overflow: {(float)(float_max + (float) 1)}");
            Console.WriteLine($"Float Min Value: {float_min}");
            Console.WriteLine($"Float Underflow: {(float)(float_min - (float) 1)}");

            //Empty print to prevent a block of text
            Console.WriteLine();

            //Define min and max value of a float
            double double_min = double.MinValue;
            double double_max = double.MaxValue;

            //Print min, max, overflow and underflow value of a double
            Console.WriteLine($"Double Max Value: {double_max}");
            Console.WriteLine($"Double Overflow: {(double)(double_max + (double) 1)}");
            Console.WriteLine($"Double Min Value: {double_min}");
            Console.WriteLine($"Double Underflow: {(double)(double_min - (double) 1)}");

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
