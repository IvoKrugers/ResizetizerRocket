﻿using System;
using System.Diagnostics;
using System.Globalization;
using Xamarin.Forms;

namespace BoardPapers.UI.Converters
{
    public class StringToColorResourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Color.Default;

            string valueAsString = value.ToString();
            Debug.WriteLine(valueAsString);

            switch (valueAsString)
            {
                case "":
                    return Color.Default;
                default:
                    var c = LookupColor(valueAsString);
                    return c;
            }
        }

        public Color LookupColor(string key)
        {
            try
            {
                Application.Current.Resources.TryGetValue(key, out var newColor);
                return (Color)newColor;
            }
            catch
            {
                return Color.White;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
