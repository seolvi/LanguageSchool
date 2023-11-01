﻿using System;
using System.IO;
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
using LanguageSchool.Pages;

namespace LanguageSchool
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigation.mainWindow = this;
            //var path = @"C:\Users\212125\Downloads\Task (1)\Сессия 1\services_s_import\";
            //foreach(var item in App.db.Service.ToArray())
            //{
            //    var fullPath = path + item.MainImagePath;
            //    item.MainImage = File.ReadAllBytes(fullPath); 
            //}
            //App.db.SaveChanges();
            Navigation.NextPage(new PageComponent("Авторизация", new AuthorizatePage()));


        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.BackPage();
        }


        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.ClearHistory();
            Navigation.NextPage(new PageComponent("Авторизация", new AuthorizatePage()));
        }
    }
}
