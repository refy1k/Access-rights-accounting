﻿using Access_rights_accounting.Classes;
using Access_rights_accounting.Pages.Workspace.EmployeePages;
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

namespace Access_rights_accounting.Pages.Workspace
{
    /// <summary>
    /// Логика взаимодействия для MainWorkSpace.xaml
    /// </summary>
    public partial class MainWorkSpace : Page
    {
        public MainWorkSpace()
        {
            InitializeComponent();
            WorkFrame.Navigate(new ApplicationPage());
            PageNavigation.WorkFrame = WorkFrame;
        }
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.MainFrame.Navigate(new Authorization());
        }
    }
}
