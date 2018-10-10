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
            int resultaat1 = optellen(a, b);
            int resultaat2 = deling(a, b);

            Console.WriteLine(resultaat1);
        }

        static int optellen(int a, int b)
        {
            return a + b;
        }

        static int deling(int a, int b)
        {

            return a / b;
        }

    }
}
