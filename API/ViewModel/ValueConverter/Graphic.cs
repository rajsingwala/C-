using System;
using System.Globalization;
using System.Windows.Data;

namespace API.ViewModel.ValueConverter
{
    public class Graphic : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool val = (bool)value;

            if (val) return "YES";
            else return "NO";
        }

       

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string val = (string)value;

            if (val == "YES") return true;
            else return false;
        }
    }
}
