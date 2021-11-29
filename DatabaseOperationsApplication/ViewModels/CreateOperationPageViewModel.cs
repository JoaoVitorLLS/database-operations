
using DatabaseOperationsRepository.DatabaseOperations;

namespace DatabaseOperationsApplication.ViewModels
{
    internal class CreateOperationPageViewModel
    {
        internal void InsertCustomer(string custumerId, string companyName, string contactName, string contactTitle,
            string adress, string city, string region, string postalCode, string country,
            string fone, string fax)
        {
            SqlCustomerOperations operations = new SqlCustomerOperations();
            operations.InsertCustomer(custumerId, companyName, contactName, contactTitle,
             adress, city, region, postalCode, country,
             fone, fax);
        }

        internal void InsertOrder(string custumerId)
        {
            SqlOrderOperations operations = new SqlOrderOperations();
            operations.InsertOrder(custumerId);
        }

        internal void InsertProducts(string orderId, string productId)
        {
            SqlOrderOperations operations = new SqlOrderOperations();
            operations.InsertProducts(orderId, productId);
        }

        internal void SelectOrder(string custumerId)
        {
            SqlOrderOperations operations = new SqlOrderOperations();
            operations.SelectOrder(custumerId);
        }

        internal void SelectProdutos()
        {
            SqlOrderOperations operations = new SqlOrderOperations();
            operations.SelectProdutos();
        }
    }
}
