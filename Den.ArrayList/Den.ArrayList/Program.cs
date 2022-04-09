using System;
using System.Collections.Generic;

namespace Den.ArrayList
{
    internal class Program
    {
        enum NaturalNumber  // Перечисление.
        {
            One,Two,Three
        }
        enum week
        {
            Mon, Tue, Wed, Thu, Fri, Sat, Sun
        }
        static void Main(string[] args)
        {
            /*
            int[] arrOne = new int[3];
            arrOne[0] = 1;
            arrOne.SetValue(2,1);
            Console.WriteLine(arrOne[0]);
            Console.WriteLine(arrOne.GetValue(1));
            int[,] arrTwo = new int[3,3];
            arrTwo[0,0] = -3;
            Console.WriteLine(arrTwo[0,0]);

            List<int> listOne = new List<int>();
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add((int)NaturalNumber.One);

            List<int> listTwo = new List<int> 
            { 
                1,2,3,4,5
            };
            Console.WriteLine((int)NaturalNumber.One);
            */
            /*
             * ДЗ
             * Создать список из 5 элементов и вывести на консоль
             * Создать массив из 5 элементов и вывести на консоль
             * Создать перечисление и вывести на консоль
             */
            List<int> list = new List<int> 
            { 
                1,2,3,4
            };
            list.Add(5);
            Console.WriteLine(list[0]+" "+ list[1] + " " + list[2] + " " + list[3] + " " + list[4] + "\n");
            int[] arr = new int[5]
            {
                1,2,3,4,5
            };
            Console.WriteLine(arr[0] + " " + arr[1] + " " + arr[2] + " " + arr[3] + " " + arr[4]);

            Console.WriteLine(week.Mon.ToString()+" "+week.Tue.ToString()+" "+week.Wed.ToString()+" "+week.Thu.ToString()+" "+week.Fri.ToString()+" "+week.Sat.ToString()+" "+week.Sun.ToString());
            Console.ReadKey();
        }
    }
}
