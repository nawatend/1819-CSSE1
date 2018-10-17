using System;

namespace lesweek3
{
    class Program
    {
        static void Main(string[] args)
        {

            // het afdrukke nvan tekst in console.
            Console.WriteLine("Hello World!");

            // functiono maken  _ Rekenmachine
            int a = 5;
            int b = 6;
            int resultaat1 = sum(a, b);
            int resultaat2 = divide(a, b);
            Console.WriteLine(resultaat1);


            int x = 100;
            int y = 7;
            int z = x + y;

            int i = 3;
            int j = z * i;

            int One = j;

            int k = 406;
            int l = 7367;

            int m = 69;
            int n = (k + l) / m;
            int Two = 5 * n;

            int p = 73;
            int q = 41;

            int r = p * q;

            int Three = r - 39;

            int s = 7;
            int t = 8;

            int u = 19;
            int Four = (s * t) - u;
            int result2 = One + Two + Three + Four;


            int result = sum(sum((multiply(sum(100, 7), 3)), (multiply(5, divide((sum(406, 7367)), 69)))), sum((aftrekken(multiply(73, 41), 39)), (aftrekken(multiply(7, 8), 19))));




            if (result == 3872)
            {
                Console.WriteLine("This result is correct: " + result);

            }
            else
            {
                Console.WriteLine("This result is incorrect: " + result);


            }

            Console.WriteLine(result2);
        }

        static int sum(int a, int b)
        {
            return a + b;
        }

        static int divide(int a, int b)
        {

            return a / b;
        }

        static int multiply(int a, int b)
        {

            return a * b;
        }

        static int aftrekken(int a, int b)
        {

            return a - b;
        }

    }
}
