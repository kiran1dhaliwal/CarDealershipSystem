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
    /// Interaction logic for AddEmployeeUC.xaml
    /// </summary>
    public partial class AddEmployeeUC : UserControl
    {
        public AddEmployeeUC()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {

           
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;
            string officeAddress = officeAddressTextBox.Text;
            string un = usernameTextBox.Text;
            string pwd = passwordTextBox.Text;
            string phoneExtension = phoneExtensionTextBox.Text;
            string role = roleTextBox.Text;

            Person p = new Person();
            p.Name = name;
            p.Address = address;
            p.Phone = phone;
            Employee em = new Employee();
            em.OfficeAddress = officeAddress;
            em.PhoneExtension = phoneExtension;
            em.Username = un;
            em.Password = pwd;
            em.Role = role;
            em.EmployeeNavigation = p;

            DAO db = new DAO();
            db.addEmployee(em);
            MessageBox.Show("Employee data addded successfully");
            

        }
    }
}
