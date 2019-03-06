using System;

namespace BottlesOfBeer
{
    public static class Program
    {
        public static void Main()
        {
            for (int i = 99; i > 0; i--)
            {
                int bottleNum = i;
                int lastBottle = i - 1;
                Console.WriteLine($"{bottleNum} bottles of beer on the wall. {bottleNum} bottles of beer. Take 1 down and pass it around, {lastBottle} bottles of beer on the wall." );
            }
            
            Console.ReadLine();
        }
    }
}
