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
    /// Interaction logic for UpdateEmployeeUC.xaml
    /// </summary>
    public partial class UpdateEmployeeUC : UserControl
    {
        Employee em;
        public UpdateEmployeeUC()
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

        private void SearchEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (searchEIDTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter employee id first");
            }
            else
            {
                int eid = int.Parse(searchEIDTextBox.Text);
                DAO db = new DAO();
                 em = db.searchEmployeeByID(eid);
                if (em == null)
                {
                    MessageBox.Show("No employee found with this id");
                }
                else
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

        private void UpdateEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            em.EmployeeNavigation.Name = nameTextBox.Text;
            em.EmployeeNavigation.Address = addressTextBox.Text;
            em.EmployeeNavigation.Phone = phoneTextBox.Text;
            em.PhoneExtension = phoneExtensionTextBox.Text;
            em.Username = usernameTextBox.Text;
            em.Password = passwordTextBox.Text;
            em.Role = roleTextBox.Text;
            em.OfficeAddress = officeAddressTextBox.Text;
            DAO db = new DAO();
            db.updateEmployee(em);
            MessageBox.Show("Employee data has been updated");

        }
    }
}
