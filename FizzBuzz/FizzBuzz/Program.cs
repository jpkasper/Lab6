﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        // this is a comment by josiah poss
        // testing two, three, one
        static void Main(string[] args)
        {
            for(int i = 1; i < 101; i++)
            {
                if(i % 3 == 0)
                {
                    if(i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    } else
                    {
                        Console.WriteLine("Fizz");
                    }
                } else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
            // hello world
            Console.ReadKey();
            //John's change
        }
    }
}
