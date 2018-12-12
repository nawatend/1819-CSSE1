using System;

namespace opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Object o = null;

            try
            {
                int i = (int)o;

            }

            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Exception e: " + e.Message));
            }

        }
    }
}
