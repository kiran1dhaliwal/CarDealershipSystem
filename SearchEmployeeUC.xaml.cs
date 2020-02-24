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
using CarDealershipSystem.Models.DB;

namespace CarDealershipSystem
{
    /// <summary>
    /// Interaction logic for SearchEmployeeUC.xaml
    /// </summary>
    public partial class SearchEmployeeUC : UserControl
    {
        public SearchEmployeeUC()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            employeeGrid.Visibility = System.Windows.Visibility.Hidden;
            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (searchEmployeeIDTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter employee id first");
            }
            else
            {
                int eid = int.Parse(searchEmployeeIDTextBox.Text);
                DAO db = new DAO();
                Employee em = db.searchEmployeeByID(eid);
                if(em == null)
                {
                    MessageBox.Show("No employee found with this id");
                }else
                {
                    employeeGrid.Visibility = System.Windows.Visibility.Visible;
                    employeeIdTextBox.Text = em.EmployeeId.ToString();
                    nameTextBox.Text = em.EmployeeNavigation.Name;
                    phoneTextBox.Text = em.EmployeeNavigation.Phone;
                    addressTextBox.Text = em.EmployeeNavigation.Address;
                    officeAddressTextBox.Text = em.OfficeAddress;
                    phoneExtensionTextBox.Text = em.PhoneExtension;
                    usernameTextBox.Text = em.Username;
                    passwordTextBox.Text = em.Password;
                    roleTextBox.Text = em.Role;
                         
                }

            }
        }
    }
}
