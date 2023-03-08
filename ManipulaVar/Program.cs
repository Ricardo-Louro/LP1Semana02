using System;

namespace ManipulaVar
{
    /// <summary>
    /// This program will convert the first argument provided into int, then
    /// utilize it in an operation with ++ and another with --
    /// </summary>
    class Program
    {
        /// <summary>
        /// Receive the arguments provided through the console
        /// </summary>
        /// <param name="args">String able to be converted into an int</param>
        static void Main(string[] args)
        {
            //Convert the argument into an int
            int x = int.Parse(args[0]);
            //Increment it after evaluating x for the current expression 
            x++;
            //Print the current value of x
            Console.WriteLine($"{x}");
        
            //Convert the argument into an int
            x = int.Parse(args[0]);
            //Decrement it before evaluating x for the current expression
            --x;
            //Print the current value of x
            Console.WriteLine($"{x}");
        }
    }
}