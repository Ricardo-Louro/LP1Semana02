using System;

namespace CrossSquare
{
    /// <summary>
    /// Receives an argument and uses it to make a square with an X made of
    /// Xs inside based on said argument
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Convert the argument into int
            int number = int.Parse(args[0]);

            //For loop until i becomes bigger than i and increments i each turn
            for (int i = 1; i <= number; i++)
            {
                //On the first and last loop
                if(i == 1 || i == number)
                {
                    //Create a line with the correct number of #
                    string cardinal_line = new String(char.Parse("#"), number);
                    //Print said line
                    Console.WriteLine(cardinal_line);
                }
                //If it's not the first and last loop
                else
                {
                    //For loop until i becomes bigger than number and increments
                    //i each turn
                    for (int x = 1; x <= number; x++)
                    {
                        //If it's the first and last character of the line
                        if(x == 1 || x == number)
                        {
                            //Print #
                            Console.Write("#");
                        }
                        //If it's the correct place for the X
                        else if(x == i || x == number - i + 1)
                        {
                            //Print X
                            Console.Write("X");
                        }
                        //If none of these cases are true
                        else
                        {
                            //Print a space
                            Console.Write(" ");
                        }
                        
                    }
                    //Break line for the next loop
                    Console.WriteLine();
                }
            }
        }
    }
}
