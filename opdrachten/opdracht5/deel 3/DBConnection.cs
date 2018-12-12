namespace deel3
{
    class DBConnection
    {



        private static DBConnection _instance;


        protected DBConnection()
        {

        }

        public static DBConnection Instance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;

        }
    }
}