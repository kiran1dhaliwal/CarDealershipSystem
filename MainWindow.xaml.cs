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
using CarDealershipSystem.Stock_Management;

namespace CarDealershipSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddEmployeeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new AddEmployeeUC());
        }

        private void ShowEmployeeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new ShowEmployeeUC());
        }

        private void SearchEmployeemenuItem_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new SearchEmployeeUC());
        }

        private void UpdateEmployeeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new UpdateEmployeeUC());
        }

        private void SellCarNewCustomerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new SellCarToNewCustomerUC());
        }

        private void AddNewCarWithNewModel_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new AddNewCarNewModel());
        }

        private void AddNewCarWithExistingModel_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new NewCarWithExistingModelUC());
        }
    }
}
