using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WeatherAPI.ViewModel.ValueConverters
{
    public class BoolToRain : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isRain = (bool)value;

            if (isRain) return "Currently Raining";
            else return "Currently not Raining";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string isRain = (string)value;

            if (isRain == "Currently Raining") return true;
            else return false;
        }
    }
}
