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
    /// Interaction logic for AddNewCarNewModel.xaml
    /// </summary>
    public partial class AddNewCarNewModel : UserControl
    {
        public AddNewCarNewModel()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
            DAO db = new DAO();
            featureComboBox.ItemsSource = db.getCarFeature();
            featureComboBox.DisplayMemberPath = "Feature";
            featureComboBox.SelectedValuePath = "CarFeatureId";
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string output1 = Utility.emptyInputValidation(grid1);
            string output2 = Utility.emptyInputValidation(grid2);
            string output3 = Utility.emptyInputValidation(grid3);
            string output4 = Utility.emptyInputValidation(grid4);
            string result = output1 + output2 + output3+ output4;
            if (result != null )
            {
                MessageBox.Show(result);
            }
            else
            {
                DAO db = new DAO();
                CarModel model = new CarModel();
                model.Manufacturer = manufacturerTextBox.Text;
                model.Seats = int.Parse(seatsTextBox.Text);
                model.EngineSize = engineSizeTextBox.Text;
                model.Model = modelTextBox.Text;
                Car car = new Car();
                car.BodyType = bodyTypeTextBox.Text;
                car.Colour = colourTextBox.Text;
                car.DateImported = dateImportedDatePicker.SelectedDate.Value;
                car.CurrentMileage = currentMileageTextBox.Text;
                car.Status = statusTextBox.Text;
                car.Transmission = transmissionTextBox.Text;
                car.ManufacturerYear = int.Parse(manufacturerYearTextBox.Text);
                car.CarModel = model;
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
}
