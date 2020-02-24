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

namespace CarDealershipSystem.Stock_Management
{
    /// <summary>
    /// Interaction logic for NewCarWithExistingModelUC.xaml
    /// </summary>
    public partial class NewCarWithExistingModelUC : UserControl
    {
        public NewCarWithExistingModelUC()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            DAO db = new DAO();
            featureComboBox.ItemsSource = db.getCarFeature();
            featureComboBox.DisplayMemberPath = "Feature";
            featureComboBox.SelectedValuePath = "CarFeatureId";
            modelComboBox.ItemsSource = db.getCarModels();
            modelComboBox.DisplayMemberPath = "Model";
            modelComboBox.SelectedValuePath = "ModelId";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DAO db = new DAO();
           
            Car car = new Car();
            car.BodyType = bodyTypeTextBox.Text;
            car.Colour = colourTextBox.Text;
            car.DateImported = dateImportedDatePicker.SelectedDate.Value;
            car.CurrentMileage = currentMileageTextBox.Text;
            car.Status = statusTextBox.Text;
            car.Transmission = transmissionTextBox.Text;
            car.ManufacturerYear = int.Parse(manufacturerYearTextBox.Text);
            car.CarModelId =int.Parse( modelComboBox.SelectedValue.ToString());

            int featureID = int.Parse(featureComboBox.SelectedValue.ToString());

            //Bridging table carFetures
            CarFeatures junction = new CarFeatures();
            junction.CarFeatureId = featureID;
            junction.Car = car;

            car.CarFeatures.Add(junction);
            db.addNewCarNewModel(car);
            MessageBox.Show("new car model added successfully");
        }
    }
}
