using System;
using System.Collections.Generic;
namespace opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Voertuig auto1 = new Voertuig(4);
            // Console.WriteLine(auto1.ToString());


            // // properties value aanvullen, deze manier heeft meer code nodig dan manier boven.
            // Voertuig auto = new Voertuig();
            // auto.Laadvermogen = 11;
            // Console.WriteLine(auto.ToString());



            //Deel 2: OOP
            //VRAGEN    
            // - Welke klasse is de subklasse? Welke de basisklasse?   DONE
            // ==== ik gebruik geen subklasse. MenuItem, Product, Price zijn basisklasse. 
            // - Ga nu aan de slag met de klassen en maak 10 instanties van de klasse MenuItem, geef ook relevante waarden voor de instanties.   DONE
            // - Sla deze instanties op in een lijst.   DONE
            // - Overloop alle elementen in de lijst en maak gebruik van je implementatie van de ToString() functie, om per object een weergave af te drukken via de Console. 
            // - Als je een sortering zou uitvoeren op de elementen van de lijst hoe zou dit dan implementeren?      

            List<MenuItem> listOfMenuItem = new List<MenuItem>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("Menu Item: " + (i + 1));

                Product newProduct = new Product("Kip Salade Nr. " + i, "Salade", new string[] { "kip", "groeten" });
                Price newPrice = new Price("EUR", i + 1 * 1.42);
                MenuItem newMenuItem = new MenuItem(newProduct, newPrice);


                listOfMenuItem.Add(newMenuItem);
            }

            foreach (var item in listOfMenuItem)
            {
                Console.WriteLine(item);
            }
        }
    }


}
