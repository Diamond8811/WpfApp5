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
        public AddEditPage()
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
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CanselBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
