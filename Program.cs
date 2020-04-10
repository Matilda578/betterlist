using System;
using System.Collections.Generic;

namespace NewListAttempt
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<int> biglist = new List<int>();
                int finalnumber = 0;
                while (biglist.Count < 5)
                {
                    Console.WriteLine("enter a number: " + (biglist.Count + 1));
                    biglist.Add(Int32.Parse(Console.ReadLine()));
                }
                
                Console.WriteLine("Input one more number ");
                finalnumber = Int32.Parse(Console.ReadLine());

                if (biglist.Contains(finalnumber))
                {
                    Console.WriteLine("this number is already entered");
                }
                else
                {
                    Console.WriteLine("this is a new numbner!");
                }
            }
        }
    }