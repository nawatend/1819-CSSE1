using System;
using System.Collections.Generic;
using System.Linq;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Create dictionary and add five keys and values.
            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            dictionary.Add("Plat Water", 1);
            dictionary.Add("Cola 25 cl", 1.5);
            dictionary.Add("Cola 33 cl", 2);
            dictionary.Add("Witte Wijn", 3);
            dictionary.Add("Pils", 2.5);
            dictionary.Add("Toast", 5);
            dictionary.Add("Kaasplank", 4);



            //sort by name
            dictionary = SortByName(dictionary);
            //read dictionary
            //Loop through keys. Keys to list
            var keys = new List<string>(dictionary.Keys);
            foreach (var key in keys)
            {
                Console.WriteLine("{0}: -- {1}", key, dictionary[key.ToString()]);
            }

            //sort by Price
            dictionary = SortByPrice(dictionary);

            var keyPrice = new List<string>(dictionary.Keys);
            foreach (var k in keyPrice)
            {
                Console.WriteLine("{0}:* {1}", k, dictionary[k.ToString()]);
            }


            //Search item in dictionary collection
            Console.WriteLine("Write Search value: ");
            GetItemFromCollection(Console.ReadLine(), dictionary);

        }
        static Dictionary<string, double> SortByName(Dictionary<string, double> dictionaryOriginal)
        {
            Console.WriteLine();
            Console.WriteLine("Sort by Name: ");
            var keys = new List<string>(dictionaryOriginal.Keys);
            keys.Sort();
            Dictionary<string, double> newDict = new Dictionary<string, double>();
            foreach (string key in keys)
            {
                //Console.WriteLine("{0}: {1}", key, dictionaryOriginal[key]);
                newDict.Add(key, dictionaryOriginal[key]);
            }
            return newDict;

        }

        static Dictionary<string, double> SortByPrice(Dictionary<string, double> dictionaryOriginal)
        {
            Console.WriteLine();
            Console.WriteLine("Sort by Price: ");
            //get values into list
            List<double> valuesToSort = new List<double>();

            foreach (KeyValuePair<string, double> kvp in dictionaryOriginal)
            {

                valuesToSort.Add(kvp.Value);
            }
            //sort these values
            valuesToSort.Sort();

            Dictionary<string, double> cloneDictOrignal = new Dictionary<string, double>(dictionaryOriginal);

            Dictionary<string, double> newDict = new Dictionary<string, double>();

            foreach (var item in valuesToSort)
            {
                foreach (KeyValuePair<string, double> kvp in cloneDictOrignal)
                {
                    if (cloneDictOrignal.Count != 0)
                    {

                        if (item == kvp.Value)
                        {
                            newDict.Add(kvp.Key, kvp.Value);
                            // Remove item with key
                            // cloneDictOrignal.Remove(kvp.Key); <---- cant change collection while enumaration
                        }
                    }
                }
            }

            return newDict;

        }

        static KeyValuePair<string, double> GetItemFromCollection(string searchValue, Dictionary<string, double> dictionaryOriginal)
        {


            KeyValuePair<string, double> found = new KeyValuePair<string, double>();


            foreach (KeyValuePair<string, double> kvp in dictionaryOriginal)
            {
                if (dictionaryOriginal.Count != 0)
                {

                    if (searchValue == kvp.Value.ToString() || searchValue == kvp.Key.ToString())
                    {

                        found = new KeyValuePair<string, double>(kvp.Key, kvp.Value);
                        Console.WriteLine("Found!: " + found.Key + " -> " + found.Value);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nothing Found! ");
                        found = new KeyValuePair<string, double>("Nothing Found! ", 0);

                    }
                }
            }


            return found;
        }
    }
}
