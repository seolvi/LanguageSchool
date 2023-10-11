using LanguageSchool.Pages;
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

namespace LanguageSchool
{
    /// <summary>
    /// Логика взаимодействия для AuthorizatePage.xaml
    /// </summary>
    public partial class AuthorizatePage : Page
    {
        public AuthorizatePage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Password == "0000")
            {
                App.isAdmin = true;
                MessageBox.Show("Здравствуйте! Вы вошли как администратор!");
            }
            else
            {
                MessageBox.Show("Здравствуйте! Вы вошли как пользователь!");
            }
            
            NavigationService.Navigate(new ServiceListPage());
        }
    }
}
