using System;

namespace Den.Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberOne= 5; //UpperCamelCase
            Console.WriteLine(NumberOne);
            int numberTwo = 5; //lowerCamelCase
            Console.WriteLine(numberTwo);
            int number_three=5; //snake_case
            Console.WriteLine(number_three);
            const int NUMBER_FOUR = 5; // SNAKE_CASE
            Console.WriteLine(NUMBER_FOUR);
            string str ="32";
            int i = Convert.ToInt32(str);
            Console.WriteLine(i);
            str = "d24";
            int j;
            bool result = int.TryParse(str,out j);
            Console.WriteLine(j+" "+result);
            str = result.ToString();
            Console.WriteLine(str);
            if (bool.TryParse(str, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("true");
            }
            str = str.Insert(0,Console.ReadLine());
            Console.WriteLine(str);
            double d = 1.2;
            float f = (float)d;
            d = f;

            Console.WriteLine(str += f);
            Console.ReadKey();
        }
    }
}
