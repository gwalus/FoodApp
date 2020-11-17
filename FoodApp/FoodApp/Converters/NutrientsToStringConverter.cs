using System;
using System.Globalization;
using Xamarin.Forms;

namespace FoodApp.Converters
{
    public class NutrientsToStringConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null)
                return $"{values[0]}, {values[1]}, {values[2]}";

            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
