using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CarDealershipSystem
{
    class Utility
    {
        public static string emptyInputValidation(Grid grid)
        {
            string message = null;
            foreach (Control ctr in grid.Children)
            {
                if (ctr.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)ctr;
                    if (tb.Text.Length == 0)
                    {
                        message = message + "Please enter value for " + tb.Uid + "\n";
                    }
                }
                if (ctr.GetType() == typeof(DatePicker))
                {
                    DatePicker dp = (DatePicker)ctr;
                    if (dp.SelectedDate == null)
                    {
                        message += "Please select date for " + dp.Uid + "\n";
                    }
                }
                if (ctr.GetType() == typeof(ComboBox))
                {
                    ComboBox cb = (ComboBox)ctr;
                    if (string.IsNullOrEmpty(cb.Text))
                    {
                        message += "Please select value for " + cb.Uid + "\n";
                    }
                }
            }
            return message;
        }
    }
}
