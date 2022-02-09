using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ViewModel.ValueConverter
{
    public class Graphic : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool val = (bool)value;

            if (val) return "YES";
            else return "NO";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            string val = (string)value;

            if (val == "YES") return true;
            else return false;
        }
    }
}
