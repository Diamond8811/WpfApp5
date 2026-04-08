using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp5.db;

namespace WpfApp5.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductListPage.xaml
    /// </summary>
    public partial class ProductListPage : Page
    {
        public ProductListPage()
        {
            InitializeComponent();
            if(App.avtorizationUser.RoleId != 1 || App.avtorizationUser.RoleId != 2)
                FilterSp.Visibility = Visibility.Collapsed;
            else
                FilterSp.Visibility = Visibility.Visible;

            App.mainWindow.TitleTb.Text = "Товары";
            ProductList.ItemsSource = Connect.connect.Product.ToList();
        }
        private void UpdateListProduct()
        {
            var products = Connect.connect.Product.ToList();
            if(SearchTb.Text.Length > 0 )
                { 
                products = products.Where(x=> x.Name.Contains(SearchTb.Text) || x.Article.Contains(SearchTb.Text) || x.Description.Contains(SearchTb.Text)).ToList();
            }
            if (FilterCb.SelectedIndex == 1)
            {
                products = products.OrderBy(x => x.Coast).ToList();
            }
            else { products = products.OrderByDescending(x => x.Coast).ToList(); }
                ProductList.ItemsSource = products;

        }
        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateListProduct();
        }

        private void FilterCb_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditPage(new Product()));
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectProduct = ProductList.SelectedItem as Product;
        }
    }
}
