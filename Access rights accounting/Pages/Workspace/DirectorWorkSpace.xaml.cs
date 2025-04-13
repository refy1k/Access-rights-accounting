using Access_rights_accounting.Classes;
using Access_rights_accounting.Pages.Workspace.DirectorPages;
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
    /// Логика взаимодействия для DirectorWorkSpace.xaml
    /// </summary>
    public partial class DirectorWorkSpace : Page
    {
        public DirectorWorkSpace()
        {
            InitializeComponent();
            WorkFrame.Navigate(new ChoicePage());
            PageNavigation.WorkFrame = WorkFrame;
        }
    }
}
