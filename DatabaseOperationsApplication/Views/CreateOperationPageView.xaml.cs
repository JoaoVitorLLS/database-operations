using DatabaseOperationsApplication.ViewModels;
using Windows.UI.Xaml.Controls;

namespace DatabaseOperationsApplication.Views
{
    public sealed partial class CreateOperationPageView : Page
    {
        public CreateOperationPageView()
        {
            InitializeComponent();
        }

        private void BtnInserir_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (CustumerId.Text.Length > 0 && CompanyName.Text.Length > 0 && ContactName.Text.Length > 0
                && ContactTitle.Text.Length > 0 && Addres.Text.Length > 0 && Cidade.Text.Length > 0
                && Regiao.Text.Length > 0 && PostalCode1.Text.Length > 0 && Pais.Text.Length > 0
                && Fone.Text.Length > 0 && Fax.Text.Length > 0)
            {
                CreateOperationPageViewModel viewModel = new CreateOperationPageViewModel();
                viewModel.InsertCustomer(CustumerId.Text, CompanyName.Text, ContactName.Text,
                    ContactTitle.Text, Addres.Text, Cidade.Text, Regiao.Text, PostalCode1.Text,
                    Pais.Text, Fone.Text, Fax.Text);
            }
            
        }
    }
}
