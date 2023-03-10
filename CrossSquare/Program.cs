using System;

namespace CrossSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(args[0]);

            for (int i = 1; i <= number; i++)
            {
                if(i == 1 || i == number)
                {
                    string cardinal_line = new String(char.Parse("#"), number);
                    Console.WriteLine(cardinal_line);
                }
                else
                {
                    for (int x = 1; x <= number; x++)
                    {
                        if(x == 1 || x == number)
                        {
                            Console.Write("#");
                        }
                        else if(x == i || x == number - i + 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
