using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmax
{
    internal class Program
    {
        static void Main()
        {

            Random rand = new Random();


            int[] numbers = new int[10];


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(0, 101);
            }


            Console.WriteLine("A tömb elemei:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            int min = numbers[0];
            int max = numbers[0];


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }


            Console.WriteLine($"A legkisebb elem: {min}");
            Console.WriteLine($"A legnagyobb elem: {max}");
        }
    }
}




