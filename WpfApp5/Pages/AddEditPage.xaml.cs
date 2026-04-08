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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>S
    public partial class AddEditPage : Page
    {
        Product product;
        public AddEditPage(Product _product)
        {
            InitializeComponent();
            UnitCb.ItemsSource = Connect.connect.Units.ToList();
            UnitCb.DisplayMemberPath = "Name";
            SupplierCb.ItemsSource = Connect.connect.Supplier.ToList();
            SupplierCb.DisplayMemberPath = "Name";
            ManufactCb.ItemsSource = Connect.connect.Manufacturer.ToList();
            ManufactCb.DisplayMemberPath= "Name";
            CategoryCb.ItemsSource= Connect.connect.Category.ToList();
            CategoryCb.DisplayMemberPath = "Name";
            product = _product;
            this.DataContext = product;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try

            {
                product.Units_Id = (UnitCb.SelectedItem as Units).Id;
                product.Supplier_Id = (SupplierCb.SelectedItem as Supplier).Id;
                product.Manufacturer_Id = (ManufactCb.SelectedItem as Manufacturer).Id;
                product.Product_Categories_Id = (CategoryCb.SelectedItem as Category).Id;
                if (product.Article == "")
                {
                    Connect.connect.Product.Add(product);
                }
                Connect.connect.SaveChanges();
                MessageBox.Show("Операция прошла успешно!");
                NavigationService.Navigate(new ProductListPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CanselBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductListPage());
        }
    }
}
