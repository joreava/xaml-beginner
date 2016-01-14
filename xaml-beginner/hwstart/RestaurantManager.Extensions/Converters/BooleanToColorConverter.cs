using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;

namespace RestaurantManager.Extensions.Converters
{
    public class BooleanToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (bool)value ? Colors.Green : Colors.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            //Colors color = value as Colors;
            //switch (color)
            //{
            //    case Colors.Red:
            //        return true;

            //    default:
            //        return false;
            //}
            return false;
           
        }
    }
}
