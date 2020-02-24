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
    /// Interaction logic for ShowEmployeeUC.xaml
    /// </summary>
    public partial class ShowEmployeeUC : UserControl
    {
        System.Windows.Data.CollectionViewSource myCollectionViewSource = null;
        public ShowEmployeeUC()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

      myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["employeeViewSource"];
            
        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            DAO db = new DAO();
            myCollectionViewSource.Source = db.getEmployees();
        }
    }
}
