using System;

namespace Den.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i = 5.2;
            double j = 3.2;
            i += j;
            Console.WriteLine("i=" + i);
            String s1 ="Hello";
            dynamic s2 = s1.Clone();
            Console.WriteLine(s1 + " " + s2);
            int k=s2.Length; ;
            Console.WriteLine(k);
            decimal d = 2.30001M;
            Console.WriteLine(d);
            s1 = d.ToString();
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
