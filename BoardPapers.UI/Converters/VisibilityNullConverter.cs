using System;
using System.Globalization;
using Xamarin.Forms;

namespace BoardPapers.UI.Converters
{
    public class VisibilityNullConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
