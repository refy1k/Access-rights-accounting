﻿using Access_rights_accounting.Classes;
using Access_rights_accounting.Model;
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
    /// Логика взаимодействия для RolePage.xaml
    /// </summary>
    public partial class RolePage : Page
    {
        public RolePage()
        {
            InitializeComponent();
            DGRolePage.ItemsSource = Accounting_for_access_rightsEntities.GetContext().Roles.ToList();
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.WorkFrame.Navigate(new ChoicePage());
        }
    }
}
