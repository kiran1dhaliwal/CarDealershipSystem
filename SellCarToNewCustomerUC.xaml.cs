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
    /// Interaction logic for SellCarToNewCustomerUC.xaml
    /// </summary>
    public partial class SellCarToNewCustomerUC : UserControl
    {
        public SellCarToNewCustomerUC()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void SellButton_Click(object sender, RoutedEventArgs e)
        {
            int carId = int.Parse(carIDTextBox.Text);
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;
            string licencseNumber = licenceNumberTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            DateTime licenceExpiryDate = licenceExpiryDateDatePicker.SelectedDate.Value;

            Person p = new Person();
            p.Address = address;
            p.Name = name;
            p.Phone = phone;

            Customer cust = new Customer();
            cust.LicenceExpiryDate = licenceExpiryDate;
            cust.LicenceNumber = licencseNumber;
            cust.Age = age;
            cust.CustomerNavigation = p;

            DAO db = new DAO();
            Car car = db.searchCarByID(carId);
            decimal totalPrice = decimal.Parse(totalPriceTextBox.Text);
            string notes = notesTextBox.Text;

            db.sellCar(car, cust, totalPrice , notes);
            MessageBox.Show("Car Sold successfully");

        }
    }
}
