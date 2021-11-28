using DatabaseOperationsRepository.DatabaseOperations;

namespace DatabaseOperationsApplication.ViewModels
{
    internal class DeleteOperationPageViewModel
    {
        internal void DeleteCustomer(string customerIdentification)
        {
            SqlCustomerOperations operations = new SqlCustomerOperations();
            operations.DeleteCustomer(customerIdentification);
        }
    }
}
