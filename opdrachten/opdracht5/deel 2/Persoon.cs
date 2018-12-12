using System;

namespace deel2
{
    public class Persoon : Gebruiker, IInformatie
    {
        public string Naam
        {
            get;
            set;
        }

        public string VolledigeNaam
        {
            get
            {
                return this.naam + " " + this.voornaam;
            }
        }

        private string naam;
        private string voornaam;
        public DateTime Geboortedatum
        {
            get;

            set;

        }

        public string Voornaam
        {
            get
            {
                return this.voornaam;
            }
            set
            {
                this.voornaam = value;
            }

        }

        // -----------------------------------------------------METHODES


        public int Leeftijd()
        {
            return 2;
        }
        public override string GenereerWachtwoord()
        { return "ww"; }

        // public virtual int GenereerWachtwoord()
        // {
        //     return 2511655;
        // }

        public string GenereerWachtwoord(string input)
        {
            // Console.WriteLine("Maak zelf een wachtwoord");
            // string newWW = Console.ReadLine();
            return input;
        }
        public int GenereerWachtwoord(int input)
        {
            // Console.WriteLine("Maak zelf een wachtwoord");
            // string newWW = Console.ReadLine();
            return input;
        }

        public override string ToString()
        {
            return "waarden van object Persoon";
        }

    }
}