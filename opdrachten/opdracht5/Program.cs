using System;

namespace deel3

{
    class Program
    {
        static void Main(string[] args)
        {

            // -------------- Deel 1------------------------------- Verander namespace naar deel1

            // Console.WriteLine("-------------**** DEEL 1 **** ---------------");
            // Author author = new Author("Nawang", "n@gmail.com", 'M');
            // Book newBook = new Book("Le Book", author, 91.2, 4);

            // newBook.print();


            //////-----DEEL 2------------------------------ Verander namespace naar deel2
            // Opleiding o = new Opleiding { Campus = "Artevelde Mariakerke", OpleidingsNaam = "GDM" };
            // Console.WriteLine(o.ToString());

            // Student s = new Student { Naam = "Tendar", Geboortedatum = new DateTime(2017, 1, 18), Voornaam = "Nawang" };

            // s.Emailadres = "nawang@gmail.com";
            // Console.WriteLine(s.GenereerWachtwoord());


            /////------ DEEL 3------------------------------ Verander namespace naar deel3

            DBConnection connectie = DBConnection.Instance();
            DBConnection connectie2 = DBConnection.Instance();
            if (connectie == connectie2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            else
            {
                Console.WriteLine("Objects are not same instance");
            }


        }
    }
}
