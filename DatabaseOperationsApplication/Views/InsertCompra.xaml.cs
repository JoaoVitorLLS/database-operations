using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using DatabaseOperationsApplication.ViewModels;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace DatabaseOperationsApplication.Views
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class InsertPageView : Page
    {
        public InsertPageView()
        {
            this.InitializeComponent();
        }

        private void BtnIDCompra_Click(object sender, RoutedEventArgs e)
        {
            if (IDdigitada.Text.Length > 0)
            {
                CreateOperationPageViewModel viewModel = new CreateOperationPageViewModel();
                viewModel.InsertOrder(IDdigitada.Text);
            }
        }

        private void BtnComprar_Click(object sender, RoutedEventArgs e)
        {
            if (CodCompra.Text.Length > 0 && IDproduto.Text.Length > 0)
            {
                CreateOperationPageViewModel viewModel = new CreateOperationPageViewModel();
                viewModel.InsertProducts(CodCompra.Text, IDproduto.Text);
            }
            
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CreateOperationPageViewModel viewModel = new CreateOperationPageViewModel();
            viewModel.SelectOrder(IDdigitada.Text);
        }

        private void ViewTodosProdutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CreateOperationPageViewModel viewModel = new CreateOperationPageViewModel();
            viewModel.SelectProdutos();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
