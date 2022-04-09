using System;
using System.Collections.Generic;

namespace Den.IfElseSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int count=0;
            retryOne:
            if (count < 3)
            {
                if (int.TryParse(Console.ReadLine(), out arr[count]))
                {
                    count++;
                }
                goto retryOne;
            }
            int maxValue;
            if (arr[0] > arr[1])
            {
                if (arr[0] > arr[2])
                {
                    maxValue=arr[0];
                }
                else
                {
                    maxValue = arr[2];
                }
            }
            else
            {
                if (arr[1] > arr[2])
                {
                    maxValue = arr[1];
                }
                else 
                {
                    maxValue = arr[2];
                }
            }

            switch (maxValue%10)
            {
                case 0:
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine(maxValue+" четно");
                    break;
                default:
                    Console.WriteLine(maxValue+" нечетно");
                    break;
            }
            List<int> list = new List<int>();
            Console.WriteLine(list.Count < 100 ? "<100" : ">=100");
            retryTwo:
            if (list.Count < 100)
            {
                list.Add(1);
                goto retryTwo;
            }
            Console.WriteLine(list.Count < 100 ? "<100" : ">=100");
            Console.ReadKey();
        }
    }
}
