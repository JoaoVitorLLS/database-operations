using DatabaseOperationsRepository.DatabaseConection;


namespace DatabaseOperationsRepository.DatabaseOperations
{
    public class SqlOrderOperations
    {
        public void SelectProdutos()
        {
            var queryString = "SELECT productID, productName from Products;";
            SendQueryString(queryString);
        }

        public void InsertProducts(string orderId, string productId)
        {
            var queryString = "INSERT INTO [Order Details](OrderID ,ProductID) VALUES (" +
            orderId + ", " + productId;
            SendQueryString(queryString);

        }

        public void InsertOrder(string custumerId)
        {
            var queryString = "INSERT INTO Order (CustomerID) VALUES ('" +
            custumerId + "'); " ;
            SendQueryString(queryString);
        }
        public void SelectOrder(string custumerId)
        {
            var queryString = "EXEC busca '" + custumerId + "';"; //Executa a procedure feita no banco
            SendQueryString(queryString);
        }


        private void SendQueryString(string queryString)
        {
            SqlDatabaseConnection sqlDatabaseConnection = new SqlDatabaseConnection();
            sqlDatabaseConnection.ExecuteCommand(queryString);
        }

    }
}
