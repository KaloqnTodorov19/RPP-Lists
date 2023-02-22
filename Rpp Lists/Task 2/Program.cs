using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

             nums = nums.Where(x => x >= 0).ToArray();

            if(nums.Length == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Array.Reverse(nums);
                Console.WriteLine("Resulting list:", string.Join(" ", nums));
            }
        }
    }
}
