﻿using Access_rights_accounting.Classes;
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

namespace Access_rights_accounting.Pages.Workspace.DirectorPages
{
    /// <summary>
    /// Логика взаимодействия для ChoicePage.xaml
    /// </summary>
    public partial class ChoicePage : Page
    {
        public ChoicePage()
        {
            InitializeComponent();
        }

        private void BtnEmployee_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.WorkFrame.Navigate(new EmployeePage());
        }

        private void BtnRole_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.WorkFrame.Navigate(new RolePage());
        }

        private void BntLog_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.WorkFrame.Navigate(new LogPage());
        }
    }
}
