﻿using System;
using System.Windows.Data;

namespace SIQuester.Converters
{
    [ValueConversion(typeof(int), typeof(bool))]
    public sealed class GreaterThanValueConverter: IValueConverter
    {
        public int BaseValue { get; set; }
        
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (int)value > BaseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
