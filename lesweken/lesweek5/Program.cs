using System;

namespace lesweek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //string always small -- string is array van char
            string tekst = " This is string ";

            int length = tekst.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(tekst[i]);

            }
            Console.WriteLine(tekst.ToUpper());
            Console.WriteLine(tekst.ToLower());

            //read word by wrod
            string[] woorden = tekst.Split(' ');
            foreach (var woord in woorden)
            {

                Console.WriteLine(woord);
            }


            //remove spaces. Write char within ' ' 
            //this removes every spaces
            Console.WriteLine(tekst.Replace(" ", ""));

            //this removes before and after spaces a string
            //Console.WriteLine(tekst);
            Console.WriteLine(tekst.Trim(' '));

            string wachtword = "test";
            bool test1 = wachtword.Contains('b');
            Console.WriteLine(test1);
            bool test2 = wachtword.Contains('b');
            Console.WriteLine(test2);
            bool test3 = wachtword.Contains('t');

            if (wachtword == "text")
            {
                Console.WriteLine("Het wachtwoord is gelijk aan test");
            }

            //string.Equals(wachtword, "test") ? Console.WriteLine("Het wachtwoord is gelijk aan test") : Console.WriteLine("Het wachtwoord is niet gelijk aan test");

            Random randomGetal = new Random();
            int getal1 = randomGetal.Next(0, 20);
            Console.WriteLine(getal1);
            int getal2 = randomGetal.Next(0, 20);
            Console.WriteLine(getal2);
            int getal3 = randomGetal.Next(0, 20);
            Console.WriteLine(getal3);


            for (int i = 0; i < 50; i++)
            {

                Console.WriteLine(randomGetal.Next(0, 20));
            }

            char[] chars = new char[0];
            chars[0] = ' ';
            chars[1] = 'G';
            //char aanroepen met behulp van integer waarde
            chars[2] = (char)78;
            //Char aanroepen door middel van de unicode  van het karakter
            chars[3] = '\u002E';
            chars[4] = 'f';
            chars[5] = 'a';
            chars[6] = 'i';
            chars[7] = (char)85;


            foreach (char c in chars)
            {

                Console.Write(c);
            }


            char[] campus = { 'M', 'A', 'B' };
            // 3 is aantal items/elementen  dat we willen in deze array
            string[] menu1 = new string[3];
            menu1[0] = "broodje martino";
            menu1[1] = "broodje boulet";
            menu1[2] = "broodje kaas";

            foreach (var item in menu1)
            {

                Console.Write(item);
            }

            string[] menu2 = new string[] { "broodje scampi", "broodje brei", "broodje oulet" };
            foreach (var item in menu2)
            {

                Console.Write(item);
            }

            Console.WriteLine("For Loop:");

            for (int i = 0; i < menu2.Length; i++)
            {


                Console.WriteLine(menu2[i]);
            }

            string[,] menu3 = new string[,] { { "broodje scampi", "4" }, { "broodje brei", "5" }, { "broodje oulet", "891" } };
            foreach (var item in menu3)
            {

                Console.Write(item);
            }

        }
    }
}
