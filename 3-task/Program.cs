using System;
using _3_task.Classes;

namespace _3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Choose an array you want to work with, 1 or 2");
                Console.WriteLine("1: int[]");
                Console.WriteLine("2: string[]");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1) Console.WriteLine(1);
                while (number != 1 && number != 2)
                {
                    Console.WriteLine("only 1 or 2");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                if (number == 1)
                {
                    Console.WriteLine("You chose int array\n");
                    Console.WriteLine("Write array size");
                    int arraySize = Convert.ToInt32(Console.ReadLine());
                    ArrayWork arrayWork = new ArrayWork(arraySize);
                    Console.WriteLine($"Size of the array is {arraySize}\n");
                    Console.WriteLine("Write an index of the array to see an element");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"In index {index} is {arrayWork[index]}\n");
                    Console.WriteLine("If you want to change this value write new value, if don't want write '0'");
                    int newValue = Convert.ToInt32(Console.ReadLine());
                    if (newValue != 0)
                    {
                        arrayWork[index] = newValue;
                        Console.WriteLine($"You successfully change the value in index {index} on {arrayWork[index]}");
                    }
                }
                else if (number == 2)
                {
                    Console.WriteLine("You chose string array\n");
                    Console.WriteLine("Write array size");
                    int arraySize = Convert.ToInt32(Console.ReadLine());
                    ArrayWorkStr arrayWork = new ArrayWorkStr(arraySize);
                    Console.WriteLine($"Size of the array is {arraySize}\n");
                    Console.WriteLine("Write an index of the array to see an element");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"In index {index} is {arrayWork[index]}\n");
                    Console.WriteLine("If you want to change this value write new value, if don't want write '0'");
                    string newValue = Console.ReadLine();
                    if (newValue != "0")
                    {
                        arrayWork[index] = newValue;
                        Console.WriteLine($"You successfully change the value in index {index} on {arrayWork[index]}");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Must be an integer");
            }
        }
    }

}
