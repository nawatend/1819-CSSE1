namespace deel2
{

    public class Opleiding : IInformatie
    {
        private string afkortingCampus;
        protected int campusNummer;
        public string Campus
        {
            //
            get;
            set;
        }

        public string OpleidingsNaam
        {
            get;
            set;
        }
        public string GetWifiCode()
        {
            return "code";
        }

        public Opleiding()
        {
            this.afkortingCampus = "AS";
            this.campusNummer = 5;
        }
        public override string ToString()
        {
            return string.Format("Campus {0} - campusnummer {1}", this.Campus, this.campusNummer);
        }

    }
}