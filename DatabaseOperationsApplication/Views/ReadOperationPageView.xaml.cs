using DatabaseOperationsApplication.ViewModels;
using Windows.UI.Xaml.Controls;

namespace DatabaseOperationsApplication.Views
{
    public sealed partial class ReadOperationPageView : Page
    {
        public ReadOperationPageView()
        {
            InitializeComponent();
        }

        private void SearchButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (customerIdentificationTextBox.Text.Length > 0)
            {
                ReadOperationPageViewModel viewModel = new ReadOperationPageViewModel();
                viewModel.ReadCustomer(customerIdentificationTextBox.Text);
            }
            else
            {
                customerIdentificationTextBox.Text = "Invalid customer identification!";
            }
        }
        private void DeleteButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        }
    }
}
