﻿using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(args[0]);
            x++;
            Console.WriteLine($"{x}");
        
            x = int.Parse(args[0]);
            --x;
            Console.WriteLine($"{x}");
        }
    }
}