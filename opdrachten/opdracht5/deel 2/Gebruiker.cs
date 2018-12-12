namespace deel2
{



    public class Gebruiker
    {

        protected string wachtwoord;
        public string Gebruikersnaam
        {
            get;
            set;
        }

        public virtual string GenereerWachtwoord()
        {
            return "generated ww";
        }
        public void GenereerGebruikersnaam()
        {

        }
        public Gebruiker()
        {

            this.wachtwoord = GenereerWachtwoord();
        }
    }
}