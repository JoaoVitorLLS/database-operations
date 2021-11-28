using DatabaseOperationsApplication.ViewModels;
using Windows.UI.Xaml.Controls;

namespace DatabaseOperationsApplication.Views
{
    public sealed partial class DeleteOperationPageView : Page
    {
        public DeleteOperationPageView()
        {
            InitializeComponent();
        }

        private void DeleteButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (customerIdentificationTextBox.Text.Length > 0)
            {
                DeleteOperationPageViewModel viewModel = new DeleteOperationPageViewModel();
                viewModel.DeleteCustomer(customerIdentificationTextBox.Text);
            } 
            else
            {
                customerIdentificationTextBox.Text = "Invalid customer identification!";
            }
        }
    }
}
