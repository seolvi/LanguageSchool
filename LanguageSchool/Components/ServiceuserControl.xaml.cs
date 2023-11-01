﻿using LanguageSchool.Pages;
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

namespace LanguageSchool.Components
{
    /// <summary>
    /// Логика взаимодействия для ServiceuserControl.xaml
    /// </summary>
    public partial class ServiceuserControl : UserControl
    {
        private Service service;
        public ServiceuserControl(Service _service)
        {
            InitializeComponent();
            service=_service;   
            if (App.isAdmin == false)
            {
                EditBtn.Visibility = Visibility.Hidden;
                DeleteBtn.Visibility = Visibility.Hidden;
            }
            TitleTb.Text = service.Title;
            CostTimeTb.Text = service.costTimeStr;
            DiscountTb.Text = service.DiscountStr;
            CostTb.Text = service.Cost.ToString("N0");
            CostTb.Visibility = service.CostVisibility;
            MainBorder.Background = service.ColorDiscount;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        { 
         Navigation.NextPage(new PageComponent("Редактирование услуги", new AddEditeServicePage(service)));
        }

    private void DeleteBtn_Click(object sender, RoutedEventArgs e)
    {
        if (service.ClientService != null)
        {
            MessageBox.Show("ЗАПРЕЩЕНО УДАЛЯТЬ ");
        }
        else
        {
            App.db.Service.Remove(service);
            App.db.SaveChanges();
        }
    }
}
}
