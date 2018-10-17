using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Opdracht 2!");

            Console.WriteLine(faculti(5));
            Console.WriteLine(fibonachi(10));
        }

        static int faculti(int number)
        {
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;


        }

        static string fibonachi(int length)
        {

            string results = "";
            int result = 0;
            int preValue1 = 1;
            int preValue2 = 0;
            for (int i = 0; i <= length; i++)
            {


                result = preValue2 + preValue1;

                preValue2 = preValue1;
                preValue1 = result;
                results += result.ToString() + ", ";

            }

            return results;
        }
    }
}
