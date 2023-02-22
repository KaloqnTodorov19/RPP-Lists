using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while(true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                if(command == "print")
                {
                    break;
                }
                switch(command)
                {
                    case"add":
                        {
                            var index = int.Parse(input[1]);
                            var element = int.Parse(input[2]);
                            nums.Insert(index, element);
                            break;
                        }
                    case "addMany":
                        {

                            break;
                        }


                    default:
                    break;
                }

            }
        }
    }
}
