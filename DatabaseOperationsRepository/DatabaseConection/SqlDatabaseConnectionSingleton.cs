namespace DatabaseOperationsRepository.DatabaseConection
{
    internal class SqlDatabaseConnectionSingleton
    {
        internal static SqlDatabaseConnectionSingleton Instance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new SqlDatabaseConnectionSingleton();
                }
                return Instance;
            }

            private set
            {
                if (value != null)
                {
                    Instance = value;
                }
            }
        }

        internal SqlDatabaseConnection DatabaseConnection
        {
            get
            {
                return DatabaseConnection;
            }

            private set
            {
                if (value != null)
                {
                    DatabaseConnection = value;
                }
            }
        }

        private SqlDatabaseConnectionSingleton()
        {
            DatabaseConnection = new SqlDatabaseConnection();
        }
    }
}
