using System.Data.SqlClient;

namespace DatabaseOperationsRepository.DatabaseConection
{
    internal class SqlDatabaseConnection
    {
        private const string ConnectionString = "Data Source=jvitor-g7-w11;Initial Catalog=Northwind;Integrated Security=True";

        private SqlConnection DatabaseConnection = new SqlConnection(ConnectionString);

        internal SqlDatabaseConnection()
        {
        }

        private void OpenConnection()
        {
            if (DatabaseConnection.State.Equals(0))
            {
                DatabaseConnection.Open();
            }
        }

        private void CloseConnection()
        {
            if (DatabaseConnection.State.Equals(1))
            {
                DatabaseConnection.Close();
            }
        }

        internal void ExecuteCommand(string queryString)
        {
            OpenConnection();
            _ = new SqlCommand(queryString, DatabaseConnection);
            CloseConnection();
        }
    }
}
