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
using LanguageSchool.Components;

namespace LanguageSchool.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditeServicePage.xaml
    /// </summary>
    public partial class AddEditeServicePage : Page
    {
        private Service service;
        public AddEditeServicePage(Service _service)
        {
            InitializeComponent();
            service = _service;
            this.DataContext = service;
        }

        private void EditImageBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (App.db.Service.Any(x=>x.Title==service.Title))
            {
                error.AppendLine("Хелоу Бамбук! Не тупи чувак такая услуга уже существует!");
            }
            if (service.DurationInSeconds > 14400)
            {
                error.AppendLine("Ну ты бамбук ВРЕМЯ УСЛУГИ НЕ МОЖЕТ ПРЕВЫШАТЬ 4 ЧАСА!");
            }
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (service.ID == 0)
            {
                App.db.Service.Add(service);
            }
            App.db.SaveChanges();
        }
    }
}
