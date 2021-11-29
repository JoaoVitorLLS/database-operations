using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace DatabaseOperationsApplication.Views
{
    public sealed partial class MainMenuPageView : Page
    {
        public MainMenuPageView()
        {
            InitializeComponent();
        }

        private void PaneClosing(object sender, NavigationViewPaneClosingEventArgs e)
        {
            CreateMenuItem.Content = "C";
            ReadMenuItem.Content = "R";
            UpdateMenuItem.Content = "U";
            DeleteMenuItem.Content = "D";
            CompraMenuItem.Content = "c";
        }

        private void PaneOpening(object sender, object e)
        {
            CreateMenuItem.Content = "Create";
            ReadMenuItem.Content = "Read";
            UpdateMenuItem.Content = "Update";
            DeleteMenuItem.Content = "Delete";
            CompraMenuItem.Content = "Compra";
        }

        private void CreateMenuItemTapped(object sender, TappedRoutedEventArgs e)
        {
            PageContent.Navigate(typeof(CreateOperationPageView));
        }

        private void ReadMenuItemTapped(object sender, TappedRoutedEventArgs e)
        {
            PageContent.Navigate(typeof(ReadOperationPageView));
        }

        private void UpdateMenuItemTapped(object sender, TappedRoutedEventArgs e)
        {
            PageContent.Navigate(typeof(UpdateOperationPageView));
        }

        private void DeleteMenuItemTapped(object sender, TappedRoutedEventArgs e)
        {
            PageContent.Navigate(typeof(DeleteOperationPageView));
        }

        private void CompraMenuItemTapped(object sender, TappedRoutedEventArgs e)
        {
            PageContent.Navigate(typeof(InsertPageView));
        }
    }
}
