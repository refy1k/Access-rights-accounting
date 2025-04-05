using Access_rights_accounting.Classes;
using Access_rights_accounting.Pages.Loading_Pages;
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

namespace Access_rights_accounting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new SplashWindow());
            ShowAuthorizationPageAfterDelay();

            PageNavigation.MainFrame = MainFrame;
        }

        private async void ShowAuthorizationPageAfterDelay()
        {
            await Task.Delay(1200);
            MainFrame.Navigate(new Authorization());
        }
    }
}
