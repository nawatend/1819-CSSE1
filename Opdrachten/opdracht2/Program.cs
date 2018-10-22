using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Opdracht 2!");


            for (int counter = 1; counter < 11; counter++)
            {

                for (int counter2 = 1; counter2 < 11; counter2++)
                {
                    Console.WriteLine(counter + " x " + counter2 + " = " + multiply(counter, counter2));

                }
            }

            Console.WriteLine("Dit is faculteit van 5: " + faculti(5));
            Console.WriteLine("Dit is fibonachi van 22de keer: " + fibonachi(22));
        }
        static int multiply(int a, int b)
        {

            return a * b;
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
