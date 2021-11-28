using DatabaseOperationsRepository.DatabaseConection;

namespace DatabaseOperationsRepository.DatabaseOperations
{
    public class SqlCustomerOperations
    {
        public void SelectCustomer(string customerIdentification)
        {
            var queryString = "SELECT * FROM Customers WHERE CustomerID = '" + customerIdentification + "';";
                SendQueryString(queryString);
        }

        public void InsertCustomer()
        {
            var queryString = "DELETE * FROM Customers WHERE CustomerID = '" + "AFND" + "';";
            SendQueryString(queryString);
        }

        public void DeleteCustomer(string customerIdentification)
        {
            var queryString = "DELETE * FROM Customers WHERE CustomerID = '" + customerIdentification + "';";
            SendQueryString(queryString);
        }

        private void SendQueryString(string queryString)
        {
            SqlDatabaseConnection sqlDatabaseConnection = new SqlDatabaseConnection();
            sqlDatabaseConnection.ExecuteCommand(queryString);
        }
    }
}
