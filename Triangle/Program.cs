using System;

namespace Triangle
{
    /// <summary>
    /// Receive via command line a character and a number and create a triangle
    /// using those parameters.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //For loop which increments a variable i each loop until the number
            //provided via the command line
            for(int i=1; i<=int.Parse(args[0]); i++)
            {
                //Creates a string with the character provided via the command
                //repeated i times
                string output = new String (char.Parse(args[1]), i);
                
                //Prints the intended string
                Console.WriteLine(output);
            }
        }
    }
}
