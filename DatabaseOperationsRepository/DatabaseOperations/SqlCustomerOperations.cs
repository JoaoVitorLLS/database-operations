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

        public void InsertCustomer(string custumerId, string companyName, string contactName, string contactTitle,
            string adress, string city, string region, string postalCode, string country,
            string fone, string fax)
        {
            var queryString = "Insert into Customers (CustomerID , CompanyName, ContactName, ContactTitle, Adress, " +
                "City, Region, PostalCode, Country, Phone, Fax) values('" + custumerId + "', '" + companyName + "', '" + 
                contactName + "', '" + contactTitle + "', '" + adress + "', '" + city + "', '" + region + "', '" + 
                postalCode + "', '" + country + "', '" + fone + "', '" + fax + "');";
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
