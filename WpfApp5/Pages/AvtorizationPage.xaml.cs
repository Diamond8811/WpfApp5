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

namespace WpfApp5.Pages
{
    /// <summary>
    /// Логика взаимодействия для AvtorizationPage.xaml
    /// </summary>
    public partial class AvtorizationPage : Page
    {
        public AvtorizationPage()
        {
            InitializeComponent();
            App.mainWindow.TitleTb.Text = "Страница авторизации";
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            App.avtorizationUser = db.Connect.connect.User.FirstOrDefault(x => x.Login == LoginTb.Text && x.Password == PasswordTb.Password);
            if(App.avtorizationUser != null)
            {
                MessageBox.Show("Авторизация прошла успешно");
                NavigationService.Navigate(new ProductListPage());
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }

          
        }
    }
}
