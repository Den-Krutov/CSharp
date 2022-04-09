using System;
using System.Collections.Generic;

namespace ForWhileForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            while (list.Count < 15)
            {
                if(int.TryParse(Console.ReadLine(),out int temp))
                {
                    list.Add(temp);
                }
            }
            var result = 0;
            for (int i=0;i<list.Count;i++)
            {
                result += list[i];
            }
            Console.WriteLine(result);
            int k =0;
            while (k<list.Count)
            {
                result-=list[k];
                k++;
            }
            Console.WriteLine(result);
            k = 0;
            result = 1;
            do
            {
                result *= list[k];
                k++;
            } 
            while (k < list.Count);
            Console.WriteLine(result);
            foreach (int temp in list)
            {
                Console.Write(temp+" ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
