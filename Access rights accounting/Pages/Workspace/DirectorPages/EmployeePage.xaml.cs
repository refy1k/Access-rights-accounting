using Access_rights_accounting.Classes;
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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        public EmployeePage()
        {
            InitializeComponent();
            DGUsersPage.ItemsSource = Accounting_for_access_rightsEntities.GetContext().Users.ToList();
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.WorkFrame.Navigate(new ChoicePage());
        }

        private void BntEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
