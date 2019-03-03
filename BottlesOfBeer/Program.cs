using System;

namespace BottlesOfBeer
{
    public static class Program
    {
        public static void Main()
        {
            int counter = 99;
            for (int i = 1; i < 100; i++)

                counter = NewMethod(counter);

            Console.ReadLine();
        }

        private static int NewMethod(int counter)
        {
            Console.WriteLine($" {counter} bottles of beer on the wall.");

            Console.WriteLine($" {counter} bottles of beer");

            Console.WriteLine($"Take one down. Pass it around.");

            counter--;
            
            Console.WriteLine($" {counter} bottles of beer on the wall.");
            Console.WriteLine();
            return counter;
        }
            
        }
    }

