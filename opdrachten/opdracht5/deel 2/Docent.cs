using System.Collections.Generic;

namespace deel2
{


    class Docent : Persoon
    {

        public string E_mailadres
        {
            set;
            get;
        }

        public List<Opleiding> Opleidingen
        {

            set;
            get;
        }


        // public override int GenereerWachtwoord()
        // {
        //     return 455;
        // }
    }
}