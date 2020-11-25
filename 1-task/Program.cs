﻿using System;

namespace _1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an index");
            F f = new F();
            try
            {
                int index = Convert.ToInt32(Console.ReadLine());
                if (f[index] != null)
                    Console.WriteLine(f[index]);
                else
                    Console.WriteLine("index has to be 0 or 1");
            }
            catch
            {
                Console.WriteLine("index has to be 0 or 1");
            }
            Console.ReadKey();
        }

        class F
        {
            string x = "X";
            string y = "Y";
            public string this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0: return x;
                        case 1: return y;
                        default:
                            return null;
                    }
                }
            }
        }
    }
}
