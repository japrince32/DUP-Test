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
using MahApps.Metro.Controls;

namespace DUPMuseum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        Uri currentPage = null;
        Uri HOME = new Uri("search.xaml", UriKind.Relative);
        Uri SPLIT_PAGE = new Uri("SplitPage.xaml", UriKind.Relative);
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(HOME);
            currentPage = HOME;
        }

        private void btnNewTitle_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnNav1_Click(object sender, RoutedEventArgs e)
        {
            if (currentPage == HOME)
            {
                MainFrame.Navigate(SPLIT_PAGE);
                btnNav1.Content = "Search";
                currentPage = SPLIT_PAGE;
            }
            else if (currentPage == SPLIT_PAGE)
            {
                MainFrame.Navigate(HOME);
                btnNav1.Content = "Split Page";
                currentPage = HOME;
            }

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();

            // set owner of login dialog (allows centered window)
            login.Owner = this;
            login.ShowDialog();
        }
    }
}
